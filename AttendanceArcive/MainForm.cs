using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceArcive
{
    public partial class MainForm : Form
    {
        private List<TBL_EMPLOYEES> employeesInfo;
        private List<TBL_TRANSDUMPS> allOldTransactionsRecords;
        private List<EmployeeVacation> allOldVacationsRecords;
        private List<TBL_EMP_SHIFT> allOldShiftsRecords;


        //private List<EmployeeAttendanceRecord> newTransactionsRecords;
        //private List<EmployeeAttendanceRecord> allTransactionsRecords;
        //private List<EmployeeVacation> newVacationsRecords;
        //private List<EmployeeVacation> allVacationsRecords;

        public MainForm()
        {
            InitializeComponent();
        }

        private void resetData()
        {
            allOldTransactionsRecords = new List<TBL_TRANSDUMPS>();
            allOldVacationsRecords = new List<EmployeeVacation>();
            allOldShiftsRecords = new List<TBL_EMP_SHIFT>();

            //newTransactionsRecords = new List<EmployeeAttendanceRecord>();
            //allTransactionsRecords = new List<EmployeeAttendanceRecord>();           
            //newVacationsRecords = new List<EmployeeVacation>();
            //allVacationsRecords = new List<EmployeeVacation>();   
        }

        private void resetBindings()
        {
            this.tBL_EMPLOYEESBindingSource.DataSource = employeesInfo;
            this.tBL_EMPLOYEESBindingSource.ResetBindings(false);

            this.tBL_TRANSDUMPSBindingSource.DataSource = this.allOldTransactionsRecords;
            this.tBL_TRANSDUMPSBindingSource.ResetBindings(false);

            this.employeeVacationBindingSource.DataSource = this.allOldVacationsRecords.OrderBy(v => v.StartDate).ToList();
            this.employeeVacationBindingSource.ResetBindings(false);

            this.tBL_EMP_SHIFTBindingSource.DataSource = this.allOldShiftsRecords;
            this.tBL_EMP_SHIFTBindingSource.ResetBindings(false);

            //this.employeeAttendanceRecordBindingSource.DataSource = this.newTransactionsRecords;
            //this.employeeAttendanceRecordBindingSource.ResetBindings(false);

            //this.newVacationsBindingSource.DataSource = this.newVacationsRecords.OrderBy(v => v.StartDate).ToList();
            //this.newVacationsBindingSource.ResetBindings(false);
        }

        private async void btnGetIds_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            employeesInfo = new List<TBL_EMPLOYEES>();

            this.resetData();
            this.resetBindings();

            if (string.IsNullOrWhiteSpace(this.txtEmployeesCodes.Text))
            {
                return;
            }

            string[] employeesCodes = txtEmployeesCodes.Text.Split(',');
            var db = new QAMS();
            this.employeesInfo = await db.TBL_EMPLOYEES.Where(emp => employeesCodes.Contains(emp.EPCODE)).AsNoTracking().ToListAsync();

            resetBindings();

            this.Cursor = Cursors.Default;
        }

        private async void btnGetRowAttendance_Click(object sender, EventArgs e)
        {
            if (this.employeesInfo == null || this.employeesInfo.Count < 1 || dtFrom.Value.Date > dtTo.Value.Date)
            {
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            this.resetData();
            this.resetBindings();

            DateTime fromDate = dtFrom.Value.Date;
            DateTime toDate = dtTo.Value.AddDays(1).Date;

            //Setup old data dates
            DateTime oldDataMaxDate = new DateTime(2018, 12, 1).Date;
            DateTime? oldDataFromDate = fromDate < oldDataMaxDate ? fromDate : default(DateTime?);
            DateTime oldDataToDate = toDate >= oldDataMaxDate ? oldDataMaxDate : toDate;

            //Setup new data dates
            DateTime newDataFromDate = fromDate >= oldDataMaxDate ? fromDate : oldDataMaxDate;
            DateTime? newDataToDate = toDate >= oldDataMaxDate ? toDate : default(DateTime?);

            if (oldDataFromDate.HasValue)
            {
                var db = new QAMS();
                var employeesIds = this.employeesInfo.Select(emp => emp.EPID).ToList();
                this.allOldTransactionsRecords = await db.TBL_TRANSDUMPS
                    .Where(tr => tr.TRDATE >= oldDataFromDate.Value
                              && tr.TRDATE < oldDataToDate
                              && tr.EPID.HasValue
                              && employeesIds.Contains(tr.EPID.Value))
                    .OrderBy(tr => tr.EPID)
                    .ThenBy(tr => tr.TRDATE).AsNoTracking().ToListAsync();

                var oldVacations = await db.TBL_EMP_VACATION
                        .Where(v => ((v.EVFROM <= oldDataFromDate.Value && v.EVTO >= oldDataFromDate.Value)
                                 || (v.EVFROM >= oldDataFromDate.Value && v.EVFROM <= oldDataToDate)) && employeesIds.Contains(v.EPID))
                        .ToListAsync();

                var vacationsTypes = await db.TBL_VAC_TYPE.ToListAsync();

                this.allOldVacationsRecords = oldVacations.Select(v => new EmployeeVacation
                {
                    EmployeeId = int.Parse(this.employeesInfo.FirstOrDefault(emp => emp.EPID == v.EPID).EPCODE),
                    RegisterDate = v.SYS_DATE.Date,
                    StartDate = v.EVFROM,
                    EndDate = v.EVTO,
                    VacationTypeName = vacationsTypes.FirstOrDefault(vt => vt.VTID == v.VTID).VTNAME ?? ""
                }).ToList();

                var duties = await db.TBL_EMP_DUTY.Where(d => d.EDFROM.HasValue && d.EDTO.HasValue && ((d.EDFROM <= oldDataFromDate.Value && d.EDTO >= oldDataFromDate.Value)
                                 || (d.EDFROM >= oldDataFromDate.Value && d.EDTO <= oldDataToDate)) && employeesIds.Contains(d.EPID)).ToListAsync();

                var dutiesVacations = duties.Select(d => new EmployeeVacation
                {
                    EmployeeId = int.Parse(this.employeesInfo.FirstOrDefault(emp => emp.EPID == d.EPID).EPCODE),
                    RegisterDate = d.SYS_DATE.Date,
                    StartDate = d.EDFROM.Value,
                    EndDate = d.EDTO.Value,
                    VacationTypeName = d.EDNAME,
                    Note = d.EDDESC,
                    IsExcuse = true
                }).ToList();

                this.allOldVacationsRecords.AddRange(dutiesVacations);

                this.allOldShiftsRecords = await db.TBL_EMP_SHIFT
                    .Where(sh => employeesIds.Contains(sh.EPID) 
                        && sh.ESSTART >= oldDataFromDate.Value && sh.ESSTART <= oldDataToDate)
                    .AsNoTracking().ToListAsync();
            }

            //if (newDataToDate.HasValue)
            //{
            //    try
            //    {
            //        var client = new HttpClient();
            //        client.BaseAddress = new Uri(uriString: @"http://172.16.11.44:810/HrPortalApi/api/Hr/portal/");
            //        client.DefaultRequestHeaders.Accept.Clear();
            //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType: "application/json"));

            //        string recordsRequestUrl = $"RawAttendanceTransactions?fromdate={newDataFromDate.ToString("yyyy-MM-dd", new CultureInfo("en-US"))}&todate={newDataToDate.Value.ToString("yyyy-MM-dd", new CultureInfo("en-US"))}&employeesIds={this.txtEmployeesCodes.Text}";

            //        HttpResponseMessage recordsResponse = await client.GetAsync(recordsRequestUrl);
            //        if (recordsResponse.IsSuccessStatusCode)
            //        {
            //            string content = await recordsResponse.Content.ReadAsStringAsync();
            //            this.newTransactionsRecords = JsonConvert.DeserializeObject<List<EmployeeAttendanceRecord>>(content);
            //        }

            //        string vacationsRequestUrl = $"vacations?fromdate={newDataFromDate.ToString("yyyy-MM-dd", new CultureInfo("en-US"))}&todate={newDataToDate.Value.ToString("yyyy-MM-dd", new CultureInfo("en-US"))}&employeesIds={this.txtEmployeesCodes.Text}";

            //        HttpResponseMessage vacationsResponse = await client.GetAsync(vacationsRequestUrl);
            //        if (vacationsResponse.IsSuccessStatusCode)
            //        {
            //            string vacationsContent = await vacationsResponse.Content.ReadAsStringAsync();
            //            this.newVacationsRecords = JsonConvert.DeserializeObject<List<EmployeeVacation>>(vacationsContent);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}

            //this.allTransactionsRecords = this.oldTransactionsRecords.Select(t => new EmployeeAttendanceRecord
            //{
            //    EmployeeId = int.Parse(t.TREMP_ID),
            //    TransactionDate = t.TRDATE
            //}).ToList();

            //this.allTransactionsRecords.AddRange(this.newTransactionsRecords);

            //this.allTransactionsRecords = this.allTransactionsRecords.OrderBy(t => t.EmployeeId).ThenBy(t => t.TransactionDate).ToList();

            //this.allVacationsRecords.AddRange(this.oldVacationsRecords);
            //this.allVacationsRecords.AddRange(this.newVacationsRecords);

            //this.allVacationsRecords = this.allVacationsRecords.OrderBy(v => v.EmployeeId).ThenBy(v => v.StartDate).ToList();

            this.resetBindings();

            this.Cursor = Cursors.Default;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (this.employeesInfo == null || this.employeesInfo.Count < 1 || dtFrom.Value.Date > dtTo.Value.Date)
            {
                return;
            }

            DateTime fromDate = dtFrom.Value.Date;
            DateTime toDate = dtTo.Value.AddDays(1).Date;

            //Setup old data dates
            DateTime oldDataMaxDate = new DateTime(2018, 12, 1).Date;
            DateTime? oldDataFromDate = fromDate < oldDataMaxDate ? fromDate : default(DateTime?);
            DateTime oldDataToDate = toDate >= oldDataMaxDate ? oldDataMaxDate : toDate;

            //Setup new data dates
            DateTime newDataFromDate = fromDate >= oldDataMaxDate ? fromDate : oldDataMaxDate;
            DateTime? newDataToDate = toDate >= oldDataMaxDate ? toDate : default(DateTime?);

            var daysReports = new List<AttendanceDayReport>();

            if (oldDataFromDate.HasValue)
            {
                DateTime currentDate = oldDataFromDate.Value;
                while (currentDate <= oldDataToDate)
                {
                    foreach (var emp in this.employeesInfo)
                    {
                        int employeeId = int.Parse(emp.EPCODE);
                        var employeeOldTransactionsRecords = this.allOldTransactionsRecords.Where(t => t.EPID == emp.EPID && t.TRDATE.Date == currentDate).OrderBy(t => t.TRDATE).ToList();
                        var employeeOldVacationsRecord = this.allOldVacationsRecords.FirstOrDefault(v => v.EmployeeId == employeeId && currentDate >= v.StartDate.Date && currentDate <= v.EndDate.Date);
                        var employeeShiftsRecord = this.allOldShiftsRecords.FirstOrDefault(sh => sh.ESSTART.Date == currentDate);

                        var checkin = employeeOldTransactionsRecords.FirstOrDefault()?.TRDATE ?? default(DateTime?);
                        var checkout = employeeOldTransactionsRecords
                            .Where(t => checkin.HasValue && t.TRDATE > checkin).LastOrDefault()?.TRDATE ?? default(DateTime?);

                        var newDayReport =  new AttendanceDayReport
                        {
                            Date = currentDate.Date,
                            EmployeeId = employeeId,
                            EmployeeName = emp.EPNAME,
                            CheckInDateTime = checkin,
                            CheckOutDateTime = checkout,
                            IsVacation = employeeOldVacationsRecord != null,
                            VacationTypeName = employeeOldVacationsRecord?.VacationTypeName ?? "",
                            VacationRegisterDate = employeeOldVacationsRecord?.RegisterDate ?? default(DateTime?),
                            VacationDescription = employeeOldVacationsRecord?.Note ?? "",
                            WorkDay = employeeShiftsRecord != null,
                            ShiftName=employeeShiftsRecord?.ESNAME ?? "",
                            ShiftStart = employeeShiftsRecord?.ESSTART ?? default(DateTime?),
                            ShiftEnd = employeeShiftsRecord?.ESEND ?? default(DateTime?),
                            IsAbsent = employeeShiftsRecord != null 
                                    && employeeOldVacationsRecord == null
                                    && !checkin.HasValue && !checkout.HasValue,
                            ShiftDurationTime = employeeShiftsRecord != null ?
                                employeeShiftsRecord.ESEND.Subtract(employeeShiftsRecord.ESSTART):default(TimeSpan?)       
                               
                        };

                        newDayReport.CheckInLateDurationTime = newDayReport.CheckInDateTime.HasValue 
                            && newDayReport.ShiftStart.HasValue 
                            && newDayReport.CheckInDateTime.Value > newDayReport.ShiftStart.Value.AddMinutes(31) 
                            ? newDayReport.CheckInDateTime.Value.Subtract(newDayReport.ShiftStart.Value) : default(TimeSpan?);

                        if (newDayReport.CheckInLateDurationTime.HasValue && newDayReport.CheckInLateDurationTime > newDayReport.ShiftDurationTime)
                        {
                            newDayReport.CheckInLateDurationTime = newDayReport.ShiftDurationTime;
                        } 

                        newDayReport.CheckOutEarlyDurationTime = newDayReport.CheckOutDateTime.HasValue
                            && newDayReport.ShiftEnd.HasValue
                            && newDayReport.CheckOutDateTime.Value < newDayReport.ShiftEnd.Value
                            ? newDayReport.ShiftEnd.Value.Subtract(newDayReport.CheckOutDateTime.Value) : default(TimeSpan?);

                        var totalWaste = new TimeSpan(0, 0, 0);
                        totalWaste = totalWaste.Add(newDayReport.CheckInLateDurationTime ?? new TimeSpan(0, 0, 0));
                        totalWaste = totalWaste.Add(newDayReport.CheckOutEarlyDurationTime ?? new TimeSpan(0, 0, 0));

                        newDayReport.WasteDurationTime = totalWaste > new TimeSpan(0, 0, 0) ? totalWaste : default(TimeSpan);

                        if (newDayReport.WorkDay 
                            && !newDayReport.IsVacation 
                            && !newDayReport.IsAbsent 
                            && newDayReport.ShiftDurationTime.HasValue
                            && newDayReport.CheckInDateTime.HasValue 
                            && newDayReport.CheckOutDateTime.HasValue)
                        {
                            newDayReport.WorkDurationTime = newDayReport
                                .ShiftDurationTime.Value
                                .Subtract(newDayReport.WasteDurationTime ?? new TimeSpan(0,0,0));
                        }

                        daysReports.Add(newDayReport);
                    }

                    currentDate = currentDate.AddDays(1);
                }
            }

            new ReportsForm(daysReports).ShowDialog();
        }
    }
}
