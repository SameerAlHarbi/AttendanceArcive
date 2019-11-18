namespace AttendanceArcive
{
    partial class MainForm
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
            this.employeeVacationDataGridView = new System.Windows.Forms.DataGridView();
            this.VacationTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReport = new System.Windows.Forms.Button();
            this.tBL_EMP_SHIFTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBL_EMP_SHIFTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeVacationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBL_TRANSDUMPSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBL_EMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeAttendanceRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newVacationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_EMP_TRANS_MSTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_EMP_TRANS_MSTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TMDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_EMPLOYEESDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TRANSDUMPSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeVacationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_EMP_SHIFTDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_EMP_SHIFTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeVacationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TRANSDUMPSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_EMPLOYEESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAttendanceRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVacationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_EMP_TRANS_MSTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_EMP_TRANS_MSTDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "yyyy/MM/dd ddd";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(827, 12);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(148, 20);
            this.dtTo.TabIndex = 13;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "yyyy/MM/dd ddd";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(615, 12);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(148, 20);
            this.dtFrom.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(769, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "To Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(545, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "From Date :";
            // 
            // btnGetRowAttendance
            // 
            this.btnGetRowAttendance.Location = new System.Drawing.Point(981, 11);
            this.btnGetRowAttendance.Name = "btnGetRowAttendance";
            this.btnGetRowAttendance.Size = new System.Drawing.Size(160, 23);
            this.btnGetRowAttendance.TabIndex = 9;
            this.btnGetRowAttendance.Text = "Get Attendance Records";
            this.btnGetRowAttendance.UseVisualStyleBackColor = true;
            this.btnGetRowAttendance.Click += new System.EventHandler(this.btnGetRowAttendance_Click);
            // 
            // btnGetIds
            // 
            this.btnGetIds.Location = new System.Drawing.Point(414, 11);
            this.btnGetIds.Name = "btnGetIds";
            this.btnGetIds.Size = new System.Drawing.Size(125, 23);
            this.btnGetIds.TabIndex = 10;
            this.btnGetIds.Text = "Get Employees Ids";
            this.btnGetIds.UseVisualStyleBackColor = true;
            this.btnGetIds.Click += new System.EventHandler(this.btnGetIds_Click);
            // 
            // txtEmployeesCodes
            // 
            this.txtEmployeesCodes.Location = new System.Drawing.Point(121, 12);
            this.txtEmployeesCodes.Name = "txtEmployeesCodes";
            this.txtEmployeesCodes.Size = new System.Drawing.Size(287, 20);
            this.txtEmployeesCodes.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(17, 16);
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
            this.tBL_EMPLOYEESDataGridView.Location = new System.Drawing.Point(20, 40);
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
            this.tBL_TRANSDUMPSDataGridView.Location = new System.Drawing.Point(548, 40);
            this.tBL_TRANSDUMPSDataGridView.Name = "tBL_TRANSDUMPSDataGridView";
            this.tBL_TRANSDUMPSDataGridView.ReadOnly = true;
            this.tBL_TRANSDUMPSDataGridView.Size = new System.Drawing.Size(314, 369);
            this.tBL_TRANSDUMPSDataGridView.TabIndex = 16;
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
            this.employeeVacationDataGridView.Location = new System.Drawing.Point(20, 415);
            this.employeeVacationDataGridView.Name = "employeeVacationDataGridView";
            this.employeeVacationDataGridView.ReadOnly = true;
            this.employeeVacationDataGridView.Size = new System.Drawing.Size(1345, 199);
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
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(570, 835);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(249, 34);
            this.btnReport.TabIndex = 19;
            this.btnReport.Text = "Show Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // tBL_EMP_SHIFTDataGridView
            // 
            this.tBL_EMP_SHIFTDataGridView.AllowUserToAddRows = false;
            this.tBL_EMP_SHIFTDataGridView.AllowUserToDeleteRows = false;
            this.tBL_EMP_SHIFTDataGridView.AutoGenerateColumns = false;
            this.tBL_EMP_SHIFTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tBL_EMP_SHIFTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.tBL_EMP_SHIFTDataGridView.DataSource = this.tBL_EMP_SHIFTBindingSource;
            this.tBL_EMP_SHIFTDataGridView.Location = new System.Drawing.Point(868, 40);
            this.tBL_EMP_SHIFTDataGridView.Name = "tBL_EMP_SHIFTDataGridView";
            this.tBL_EMP_SHIFTDataGridView.ReadOnly = true;
            this.tBL_EMP_SHIFTDataGridView.Size = new System.Drawing.Size(497, 369);
            this.tBL_EMP_SHIFTDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "EPID";
            this.dataGridViewTextBoxColumn8.HeaderText = "EPID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 40;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ESNAME";
            this.dataGridViewTextBoxColumn14.HeaderText = "ESNAME";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ESSTART";
            this.dataGridViewTextBoxColumn16.HeaderText = "ESSTART";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 130;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "ESEND";
            this.dataGridViewTextBoxColumn17.HeaderText = "ESEND";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 130;
            // 
            // tBL_EMP_SHIFTBindingSource
            // 
            this.tBL_EMP_SHIFTBindingSource.DataSource = typeof(AttendanceArcive.TBL_EMP_SHIFT);
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
            // employeeAttendanceRecordBindingSource
            // 
            this.employeeAttendanceRecordBindingSource.DataSource = typeof(AttendanceArcive.EmployeeAttendanceRecord);
            // 
            // newVacationsBindingSource
            // 
            this.newVacationsBindingSource.DataSource = typeof(AttendanceArcive.EmployeeVacation);
            // 
            // tBL_EMP_TRANS_MSTBindingSource
            // 
            this.tBL_EMP_TRANS_MSTBindingSource.DataSource = typeof(AttendanceArcive.TBL_EMP_TRANS_MST);
            // 
            // tBL_EMP_TRANS_MSTDataGridView
            // 
            this.tBL_EMP_TRANS_MSTDataGridView.AllowUserToAddRows = false;
            this.tBL_EMP_TRANS_MSTDataGridView.AllowUserToDeleteRows = false;
            this.tBL_EMP_TRANS_MSTDataGridView.AutoGenerateColumns = false;
            this.tBL_EMP_TRANS_MSTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tBL_EMP_TRANS_MSTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.TMDATE,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23});
            this.tBL_EMP_TRANS_MSTDataGridView.DataSource = this.tBL_EMP_TRANS_MSTBindingSource;
            this.tBL_EMP_TRANS_MSTDataGridView.Location = new System.Drawing.Point(20, 620);
            this.tBL_EMP_TRANS_MSTDataGridView.Name = "tBL_EMP_TRANS_MSTDataGridView";
            this.tBL_EMP_TRANS_MSTDataGridView.ReadOnly = true;
            this.tBL_EMP_TRANS_MSTDataGridView.Size = new System.Drawing.Size(1345, 184);
            this.tBL_EMP_TRANS_MSTDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "EPID";
            this.dataGridViewTextBoxColumn15.HeaderText = "EPID";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // TMDATE
            // 
            this.TMDATE.DataPropertyName = "TMDATE";
            this.TMDATE.HeaderText = "TMDATE";
            this.TMDATE.Name = "TMDATE";
            this.TMDATE.ReadOnly = true;
            this.TMDATE.Width = 150;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "HOID";
            this.dataGridViewTextBoxColumn21.HeaderText = "HOID";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "HOCODE";
            this.dataGridViewTextBoxColumn22.HeaderText = "HOCODE";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn23.DataPropertyName = "HONAME";
            this.dataGridViewTextBoxColumn23.HeaderText = "HONAME";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 889);
            this.Controls.Add(this.tBL_EMP_TRANS_MSTDataGridView);
            this.Controls.Add(this.tBL_EMP_SHIFTDataGridView);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.employeeVacationDataGridView);
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
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBL_EMPLOYEESDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TRANSDUMPSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeVacationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_EMP_SHIFTDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_EMP_SHIFTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeVacationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TRANSDUMPSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_EMPLOYEESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAttendanceRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVacationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_EMP_TRANS_MSTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_EMP_TRANS_MSTDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource employeeVacationBindingSource;
        private System.Windows.Forms.DataGridView employeeVacationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacationTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.BindingSource newVacationsBindingSource;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.BindingSource tBL_EMP_SHIFTBindingSource;
        private System.Windows.Forms.DataGridView tBL_EMP_SHIFTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.BindingSource tBL_EMP_TRANS_MSTBindingSource;
        private System.Windows.Forms.DataGridView tBL_EMP_TRANS_MSTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn TMDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
    }
}

