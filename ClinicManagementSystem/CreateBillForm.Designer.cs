namespace ClinicManagementSystem
{
    partial class CreateBillForm
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
            this.CreateUpdateBillButton = new System.Windows.Forms.Button();
            this.AppointmentIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ServicesPerformedTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectServiceButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.SelectAppointmentButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.patientIDLabel = new System.Windows.Forms.Label();
            this.PatientIDTextBox = new System.Windows.Forms.TextBox();
            this.PatientNameTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.AppointmentDateTimeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateUpdateBillButton
            // 
            this.CreateUpdateBillButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.CreateUpdateBillButton.FlatAppearance.BorderSize = 0;
            this.CreateUpdateBillButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.CreateUpdateBillButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.CreateUpdateBillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateUpdateBillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateUpdateBillButton.ForeColor = System.Drawing.Color.White;
            this.CreateUpdateBillButton.Location = new System.Drawing.Point(28, 299);
            this.CreateUpdateBillButton.Name = "CreateUpdateBillButton";
            this.CreateUpdateBillButton.Size = new System.Drawing.Size(306, 26);
            this.CreateUpdateBillButton.TabIndex = 6;
            this.CreateUpdateBillButton.Text = "Create Bill";
            this.CreateUpdateBillButton.UseVisualStyleBackColor = false;
            this.CreateUpdateBillButton.Click += new System.EventHandler(this.CreateUpdateBillButton_Click);
            // 
            // AppointmentIDTextBox
            // 
            this.AppointmentIDTextBox.Enabled = false;
            this.AppointmentIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentIDTextBox.Location = new System.Drawing.Point(194, 21);
            this.AppointmentIDTextBox.Name = "AppointmentIDTextBox";
            this.AppointmentIDTextBox.ReadOnly = true;
            this.AppointmentIDTextBox.Size = new System.Drawing.Size(306, 26);
            this.AppointmentIDTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(80, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name:";
            // 
            // ServicesPerformedTextBox
            // 
            this.ServicesPerformedTextBox.Enabled = false;
            this.ServicesPerformedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicesPerformedTextBox.Location = new System.Drawing.Point(194, 169);
            this.ServicesPerformedTextBox.Multiline = true;
            this.ServicesPerformedTextBox.Name = "ServicesPerformedTextBox";
            this.ServicesPerformedTextBox.ReadOnly = true;
            this.ServicesPerformedTextBox.Size = new System.Drawing.Size(306, 69);
            this.ServicesPerformedTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(37, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Services Performed:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.CalculateButton);
            this.panel1.Controls.Add(this.SelectServiceButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.AmountTextBox);
            this.panel1.Controls.Add(this.SelectAppointmentButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.patientIDLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CreateUpdateBillButton);
            this.panel1.Controls.Add(this.PatientIDTextBox);
            this.panel1.Controls.Add(this.AppointmentDateTimeTextBox);
            this.panel1.Controls.Add(this.PatientNameTextBox);
            this.panel1.Controls.Add(this.AppointmentIDTextBox);
            this.panel1.Controls.Add(this.ServicesPerformedTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 347);
            this.panel1.TabIndex = 14;
            // 
            // SelectServiceButton
            // 
            this.SelectServiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SelectServiceButton.FlatAppearance.BorderSize = 0;
            this.SelectServiceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.SelectServiceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.SelectServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectServiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectServiceButton.ForeColor = System.Drawing.Color.White;
            this.SelectServiceButton.Location = new System.Drawing.Point(514, 169);
            this.SelectServiceButton.Name = "SelectServiceButton";
            this.SelectServiceButton.Size = new System.Drawing.Size(169, 26);
            this.SelectServiceButton.TabIndex = 14;
            this.SelectServiceButton.Text = "Select Service";
            this.SelectServiceButton.UseVisualStyleBackColor = false;
            this.SelectServiceButton.Click += new System.EventHandler(this.SelectServiceButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Menu;
            this.label6.Location = new System.Drawing.Point(80, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Amount:";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Enabled = false;
            this.AmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTextBox.Location = new System.Drawing.Point(194, 251);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.ReadOnly = true;
            this.AmountTextBox.Size = new System.Drawing.Size(306, 26);
            this.AmountTextBox.TabIndex = 12;
            // 
            // SelectAppointmentButton
            // 
            this.SelectAppointmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SelectAppointmentButton.FlatAppearance.BorderSize = 0;
            this.SelectAppointmentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.SelectAppointmentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.SelectAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectAppointmentButton.ForeColor = System.Drawing.Color.White;
            this.SelectAppointmentButton.Location = new System.Drawing.Point(515, 21);
            this.SelectAppointmentButton.Name = "SelectAppointmentButton";
            this.SelectAppointmentButton.Size = new System.Drawing.Size(168, 26);
            this.SelectAppointmentButton.TabIndex = 10;
            this.SelectAppointmentButton.Text = "Select Appointment";
            this.SelectAppointmentButton.UseVisualStyleBackColor = false;
            this.SelectAppointmentButton.Click += new System.EventHandler(this.SelectAppointmentButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(63, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Appointment ID:";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(377, 299);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(306, 26);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.AutoSize = true;
            this.patientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.patientIDLabel.Location = new System.Drawing.Point(105, 94);
            this.patientIDLabel.Name = "patientIDLabel";
            this.patientIDLabel.Size = new System.Drawing.Size(84, 20);
            this.patientIDLabel.TabIndex = 0;
            this.patientIDLabel.Text = "Patient ID:";
            // 
            // PatientIDTextBox
            // 
            this.PatientIDTextBox.Enabled = false;
            this.PatientIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientIDTextBox.Location = new System.Drawing.Point(194, 94);
            this.PatientIDTextBox.Name = "PatientIDTextBox";
            this.PatientIDTextBox.ReadOnly = true;
            this.PatientIDTextBox.Size = new System.Drawing.Size(306, 26);
            this.PatientIDTextBox.TabIndex = 1;
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.Enabled = false;
            this.PatientNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameTextBox.Location = new System.Drawing.Point(194, 133);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.ReadOnly = true;
            this.PatientNameTextBox.Size = new System.Drawing.Size(306, 26);
            this.PatientNameTextBox.TabIndex = 1;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.CalculateButton.FlatAppearance.BorderSize = 0;
            this.CalculateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.CalculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.ForeColor = System.Drawing.Color.White;
            this.CalculateButton.Location = new System.Drawing.Point(514, 251);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(169, 26);
            this.CalculateButton.TabIndex = 14;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // AppointmentDateTimeTextBox
            // 
            this.AppointmentDateTimeTextBox.Enabled = false;
            this.AppointmentDateTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentDateTimeTextBox.Location = new System.Drawing.Point(194, 56);
            this.AppointmentDateTimeTextBox.Name = "AppointmentDateTimeTextBox";
            this.AppointmentDateTimeTextBox.ReadOnly = true;
            this.AppointmentDateTimeTextBox.Size = new System.Drawing.Size(306, 26);
            this.AppointmentDateTimeTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(8, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Appointment Date Time:";
            // 
            // CreateBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(739, 369);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CreateBillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Bill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateUpdateBillButton;
        private System.Windows.Forms.TextBox AppointmentIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServicesPerformedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label patientIDLabel;
        private System.Windows.Forms.Button SelectAppointmentButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Button SelectServiceButton;
        private System.Windows.Forms.TextBox PatientNameTextBox;
        private System.Windows.Forms.TextBox PatientIDTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AppointmentDateTimeTextBox;
    }
}