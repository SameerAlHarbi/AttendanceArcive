using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceArcive
{
    public partial class ReportsForm : Form
    {
        private List<AttendanceDayReport> _daysReports;
        public ReportsForm(List<AttendanceDayReport> daysReports)
        {
            _daysReports = daysReports;
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            this.attendanceDayReportBindingSource.DataSource = _daysReports;
            this.attendanceDayReportBindingSource.ResetBindings(false);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (this._daysReports == null || this._daysReports.Count < 1)
            {
                return;
            }

            string fileName = "";
            saveFileDialog1.Filter = "Excel File (*.xlsx)|*.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
            }
            else
            {
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            FileInfo newFile = new FileInfo(fileName);
            if (newFile.Exists)
            {
                newFile.Delete();  // ensures we create a new workbook
                newFile = new FileInfo(fileName);
            }

            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            // Get all embedded resources
            string[] arrResources = currentAssembly.GetManifestResourceNames();

            Stream st = null;
            foreach (string resourceName in arrResources)
            {
                if (resourceName.Contains("Details.xlsx"))
                {
                    st = currentAssembly.GetManifestResourceStream(resourceName);
                }
            }

            if (st == null)
            {
                return;
            }

            using (ExcelPackage package = new ExcelPackage(st))
            {
                ExcelWorksheet excelWorksheet = package.Workbook.Worksheets["Sheet1"];
                int i = 2;
                foreach (var d in this._daysReports)
                {
                    int k = 1;
                    excelWorksheet.Cells[i, k++].Value = d.EmployeeId;
                    excelWorksheet.Cells[i, k++].Value = d.EmployeeName;
                    excelWorksheet.Cells[i, k++].Value = "";
                    excelWorksheet.Cells[i, k++].Value = d.Date;
                    excelWorksheet.Cells[i, k++].Value = d.DateHijri;
                    excelWorksheet.Cells[i, k++].Value = d.ShiftDurationTime;
                    excelWorksheet.Cells[i, k++].Value = d.CheckInDateTime;
                    excelWorksheet.Cells[i, k++].Value = d.CheckOutDateTime;
                    excelWorksheet.Cells[i, k++].Value = d.WorkDurationTime;
                    excelWorksheet.Cells[i, k++].Value = d.CheckInLateDurationTime;
                    excelWorksheet.Cells[i, k++].Value = d.CheckOutEarlyDurationTime;
                    excelWorksheet.Cells[i, k++].Value = d.WasteDurationTime;

                    if(!string.IsNullOrWhiteSpace(d.VacationTypeName))
                    {
                        excelWorksheet.Cells[i, k++].Value = d.VacationTypeName;
                    }
                    else if (!d.WorkDay)
                    {
                        excelWorksheet.Cells[i, k++].Value = "لا يوجد وردية مسجلة";
                    }
                    else if (d.IsAbsent)
                    {
                        excelWorksheet.Cells[i, k++].Value = "غياب";
                    }
                    

                    i++;
                }

                package.SaveAs(newFile);
            }

            MessageBox.Show("Don");
            this.Cursor = Cursors.Default;
        }
    }
}
