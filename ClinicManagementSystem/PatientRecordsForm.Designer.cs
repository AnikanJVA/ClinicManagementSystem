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
            this.PatientIDTextBox = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.PatientIDTextBox);
            this.panel1.Controls.Add(this.PatientName);
            this.panel1.Controls.Add(this.PatientId);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 113);
            this.panel1.TabIndex = 0;
            // 
            // SexTextBox
            // 
            this.SexTextBox.Enabled = false;
            this.SexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexTextBox.Location = new System.Drawing.Point(684, 58);
            this.SexTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SexTextBox.Name = "SexTextBox";
            this.SexTextBox.ReadOnly = true;
            this.SexTextBox.Size = new System.Drawing.Size(349, 30);
            this.SexTextBox.TabIndex = 7;
            // 
            // DoBTextBox
            // 
            this.DoBTextBox.Enabled = false;
            this.DoBTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoBTextBox.Location = new System.Drawing.Point(684, 21);
            this.DoBTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoBTextBox.Name = "DoBTextBox";
            this.DoBTextBox.ReadOnly = true;
            this.DoBTextBox.Size = new System.Drawing.Size(349, 30);
            this.DoBTextBox.TabIndex = 6;
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sex.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sex.Location = new System.Drawing.Point(623, 58);
            this.Sex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(53, 25);
            this.Sex.TabIndex = 5;
            this.Sex.Text = "Sex:";
            // 
            // DoB
            // 
            this.DoB.AutoSize = true;
            this.DoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DoB.Location = new System.Drawing.Point(552, 26);
            this.DoB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DoB.Name = "DoB";
            this.DoB.Size = new System.Drawing.Size(124, 25);
            this.DoB.TabIndex = 4;
            this.DoB.Text = "Date of Birth:";
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.Enabled = false;
            this.PatientNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameTextBox.Location = new System.Drawing.Point(167, 58);
            this.PatientNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.ReadOnly = true;
            this.PatientNameTextBox.Size = new System.Drawing.Size(349, 30);
            this.PatientNameTextBox.TabIndex = 3;
            // 
            // PatientIDTextBox
            // 
            this.PatientIDTextBox.Enabled = false;
            this.PatientIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientIDTextBox.Location = new System.Drawing.Point(167, 21);
            this.PatientIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PatientIDTextBox.Name = "PatientIDTextBox";
            this.PatientIDTextBox.ReadOnly = true;
            this.PatientIDTextBox.Size = new System.Drawing.Size(349, 30);
            this.PatientIDTextBox.TabIndex = 2;
            this.PatientIDTextBox.TextChanged += new System.EventHandler(this.PatientIDTextBox_TextChanged);
            // 
            // PatientName
            // 
            this.PatientName.AutoSize = true;
            this.PatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PatientName.Location = new System.Drawing.Point(16, 58);
            this.PatientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(132, 25);
            this.PatientName.TabIndex = 1;
            this.PatientName.Text = "Patient name:";
            // 
            // PatientId
            // 
            this.PatientId.AutoSize = true;
            this.PatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PatientId.Location = new System.Drawing.Point(51, 21);
            this.PatientId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientId.Name = "PatientId";
            this.PatientId.Size = new System.Drawing.Size(99, 25);
            this.PatientId.TabIndex = 0;
            this.PatientId.Text = "Patient Id:";
            // 
            // PastAppointmentRecords
            // 
            this.PastAppointmentRecords.AutoSize = true;
            this.PastAppointmentRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PastAppointmentRecords.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PastAppointmentRecords.Location = new System.Drawing.Point(376, 150);
            this.PastAppointmentRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PastAppointmentRecords.Name = "PastAppointmentRecords";
            this.PastAppointmentRecords.Size = new System.Drawing.Size(315, 29);
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
            this.CloseButton.Location = new System.Drawing.Point(416, 479);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(271, 41);
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
            this.Patients_DataGridView.Location = new System.Drawing.Point(16, 187);
            this.Patients_DataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Patients_DataGridView.Name = "Patients_DataGridView";
            this.Patients_DataGridView.ReadOnly = true;
            this.Patients_DataGridView.RowHeadersWidth = 51;
            this.Patients_DataGridView.Size = new System.Drawing.Size(1071, 284);
            this.Patients_DataGridView.TabIndex = 11;
            this.Patients_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Patients_DataGridView_CellClick_1);
            this.Patients_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Patients_DataGridView_CellContentClick);
            // 
            // PatientRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1103, 534);
            this.Controls.Add(this.Patients_DataGridView);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PastAppointmentRecords);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "PatientRecordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Records";
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
        private System.Windows.Forms.TextBox PatientIDTextBox;
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