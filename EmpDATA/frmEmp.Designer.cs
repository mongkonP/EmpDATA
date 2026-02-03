namespace EmpDATA
{
    partial class frmEmp
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
            System.Windows.Forms.Label attendanceIDLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label workDateLabel;
            System.Windows.Forms.Label shiftIDLabel;
            System.Windows.Forms.Label checkInTimeLabel;
            System.Windows.Forms.Label checkOutTimeLabel;
            System.Windows.Forms.Label workMinutesLabel;
            System.Windows.Forms.Label lateMinutesLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label workHoursLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmp));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tblAttendanceDataGridView = new System.Windows.Forms.DataGridView();
            this.attendanceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lateMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.earlyLeaveMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oTMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB = new EmpDATA.DATA.DB();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.workHoursTextBox = new System.Windows.Forms.TextBox();
            this.tblShiftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.endTimeTextBox = new System.Windows.Forms.TextBox();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.lateMinutesTextBox = new System.Windows.Forms.TextBox();
            this.workMinutesTextBox = new System.Windows.Forms.TextBox();
            this.checkOutTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkInTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shiftIDTextBox = new System.Windows.Forms.TextBox();
            this.workDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.attendanceIDTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEmpID_Find = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tblEmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resignDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmployeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tblShiftDataGridView = new System.Windows.Forms.DataGridView();
            this.shiftIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tblAttendanceTableAdapter = new EmpDATA.DATA.DBTableAdapters.tblAttendanceTableAdapter();
            this.tblEmployeeTableAdapter = new EmpDATA.DATA.DBTableAdapters.tblEmployeeTableAdapter();
            this.tableAdapterManager1 = new EmpDATA.DATA.DBTableAdapters.TableAdapterManager();
            this.tblShiftTableAdapter1 = new EmpDATA.DATA.DBTableAdapters.tblShiftTableAdapter();
            this.btnFind = new System.Windows.Forms.Button();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tblEmployeeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.tblShiftBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            attendanceIDLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            workDateLabel = new System.Windows.Forms.Label();
            shiftIDLabel = new System.Windows.Forms.Label();
            checkInTimeLabel = new System.Windows.Forms.Label();
            checkOutTimeLabel = new System.Windows.Forms.Label();
            workMinutesLabel = new System.Windows.Forms.Label();
            lateMinutesLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            workHoursLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAttendanceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblShiftBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingNavigator)).BeginInit();
            this.tblEmployeeBindingNavigator.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblShiftDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblShiftBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // attendanceIDLabel
            // 
            attendanceIDLabel.AutoSize = true;
            attendanceIDLabel.Location = new System.Drawing.Point(8, 22);
            attendanceIDLabel.Name = "attendanceIDLabel";
            attendanceIDLabel.Size = new System.Drawing.Size(79, 13);
            attendanceIDLabel.TabIndex = 0;
            attendanceIDLabel.Text = "Attendance ID:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(17, 48);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(70, 13);
            employeeIDLabel.TabIndex = 2;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // workDateLabel
            // 
            workDateLabel.AutoSize = true;
            workDateLabel.Location = new System.Drawing.Point(25, 75);
            workDateLabel.Name = "workDateLabel";
            workDateLabel.Size = new System.Drawing.Size(62, 13);
            workDateLabel.TabIndex = 4;
            workDateLabel.Text = "Work Date:";
            // 
            // shiftIDLabel
            // 
            shiftIDLabel.AutoSize = true;
            shiftIDLabel.Location = new System.Drawing.Point(42, 100);
            shiftIDLabel.Name = "shiftIDLabel";
            shiftIDLabel.Size = new System.Drawing.Size(45, 13);
            shiftIDLabel.TabIndex = 6;
            shiftIDLabel.Text = "Shift ID:";
            // 
            // checkInTimeLabel
            // 
            checkInTimeLabel.AutoSize = true;
            checkInTimeLabel.Location = new System.Drawing.Point(215, 75);
            checkInTimeLabel.Name = "checkInTimeLabel";
            checkInTimeLabel.Size = new System.Drawing.Size(79, 13);
            checkInTimeLabel.TabIndex = 8;
            checkInTimeLabel.Text = "Check In Time:";
            // 
            // checkOutTimeLabel
            // 
            checkOutTimeLabel.AutoSize = true;
            checkOutTimeLabel.Location = new System.Drawing.Point(403, 75);
            checkOutTimeLabel.Name = "checkOutTimeLabel";
            checkOutTimeLabel.Size = new System.Drawing.Size(87, 13);
            checkOutTimeLabel.TabIndex = 10;
            checkOutTimeLabel.Text = "Check Out Time:";
            // 
            // workMinutesLabel
            // 
            workMinutesLabel.AutoSize = true;
            workMinutesLabel.Location = new System.Drawing.Point(595, 74);
            workMinutesLabel.Name = "workMinutesLabel";
            workMinutesLabel.Size = new System.Drawing.Size(76, 13);
            workMinutesLabel.TabIndex = 12;
            workMinutesLabel.Text = "Work Minutes:";
            // 
            // lateMinutesLabel
            // 
            lateMinutesLabel.AutoSize = true;
            lateMinutesLabel.Location = new System.Drawing.Point(795, 75);
            lateMinutesLabel.Name = "lateMinutesLabel";
            lateMinutesLabel.Size = new System.Drawing.Size(71, 13);
            lateMinutesLabel.TabIndex = 14;
            lateMinutesLabel.Text = "Late Minutes:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(236, 100);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(58, 13);
            startTimeLabel.TabIndex = 16;
            startTimeLabel.Text = "Start Time:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(435, 100);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(55, 13);
            endTimeLabel.TabIndex = 18;
            endTimeLabel.Text = "End Time:";
            // 
            // workHoursLabel
            // 
            workHoursLabel.AutoSize = true;
            workHoursLabel.Location = new System.Drawing.Point(604, 100);
            workHoursLabel.Name = "workHoursLabel";
            workHoursLabel.Size = new System.Drawing.Size(67, 13);
            workHoursLabel.TabIndex = 20;
            workHoursLabel.Text = "Work Hours:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1091, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.tblAttendanceDataGridView);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.bindingNavigator2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1083, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ตารางการทำงาน";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tblAttendanceDataGridView
            // 
            this.tblAttendanceDataGridView.AllowUserToAddRows = false;
            this.tblAttendanceDataGridView.AllowUserToDeleteRows = false;
            this.tblAttendanceDataGridView.AutoGenerateColumns = false;
            this.tblAttendanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAttendanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attendanceIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.workDateDataGridViewTextBoxColumn,
            this.shiftIDDataGridViewTextBoxColumn,
            this.checkInTimeDataGridViewTextBoxColumn,
            this.checkOutTimeDataGridViewTextBoxColumn,
            this.workMinutesDataGridViewTextBoxColumn,
            this.lateMinutesDataGridViewTextBoxColumn,
            this.earlyLeaveMinutesDataGridViewTextBoxColumn,
            this.oTMinutesDataGridViewTextBoxColumn,
            this.workStatusDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.approvedByDataGridViewTextBoxColumn,
            this.approvedDateDataGridViewTextBoxColumn});
            this.tblAttendanceDataGridView.DataSource = this.tblAttendanceBindingSource;
            this.tblAttendanceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblAttendanceDataGridView.Location = new System.Drawing.Point(3, 28);
            this.tblAttendanceDataGridView.Name = "tblAttendanceDataGridView";
            this.tblAttendanceDataGridView.ReadOnly = true;
            this.tblAttendanceDataGridView.Size = new System.Drawing.Size(1077, 156);
            this.tblAttendanceDataGridView.TabIndex = 3;
            this.tblAttendanceDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblAttendanceDataGridView_CellClick);
            // 
            // attendanceIDDataGridViewTextBoxColumn
            // 
            this.attendanceIDDataGridViewTextBoxColumn.DataPropertyName = "AttendanceID";
            this.attendanceIDDataGridViewTextBoxColumn.HeaderText = "AttendanceID";
            this.attendanceIDDataGridViewTextBoxColumn.Name = "attendanceIDDataGridViewTextBoxColumn";
            this.attendanceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workDateDataGridViewTextBoxColumn
            // 
            this.workDateDataGridViewTextBoxColumn.DataPropertyName = "WorkDate";
            this.workDateDataGridViewTextBoxColumn.HeaderText = "WorkDate";
            this.workDateDataGridViewTextBoxColumn.Name = "workDateDataGridViewTextBoxColumn";
            this.workDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shiftIDDataGridViewTextBoxColumn
            // 
            this.shiftIDDataGridViewTextBoxColumn.DataPropertyName = "ShiftID";
            this.shiftIDDataGridViewTextBoxColumn.HeaderText = "ShiftID";
            this.shiftIDDataGridViewTextBoxColumn.Name = "shiftIDDataGridViewTextBoxColumn";
            this.shiftIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkInTimeDataGridViewTextBoxColumn
            // 
            this.checkInTimeDataGridViewTextBoxColumn.DataPropertyName = "CheckInTime";
            this.checkInTimeDataGridViewTextBoxColumn.HeaderText = "CheckInTime";
            this.checkInTimeDataGridViewTextBoxColumn.Name = "checkInTimeDataGridViewTextBoxColumn";
            this.checkInTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkOutTimeDataGridViewTextBoxColumn
            // 
            this.checkOutTimeDataGridViewTextBoxColumn.DataPropertyName = "CheckOutTime";
            this.checkOutTimeDataGridViewTextBoxColumn.HeaderText = "CheckOutTime";
            this.checkOutTimeDataGridViewTextBoxColumn.Name = "checkOutTimeDataGridViewTextBoxColumn";
            this.checkOutTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workMinutesDataGridViewTextBoxColumn
            // 
            this.workMinutesDataGridViewTextBoxColumn.DataPropertyName = "WorkMinutes";
            this.workMinutesDataGridViewTextBoxColumn.HeaderText = "WorkMinutes";
            this.workMinutesDataGridViewTextBoxColumn.Name = "workMinutesDataGridViewTextBoxColumn";
            this.workMinutesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lateMinutesDataGridViewTextBoxColumn
            // 
            this.lateMinutesDataGridViewTextBoxColumn.DataPropertyName = "LateMinutes";
            this.lateMinutesDataGridViewTextBoxColumn.HeaderText = "LateMinutes";
            this.lateMinutesDataGridViewTextBoxColumn.Name = "lateMinutesDataGridViewTextBoxColumn";
            this.lateMinutesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // earlyLeaveMinutesDataGridViewTextBoxColumn
            // 
            this.earlyLeaveMinutesDataGridViewTextBoxColumn.DataPropertyName = "EarlyLeaveMinutes";
            this.earlyLeaveMinutesDataGridViewTextBoxColumn.HeaderText = "EarlyLeaveMinutes";
            this.earlyLeaveMinutesDataGridViewTextBoxColumn.Name = "earlyLeaveMinutesDataGridViewTextBoxColumn";
            this.earlyLeaveMinutesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oTMinutesDataGridViewTextBoxColumn
            // 
            this.oTMinutesDataGridViewTextBoxColumn.DataPropertyName = "OTMinutes";
            this.oTMinutesDataGridViewTextBoxColumn.HeaderText = "OTMinutes";
            this.oTMinutesDataGridViewTextBoxColumn.Name = "oTMinutesDataGridViewTextBoxColumn";
            this.oTMinutesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workStatusDataGridViewTextBoxColumn
            // 
            this.workStatusDataGridViewTextBoxColumn.DataPropertyName = "WorkStatus";
            this.workStatusDataGridViewTextBoxColumn.HeaderText = "WorkStatus";
            this.workStatusDataGridViewTextBoxColumn.Name = "workStatusDataGridViewTextBoxColumn";
            this.workStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // approvedByDataGridViewTextBoxColumn
            // 
            this.approvedByDataGridViewTextBoxColumn.DataPropertyName = "ApprovedBy";
            this.approvedByDataGridViewTextBoxColumn.HeaderText = "ApprovedBy";
            this.approvedByDataGridViewTextBoxColumn.Name = "approvedByDataGridViewTextBoxColumn";
            this.approvedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // approvedDateDataGridViewTextBoxColumn
            // 
            this.approvedDateDataGridViewTextBoxColumn.DataPropertyName = "ApprovedDate";
            this.approvedDateDataGridViewTextBoxColumn.HeaderText = "ApprovedDate";
            this.approvedDateDataGridViewTextBoxColumn.Name = "approvedDateDataGridViewTextBoxColumn";
            this.approvedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblAttendanceBindingSource
            // 
            this.tblAttendanceBindingSource.DataMember = "tblAttendance";
            this.tblAttendanceBindingSource.DataSource = this.dB;
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 237);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.statusStrip1);
            this.groupBox2.Controls.Add(workHoursLabel);
            this.groupBox2.Controls.Add(this.workHoursTextBox);
            this.groupBox2.Controls.Add(endTimeLabel);
            this.groupBox2.Controls.Add(this.endTimeTextBox);
            this.groupBox2.Controls.Add(startTimeLabel);
            this.groupBox2.Controls.Add(this.startTimeTextBox);
            this.groupBox2.Controls.Add(lateMinutesLabel);
            this.groupBox2.Controls.Add(this.lateMinutesTextBox);
            this.groupBox2.Controls.Add(workMinutesLabel);
            this.groupBox2.Controls.Add(this.workMinutesTextBox);
            this.groupBox2.Controls.Add(checkOutTimeLabel);
            this.groupBox2.Controls.Add(this.checkOutTimeDateTimePicker);
            this.groupBox2.Controls.Add(checkInTimeLabel);
            this.groupBox2.Controls.Add(this.checkInTimeDateTimePicker);
            this.groupBox2.Controls.Add(shiftIDLabel);
            this.groupBox2.Controls.Add(this.shiftIDTextBox);
            this.groupBox2.Controls.Add(workDateLabel);
            this.groupBox2.Controls.Add(this.workDateDateTimePicker);
            this.groupBox2.Controls.Add(employeeIDLabel);
            this.groupBox2.Controls.Add(this.employeeIDTextBox);
            this.groupBox2.Controls.Add(attendanceIDLabel);
            this.groupBox2.Controls.Add(this.attendanceIDTextBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1077, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "เพิ่ม/แก้ไข";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(3, 150);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1071, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Status";
            // 
            // workHoursTextBox
            // 
            this.workHoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblShiftBindingSource1, "WorkHours", true));
            this.workHoursTextBox.Location = new System.Drawing.Point(677, 97);
            this.workHoursTextBox.Name = "workHoursTextBox";
            this.workHoursTextBox.ReadOnly = true;
            this.workHoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.workHoursTextBox.TabIndex = 21;
            // 
            // tblShiftBindingSource
            // 
            this.tblShiftBindingSource.DataMember = "tblShift";
            this.tblShiftBindingSource.DataSource = this.dB;
            // 
            // endTimeTextBox
            // 
            this.endTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblShiftBindingSource1, "EndTime", true));
            this.endTimeTextBox.Location = new System.Drawing.Point(496, 97);
            this.endTimeTextBox.Name = "endTimeTextBox";
            this.endTimeTextBox.ReadOnly = true;
            this.endTimeTextBox.Size = new System.Drawing.Size(87, 20);
            this.endTimeTextBox.TabIndex = 19;
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblShiftBindingSource1, "StartTime", true));
            this.startTimeTextBox.Location = new System.Drawing.Point(300, 97);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.ReadOnly = true;
            this.startTimeTextBox.Size = new System.Drawing.Size(93, 20);
            this.startTimeTextBox.TabIndex = 17;
            // 
            // lateMinutesTextBox
            // 
            this.lateMinutesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAttendanceBindingSource, "LateMinutes", true));
            this.lateMinutesTextBox.Location = new System.Drawing.Point(872, 72);
            this.lateMinutesTextBox.Name = "lateMinutesTextBox";
            this.lateMinutesTextBox.Size = new System.Drawing.Size(100, 20);
            this.lateMinutesTextBox.TabIndex = 15;
            // 
            // workMinutesTextBox
            // 
            this.workMinutesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAttendanceBindingSource, "WorkMinutes", true));
            this.workMinutesTextBox.Location = new System.Drawing.Point(677, 71);
            this.workMinutesTextBox.Name = "workMinutesTextBox";
            this.workMinutesTextBox.Size = new System.Drawing.Size(100, 20);
            this.workMinutesTextBox.TabIndex = 13;
            // 
            // checkOutTimeDateTimePicker
            // 
            this.checkOutTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblAttendanceBindingSource, "CheckOutTime", true));
            this.checkOutTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.checkOutTimeDateTimePicker.Location = new System.Drawing.Point(496, 71);
            this.checkOutTimeDateTimePicker.Name = "checkOutTimeDateTimePicker";
            this.checkOutTimeDateTimePicker.Size = new System.Drawing.Size(87, 20);
            this.checkOutTimeDateTimePicker.TabIndex = 11;
            // 
            // checkInTimeDateTimePicker
            // 
            this.checkInTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblAttendanceBindingSource, "CheckInTime", true));
            this.checkInTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.checkInTimeDateTimePicker.Location = new System.Drawing.Point(300, 71);
            this.checkInTimeDateTimePicker.Name = "checkInTimeDateTimePicker";
            this.checkInTimeDateTimePicker.Size = new System.Drawing.Size(93, 20);
            this.checkInTimeDateTimePicker.TabIndex = 9;
            // 
            // shiftIDTextBox
            // 
            this.shiftIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAttendanceBindingSource, "ShiftID", true));
            this.shiftIDTextBox.Location = new System.Drawing.Point(93, 97);
            this.shiftIDTextBox.Name = "shiftIDTextBox";
            this.shiftIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.shiftIDTextBox.TabIndex = 7;
            // 
            // workDateDateTimePicker
            // 
            this.workDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblAttendanceBindingSource, "WorkDate", true));
            this.workDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.workDateDateTimePicker.Location = new System.Drawing.Point(93, 71);
            this.workDateDateTimePicker.Name = "workDateDateTimePicker";
            this.workDateDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.workDateDateTimePicker.TabIndex = 5;
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAttendanceBindingSource, "EmployeeID", true));
            this.employeeIDTextBox.Location = new System.Drawing.Point(93, 45);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.employeeIDTextBox.TabIndex = 3;
            // 
            // attendanceIDTextBox
            // 
            this.attendanceIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAttendanceBindingSource, "AttendanceID", true));
            this.attendanceIDTextBox.Location = new System.Drawing.Point(93, 19);
            this.attendanceIDTextBox.Name = "attendanceIDTextBox";
            this.attendanceIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.attendanceIDTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.txtEmpID_Find);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหา";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(553, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Test DATA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmpID_Find
            // 
            this.txtEmpID_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtEmpID_Find.Location = new System.Drawing.Point(400, 23);
            this.txtEmpID_Find.Name = "txtEmpID_Find";
            this.txtEmpID_Find.Size = new System.Drawing.Size(100, 24);
            this.txtEmpID_Find.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(199, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(118, 24);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(172, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "to";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 24);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(336, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "EmpID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.toolStripButton8;
            this.bindingNavigator2.BindingSource = this.tblAttendanceBindingSource;
            this.bindingNavigator2.CountItem = this.toolStripLabel2;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripSeparator6,
            this.toolStripButton8,
            this.toolStripButton14});
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton10;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton13;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton12;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton11;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox2;
            this.bindingNavigator2.Size = new System.Drawing.Size(1077, 25);
            this.bindingNavigator2.TabIndex = 3;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tblEmployeeDataGridView);
            this.tabPage1.Controls.Add(this.tblEmployeeBindingNavigator);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1083, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tblEmployeeDataGridView
            // 
            this.tblEmployeeDataGridView.AutoGenerateColumns = false;
            this.tblEmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblEmployeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn1,
            this.employeeCodeDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.resignDateDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.tblEmployeeDataGridView.DataSource = this.tblEmployeeBindingSource;
            this.tblEmployeeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEmployeeDataGridView.Location = new System.Drawing.Point(3, 28);
            this.tblEmployeeDataGridView.Name = "tblEmployeeDataGridView";
            this.tblEmployeeDataGridView.Size = new System.Drawing.Size(1077, 393);
            this.tblEmployeeDataGridView.TabIndex = 0;
            // 
            // employeeIDDataGridViewTextBoxColumn1
            // 
            this.employeeIDDataGridViewTextBoxColumn1.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn1.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn1.Name = "employeeIDDataGridViewTextBoxColumn1";
            this.employeeIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // employeeCodeDataGridViewTextBoxColumn
            // 
            this.employeeCodeDataGridViewTextBoxColumn.DataPropertyName = "EmployeeCode";
            this.employeeCodeDataGridViewTextBoxColumn.HeaderText = "EmployeeCode";
            this.employeeCodeDataGridViewTextBoxColumn.Name = "employeeCodeDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // resignDateDataGridViewTextBoxColumn
            // 
            this.resignDateDataGridViewTextBoxColumn.DataPropertyName = "ResignDate";
            this.resignDateDataGridViewTextBoxColumn.HeaderText = "ResignDate";
            this.resignDateDataGridViewTextBoxColumn.Name = "resignDateDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // tblEmployeeBindingSource
            // 
            this.tblEmployeeBindingSource.DataMember = "tblEmployee";
            this.tblEmployeeBindingSource.DataSource = this.dB;
            // 
            // tblEmployeeBindingNavigator
            // 
            this.tblEmployeeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblEmployeeBindingNavigator.BindingSource = this.tblEmployeeBindingSource;
            this.tblEmployeeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblEmployeeBindingNavigator.DeleteItem = null;
            this.tblEmployeeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.tblEmployeeBindingNavigatorSaveItem});
            this.tblEmployeeBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.tblEmployeeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblEmployeeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblEmployeeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblEmployeeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblEmployeeBindingNavigator.Name = "tblEmployeeBindingNavigator";
            this.tblEmployeeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblEmployeeBindingNavigator.Size = new System.Drawing.Size(1077, 25);
            this.tblEmployeeBindingNavigator.TabIndex = 2;
            this.tblEmployeeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tblShiftDataGridView);
            this.tabPage2.Controls.Add(this.bindingNavigator1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1083, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ตารางเวลาเข้า-ออก งาน";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tblShiftDataGridView
            // 
            this.tblShiftDataGridView.AutoGenerateColumns = false;
            this.tblShiftDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblShiftDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shiftIDDataGridViewTextBoxColumn1,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.workHoursDataGridViewTextBoxColumn});
            this.tblShiftDataGridView.DataSource = this.tblShiftBindingSource;
            this.tblShiftDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblShiftDataGridView.Location = new System.Drawing.Point(3, 28);
            this.tblShiftDataGridView.Name = "tblShiftDataGridView";
            this.tblShiftDataGridView.Size = new System.Drawing.Size(1077, 393);
            this.tblShiftDataGridView.TabIndex = 2;
            // 
            // shiftIDDataGridViewTextBoxColumn1
            // 
            this.shiftIDDataGridViewTextBoxColumn1.DataPropertyName = "ShiftID";
            this.shiftIDDataGridViewTextBoxColumn1.HeaderText = "ShiftID";
            this.shiftIDDataGridViewTextBoxColumn1.Name = "shiftIDDataGridViewTextBoxColumn1";
            this.shiftIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            // 
            // workHoursDataGridViewTextBoxColumn
            // 
            this.workHoursDataGridViewTextBoxColumn.DataPropertyName = "WorkHours";
            this.workHoursDataGridViewTextBoxColumn.HeaderText = "WorkHours";
            this.workHoursDataGridViewTextBoxColumn.Name = "workHoursDataGridViewTextBoxColumn";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton1;
            this.bindingNavigator1.BindingSource = this.tblShiftBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton7});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1077, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tblAttendanceTableAdapter
            // 
            this.tblAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // tblEmployeeTableAdapter
            // 
            this.tblEmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tblAttendanceTableAdapter = this.tblAttendanceTableAdapter;
            this.tableAdapterManager1.tblEmployeeTableAdapter = this.tblEmployeeTableAdapter;
            this.tableAdapterManager1.tblShiftTableAdapter = this.tblShiftTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = EmpDATA.DATA.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblShiftTableAdapter1
            // 
            this.tblShiftTableAdapter1.ClearBeforeFill = true;
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = global::EmpDATA.Properties.Resources.search32x32;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFind.Location = new System.Drawing.Point(506, 21);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(41, 31);
            this.btnFind.TabIndex = 6;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Add new";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Move first";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Move previous";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Move next";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "Move last";
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "Save Data";
            this.toolStripButton14.Click += new System.EventHandler(this.toolStripButton14_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // tblEmployeeBindingNavigatorSaveItem
            // 
            this.tblEmployeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblEmployeeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblEmployeeBindingNavigatorSaveItem.Image")));
            this.tblEmployeeBindingNavigatorSaveItem.Name = "tblEmployeeBindingNavigatorSaveItem";
            this.tblEmployeeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblEmployeeBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Add new";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Save Data";
            // 
            // tblShiftBindingSource1
            // 
            this.tblShiftBindingSource1.DataMember = "tblShift";
            this.tblShiftBindingSource1.DataSource = this.dB;
            // 
            // frmEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Work";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmp_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAttendanceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblShiftBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingNavigator)).EndInit();
            this.tblEmployeeBindingNavigator.ResumeLayout(false);
            this.tblEmployeeBindingNavigator.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblShiftDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblShiftBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtEmpID_Find;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView tblEmployeeDataGridView;
        private System.Windows.Forms.BindingNavigator tblEmployeeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblEmployeeBindingNavigatorSaveItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView tblShiftDataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private DATA.DB dB;
        private System.Windows.Forms.BindingSource tblAttendanceBindingSource;
        private DATA.DBTableAdapters.tblAttendanceTableAdapter tblAttendanceTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isManualDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblEmployeeBindingSource;
        private DATA.DBTableAdapters.tblEmployeeTableAdapter tblEmployeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resignDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource tblShiftBindingSource;
        //private DATA.DBTableAdapters.tblShiftTableAdapter tblShiftTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn2;
        private DATA.DBTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tblAttendanceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lateMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn earlyLeaveMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oTMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker workDateDateTimePicker;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.TextBox attendanceIDTextBox;
        private System.Windows.Forms.TextBox workHoursTextBox;
        private System.Windows.Forms.TextBox endTimeTextBox;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.TextBox lateMinutesTextBox;
        private System.Windows.Forms.TextBox workMinutesTextBox;
        private System.Windows.Forms.DateTimePicker checkOutTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker checkInTimeDateTimePicker;
        private System.Windows.Forms.TextBox shiftIDTextBox;
        private DATA.DBTableAdapters.tblShiftTableAdapter tblShiftTableAdapter1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.BindingSource tblShiftBindingSource1;
    }
}