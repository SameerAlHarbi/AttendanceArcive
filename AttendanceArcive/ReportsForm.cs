using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
