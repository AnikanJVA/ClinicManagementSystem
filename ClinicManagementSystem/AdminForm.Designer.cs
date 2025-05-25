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
            this.UpdateDoctorButton = new System.Windows.Forms.Button();
            this.UpdateReceptionistButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.RegisterDoctorButton.Location = new System.Drawing.Point(39, 12);
            this.RegisterDoctorButton.Name = "RegisterDoctorButton";
            this.RegisterDoctorButton.Size = new System.Drawing.Size(173, 33);
            this.RegisterDoctorButton.TabIndex = 4;
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(230, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(681, 355);
            this.dataGridView1.TabIndex = 7;
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
            this.LogoutButton.Location = new System.Drawing.Point(48, 334);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(164, 33);
            this.LogoutButton.TabIndex = 6;
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
            this.RegisterReceptionistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterReceptionistButton.ForeColor = System.Drawing.Color.White;
            this.RegisterReceptionistButton.Location = new System.Drawing.Point(39, 110);
            this.RegisterReceptionistButton.Name = "RegisterReceptionistButton";
            this.RegisterReceptionistButton.Size = new System.Drawing.Size(173, 33);
            this.RegisterReceptionistButton.TabIndex = 5;
            this.RegisterReceptionistButton.Text = "Register Receptionist";
            this.RegisterReceptionistButton.UseVisualStyleBackColor = false;
            this.RegisterReceptionistButton.Click += new System.EventHandler(this.RegisterReceptionistButton_Click);
            // 
            // UpdateDoctorButton
            // 
            this.UpdateDoctorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.UpdateDoctorButton.FlatAppearance.BorderSize = 0;
            this.UpdateDoctorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.UpdateDoctorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.UpdateDoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateDoctorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.UpdateDoctorButton.ForeColor = System.Drawing.Color.White;
            this.UpdateDoctorButton.Location = new System.Drawing.Point(39, 61);
            this.UpdateDoctorButton.Name = "UpdateDoctorButton";
            this.UpdateDoctorButton.Size = new System.Drawing.Size(173, 33);
            this.UpdateDoctorButton.TabIndex = 9;
            this.UpdateDoctorButton.Text = "Update Doctor";
            this.UpdateDoctorButton.UseVisualStyleBackColor = false;
            this.UpdateDoctorButton.Click += new System.EventHandler(this.UpdateDoctorButton_Click);
            // 
            // UpdateReceptionistButton
            // 
            this.UpdateReceptionistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.UpdateReceptionistButton.FlatAppearance.BorderSize = 0;
            this.UpdateReceptionistButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.UpdateReceptionistButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.UpdateReceptionistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateReceptionistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateReceptionistButton.ForeColor = System.Drawing.Color.White;
            this.UpdateReceptionistButton.Location = new System.Drawing.Point(39, 159);
            this.UpdateReceptionistButton.Name = "UpdateReceptionistButton";
            this.UpdateReceptionistButton.Size = new System.Drawing.Size(173, 33);
            this.UpdateReceptionistButton.TabIndex = 10;
            this.UpdateReceptionistButton.Text = "Update Receptionist";
            this.UpdateReceptionistButton.UseVisualStyleBackColor = false;
            this.UpdateReceptionistButton.Click += new System.EventHandler(this.UpdateReceptionistButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(921, 382);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RegisterReceptionistButton);
            this.Controls.Add(this.RegisterDoctorButton);
            this.Controls.Add(this.UpdateDoctorButton);
            this.Controls.Add(this.UpdateReceptionistButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RegisterDoctorButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button RegisterReceptionistButton;
        private System.Windows.Forms.Button UpdateDoctorButton;
        private System.Windows.Forms.Button UpdateReceptionistButton;
    }
}