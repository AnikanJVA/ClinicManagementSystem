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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.DoctorsButton = new System.Windows.Forms.Button();
            this.BillingButton = new System.Windows.Forms.Button();
            this.PatientsButton = new System.Windows.Forms.Button();
            this.AppointmentsButton = new System.Windows.Forms.Button();
            this.DoctorTabControl = new System.Windows.Forms.TabControl();
            this.ActiveDoctorTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InactiveDoctorTab = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.RegisterDoctorButton = new System.Windows.Forms.Button();
            this.UpdateDoctorButton = new System.Windows.Forms.Button();
            this.AppointmentTabControl = new System.Windows.Forms.TabControl();
            this.ApprovedTab = new System.Windows.Forms.TabPage();
            this.ApprovedDataGridView = new System.Windows.Forms.DataGridView();
            this.PendingTab = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.RescheduledTab = new System.Windows.Forms.TabPage();
            this.CanceledTab = new System.Windows.Forms.TabPage();
            this.FinishedTab = new System.Windows.Forms.TabPage();
            this.createAppointmentButton = new System.Windows.Forms.Button();
            this.updateApointmentButton = new System.Windows.Forms.Button();
            this.MedicinesButton = new System.Windows.Forms.Button();
            this.ServicesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.DoctorTabControl.SuspendLayout();
            this.ActiveDoctorTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.InactiveDoctorTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.AppointmentTabControl.SuspendLayout();
            this.ApprovedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApprovedDataGridView)).BeginInit();
            this.PendingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.SplitContainer.Panel1.Controls.Add(this.LogoutButton);
            this.SplitContainer.Panel1.Controls.Add(this.ServicesButton);
            this.SplitContainer.Panel1.Controls.Add(this.MedicinesButton);
            this.SplitContainer.Panel1.Controls.Add(this.DoctorsButton);
            this.SplitContainer.Panel1.Controls.Add(this.BillingButton);
            this.SplitContainer.Panel1.Controls.Add(this.PatientsButton);
            this.SplitContainer.Panel1.Controls.Add(this.AppointmentsButton);
            this.SplitContainer.Panel1MinSize = 282;
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
            this.SplitContainer.Panel2.Controls.Add(this.RegisterDoctorButton);
            this.SplitContainer.Panel2.Controls.Add(this.UpdateDoctorButton);
            this.SplitContainer.Panel2.Controls.Add(this.AppointmentTabControl);
            this.SplitContainer.Panel2.Controls.Add(this.createAppointmentButton);
            this.SplitContainer.Panel2.Controls.Add(this.updateApointmentButton);
            this.SplitContainer.Panel2.Controls.Add(this.DoctorTabControl);
            this.SplitContainer.Panel2MinSize = 978;
            this.SplitContainer.Size = new System.Drawing.Size(1264, 681);
            this.SplitContainer.SplitterDistance = 282;
            this.SplitContainer.TabIndex = 0;
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
            this.LogoutButton.TabIndex = 6;
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
            this.DoctorsButton.Location = new System.Drawing.Point(20, 265);
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
            this.BillingButton.Location = new System.Drawing.Point(20, 178);
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
            this.PatientsButton.Location = new System.Drawing.Point(20, 93);
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
            this.AppointmentsButton.Location = new System.Drawing.Point(20, 11);
            this.AppointmentsButton.Name = "AppointmentsButton";
            this.AppointmentsButton.Size = new System.Drawing.Size(239, 66);
            this.AppointmentsButton.TabIndex = 1;
            this.AppointmentsButton.Text = "Appointments";
            this.AppointmentsButton.UseVisualStyleBackColor = false;
            this.AppointmentsButton.Click += new System.EventHandler(this.AppointmentsButton_Click);
            // 
            // DoctorTabControl
            // 
            this.DoctorTabControl.Controls.Add(this.ActiveDoctorTab);
            this.DoctorTabControl.Controls.Add(this.InactiveDoctorTab);
            this.DoctorTabControl.Location = new System.Drawing.Point(36, 12);
            this.DoctorTabControl.Name = "DoctorTabControl";
            this.DoctorTabControl.SelectedIndex = 0;
            this.DoctorTabControl.Size = new System.Drawing.Size(726, 449);
            this.DoctorTabControl.TabIndex = 12;
            this.DoctorTabControl.Visible = false;
            // 
            // ActiveDoctorTab
            // 
            this.ActiveDoctorTab.Controls.Add(this.dataGridView1);
            this.ActiveDoctorTab.Location = new System.Drawing.Point(4, 22);
            this.ActiveDoctorTab.Name = "ActiveDoctorTab";
            this.ActiveDoctorTab.Padding = new System.Windows.Forms.Padding(3);
            this.ActiveDoctorTab.Size = new System.Drawing.Size(718, 423);
            this.ActiveDoctorTab.TabIndex = 0;
            this.ActiveDoctorTab.Text = "Active";
            this.ActiveDoctorTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // InactiveDoctorTab
            // 
            this.InactiveDoctorTab.Controls.Add(this.dataGridView3);
            this.InactiveDoctorTab.Location = new System.Drawing.Point(4, 22);
            this.InactiveDoctorTab.Name = "InactiveDoctorTab";
            this.InactiveDoctorTab.Padding = new System.Windows.Forms.Padding(3);
            this.InactiveDoctorTab.Size = new System.Drawing.Size(994, 565);
            this.InactiveDoctorTab.TabIndex = 1;
            this.InactiveDoctorTab.Text = "Inactive";
            this.InactiveDoctorTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1, 0);
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
            // AppointmentTabControl
            // 
            this.AppointmentTabControl.Controls.Add(this.ApprovedTab);
            this.AppointmentTabControl.Controls.Add(this.PendingTab);
            this.AppointmentTabControl.Controls.Add(this.RescheduledTab);
            this.AppointmentTabControl.Controls.Add(this.CanceledTab);
            this.AppointmentTabControl.Controls.Add(this.FinishedTab);
            this.AppointmentTabControl.Location = new System.Drawing.Point(37, 12);
            this.AppointmentTabControl.Name = "AppointmentTabControl";
            this.AppointmentTabControl.SelectedIndex = 0;
            this.AppointmentTabControl.Size = new System.Drawing.Size(725, 449);
            this.AppointmentTabControl.TabIndex = 7;
            // 
            // ApprovedTab
            // 
            this.ApprovedTab.Controls.Add(this.ApprovedDataGridView);
            this.ApprovedTab.Location = new System.Drawing.Point(4, 22);
            this.ApprovedTab.Name = "ApprovedTab";
            this.ApprovedTab.Padding = new System.Windows.Forms.Padding(3);
            this.ApprovedTab.Size = new System.Drawing.Size(717, 423);
            this.ApprovedTab.TabIndex = 0;
            this.ApprovedTab.Text = "Approved";
            this.ApprovedTab.UseVisualStyleBackColor = true;
            // 
            // ApprovedDataGridView
            // 
            this.ApprovedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApprovedDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ApprovedDataGridView.Name = "ApprovedDataGridView";
            this.ApprovedDataGridView.Size = new System.Drawing.Size(717, 422);
            this.ApprovedDataGridView.TabIndex = 0;
            // 
            // PendingTab
            // 
            this.PendingTab.Controls.Add(this.dataGridView2);
            this.PendingTab.Location = new System.Drawing.Point(4, 22);
            this.PendingTab.Name = "PendingTab";
            this.PendingTab.Padding = new System.Windows.Forms.Padding(3);
            this.PendingTab.Size = new System.Drawing.Size(994, 565);
            this.PendingTab.TabIndex = 1;
            this.PendingTab.Text = "Pending";
            this.PendingTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 15);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(994, 565);
            this.dataGridView2.TabIndex = 1;
            // 
            // RescheduledTab
            // 
            this.RescheduledTab.Location = new System.Drawing.Point(4, 22);
            this.RescheduledTab.Name = "RescheduledTab";
            this.RescheduledTab.Padding = new System.Windows.Forms.Padding(3);
            this.RescheduledTab.Size = new System.Drawing.Size(994, 565);
            this.RescheduledTab.TabIndex = 2;
            this.RescheduledTab.Text = "Rescheduled";
            this.RescheduledTab.UseVisualStyleBackColor = true;
            // 
            // CanceledTab
            // 
            this.CanceledTab.Location = new System.Drawing.Point(4, 22);
            this.CanceledTab.Name = "CanceledTab";
            this.CanceledTab.Padding = new System.Windows.Forms.Padding(3);
            this.CanceledTab.Size = new System.Drawing.Size(994, 565);
            this.CanceledTab.TabIndex = 3;
            this.CanceledTab.Text = "Canceled";
            this.CanceledTab.UseVisualStyleBackColor = true;
            // 
            // FinishedTab
            // 
            this.FinishedTab.Location = new System.Drawing.Point(4, 22);
            this.FinishedTab.Name = "FinishedTab";
            this.FinishedTab.Padding = new System.Windows.Forms.Padding(3);
            this.FinishedTab.Size = new System.Drawing.Size(994, 565);
            this.FinishedTab.TabIndex = 4;
            this.FinishedTab.Text = "Finished";
            this.FinishedTab.UseVisualStyleBackColor = true;
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
            // MedicinesButton
            // 
            this.MedicinesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MedicinesButton.FlatAppearance.BorderSize = 0;
            this.MedicinesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.MedicinesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.MedicinesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MedicinesButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicinesButton.ForeColor = System.Drawing.Color.White;
            this.MedicinesButton.Location = new System.Drawing.Point(20, 350);
            this.MedicinesButton.Name = "MedicinesButton";
            this.MedicinesButton.Size = new System.Drawing.Size(239, 66);
            this.MedicinesButton.TabIndex = 4;
            this.MedicinesButton.Text = "Medicines";
            this.MedicinesButton.UseVisualStyleBackColor = false;
            this.MedicinesButton.Click += new System.EventHandler(this.Medicines_Click);
            // 
            // ServicesButton
            // 
            this.ServicesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ServicesButton.FlatAppearance.BorderSize = 0;
            this.ServicesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.ServicesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.ServicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServicesButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicesButton.ForeColor = System.Drawing.Color.White;
            this.ServicesButton.Location = new System.Drawing.Point(20, 442);
            this.ServicesButton.Name = "ServicesButton";
            this.ServicesButton.Size = new System.Drawing.Size(239, 66);
            this.ServicesButton.TabIndex = 4;
            this.ServicesButton.Text = "Services";
            this.ServicesButton.UseVisualStyleBackColor = false;
            this.ServicesButton.Click += new System.EventHandler(this.ServicesButton_Click);
            // 
            // RecepView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.SplitContainer);
            this.Name = "RecepView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DENTAL CLINIC";
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.DoctorTabControl.ResumeLayout(false);
            this.ActiveDoctorTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.InactiveDoctorTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.AppointmentTabControl.ResumeLayout(false);
            this.ApprovedTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ApprovedDataGridView)).EndInit();
            this.PendingTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.TabPage ApprovedTab;
        private System.Windows.Forms.TabPage PendingTab;
        private System.Windows.Forms.Button updateApointmentButton;
        private System.Windows.Forms.Button createAppointmentButton;
        private System.Windows.Forms.DataGridView ApprovedDataGridView;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage RescheduledTab;
        private System.Windows.Forms.TabPage CanceledTab;
        private System.Windows.Forms.TabPage FinishedTab;
        private System.Windows.Forms.Button UpdateDoctorButton;
        private System.Windows.Forms.Button RegisterDoctorButton;
        private System.Windows.Forms.TabControl DoctorTabControl;
        private System.Windows.Forms.TabPage ActiveDoctorTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage InactiveDoctorTab;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button ServicesButton;
        private System.Windows.Forms.Button MedicinesButton;
    }
}