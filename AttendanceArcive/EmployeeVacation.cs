using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceArcive
{
    public class EmployeeVacation
    {
        public int EmployeeId { get; set; }

        public DateTime RegisterDate { get; set; }

        public string VacationTypeName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Note { get; set; }

        public bool IsExcuse { get; set; }
    }
}
