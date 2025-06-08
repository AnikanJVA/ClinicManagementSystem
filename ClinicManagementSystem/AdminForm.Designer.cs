namespace ClinicManagementSystem
{
    partial class AdminForm
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
            this.RegisterDoctorButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.RegisterReceptionistButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.FnameTextBox = new System.Windows.Forms.TextBox();
            this.MnameTextBox = new System.Windows.Forms.TextBox();
            this.AltContactNoTextBox = new System.Windows.Forms.TextBox();
            this.LnameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.EmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.ContactNoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScheduleLabel = new System.Windows.Forms.Label();
            this.LicenseNumberLabel = new System.Windows.Forms.Label();
            this.LicenseNumberTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.UserIDTextBox = new System.Windows.Forms.TextBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.ScheduleTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AccTypeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterDoctorButton
            // 
            this.RegisterDoctorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.RegisterDoctorButton.FlatAppearance.BorderSize = 0;
            this.RegisterDoctorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.RegisterDoctorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.RegisterDoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterDoctorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RegisterDoctorButton.ForeColor = System.Drawing.Color.White;
            this.RegisterDoctorButton.Location = new System.Drawing.Point(13, 272);
            this.RegisterDoctorButton.Name = "RegisterDoctorButton";
            this.RegisterDoctorButton.Size = new System.Drawing.Size(252, 33);
            this.RegisterDoctorButton.TabIndex = 1;
            this.RegisterDoctorButton.Text = "Register Doctor";
            this.RegisterDoctorButton.UseVisualStyleBackColor = false;
            this.RegisterDoctorButton.Click += new System.EventHandler(this.RegisterDoctorButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(869, 311);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.LogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(12, 637);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(164, 33);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // RegisterReceptionistButton
            // 
            this.RegisterReceptionistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.RegisterReceptionistButton.FlatAppearance.BorderSize = 0;
            this.RegisterReceptionistButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.RegisterReceptionistButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.RegisterReceptionistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterReceptionistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RegisterReceptionistButton.ForeColor = System.Drawing.Color.White;
            this.RegisterReceptionistButton.Location = new System.Drawing.Point(325, 272);
            this.RegisterReceptionistButton.Name = "RegisterReceptionistButton";
            this.RegisterReceptionistButton.Size = new System.Drawing.Size(252, 33);
            this.RegisterReceptionistButton.TabIndex = 3;
            this.RegisterReceptionistButton.Text = "Register Receptionist";
            this.RegisterReceptionistButton.UseVisualStyleBackColor = false;
            this.RegisterReceptionistButton.Click += new System.EventHandler(this.RegisterReceptionistButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.UpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(637, 272);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(244, 33);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update User";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.UserIDTextBox);
            this.panel1.Controls.Add(this.ScheduleLabel);
            this.panel1.Controls.Add(this.LicenseNumberLabel);
            this.panel1.Controls.Add(this.LicenseNumberTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.AccTypeTextBox);
            this.panel1.Controls.Add(this.FnameTextBox);
            this.panel1.Controls.Add(this.MnameTextBox);
            this.panel1.Controls.Add(this.AltContactNoTextBox);
            this.panel1.Controls.Add(this.ScheduleTextBox);
            this.panel1.Controls.Add(this.StatusTextBox);
            this.panel1.Controls.Add(this.LnameTextBox);
            this.panel1.Controls.Add(this.AddressTextBox);
            this.panel1.Controls.Add(this.EmailAddressTextBox);
            this.panel1.Controls.Add(this.ContactNoTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 243);
            this.panel1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(511, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "*Status:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(113, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "*Address:";
            // 
            // FnameTextBox
            // 
            this.FnameTextBox.Enabled = false;
            this.FnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnameTextBox.Location = new System.Drawing.Point(583, 54);
            this.FnameTextBox.Name = "FnameTextBox";
            this.FnameTextBox.Size = new System.Drawing.Size(244, 26);
            this.FnameTextBox.TabIndex = 37;
            // 
            // MnameTextBox
            // 
            this.MnameTextBox.Enabled = false;
            this.MnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnameTextBox.Location = new System.Drawing.Point(583, 88);
            this.MnameTextBox.Name = "MnameTextBox";
            this.MnameTextBox.Size = new System.Drawing.Size(244, 26);
            this.MnameTextBox.TabIndex = 38;
            // 
            // AltContactNoTextBox
            // 
            this.AltContactNoTextBox.Enabled = false;
            this.AltContactNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltContactNoTextBox.Location = new System.Drawing.Point(201, 123);
            this.AltContactNoTextBox.Name = "AltContactNoTextBox";
            this.AltContactNoTextBox.Size = new System.Drawing.Size(244, 26);
            this.AltContactNoTextBox.TabIndex = 35;
            // 
            // LnameTextBox
            // 
            this.LnameTextBox.Enabled = false;
            this.LnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnameTextBox.Location = new System.Drawing.Point(583, 123);
            this.LnameTextBox.Name = "LnameTextBox";
            this.LnameTextBox.Size = new System.Drawing.Size(244, 26);
            this.LnameTextBox.TabIndex = 34;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Enabled = false;
            this.AddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextBox.Location = new System.Drawing.Point(201, 159);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(244, 26);
            this.AddressTextBox.TabIndex = 36;
            // 
            // EmailAddressTextBox
            // 
            this.EmailAddressTextBox.Enabled = false;
            this.EmailAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressTextBox.Location = new System.Drawing.Point(201, 54);
            this.EmailAddressTextBox.Name = "EmailAddressTextBox";
            this.EmailAddressTextBox.Size = new System.Drawing.Size(244, 26);
            this.EmailAddressTextBox.TabIndex = 32;
            // 
            // ContactNoTextBox
            // 
            this.ContactNoTextBox.Enabled = false;
            this.ContactNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNoTextBox.Location = new System.Drawing.Point(201, 89);
            this.ContactNoTextBox.Name = "ContactNoTextBox";
            this.ContactNoTextBox.Size = new System.Drawing.Size(244, 26);
            this.ContactNoTextBox.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "*Alt Contact Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(63, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "*Contact Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(482, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "*Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(75, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "*Email Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(483, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "*First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(467, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "*Middle Name:";
            // 
            // ScheduleLabel
            // 
            this.ScheduleLabel.AutoSize = true;
            this.ScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleLabel.ForeColor = System.Drawing.Color.White;
            this.ScheduleLabel.Location = new System.Drawing.Point(492, 200);
            this.ScheduleLabel.Name = "ScheduleLabel";
            this.ScheduleLabel.Size = new System.Drawing.Size(86, 20);
            this.ScheduleLabel.TabIndex = 44;
            this.ScheduleLabel.Text = "*Schedule:";
            this.ScheduleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScheduleLabel.Visible = false;
            // 
            // LicenseNumberLabel
            // 
            this.LicenseNumberLabel.AutoSize = true;
            this.LicenseNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseNumberLabel.ForeColor = System.Drawing.Color.White;
            this.LicenseNumberLabel.Location = new System.Drawing.Point(58, 199);
            this.LicenseNumberLabel.Name = "LicenseNumberLabel";
            this.LicenseNumberLabel.Size = new System.Drawing.Size(134, 20);
            this.LicenseNumberLabel.TabIndex = 43;
            this.LicenseNumberLabel.Text = "*License Number:";
            this.LicenseNumberLabel.Visible = false;
            // 
            // LicenseNumberTextBox
            // 
            this.LicenseNumberTextBox.Enabled = false;
            this.LicenseNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseNumberTextBox.Location = new System.Drawing.Point(201, 197);
            this.LicenseNumberTextBox.Name = "LicenseNumberTextBox";
            this.LicenseNumberTextBox.Size = new System.Drawing.Size(244, 26);
            this.LicenseNumberTextBox.TabIndex = 42;
            this.LicenseNumberTextBox.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(127, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "User ID:";
            // 
            // UserIDTextBox
            // 
            this.UserIDTextBox.Enabled = false;
            this.UserIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDTextBox.Location = new System.Drawing.Point(201, 13);
            this.UserIDTextBox.Name = "UserIDTextBox";
            this.UserIDTextBox.ReadOnly = true;
            this.UserIDTextBox.Size = new System.Drawing.Size(244, 26);
            this.UserIDTextBox.TabIndex = 46;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Enabled = false;
            this.StatusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTextBox.Location = new System.Drawing.Point(583, 161);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(244, 26);
            this.StatusTextBox.TabIndex = 34;
            // 
            // ScheduleTextBox
            // 
            this.ScheduleTextBox.Enabled = false;
            this.ScheduleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleTextBox.Location = new System.Drawing.Point(583, 197);
            this.ScheduleTextBox.Name = "ScheduleTextBox";
            this.ScheduleTextBox.Size = new System.Drawing.Size(244, 26);
            this.ScheduleTextBox.TabIndex = 34;
            this.ScheduleTextBox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(467, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Account Type:";
            // 
            // AccTypeTextBox
            // 
            this.AccTypeTextBox.Enabled = false;
            this.AccTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccTypeTextBox.Location = new System.Drawing.Point(583, 15);
            this.AccTypeTextBox.Name = "AccTypeTextBox";
            this.AccTypeTextBox.Size = new System.Drawing.Size(244, 26);
            this.AccTypeTextBox.TabIndex = 37;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(897, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RegisterReceptionistButton);
            this.Controls.Add(this.RegisterDoctorButton);
            this.Controls.Add(this.UpdateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RegisterDoctorButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button RegisterReceptionistButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox FnameTextBox;
        private System.Windows.Forms.TextBox MnameTextBox;
        private System.Windows.Forms.TextBox AltContactNoTextBox;
        private System.Windows.Forms.TextBox LnameTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox EmailAddressTextBox;
        private System.Windows.Forms.TextBox ContactNoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ScheduleLabel;
        private System.Windows.Forms.Label LicenseNumberLabel;
        private System.Windows.Forms.TextBox LicenseNumberTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox UserIDTextBox;
        private System.Windows.Forms.TextBox ScheduleTextBox;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.TextBox AccTypeTextBox;
        private System.Windows.Forms.Label label4;
    }
}