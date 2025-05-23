﻿namespace ClinicManagementSystem
{
    partial class CreateAppointmentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SelectPatientButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectDoctorButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AppointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ReasonTextBox = new System.Windows.Forms.TextBox();
            this.DoctorNameTextBox = new System.Windows.Forms.TextBox();
            this.DoctorIdTextBox = new System.Windows.Forms.TextBox();
            this.PatientNameTextBox = new System.Windows.Forms.TextBox();
            this.PatientIdTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.CreateAppoitnmentButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(82, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patients Name:";
            // 
            // SelectPatientButton
            // 
            this.SelectPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SelectPatientButton.FlatAppearance.BorderSize = 0;
            this.SelectPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectPatientButton.ForeColor = System.Drawing.Color.White;
            this.SelectPatientButton.Location = new System.Drawing.Point(491, 33);
            this.SelectPatientButton.Name = "SelectPatientButton";
            this.SelectPatientButton.Size = new System.Drawing.Size(137, 26);
            this.SelectPatientButton.TabIndex = 1;
            this.SelectPatientButton.Text = "Select Patient";
            this.SelectPatientButton.UseVisualStyleBackColor = false;
            this.SelectPatientButton.Click += new System.EventHandler(this.SelectPatientButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(91, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Doctor Name: ";
            // 
            // SelectDoctorButton
            // 
            this.SelectDoctorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SelectDoctorButton.FlatAppearance.BorderSize = 0;
            this.SelectDoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectDoctorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDoctorButton.ForeColor = System.Drawing.Color.White;
            this.SelectDoctorButton.Location = new System.Drawing.Point(491, 111);
            this.SelectDoctorButton.Name = "SelectDoctorButton";
            this.SelectDoctorButton.Size = new System.Drawing.Size(137, 26);
            this.SelectDoctorButton.TabIndex = 2;
            this.SelectDoctorButton.Text = "Select Doctor";
            this.SelectDoctorButton.UseVisualStyleBackColor = false;
            this.SelectDoctorButton.Click += new System.EventHandler(this.SelectDoctorButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.AppointmentDateTimePicker);
            this.panel1.Controls.Add(this.ReasonTextBox);
            this.panel1.Controls.Add(this.DoctorNameTextBox);
            this.panel1.Controls.Add(this.DoctorIdTextBox);
            this.panel1.Controls.Add(this.PatientNameTextBox);
            this.panel1.Controls.Add(this.PatientIdTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.CreateAppoitnmentButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SelectDoctorButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SelectPatientButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.SystemColors.Menu;
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 364);
            this.panel1.TabIndex = 9;
            // 
            // AppointmentDateTimePicker
            // 
            this.AppointmentDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AppointmentDateTimePicker.Location = new System.Drawing.Point(199, 261);
            this.AppointmentDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.AppointmentDateTimePicker.Name = "AppointmentDateTimePicker";
            this.AppointmentDateTimePicker.Size = new System.Drawing.Size(277, 26);
            this.AppointmentDateTimePicker.TabIndex = 4;
            // 
            // ReasonTextBox
            // 
            this.ReasonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReasonTextBox.Location = new System.Drawing.Point(199, 184);
            this.ReasonTextBox.Multiline = true;
            this.ReasonTextBox.Name = "ReasonTextBox";
            this.ReasonTextBox.Size = new System.Drawing.Size(429, 62);
            this.ReasonTextBox.TabIndex = 0;
            // 
            // DoctorNameTextBox
            // 
            this.DoctorNameTextBox.Enabled = false;
            this.DoctorNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorNameTextBox.Location = new System.Drawing.Point(199, 145);
            this.DoctorNameTextBox.Name = "DoctorNameTextBox";
            this.DoctorNameTextBox.ReadOnly = true;
            this.DoctorNameTextBox.Size = new System.Drawing.Size(277, 26);
            this.DoctorNameTextBox.TabIndex = 0;
            // 
            // DoctorIdTextBox
            // 
            this.DoctorIdTextBox.Enabled = false;
            this.DoctorIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorIdTextBox.Location = new System.Drawing.Point(199, 109);
            this.DoctorIdTextBox.Name = "DoctorIdTextBox";
            this.DoctorIdTextBox.ReadOnly = true;
            this.DoctorIdTextBox.Size = new System.Drawing.Size(277, 26);
            this.DoctorIdTextBox.TabIndex = 0;
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.Enabled = false;
            this.PatientNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameTextBox.Location = new System.Drawing.Point(199, 70);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.ReadOnly = true;
            this.PatientNameTextBox.Size = new System.Drawing.Size(277, 26);
            this.PatientNameTextBox.TabIndex = 0;
            // 
            // PatientIdTextBox
            // 
            this.PatientIdTextBox.Enabled = false;
            this.PatientIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientIdTextBox.Location = new System.Drawing.Point(199, 33);
            this.PatientIdTextBox.Name = "PatientIdTextBox";
            this.PatientIdTextBox.ReadOnly = true;
            this.PatientIdTextBox.Size = new System.Drawing.Size(277, 26);
            this.PatientIdTextBox.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Menu;
            this.label7.Location = new System.Drawing.Point(116, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Doctor ID: ";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(351, 308);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(277, 31);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CreateAppoitnmentButton
            // 
            this.CreateAppoitnmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.CreateAppoitnmentButton.FlatAppearance.BorderSize = 0;
            this.CreateAppoitnmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAppoitnmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAppoitnmentButton.ForeColor = System.Drawing.Color.White;
            this.CreateAppoitnmentButton.Location = new System.Drawing.Point(26, 308);
            this.CreateAppoitnmentButton.Name = "CreateAppoitnmentButton";
            this.CreateAppoitnmentButton.Size = new System.Drawing.Size(297, 31);
            this.CreateAppoitnmentButton.TabIndex = 5;
            this.CreateAppoitnmentButton.Text = "Create Appointment ";
            this.CreateAppoitnmentButton.UseVisualStyleBackColor = false;
            this.CreateAppoitnmentButton.Click += new System.EventHandler(this.CreateAppoitnmentButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Appointment Date Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(15, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reason for Appointment:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(117, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patient ID: ";
            // 
            // CreateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(673, 387);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CreateAppointmentForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Appointment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SelectDoctorButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CreateAppoitnmentButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PatientIdTextBox;
        private System.Windows.Forms.TextBox PatientNameTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button SelectPatientButton;
        private System.Windows.Forms.TextBox DoctorNameTextBox;
        private System.Windows.Forms.TextBox DoctorIdTextBox;
        private System.Windows.Forms.TextBox ReasonTextBox;
        private System.Windows.Forms.DateTimePicker AppointmentDateTimePicker;
        private System.Windows.Forms.Label label2;
    }
}