using Sameer.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceArcive
{
    public class AttendanceDayReport
    {
        public DateTime Date { get; set; }

        public string DateHijri => Date.ConvertToString(true, true, true) + "هـ ";

        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public DateTime? CheckInDateTime { get; set; }

        public string CheckInDateTimeHijri => CheckInDateTime.HasValue ? CheckInDateTime.Value.ConvertToString(true, true, true) + "هـ " : "";

        public DateTime? CheckOutDateTime { get; set; }

        public string CheckOutDateTimeHijri => CheckOutDateTime.HasValue ? CheckOutDateTime.Value.ConvertToString(true, true, true) + "هـ " : "";

        public bool IsVacation { get; set; }

        public DateTime? VacationRegisterDate { get; set; }

        public string VacationRegisterDateHijri => VacationRegisterDate.HasValue ? VacationRegisterDate.Value.ConvertToString(true, true, true) + "هـ " : "";

        public string VacationTypeName { get; set; }

        public string VacationDescription { get; set; }

        public string Note { get; set; }
    }
}
