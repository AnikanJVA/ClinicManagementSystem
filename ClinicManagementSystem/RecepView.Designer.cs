namespace ClinicManagementSystem
{
    partial class RecepView
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
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.AccountTypelabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.DoctorsButton = new System.Windows.Forms.Button();
            this.BillingButton = new System.Windows.Forms.Button();
            this.PatientsButton = new System.Windows.Forms.Button();
            this.AppointmentsButton = new System.Windows.Forms.Button();
            this.billingDataGridView = new System.Windows.Forms.DataGridView();
            this.createBillButton = new System.Windows.Forms.Button();
            this.UpdateDoctorButton = new System.Windows.Forms.Button();
            this.createAppointmentButton = new System.Windows.Forms.Button();
            this.updateApointmentButton = new System.Windows.Forms.Button();
            this.AppointmentTabControl = new System.Windows.Forms.TabControl();
            this.ApprovedAppointmentTab = new System.Windows.Forms.TabPage();
            this.ApprovedDataGridView = new System.Windows.Forms.DataGridView();
            this.PendingAppointmentTab = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.RescheduledAppointmentTab = new System.Windows.Forms.TabPage();
            this.CanceledAppointmentTab = new System.Windows.Forms.TabPage();
            this.FinishedAppointmentTab = new System.Windows.Forms.TabPage();
            this.DoctorTabControl = new System.Windows.Forms.TabControl();
            this.AllDoctorsTab = new System.Windows.Forms.TabPage();
            this.ActiveDoctorsTab = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.RegisterDoctorButton = new System.Windows.Forms.Button();
            this.PatientsTabControl = new System.Windows.Forms.TabControl();
            this.AllPatientsTab = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.ActivePatientsTab = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.InactivePatientsTab = new System.Windows.Forms.TabPage();
            this.UnavailableDoctorsTab = new System.Windows.Forms.TabPage();
            this.InactiveDoctorsTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RegisterPatientButton = new System.Windows.Forms.Button();
            this.UpdatePatientButton = new System.Windows.Forms.Button();
            this.SearchPatientButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billingDataGridView)).BeginInit();
            this.AppointmentTabControl.SuspendLayout();
            this.ApprovedAppointmentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApprovedDataGridView)).BeginInit();
            this.PendingAppointmentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.DoctorTabControl.SuspendLayout();
            this.AllDoctorsTab.SuspendLayout();
            this.ActiveDoctorsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.PatientsTabControl.SuspendLayout();
            this.AllPatientsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.ActivePatientsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.InactivePatientsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
            this.SplitContainer.Panel1.Controls.Add(this.AccountTypelabel);
            this.SplitContainer.Panel1.Controls.Add(this.LogoutButton);
            this.SplitContainer.Panel1.Controls.Add(this.DoctorsButton);
            this.SplitContainer.Panel1.Controls.Add(this.BillingButton);
            this.SplitContainer.Panel1.Controls.Add(this.PatientsButton);
            this.SplitContainer.Panel1.Controls.Add(this.AppointmentsButton);
            this.SplitContainer.Panel1MinSize = 282;
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
            this.SplitContainer.Panel2.Controls.Add(this.SearchPatientButton);
            this.SplitContainer.Panel2.Controls.Add(this.UpdatePatientButton);
            this.SplitContainer.Panel2.Controls.Add(this.RegisterPatientButton);
            this.SplitContainer.Panel2.Controls.Add(this.UpdateDoctorButton);
            this.SplitContainer.Panel2.Controls.Add(this.createAppointmentButton);
            this.SplitContainer.Panel2.Controls.Add(this.updateApointmentButton);
            this.SplitContainer.Panel2.Controls.Add(this.RegisterDoctorButton);
            this.SplitContainer.Panel2.Controls.Add(this.PatientsTabControl);
            this.SplitContainer.Panel2.Controls.Add(this.AppointmentTabControl);
            this.SplitContainer.Panel2.Controls.Add(this.DoctorTabControl);
            this.SplitContainer.Panel2.Controls.Add(this.createBillButton);
            this.SplitContainer.Panel2MinSize = 978;
            this.SplitContainer.Size = new System.Drawing.Size(1264, 681);
            this.SplitContainer.SplitterDistance = 282;
            this.SplitContainer.TabIndex = 0;
            // 
            // AccountTypelabel
            // 
            this.AccountTypelabel.AutoSize = true;
            this.AccountTypelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.AccountTypelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountTypelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.AccountTypelabel.ForeColor = System.Drawing.Color.White;
            this.AccountTypelabel.Location = new System.Drawing.Point(63, 12);
            this.AccountTypelabel.Name = "AccountTypelabel";
            this.AccountTypelabel.Size = new System.Drawing.Size(149, 31);
            this.AccountTypelabel.TabIndex = 0;
            this.AccountTypelabel.Text = "Receptionist";
            this.AccountTypelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.LogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(20, 578);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(239, 66);
            this.LogoutButton.TabIndex = 7;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // DoctorsButton
            // 
            this.DoctorsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.DoctorsButton.FlatAppearance.BorderSize = 0;
            this.DoctorsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.DoctorsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.DoctorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoctorsButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorsButton.ForeColor = System.Drawing.Color.White;
            this.DoctorsButton.Location = new System.Drawing.Point(20, 317);
            this.DoctorsButton.Name = "DoctorsButton";
            this.DoctorsButton.Size = new System.Drawing.Size(239, 66);
            this.DoctorsButton.TabIndex = 4;
            this.DoctorsButton.Text = "Doctors";
            this.DoctorsButton.UseVisualStyleBackColor = false;
            this.DoctorsButton.Click += new System.EventHandler(this.DoctorsButton_Click);
            // 
            // BillingButton
            // 
            this.BillingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.BillingButton.FlatAppearance.BorderSize = 0;
            this.BillingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.BillingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.BillingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillingButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillingButton.ForeColor = System.Drawing.Color.White;
            this.BillingButton.Location = new System.Drawing.Point(20, 230);
            this.BillingButton.Name = "BillingButton";
            this.BillingButton.Size = new System.Drawing.Size(239, 66);
            this.BillingButton.TabIndex = 3;
            this.BillingButton.Text = "Billing";
            this.BillingButton.UseVisualStyleBackColor = false;
            this.BillingButton.Click += new System.EventHandler(this.BillingButton_Click);
            // 
            // PatientsButton
            // 
            this.PatientsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.PatientsButton.FlatAppearance.BorderSize = 0;
            this.PatientsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.PatientsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.PatientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientsButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientsButton.ForeColor = System.Drawing.Color.White;
            this.PatientsButton.Location = new System.Drawing.Point(20, 145);
            this.PatientsButton.Name = "PatientsButton";
            this.PatientsButton.Size = new System.Drawing.Size(239, 66);
            this.PatientsButton.TabIndex = 2;
            this.PatientsButton.Text = "Patients";
            this.PatientsButton.UseVisualStyleBackColor = false;
            this.PatientsButton.Click += new System.EventHandler(this.PatientsButton_Click);
            // 
            // AppointmentsButton
            // 
            this.AppointmentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.AppointmentsButton.FlatAppearance.BorderSize = 0;
            this.AppointmentsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.AppointmentsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.AppointmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppointmentsButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentsButton.ForeColor = System.Drawing.Color.White;
            this.AppointmentsButton.Location = new System.Drawing.Point(20, 63);
            this.AppointmentsButton.Name = "AppointmentsButton";
            this.AppointmentsButton.Size = new System.Drawing.Size(239, 66);
            this.AppointmentsButton.TabIndex = 1;
            this.AppointmentsButton.Text = "Appointments";
            this.AppointmentsButton.UseVisualStyleBackColor = false;
            this.AppointmentsButton.Click += new System.EventHandler(this.AppointmentsButton_Click);
            // 
            // billingDataGridView
            // 
            this.billingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billingDataGridView.Location = new System.Drawing.Point(6, 17);
            this.billingDataGridView.Name = "billingDataGridView";
            this.billingDataGridView.Size = new System.Drawing.Size(881, 510);
            this.billingDataGridView.TabIndex = 13;
            this.billingDataGridView.Visible = false;
            // 
            // createBillButton
            // 
            this.createBillButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.createBillButton.FlatAppearance.BorderSize = 0;
            this.createBillButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.createBillButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.createBillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBillButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBillButton.ForeColor = System.Drawing.Color.White;
            this.createBillButton.Location = new System.Drawing.Point(271, 578);
            this.createBillButton.Name = "createBillButton";
            this.createBillButton.Size = new System.Drawing.Size(410, 66);
            this.createBillButton.TabIndex = 10;
            this.createBillButton.Text = "Create Bill";
            this.createBillButton.UseVisualStyleBackColor = false;
            this.createBillButton.Visible = false;
            this.createBillButton.Click += new System.EventHandler(this.createBillButton_Click);
            // 
            // UpdateDoctorButton
            // 
            this.UpdateDoctorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.UpdateDoctorButton.FlatAppearance.BorderSize = 0;
            this.UpdateDoctorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.UpdateDoctorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.UpdateDoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateDoctorButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDoctorButton.ForeColor = System.Drawing.Color.White;
            this.UpdateDoctorButton.Location = new System.Drawing.Point(516, 578);
            this.UpdateDoctorButton.Name = "UpdateDoctorButton";
            this.UpdateDoctorButton.Size = new System.Drawing.Size(410, 66);
            this.UpdateDoctorButton.TabIndex = 11;
            this.UpdateDoctorButton.Text = "Update Doctor";
            this.UpdateDoctorButton.UseVisualStyleBackColor = false;
            this.UpdateDoctorButton.Visible = false;
            // 
            // createAppointmentButton
            // 
            this.createAppointmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.createAppointmentButton.FlatAppearance.BorderSize = 0;
            this.createAppointmentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.createAppointmentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.createAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAppointmentButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAppointmentButton.ForeColor = System.Drawing.Color.White;
            this.createAppointmentButton.Location = new System.Drawing.Point(36, 578);
            this.createAppointmentButton.Name = "createAppointmentButton";
            this.createAppointmentButton.Size = new System.Drawing.Size(410, 66);
            this.createAppointmentButton.TabIndex = 8;
            this.createAppointmentButton.Text = "Create New Appointment";
            this.createAppointmentButton.UseVisualStyleBackColor = false;
            this.createAppointmentButton.Click += new System.EventHandler(this.createAppointmentButton_Click);
            // 
            // updateApointmentButton
            // 
            this.updateApointmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.updateApointmentButton.FlatAppearance.BorderSize = 0;
            this.updateApointmentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.updateApointmentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.updateApointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateApointmentButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateApointmentButton.ForeColor = System.Drawing.Color.White;
            this.updateApointmentButton.Location = new System.Drawing.Point(516, 578);
            this.updateApointmentButton.Name = "updateApointmentButton";
            this.updateApointmentButton.Size = new System.Drawing.Size(410, 66);
            this.updateApointmentButton.TabIndex = 9;
            this.updateApointmentButton.Text = "Update Appointment";
            this.updateApointmentButton.UseVisualStyleBackColor = false;
            // 
            // AppointmentTabControl
            // 
            this.AppointmentTabControl.Controls.Add(this.ApprovedAppointmentTab);
            this.AppointmentTabControl.Controls.Add(this.PendingAppointmentTab);
            this.AppointmentTabControl.Controls.Add(this.RescheduledAppointmentTab);
            this.AppointmentTabControl.Controls.Add(this.CanceledAppointmentTab);
            this.AppointmentTabControl.Controls.Add(this.FinishedAppointmentTab);
            this.AppointmentTabControl.Location = new System.Drawing.Point(37, 12);
            this.AppointmentTabControl.Name = "AppointmentTabControl";
            this.AppointmentTabControl.SelectedIndex = 0;
            this.AppointmentTabControl.Size = new System.Drawing.Size(889, 536);
            this.AppointmentTabControl.TabIndex = 7;
            // 
            // ApprovedAppointmentTab
            // 
            this.ApprovedAppointmentTab.Controls.Add(this.ApprovedDataGridView);
            this.ApprovedAppointmentTab.Location = new System.Drawing.Point(4, 22);
            this.ApprovedAppointmentTab.Name = "ApprovedAppointmentTab";
            this.ApprovedAppointmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.ApprovedAppointmentTab.Size = new System.Drawing.Size(881, 510);
            this.ApprovedAppointmentTab.TabIndex = 0;
            this.ApprovedAppointmentTab.Text = "Approved";
            this.ApprovedAppointmentTab.UseVisualStyleBackColor = true;
            // 
            // ApprovedDataGridView
            // 
            this.ApprovedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApprovedDataGridView.Location = new System.Drawing.Point(-3, 28);
            this.ApprovedDataGridView.Name = "ApprovedDataGridView";
            this.ApprovedDataGridView.Size = new System.Drawing.Size(881, 510);
            this.ApprovedDataGridView.TabIndex = 0;
            // 
            // PendingAppointmentTab
            // 
            this.PendingAppointmentTab.Controls.Add(this.dataGridView2);
            this.PendingAppointmentTab.Location = new System.Drawing.Point(4, 22);
            this.PendingAppointmentTab.Name = "PendingAppointmentTab";
            this.PendingAppointmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.PendingAppointmentTab.Size = new System.Drawing.Size(881, 510);
            this.PendingAppointmentTab.TabIndex = 1;
            this.PendingAppointmentTab.Text = "Pending";
            this.PendingAppointmentTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 15);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(994, 565);
            this.dataGridView2.TabIndex = 1;
            // 
            // RescheduledAppointmentTab
            // 
            this.RescheduledAppointmentTab.Location = new System.Drawing.Point(4, 22);
            this.RescheduledAppointmentTab.Name = "RescheduledAppointmentTab";
            this.RescheduledAppointmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.RescheduledAppointmentTab.Size = new System.Drawing.Size(881, 510);
            this.RescheduledAppointmentTab.TabIndex = 2;
            this.RescheduledAppointmentTab.Text = "Rescheduled";
            this.RescheduledAppointmentTab.UseVisualStyleBackColor = true;
            // 
            // CanceledAppointmentTab
            // 
            this.CanceledAppointmentTab.Location = new System.Drawing.Point(4, 22);
            this.CanceledAppointmentTab.Name = "CanceledAppointmentTab";
            this.CanceledAppointmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.CanceledAppointmentTab.Size = new System.Drawing.Size(881, 510);
            this.CanceledAppointmentTab.TabIndex = 3;
            this.CanceledAppointmentTab.Text = "Canceled";
            this.CanceledAppointmentTab.UseVisualStyleBackColor = true;
            // 
            // FinishedAppointmentTab
            // 
            this.FinishedAppointmentTab.Location = new System.Drawing.Point(4, 22);
            this.FinishedAppointmentTab.Name = "FinishedAppointmentTab";
            this.FinishedAppointmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.FinishedAppointmentTab.Size = new System.Drawing.Size(881, 510);
            this.FinishedAppointmentTab.TabIndex = 4;
            this.FinishedAppointmentTab.Text = "Finished";
            this.FinishedAppointmentTab.UseVisualStyleBackColor = true;
            // 
            // DoctorTabControl
            // 
            this.DoctorTabControl.Controls.Add(this.AllDoctorsTab);
            this.DoctorTabControl.Controls.Add(this.ActiveDoctorsTab);
            this.DoctorTabControl.Controls.Add(this.UnavailableDoctorsTab);
            this.DoctorTabControl.Controls.Add(this.InactiveDoctorsTab);
            this.DoctorTabControl.Location = new System.Drawing.Point(36, 12);
            this.DoctorTabControl.Name = "DoctorTabControl";
            this.DoctorTabControl.SelectedIndex = 0;
            this.DoctorTabControl.Size = new System.Drawing.Size(890, 536);
            this.DoctorTabControl.TabIndex = 12;
            this.DoctorTabControl.Visible = false;
            // 
            // AllDoctorsTab
            // 
            this.AllDoctorsTab.Controls.Add(this.dataGridView1);
            this.AllDoctorsTab.Location = new System.Drawing.Point(4, 22);
            this.AllDoctorsTab.Name = "AllDoctorsTab";
            this.AllDoctorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AllDoctorsTab.Size = new System.Drawing.Size(882, 510);
            this.AllDoctorsTab.TabIndex = 0;
            this.AllDoctorsTab.Text = "All";
            this.AllDoctorsTab.UseVisualStyleBackColor = true;
            // 
            // ActiveDoctorsTab
            // 
            this.ActiveDoctorsTab.Controls.Add(this.dataGridView3);
            this.ActiveDoctorsTab.Location = new System.Drawing.Point(4, 22);
            this.ActiveDoctorsTab.Name = "ActiveDoctorsTab";
            this.ActiveDoctorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ActiveDoctorsTab.Size = new System.Drawing.Size(882, 510);
            this.ActiveDoctorsTab.TabIndex = 1;
            this.ActiveDoctorsTab.Text = "Active";
            this.ActiveDoctorsTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 17);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(994, 565);
            this.dataGridView3.TabIndex = 1;
            // 
            // RegisterDoctorButton
            // 
            this.RegisterDoctorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.RegisterDoctorButton.FlatAppearance.BorderSize = 0;
            this.RegisterDoctorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.RegisterDoctorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.RegisterDoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterDoctorButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterDoctorButton.ForeColor = System.Drawing.Color.White;
            this.RegisterDoctorButton.Location = new System.Drawing.Point(36, 578);
            this.RegisterDoctorButton.Name = "RegisterDoctorButton";
            this.RegisterDoctorButton.Size = new System.Drawing.Size(410, 66);
            this.RegisterDoctorButton.TabIndex = 10;
            this.RegisterDoctorButton.Text = "Register Doctor";
            this.RegisterDoctorButton.UseVisualStyleBackColor = false;
            this.RegisterDoctorButton.Visible = false;
            this.RegisterDoctorButton.Click += new System.EventHandler(this.RegisterDoctorButton_Click);
            // 
            // PatientsTabControl
            // 
            this.PatientsTabControl.Controls.Add(this.AllPatientsTab);
            this.PatientsTabControl.Controls.Add(this.ActivePatientsTab);
            this.PatientsTabControl.Controls.Add(this.InactivePatientsTab);
            this.PatientsTabControl.Location = new System.Drawing.Point(36, 11);
            this.PatientsTabControl.Name = "PatientsTabControl";
            this.PatientsTabControl.SelectedIndex = 0;
            this.PatientsTabControl.Size = new System.Drawing.Size(890, 536);
            this.PatientsTabControl.TabIndex = 14;
            this.PatientsTabControl.Visible = false;
            // 
            // AllPatientsTab
            // 
            this.AllPatientsTab.Controls.Add(this.dataGridView4);
            this.AllPatientsTab.Location = new System.Drawing.Point(4, 22);
            this.AllPatientsTab.Name = "AllPatientsTab";
            this.AllPatientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AllPatientsTab.Size = new System.Drawing.Size(882, 510);
            this.AllPatientsTab.TabIndex = 0;
            this.AllPatientsTab.Text = "All";
            this.AllPatientsTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(0, 17);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(881, 510);
            this.dataGridView4.TabIndex = 0;
            // 
            // ActivePatientsTab
            // 
            this.ActivePatientsTab.Controls.Add(this.dataGridView5);
            this.ActivePatientsTab.Location = new System.Drawing.Point(4, 22);
            this.ActivePatientsTab.Name = "ActivePatientsTab";
            this.ActivePatientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ActivePatientsTab.Size = new System.Drawing.Size(882, 510);
            this.ActivePatientsTab.TabIndex = 1;
            this.ActivePatientsTab.Text = "Active";
            this.ActivePatientsTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(6, 15);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(994, 565);
            this.dataGridView5.TabIndex = 1;
            // 
            // InactivePatientsTab
            // 
            this.InactivePatientsTab.Controls.Add(this.billingDataGridView);
            this.InactivePatientsTab.Location = new System.Drawing.Point(4, 22);
            this.InactivePatientsTab.Name = "InactivePatientsTab";
            this.InactivePatientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.InactivePatientsTab.Size = new System.Drawing.Size(882, 510);
            this.InactivePatientsTab.TabIndex = 2;
            this.InactivePatientsTab.Text = "Inactive";
            this.InactivePatientsTab.UseVisualStyleBackColor = true;
            // 
            // UnavailableDoctorsTab
            // 
            this.UnavailableDoctorsTab.Location = new System.Drawing.Point(4, 22);
            this.UnavailableDoctorsTab.Name = "UnavailableDoctorsTab";
            this.UnavailableDoctorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.UnavailableDoctorsTab.Size = new System.Drawing.Size(882, 510);
            this.UnavailableDoctorsTab.TabIndex = 2;
            this.UnavailableDoctorsTab.Text = "Unavailable";
            this.UnavailableDoctorsTab.UseVisualStyleBackColor = true;
            // 
            // InactiveDoctorsTab
            // 
            this.InactiveDoctorsTab.Location = new System.Drawing.Point(4, 22);
            this.InactiveDoctorsTab.Name = "InactiveDoctorsTab";
            this.InactiveDoctorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.InactiveDoctorsTab.Size = new System.Drawing.Size(882, 510);
            this.InactiveDoctorsTab.TabIndex = 3;
            this.InactiveDoctorsTab.Text = "Inactive";
            this.InactiveDoctorsTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(881, 510);
            this.dataGridView1.TabIndex = 0;
            // 
            // RegisterPatientButton
            // 
            this.RegisterPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.RegisterPatientButton.FlatAppearance.BorderSize = 0;
            this.RegisterPatientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.RegisterPatientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.RegisterPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterPatientButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterPatientButton.ForeColor = System.Drawing.Color.White;
            this.RegisterPatientButton.Location = new System.Drawing.Point(36, 578);
            this.RegisterPatientButton.Name = "RegisterPatientButton";
            this.RegisterPatientButton.Size = new System.Drawing.Size(280, 66);
            this.RegisterPatientButton.TabIndex = 15;
            this.RegisterPatientButton.Text = "Register Patient";
            this.RegisterPatientButton.UseVisualStyleBackColor = false;
            this.RegisterPatientButton.Visible = false;
            this.RegisterPatientButton.Click += new System.EventHandler(this.RegisterPatientButton_Click);
            // 
            // UpdatePatientButton
            // 
            this.UpdatePatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.UpdatePatientButton.FlatAppearance.BorderSize = 0;
            this.UpdatePatientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.UpdatePatientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.UpdatePatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdatePatientButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePatientButton.ForeColor = System.Drawing.Color.White;
            this.UpdatePatientButton.Location = new System.Drawing.Point(341, 578);
            this.UpdatePatientButton.Name = "UpdatePatientButton";
            this.UpdatePatientButton.Size = new System.Drawing.Size(280, 66);
            this.UpdatePatientButton.TabIndex = 15;
            this.UpdatePatientButton.Text = "Update Patient";
            this.UpdatePatientButton.UseVisualStyleBackColor = false;
            this.UpdatePatientButton.Visible = false;
            // 
            // SearchPatientButton
            // 
            this.SearchPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SearchPatientButton.FlatAppearance.BorderSize = 0;
            this.SearchPatientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.SearchPatientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.SearchPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchPatientButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPatientButton.ForeColor = System.Drawing.Color.White;
            this.SearchPatientButton.Location = new System.Drawing.Point(646, 578);
            this.SearchPatientButton.Name = "SearchPatientButton";
            this.SearchPatientButton.Size = new System.Drawing.Size(280, 66);
            this.SearchPatientButton.TabIndex = 15;
            this.SearchPatientButton.Text = "Search Patient";
            this.SearchPatientButton.UseVisualStyleBackColor = false;
            this.SearchPatientButton.Visible = false;
            // 
            // RecepView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.SplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RecepView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DENTAL CLINIC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RecepView_FormClosed);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.billingDataGridView)).EndInit();
            this.AppointmentTabControl.ResumeLayout(false);
            this.ApprovedAppointmentTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ApprovedDataGridView)).EndInit();
            this.PendingAppointmentTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.DoctorTabControl.ResumeLayout(false);
            this.AllDoctorsTab.ResumeLayout(false);
            this.ActiveDoctorsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.PatientsTabControl.ResumeLayout(false);
            this.AllPatientsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ActivePatientsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.InactivePatientsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.Button AppointmentsButton;
        private System.Windows.Forms.Button DoctorsButton;
        private System.Windows.Forms.Button BillingButton;
        private System.Windows.Forms.Button PatientsButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.TabControl AppointmentTabControl;
        private System.Windows.Forms.TabPage ApprovedAppointmentTab;
        private System.Windows.Forms.TabPage PendingAppointmentTab;
        private System.Windows.Forms.Button updateApointmentButton;
        private System.Windows.Forms.Button createAppointmentButton;
        private System.Windows.Forms.DataGridView ApprovedDataGridView;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage RescheduledAppointmentTab;
        private System.Windows.Forms.TabPage CanceledAppointmentTab;
        private System.Windows.Forms.TabPage FinishedAppointmentTab;
        private System.Windows.Forms.Button UpdateDoctorButton;
        private System.Windows.Forms.Button RegisterDoctorButton;
        private System.Windows.Forms.TabControl DoctorTabControl;
        private System.Windows.Forms.TabPage AllDoctorsTab;
        private System.Windows.Forms.TabPage ActiveDoctorsTab;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView billingDataGridView;
        private System.Windows.Forms.Button createBillButton;
        private System.Windows.Forms.Label AccountTypelabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage UnavailableDoctorsTab;
        private System.Windows.Forms.TabPage InactiveDoctorsTab;
        private System.Windows.Forms.TabControl PatientsTabControl;
        private System.Windows.Forms.TabPage AllPatientsTab;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage ActivePatientsTab;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.TabPage InactivePatientsTab;
        private System.Windows.Forms.Button RegisterPatientButton;
        private System.Windows.Forms.Button SearchPatientButton;
        private System.Windows.Forms.Button UpdatePatientButton;
    }
}