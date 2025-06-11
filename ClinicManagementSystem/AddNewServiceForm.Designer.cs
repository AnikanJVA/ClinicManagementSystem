namespace ClinicManagementSystem
{
    partial class AddNewServiceForm
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
            this.ServiceIDTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ServiceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ServiceDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ServiceNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServiceIdLabel = new System.Windows.Forms.Label();
            this.AddServiceButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.ServiceIDTextBox);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.StatusComboBox);
            this.panel1.Controls.Add(this.ServiceTypeComboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ServiceDescriptionTextBox);
            this.panel1.Controls.Add(this.PriceTextBox);
            this.panel1.Controls.Add(this.ServiceNameTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ServiceIdLabel);
            this.panel1.Controls.Add(this.AddServiceButton);
            this.panel1.Controls.Add(this.UpdateButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 290);
            this.panel1.TabIndex = 1;
            // 
            // ServiceIDTextBox
            // 
            this.ServiceIDTextBox.Enabled = false;
            this.ServiceIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceIDTextBox.Location = new System.Drawing.Point(174, 12);
            this.ServiceIDTextBox.Name = "ServiceIDTextBox";
            this.ServiceIDTextBox.ReadOnly = true;
            this.ServiceIDTextBox.Size = new System.Drawing.Size(277, 26);
            this.ServiceIDTextBox.TabIndex = 16;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton.Location = new System.Drawing.Point(329, 242);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(220, 26);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(120, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price:";
            // 
            // ServiceTypeComboBox
            // 
            this.ServiceTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServiceTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ServiceTypeComboBox.FormattingEnabled = true;
            this.ServiceTypeComboBox.Location = new System.Drawing.Point(174, 133);
            this.ServiceTypeComboBox.Name = "ServiceTypeComboBox";
            this.ServiceTypeComboBox.Size = new System.Drawing.Size(277, 28);
            this.ServiceTypeComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(69, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Service type:";
            // 
            // ServiceDescriptionTextBox
            // 
            this.ServiceDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ServiceDescriptionTextBox.Location = new System.Drawing.Point(174, 72);
            this.ServiceDescriptionTextBox.Multiline = true;
            this.ServiceDescriptionTextBox.Name = "ServiceDescriptionTextBox";
            this.ServiceDescriptionTextBox.Size = new System.Drawing.Size(277, 55);
            this.ServiceDescriptionTextBox.TabIndex = 5;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PriceTextBox.Location = new System.Drawing.Point(174, 167);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(277, 26);
            this.PriceTextBox.TabIndex = 4;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // ServiceNameTextBox
            // 
            this.ServiceNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ServiceNameTextBox.Location = new System.Drawing.Point(174, 42);
            this.ServiceNameTextBox.Name = "ServiceNameTextBox";
            this.ServiceNameTextBox.Size = new System.Drawing.Size(277, 26);
            this.ServiceNameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(22, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Service description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(59, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Service name:";
            // 
            // ServiceIdLabel
            // 
            this.ServiceIdLabel.AutoSize = true;
            this.ServiceIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ServiceIdLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ServiceIdLabel.Location = new System.Drawing.Point(87, 15);
            this.ServiceIdLabel.Name = "ServiceIdLabel";
            this.ServiceIdLabel.Size = new System.Drawing.Size(81, 20);
            this.ServiceIdLabel.TabIndex = 0;
            this.ServiceIdLabel.Text = "Service id:";
            this.ServiceIdLabel.Visible = false;
            // 
            // AddServiceButton
            // 
            this.AddServiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.AddServiceButton.FlatAppearance.BorderSize = 0;
            this.AddServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddServiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddServiceButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddServiceButton.Location = new System.Drawing.Point(52, 242);
            this.AddServiceButton.Name = "AddServiceButton";
            this.AddServiceButton.Size = new System.Drawing.Size(220, 26);
            this.AddServiceButton.TabIndex = 8;
            this.AddServiceButton.Text = "Add Service";
            this.AddServiceButton.UseVisualStyleBackColor = false;
            this.AddServiceButton.Visible = false;
            this.AddServiceButton.Click += new System.EventHandler(this.AddServiceButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateButton.Location = new System.Drawing.Point(52, 242);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(220, 26);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Update Service";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StatusLabel.Location = new System.Drawing.Point(108, 202);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(60, 20);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "Status:";
            this.StatusLabel.Visible = false;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "AVAILABLE",
            "UNAVAILABLE"});
            this.StatusComboBox.Location = new System.Drawing.Point(174, 199);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(277, 28);
            this.StatusComboBox.TabIndex = 7;
            // 
            // AddNewServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(606, 314);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddNewServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Service";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ServiceDescriptionTextBox;
        private System.Windows.Forms.TextBox ServiceNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ServiceIdLabel;
        private System.Windows.Forms.ComboBox ServiceTypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox ServiceIDTextBox;
        private System.Windows.Forms.Button AddServiceButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox StatusComboBox;
    }
}