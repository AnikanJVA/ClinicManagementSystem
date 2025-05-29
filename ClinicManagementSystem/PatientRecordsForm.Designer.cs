namespace ClinicManagementSystem
{
    partial class PatientRecordsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SexTextBox = new System.Windows.Forms.TextBox();
            this.DoBTextBox = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.Label();
            this.DoB = new System.Windows.Forms.Label();
            this.PatientNameTextBox = new System.Windows.Forms.TextBox();
            this.PatientIdTextBox = new System.Windows.Forms.TextBox();
            this.PatientName = new System.Windows.Forms.Label();
            this.PatientId = new System.Windows.Forms.Label();
            this.PastAppointmentRecords = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Patients_DataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Patients_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.SexTextBox);
            this.panel1.Controls.Add(this.DoBTextBox);
            this.panel1.Controls.Add(this.Sex);
            this.panel1.Controls.Add(this.DoB);
            this.panel1.Controls.Add(this.PatientNameTextBox);
            this.panel1.Controls.Add(this.PatientIdTextBox);
            this.panel1.Controls.Add(this.PatientName);
            this.panel1.Controls.Add(this.PatientId);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 92);
            this.panel1.TabIndex = 0;
            // 
            // SexTextBox
            // 
            this.SexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexTextBox.Location = new System.Drawing.Point(513, 47);
            this.SexTextBox.Name = "SexTextBox";
            this.SexTextBox.Size = new System.Drawing.Size(263, 26);
            this.SexTextBox.TabIndex = 7;
            // 
            // DoBTextBox
            // 
            this.DoBTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoBTextBox.Location = new System.Drawing.Point(513, 17);
            this.DoBTextBox.Name = "DoBTextBox";
            this.DoBTextBox.Size = new System.Drawing.Size(263, 26);
            this.DoBTextBox.TabIndex = 6;
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sex.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sex.Location = new System.Drawing.Point(467, 47);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(40, 20);
            this.Sex.TabIndex = 5;
            this.Sex.Text = "Sex:";
            // 
            // DoB
            // 
            this.DoB.AutoSize = true;
            this.DoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DoB.Location = new System.Drawing.Point(404, 17);
            this.DoB.Name = "DoB";
            this.DoB.Size = new System.Drawing.Size(103, 20);
            this.DoB.TabIndex = 4;
            this.DoB.Text = "Date of Birth:";
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameTextBox.Location = new System.Drawing.Point(125, 47);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.Size = new System.Drawing.Size(263, 26);
            this.PatientNameTextBox.TabIndex = 3;
            // 
            // PatientIdTextBox
            // 
            this.PatientIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientIdTextBox.Location = new System.Drawing.Point(125, 17);
            this.PatientIdTextBox.Name = "PatientIdTextBox";
            this.PatientIdTextBox.Size = new System.Drawing.Size(263, 26);
            this.PatientIdTextBox.TabIndex = 2;
            // 
            // PatientName
            // 
            this.PatientName.AutoSize = true;
            this.PatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PatientName.Location = new System.Drawing.Point(12, 47);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(107, 20);
            this.PatientName.TabIndex = 1;
            this.PatientName.Text = "Patient name:";
            // 
            // PatientId
            // 
            this.PatientId.AutoSize = true;
            this.PatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PatientId.Location = new System.Drawing.Point(38, 17);
            this.PatientId.Name = "PatientId";
            this.PatientId.Size = new System.Drawing.Size(81, 20);
            this.PatientId.TabIndex = 0;
            this.PatientId.Text = "Patient Id:";
            // 
            // PastAppointmentRecords
            // 
            this.PastAppointmentRecords.AutoSize = true;
            this.PastAppointmentRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PastAppointmentRecords.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PastAppointmentRecords.Location = new System.Drawing.Point(282, 122);
            this.PastAppointmentRecords.Name = "PastAppointmentRecords";
            this.PastAppointmentRecords.Size = new System.Drawing.Size(243, 25);
            this.PastAppointmentRecords.TabIndex = 8;
            this.PastAppointmentRecords.Text = "Past Appointment Records";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CloseButton.Location = new System.Drawing.Point(312, 389);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(203, 33);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Patients_DataGridView
            // 
            this.Patients_DataGridView.AllowUserToAddRows = false;
            this.Patients_DataGridView.AllowUserToDeleteRows = false;
            this.Patients_DataGridView.AllowUserToResizeColumns = false;
            this.Patients_DataGridView.AllowUserToResizeRows = false;
            this.Patients_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Patients_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Patients_DataGridView.Location = new System.Drawing.Point(12, 152);
            this.Patients_DataGridView.Name = "Patients_DataGridView";
            this.Patients_DataGridView.ReadOnly = true;
            this.Patients_DataGridView.Size = new System.Drawing.Size(803, 231);
            this.Patients_DataGridView.TabIndex = 11;
            this.Patients_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Patients_DataGridView_CellClick);
            // 
            // PatientRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(827, 434);
            this.Controls.Add(this.Patients_DataGridView);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PastAppointmentRecords);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PatientRecordsForm";
            this.Text = "PatientRecordsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Patients_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PatientId;
        private System.Windows.Forms.Label PatientName;
        private System.Windows.Forms.TextBox PatientIdTextBox;
        private System.Windows.Forms.TextBox SexTextBox;
        private System.Windows.Forms.TextBox DoBTextBox;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label DoB;
        private System.Windows.Forms.TextBox PatientNameTextBox;
        private System.Windows.Forms.Label PastAppointmentRecords;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataGridView Patients_DataGridView;
    }
}