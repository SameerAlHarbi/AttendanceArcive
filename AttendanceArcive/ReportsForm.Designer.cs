namespace AttendanceArcive
{
    partial class ReportsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.attendanceDayReportDataGridView = new System.Windows.Forms.DataGridView();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.WorkDay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ShiftStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftDurationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInLateDurationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOutEarlyDurationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WasteDurationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAbsent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.WorkDurationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDayReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDayReportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDayReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // attendanceDayReportDataGridView
            // 
            this.attendanceDayReportDataGridView.AllowUserToAddRows = false;
            this.attendanceDayReportDataGridView.AllowUserToDeleteRows = false;
            this.attendanceDayReportDataGridView.AutoGenerateColumns = false;
            this.attendanceDayReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendanceDayReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.WorkDay,
            this.ShiftStart,
            this.ShiftEnd,
            this.ShiftDurationTime,
            this.CheckInLateDurationTime,
            this.CheckOutEarlyDurationTime,
            this.WasteDurationTime,
            this.IsAbsent,
            this.WorkDurationTime});
            this.attendanceDayReportDataGridView.DataSource = this.attendanceDayReportBindingSource;
            this.attendanceDayReportDataGridView.Location = new System.Drawing.Point(12, 24);
            this.attendanceDayReportDataGridView.Name = "attendanceDayReportDataGridView";
            this.attendanceDayReportDataGridView.ReadOnly = true;
            this.attendanceDayReportDataGridView.Size = new System.Drawing.Size(1339, 602);
            this.attendanceDayReportDataGridView.TabIndex = 1;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(560, 649);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(242, 43);
            this.btnExportExcel.TabIndex = 2;
            this.btnExportExcel.Text = "Export Data Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // WorkDay
            // 
            this.WorkDay.DataPropertyName = "WorkDay";
            this.WorkDay.HeaderText = "WorkDay";
            this.WorkDay.Name = "WorkDay";
            this.WorkDay.ReadOnly = true;
            // 
            // ShiftStart
            // 
            this.ShiftStart.DataPropertyName = "ShiftStart";
            this.ShiftStart.HeaderText = "ShiftStart";
            this.ShiftStart.Name = "ShiftStart";
            this.ShiftStart.ReadOnly = true;
            // 
            // ShiftEnd
            // 
            this.ShiftEnd.DataPropertyName = "ShiftEnd";
            this.ShiftEnd.HeaderText = "ShiftEnd";
            this.ShiftEnd.Name = "ShiftEnd";
            this.ShiftEnd.ReadOnly = true;
            // 
            // ShiftDurationTime
            // 
            this.ShiftDurationTime.DataPropertyName = "ShiftDurationTime";
            this.ShiftDurationTime.HeaderText = "ShiftDurationTime";
            this.ShiftDurationTime.Name = "ShiftDurationTime";
            this.ShiftDurationTime.ReadOnly = true;
            // 
            // CheckInLateDurationTime
            // 
            this.CheckInLateDurationTime.DataPropertyName = "CheckInLateDurationTime";
            this.CheckInLateDurationTime.HeaderText = "CheckInLateDurationTime";
            this.CheckInLateDurationTime.Name = "CheckInLateDurationTime";
            this.CheckInLateDurationTime.ReadOnly = true;
            // 
            // CheckOutEarlyDurationTime
            // 
            this.CheckOutEarlyDurationTime.DataPropertyName = "CheckOutEarlyDurationTime";
            this.CheckOutEarlyDurationTime.HeaderText = "CheckOutEarlyDurationTime";
            this.CheckOutEarlyDurationTime.Name = "CheckOutEarlyDurationTime";
            this.CheckOutEarlyDurationTime.ReadOnly = true;
            // 
            // WasteDurationTime
            // 
            this.WasteDurationTime.DataPropertyName = "WasteDurationTime";
            this.WasteDurationTime.HeaderText = "WasteDurationTime";
            this.WasteDurationTime.Name = "WasteDurationTime";
            this.WasteDurationTime.ReadOnly = true;
            // 
            // IsAbsent
            // 
            this.IsAbsent.DataPropertyName = "IsAbsent";
            this.IsAbsent.HeaderText = "IsAbsent";
            this.IsAbsent.Name = "IsAbsent";
            this.IsAbsent.ReadOnly = true;
            // 
            // WorkDurationTime
            // 
            this.WorkDurationTime.DataPropertyName = "WorkDurationTime";
            this.WorkDurationTime.HeaderText = "WorkDurationTime";
            this.WorkDurationTime.Name = "WorkDurationTime";
            this.WorkDurationTime.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateHijri";
            this.dataGridViewTextBoxColumn2.HeaderText = "DateHijri";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EmployeeId";
            this.dataGridViewTextBoxColumn3.HeaderText = "EmployeeId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EmployeeName";
            this.dataGridViewTextBoxColumn4.HeaderText = "EmployeeName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CheckInDateTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "CheckInDateTime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CheckInDateTimeHijri";
            this.dataGridViewTextBoxColumn6.HeaderText = "CheckInDateTimeHijri";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CheckOutDateTime";
            this.dataGridViewTextBoxColumn7.HeaderText = "CheckOutDateTime";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CheckOutDateTimeHijri";
            this.dataGridViewTextBoxColumn8.HeaderText = "CheckOutDateTimeHijri";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsVacation";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsVacation";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "VacationRegisterDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "VacationRegisterDate";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "VacationRegisterDateHijri";
            this.dataGridViewTextBoxColumn10.HeaderText = "VacationRegisterDateHijri";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "VacationTypeName";
            this.dataGridViewTextBoxColumn11.HeaderText = "VacationTypeName";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "VacationDescription";
            this.dataGridViewTextBoxColumn12.HeaderText = "VacationDescription";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Note";
            this.dataGridViewTextBoxColumn13.HeaderText = "Note";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // attendanceDayReportBindingSource
            // 
            this.attendanceDayReportBindingSource.DataSource = typeof(AttendanceArcive.AttendanceDayReport);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 708);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.attendanceDayReportDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDayReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDayReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource attendanceDayReportBindingSource;
        private System.Windows.Forms.DataGridView attendanceDayReportDataGridView;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn WorkDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftDurationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInLateDurationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOutEarlyDurationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn WasteDurationTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAbsent;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkDurationTime;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}