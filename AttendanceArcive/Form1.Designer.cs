namespace AttendanceArcive
{
    partial class Form1
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
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetRowAttendance = new System.Windows.Forms.Button();
            this.btnGetIds = new System.Windows.Forms.Button();
            this.txtEmployeesCodes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBL_EMPLOYEESDataGridView = new System.Windows.Forms.DataGridView();
            this.tBL_TRANSDUMPSDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeAttendanceRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeVacationDataGridView = new System.Windows.Forms.DataGridView();
            this.VacationTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newVacationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeVacationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeAttendanceRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBL_TRANSDUMPSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBL_EMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tBL_EMPLOYEESDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TRANSDUMPSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAttendanceRecordDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeVacationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVacationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeVacationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAttendanceRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TRANSDUMPSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_EMPLOYEESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "yyyy/MM/dd ddd";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(971, 15);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(148, 20);
            this.dtTo.TabIndex = 13;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "yyyy/MM/dd ddd";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(724, 15);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(148, 20);
            this.dtFrom.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(913, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "To Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(654, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "From Date :";
            // 
            // btnGetRowAttendance
            // 
            this.btnGetRowAttendance.Location = new System.Drawing.Point(1137, 14);
            this.btnGetRowAttendance.Name = "btnGetRowAttendance";
            this.btnGetRowAttendance.Size = new System.Drawing.Size(160, 23);
            this.btnGetRowAttendance.TabIndex = 9;
            this.btnGetRowAttendance.Text = "Get Attendance Records";
            this.btnGetRowAttendance.UseVisualStyleBackColor = true;
            this.btnGetRowAttendance.Click += new System.EventHandler(this.btnGetRowAttendance_Click);
            // 
            // btnGetIds
            // 
            this.btnGetIds.Location = new System.Drawing.Point(488, 14);
            this.btnGetIds.Name = "btnGetIds";
            this.btnGetIds.Size = new System.Drawing.Size(125, 23);
            this.btnGetIds.TabIndex = 10;
            this.btnGetIds.Text = "Get Employees Ids";
            this.btnGetIds.UseVisualStyleBackColor = true;
            this.btnGetIds.Click += new System.EventHandler(this.btnGetIds_Click);
            // 
            // txtEmployeesCodes
            // 
            this.txtEmployeesCodes.Location = new System.Drawing.Point(195, 15);
            this.txtEmployeesCodes.Name = "txtEmployeesCodes";
            this.txtEmployeesCodes.Size = new System.Drawing.Size(287, 20);
            this.txtEmployeesCodes.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(91, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employees Codes :";
            // 
            // tBL_EMPLOYEESDataGridView
            // 
            this.tBL_EMPLOYEESDataGridView.AllowUserToAddRows = false;
            this.tBL_EMPLOYEESDataGridView.AllowUserToDeleteRows = false;
            this.tBL_EMPLOYEESDataGridView.AutoGenerateColumns = false;
            this.tBL_EMPLOYEESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tBL_EMPLOYEESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tBL_EMPLOYEESDataGridView.DataSource = this.tBL_EMPLOYEESBindingSource;
            this.tBL_EMPLOYEESDataGridView.Location = new System.Drawing.Point(71, 43);
            this.tBL_EMPLOYEESDataGridView.Name = "tBL_EMPLOYEESDataGridView";
            this.tBL_EMPLOYEESDataGridView.ReadOnly = true;
            this.tBL_EMPLOYEESDataGridView.Size = new System.Drawing.Size(519, 369);
            this.tBL_EMPLOYEESDataGridView.TabIndex = 15;
            // 
            // tBL_TRANSDUMPSDataGridView
            // 
            this.tBL_TRANSDUMPSDataGridView.AllowUserToAddRows = false;
            this.tBL_TRANSDUMPSDataGridView.AllowUserToDeleteRows = false;
            this.tBL_TRANSDUMPSDataGridView.AutoGenerateColumns = false;
            this.tBL_TRANSDUMPSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tBL_TRANSDUMPSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6});
            this.tBL_TRANSDUMPSDataGridView.DataSource = this.tBL_TRANSDUMPSBindingSource;
            this.tBL_TRANSDUMPSDataGridView.Location = new System.Drawing.Point(607, 43);
            this.tBL_TRANSDUMPSDataGridView.Name = "tBL_TRANSDUMPSDataGridView";
            this.tBL_TRANSDUMPSDataGridView.ReadOnly = true;
            this.tBL_TRANSDUMPSDataGridView.Size = new System.Drawing.Size(356, 369);
            this.tBL_TRANSDUMPSDataGridView.TabIndex = 16;
            // 
            // employeeAttendanceRecordDataGridView
            // 
            this.employeeAttendanceRecordDataGridView.AllowUserToAddRows = false;
            this.employeeAttendanceRecordDataGridView.AllowUserToDeleteRows = false;
            this.employeeAttendanceRecordDataGridView.AutoGenerateColumns = false;
            this.employeeAttendanceRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeAttendanceRecordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8});
            this.employeeAttendanceRecordDataGridView.DataSource = this.employeeAttendanceRecordBindingSource;
            this.employeeAttendanceRecordDataGridView.Location = new System.Drawing.Point(975, 43);
            this.employeeAttendanceRecordDataGridView.Name = "employeeAttendanceRecordDataGridView";
            this.employeeAttendanceRecordDataGridView.ReadOnly = true;
            this.employeeAttendanceRecordDataGridView.Size = new System.Drawing.Size(345, 369);
            this.employeeAttendanceRecordDataGridView.TabIndex = 17;
            // 
            // employeeVacationDataGridView
            // 
            this.employeeVacationDataGridView.AllowUserToAddRows = false;
            this.employeeVacationDataGridView.AllowUserToDeleteRows = false;
            this.employeeVacationDataGridView.AutoGenerateColumns = false;
            this.employeeVacationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeVacationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.VacationTypeName,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.Note});
            this.employeeVacationDataGridView.DataSource = this.employeeVacationBindingSource;
            this.employeeVacationDataGridView.Location = new System.Drawing.Point(71, 420);
            this.employeeVacationDataGridView.Name = "employeeVacationDataGridView";
            this.employeeVacationDataGridView.ReadOnly = true;
            this.employeeVacationDataGridView.Size = new System.Drawing.Size(1249, 199);
            this.employeeVacationDataGridView.TabIndex = 18;
            // 
            // VacationTypeName
            // 
            this.VacationTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VacationTypeName.DataPropertyName = "VacationTypeName";
            this.VacationTypeName.HeaderText = "VacationTypeName";
            this.VacationTypeName.Name = "VacationTypeName";
            this.VacationTypeName.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.registerDateDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn15,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.newVacationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(71, 625);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1249, 199);
            this.dataGridView1.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "VacationTypeName";
            this.dataGridViewTextBoxColumn15.HeaderText = "VacationTypeName";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registerDateDataGridViewTextBoxColumn
            // 
            this.registerDateDataGridViewTextBoxColumn.DataPropertyName = "RegisterDate";
            this.registerDateDataGridViewTextBoxColumn.HeaderText = "RegisterDate";
            this.registerDateDataGridViewTextBoxColumn.Name = "registerDateDataGridViewTextBoxColumn";
            this.registerDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // newVacationsBindingSource
            // 
            this.newVacationsBindingSource.DataSource = typeof(AttendanceArcive.EmployeeVacation);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "EmployeeId";
            this.dataGridViewTextBoxColumn9.HeaderText = "EmployeeId";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "RegisterDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "RegisterDate";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn12.HeaderText = "StartDate";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn13.HeaderText = "EndDate";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // employeeVacationBindingSource
            // 
            this.employeeVacationBindingSource.DataSource = typeof(AttendanceArcive.EmployeeVacation);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EmployeeId";
            this.dataGridViewTextBoxColumn5.HeaderText = "Employee Id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TransactionDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "Transaction Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // employeeAttendanceRecordBindingSource
            // 
            this.employeeAttendanceRecordBindingSource.DataSource = typeof(AttendanceArcive.EmployeeAttendanceRecord);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TREMP_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Employee Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TRDATE";
            this.dataGridViewTextBoxColumn6.HeaderText = "Transaction Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // tBL_TRANSDUMPSBindingSource
            // 
            this.tBL_TRANSDUMPSBindingSource.DataSource = typeof(AttendanceArcive.TBL_TRANSDUMPS);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EPID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EPID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DPID";
            this.dataGridViewTextBoxColumn2.HeaderText = "DPID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EPCODE";
            this.dataGridViewTextBoxColumn3.HeaderText = "EPCODE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EPNAME";
            this.dataGridViewTextBoxColumn4.HeaderText = "EPNAME";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tBL_EMPLOYEESBindingSource
            // 
            this.tBL_EMPLOYEESBindingSource.DataSource = typeof(AttendanceArcive.TBL_EMPLOYEES);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 1110);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.employeeVacationDataGridView);
            this.Controls.Add(this.employeeAttendanceRecordDataGridView);
            this.Controls.Add(this.tBL_TRANSDUMPSDataGridView);
            this.Controls.Add(this.tBL_EMPLOYEESDataGridView);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetRowAttendance);
            this.Controls.Add(this.btnGetIds);
            this.Controls.Add(this.txtEmployeesCodes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBL_EMPLOYEESDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TRANSDUMPSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAttendanceRecordDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeVacationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVacationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeVacationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAttendanceRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TRANSDUMPSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_EMPLOYEESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetRowAttendance;
        private System.Windows.Forms.Button btnGetIds;
        private System.Windows.Forms.TextBox txtEmployeesCodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tBL_EMPLOYEESBindingSource;
        private System.Windows.Forms.DataGridView tBL_EMPLOYEESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource tBL_TRANSDUMPSBindingSource;
        private System.Windows.Forms.DataGridView tBL_TRANSDUMPSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource employeeAttendanceRecordBindingSource;
        private System.Windows.Forms.DataGridView employeeAttendanceRecordDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource employeeVacationBindingSource;
        private System.Windows.Forms.DataGridView employeeVacationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacationTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.BindingSource newVacationsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}

