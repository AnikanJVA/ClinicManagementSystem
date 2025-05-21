namespace ChooseServiceForm
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
            this.ServiceDesc = new System.Windows.Forms.TextBox();
            this.ServiceName = new System.Windows.Forms.TextBox();
            this.ServiceId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectService = new System.Windows.Forms.Button();
            this.ServiceTable = new System.Windows.Forms.DataGridView();
            this.AddNewService = new System.Windows.Forms.Button();
            this.UpdateService = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.ServiceDesc);
            this.panel1.Controls.Add(this.ServiceName);
            this.panel1.Controls.Add(this.ServiceId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 293);
            this.panel1.TabIndex = 0;
            // 
            // ServiceDesc
            // 
            this.ServiceDesc.Location = new System.Drawing.Point(158, 129);
            this.ServiceDesc.Name = "ServiceDesc";
            this.ServiceDesc.Size = new System.Drawing.Size(231, 20);
            this.ServiceDesc.TabIndex = 5;
            // 
            // ServiceName
            // 
            this.ServiceName.Location = new System.Drawing.Point(158, 99);
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.Size = new System.Drawing.Size(231, 20);
            this.ServiceName.TabIndex = 4;
            // 
            // ServiceId
            // 
            this.ServiceId.Location = new System.Drawing.Point(158, 69);
            this.ServiceId.Name = "ServiceId";
            this.ServiceId.Size = new System.Drawing.Size(231, 20);
            this.ServiceId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(27, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Service description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(59, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Service name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(82, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SelectService
            // 
            this.SelectService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SelectService.FlatAppearance.BorderSize = 0;
            this.SelectService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectService.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SelectService.Location = new System.Drawing.Point(32, 419);
            this.SelectService.Name = "SelectService";
            this.SelectService.Size = new System.Drawing.Size(409, 29);
            this.SelectService.TabIndex = 1;
            this.SelectService.Text = "Select Service";
            this.SelectService.UseVisualStyleBackColor = false;
            // 
            // ServiceTable
            // 
            this.ServiceTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ServiceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceTable.Location = new System.Drawing.Point(467, 41);
            this.ServiceTable.Name = "ServiceTable";
            this.ServiceTable.Size = new System.Drawing.Size(342, 293);
            this.ServiceTable.TabIndex = 2;
            // 
            // AddNewService
            // 
            this.AddNewService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.AddNewService.FlatAppearance.BorderSize = 0;
            this.AddNewService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewService.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddNewService.Location = new System.Drawing.Point(467, 357);
            this.AddNewService.Name = "AddNewService";
            this.AddNewService.Size = new System.Drawing.Size(156, 29);
            this.AddNewService.TabIndex = 3;
            this.AddNewService.Text = "Add New Service";
            this.AddNewService.UseVisualStyleBackColor = false;
            // 
            // UpdateService
            // 
            this.UpdateService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.UpdateService.FlatAppearance.BorderSize = 0;
            this.UpdateService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateService.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateService.Location = new System.Drawing.Point(656, 357);
            this.UpdateService.Name = "UpdateService";
            this.UpdateService.Size = new System.Drawing.Size(153, 29);
            this.UpdateService.TabIndex = 4;
            this.UpdateService.Text = "Update Service";
            this.UpdateService.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton.Location = new System.Drawing.Point(467, 419);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(342, 29);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ChooseServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(840, 487);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.UpdateService);
            this.Controls.Add(this.AddNewService);
            this.Controls.Add(this.ServiceTable);
            this.Controls.Add(this.SelectService);
            this.Controls.Add(this.panel1);
            this.Name = "ChooseServiceForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServiceId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ServiceDesc;
        private System.Windows.Forms.TextBox ServiceName;
        private System.Windows.Forms.Button SelectService;
        private System.Windows.Forms.DataGridView ServiceTable;
        private System.Windows.Forms.Button AddNewService;
        private System.Windows.Forms.Button UpdateService;
        private System.Windows.Forms.Button CancelButton;
    }
}

