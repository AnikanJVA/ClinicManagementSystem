namespace ClinicManagementSystem
{
    partial class DocView
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.AccountTypelabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.Prescriptions_NavButton = new System.Windows.Forms.Button();
            this.Patients_NavButton = new System.Windows.Forms.Button();
            this.Appointments_NavButton = new System.Windows.Forms.Button();
            this.Doctors_InactiveDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectAppointmentButton = new System.Windows.Forms.Button();
            this.SelectPatientButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Doctors_InactiveDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
            this.splitContainer1.Panel1.Controls.Add(this.AccountTypelabel);
            this.splitContainer1.Panel1.Controls.Add(this.LogoutButton);
            this.splitContainer1.Panel1.Controls.Add(this.Prescriptions_NavButton);
            this.splitContainer1.Panel1.Controls.Add(this.Patients_NavButton);
            this.splitContainer1.Panel1.Controls.Add(this.Appointments_NavButton);
            this.splitContainer1.Panel1MinSize = 282;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
            this.splitContainer1.Panel2.Controls.Add(this.SelectPatientButton);
            this.splitContainer1.Panel2.Controls.Add(this.Doctors_InactiveDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.SelectAppointmentButton);
            this.splitContainer1.Panel2MinSize = 978;
            this.splitContainer1.Size = new System.Drawing.Size(1264, 681);
            this.splitContainer1.SplitterDistance = 282;
            this.splitContainer1.TabIndex = 1;
            // 
            // AccountTypelabel
            // 
            this.AccountTypelabel.AutoSize = true;
            this.AccountTypelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.AccountTypelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountTypelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.AccountTypelabel.ForeColor = System.Drawing.Color.White;
            this.AccountTypelabel.Location = new System.Drawing.Point(97, 12);
            this.AccountTypelabel.Name = "AccountTypelabel";
            this.AccountTypelabel.Size = new System.Drawing.Size(86, 31);
            this.AccountTypelabel.TabIndex = 7;
            this.AccountTypelabel.Text = "Doctor";
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
            this.LogoutButton.TabIndex = 6;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // Prescriptions_NavButton
            // 
            this.Prescriptions_NavButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.Prescriptions_NavButton.FlatAppearance.BorderSize = 0;
            this.Prescriptions_NavButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.Prescriptions_NavButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.Prescriptions_NavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prescriptions_NavButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prescriptions_NavButton.ForeColor = System.Drawing.Color.White;
            this.Prescriptions_NavButton.Location = new System.Drawing.Point(20, 235);
            this.Prescriptions_NavButton.Name = "Prescriptions_NavButton";
            this.Prescriptions_NavButton.Size = new System.Drawing.Size(239, 66);
            this.Prescriptions_NavButton.TabIndex = 4;
            this.Prescriptions_NavButton.Text = "Prescriptions";
            this.Prescriptions_NavButton.UseVisualStyleBackColor = false;
            this.Prescriptions_NavButton.Click += new System.EventHandler(this.Prescriptions_NavButton_Click);
            // 
            // Patients_NavButton
            // 
            this.Patients_NavButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.Patients_NavButton.FlatAppearance.BorderSize = 0;
            this.Patients_NavButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.Patients_NavButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.Patients_NavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Patients_NavButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patients_NavButton.ForeColor = System.Drawing.Color.White;
            this.Patients_NavButton.Location = new System.Drawing.Point(20, 150);
            this.Patients_NavButton.Name = "Patients_NavButton";
            this.Patients_NavButton.Size = new System.Drawing.Size(239, 66);
            this.Patients_NavButton.TabIndex = 2;
            this.Patients_NavButton.Text = "Patients";
            this.Patients_NavButton.UseVisualStyleBackColor = false;
            this.Patients_NavButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // Appointments_NavButton
            // 
            this.Appointments_NavButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.Appointments_NavButton.FlatAppearance.BorderSize = 0;
            this.Appointments_NavButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.Appointments_NavButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.Appointments_NavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Appointments_NavButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appointments_NavButton.ForeColor = System.Drawing.Color.White;
            this.Appointments_NavButton.Location = new System.Drawing.Point(20, 65);
            this.Appointments_NavButton.Name = "Appointments_NavButton";
            this.Appointments_NavButton.Size = new System.Drawing.Size(239, 66);
            this.Appointments_NavButton.TabIndex = 1;
            this.Appointments_NavButton.Text = "Appointments";
            this.Appointments_NavButton.UseVisualStyleBackColor = false;
            this.Appointments_NavButton.Click += new System.EventHandler(this.AppointmentsButton_Click);
            // 
            // Doctors_InactiveDataGridView
            // 
            this.Doctors_InactiveDataGridView.AllowUserToAddRows = false;
            this.Doctors_InactiveDataGridView.AllowUserToDeleteRows = false;
            this.Doctors_InactiveDataGridView.AllowUserToResizeColumns = false;
            this.Doctors_InactiveDataGridView.AllowUserToResizeRows = false;
            this.Doctors_InactiveDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Doctors_InactiveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Doctors_InactiveDataGridView.Location = new System.Drawing.Point(45, 25);
            this.Doctors_InactiveDataGridView.Name = "Doctors_InactiveDataGridView";
            this.Doctors_InactiveDataGridView.ReadOnly = true;
            this.Doctors_InactiveDataGridView.Size = new System.Drawing.Size(881, 510);
            this.Doctors_InactiveDataGridView.TabIndex = 2;
            // 
            // SelectAppointmentButton
            // 
            this.SelectAppointmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SelectAppointmentButton.FlatAppearance.BorderSize = 0;
            this.SelectAppointmentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.SelectAppointmentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.SelectAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectAppointmentButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectAppointmentButton.ForeColor = System.Drawing.Color.White;
            this.SelectAppointmentButton.Location = new System.Drawing.Point(341, 578);
            this.SelectAppointmentButton.Name = "SelectAppointmentButton";
            this.SelectAppointmentButton.Size = new System.Drawing.Size(299, 66);
            this.SelectAppointmentButton.TabIndex = 9;
            this.SelectAppointmentButton.Text = "Select Appointment";
            this.SelectAppointmentButton.UseVisualStyleBackColor = false;
            this.SelectAppointmentButton.Visible = false;
            // 
            // SelectPatientButton
            // 
            this.SelectPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SelectPatientButton.FlatAppearance.BorderSize = 0;
            this.SelectPatientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.SelectPatientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.SelectPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectPatientButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectPatientButton.ForeColor = System.Drawing.Color.White;
            this.SelectPatientButton.Location = new System.Drawing.Point(341, 578);
            this.SelectPatientButton.Name = "SelectPatientButton";
            this.SelectPatientButton.Size = new System.Drawing.Size(299, 66);
            this.SelectPatientButton.TabIndex = 11;
            this.SelectPatientButton.Text = "Select Patient";
            this.SelectPatientButton.UseVisualStyleBackColor = false;
            this.SelectPatientButton.Visible = false;
            // 
            // DocView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DocView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DENTAL CLINIC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DocView_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Doctors_InactiveDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button Patients_NavButton;
        private System.Windows.Forms.Button Appointments_NavButton;
        private System.Windows.Forms.Button SelectAppointmentButton;
        private System.Windows.Forms.Label AccountTypelabel;
        private System.Windows.Forms.Button Prescriptions_NavButton;
        private System.Windows.Forms.DataGridView Doctors_InactiveDataGridView;
        private System.Windows.Forms.Button SelectPatientButton;
    }
}