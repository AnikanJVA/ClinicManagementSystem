namespace ClinicManagementSystem
{
    partial class ChooseServiceForm
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
            this.ServiceDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ServiceTypeTextBox = new System.Windows.Forms.TextBox();
            this.ServiceNameTextBox = new System.Windows.Forms.TextBox();
            this.ServiceIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectService = new System.Windows.Forms.Button();
            this.Services_DataGridView = new System.Windows.Forms.DataGridView();
            this.AddNewServiceButton = new System.Windows.Forms.Button();
            this.UpdateServiceButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Services_DataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.ServiceDescriptionTextBox);
            this.panel1.Controls.Add(this.PriceTextBox);
            this.panel1.Controls.Add(this.ServiceTypeTextBox);
            this.panel1.Controls.Add(this.ServiceNameTextBox);
            this.panel1.Controls.Add(this.ServiceIdTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 318);
            this.panel1.TabIndex = 0;
            // 
            // ServiceDescriptionTextBox
            // 
            this.ServiceDescriptionTextBox.Enabled = false;
            this.ServiceDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ServiceDescriptionTextBox.Location = new System.Drawing.Point(159, 160);
            this.ServiceDescriptionTextBox.Multiline = true;
            this.ServiceDescriptionTextBox.Name = "ServiceDescriptionTextBox";
            this.ServiceDescriptionTextBox.ReadOnly = true;
            this.ServiceDescriptionTextBox.Size = new System.Drawing.Size(257, 82);
            this.ServiceDescriptionTextBox.TabIndex = 5;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Enabled = false;
            this.PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PriceTextBox.Location = new System.Drawing.Point(159, 258);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(257, 26);
            this.PriceTextBox.TabIndex = 4;
            // 
            // ServiceTypeTextBox
            // 
            this.ServiceTypeTextBox.Enabled = false;
            this.ServiceTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ServiceTypeTextBox.Location = new System.Drawing.Point(159, 118);
            this.ServiceTypeTextBox.Name = "ServiceTypeTextBox";
            this.ServiceTypeTextBox.ReadOnly = true;
            this.ServiceTypeTextBox.Size = new System.Drawing.Size(257, 26);
            this.ServiceTypeTextBox.TabIndex = 4;
            // 
            // ServiceNameTextBox
            // 
            this.ServiceNameTextBox.Enabled = false;
            this.ServiceNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ServiceNameTextBox.Location = new System.Drawing.Point(159, 76);
            this.ServiceNameTextBox.Name = "ServiceNameTextBox";
            this.ServiceNameTextBox.ReadOnly = true;
            this.ServiceNameTextBox.Size = new System.Drawing.Size(257, 26);
            this.ServiceNameTextBox.TabIndex = 4;
            // 
            // ServiceIdTextBox
            // 
            this.ServiceIdTextBox.Enabled = false;
            this.ServiceIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ServiceIdTextBox.Location = new System.Drawing.Point(159, 34);
            this.ServiceIdTextBox.Name = "ServiceIdTextBox";
            this.ServiceIdTextBox.ReadOnly = true;
            this.ServiceIdTextBox.Size = new System.Drawing.Size(257, 26);
            this.ServiceIdTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(111, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(56, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Service Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(13, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Service Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(48, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Service Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(73, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SelectService
            // 
            this.SelectService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SelectService.FlatAppearance.BorderSize = 0;
            this.SelectService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectService.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SelectService.Location = new System.Drawing.Point(17, 362);
            this.SelectService.Name = "SelectService";
            this.SelectService.Size = new System.Drawing.Size(429, 29);
            this.SelectService.TabIndex = 1;
            this.SelectService.Text = "Select Service";
            this.SelectService.UseVisualStyleBackColor = false;
            this.SelectService.Click += new System.EventHandler(this.SelectService_Click);
            // 
            // Services_DataGridView
            // 
            this.Services_DataGridView.AllowUserToAddRows = false;
            this.Services_DataGridView.AllowUserToDeleteRows = false;
            this.Services_DataGridView.AllowUserToResizeColumns = false;
            this.Services_DataGridView.AllowUserToResizeRows = false;
            this.Services_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Services_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Services_DataGridView.Location = new System.Drawing.Point(7, 49);
            this.Services_DataGridView.MultiSelect = false;
            this.Services_DataGridView.Name = "Services_DataGridView";
            this.Services_DataGridView.ReadOnly = true;
            this.Services_DataGridView.Size = new System.Drawing.Size(427, 258);
            this.Services_DataGridView.TabIndex = 2;
            this.Services_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Services_DataGridView_CellClick);
            this.Services_DataGridView.Click += new System.EventHandler(this.Services_DataGridView_CellClick);
            // 
            // AddNewServiceButton
            // 
            this.AddNewServiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.AddNewServiceButton.FlatAppearance.BorderSize = 0;
            this.AddNewServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewServiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewServiceButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddNewServiceButton.Location = new System.Drawing.Point(8, 14);
            this.AddNewServiceButton.Name = "AddNewServiceButton";
            this.AddNewServiceButton.Size = new System.Drawing.Size(202, 29);
            this.AddNewServiceButton.TabIndex = 3;
            this.AddNewServiceButton.Text = "Add New Service";
            this.AddNewServiceButton.UseVisualStyleBackColor = false;
            this.AddNewServiceButton.Click += new System.EventHandler(this.AddNewService_Click);
            // 
            // UpdateServiceButton
            // 
            this.UpdateServiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.UpdateServiceButton.FlatAppearance.BorderSize = 0;
            this.UpdateServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateServiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateServiceButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateServiceButton.Location = new System.Drawing.Point(232, 14);
            this.UpdateServiceButton.Name = "UpdateServiceButton";
            this.UpdateServiceButton.Size = new System.Drawing.Size(202, 29);
            this.UpdateServiceButton.TabIndex = 4;
            this.UpdateServiceButton.Text = "Update Service";
            this.UpdateServiceButton.UseVisualStyleBackColor = false;
            this.UpdateServiceButton.Click += new System.EventHandler(this.UpdateService_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton.Location = new System.Drawing.Point(461, 362);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(426, 29);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.panel2.Controls.Add(this.Services_DataGridView);
            this.panel2.Controls.Add(this.UpdateServiceButton);
            this.panel2.Controls.Add(this.AddNewServiceButton);
            this.panel2.Location = new System.Drawing.Point(452, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 320);
            this.panel2.TabIndex = 6;
            // 
            // ChooseServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(905, 403);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectService);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChooseServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Service";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Services_DataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServiceIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ServiceDescriptionTextBox;
        private System.Windows.Forms.TextBox ServiceNameTextBox;
        private System.Windows.Forms.Button SelectService;
        private System.Windows.Forms.DataGridView Services_DataGridView;
        private System.Windows.Forms.Button AddNewServiceButton;
        private System.Windows.Forms.Button UpdateServiceButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox ServiceTypeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
    }
}

