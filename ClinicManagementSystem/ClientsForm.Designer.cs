namespace ClinicManagementSystem
{
    partial class ClientsForm
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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.StaffsButton = new System.Windows.Forms.Button();
            this.DoctorsButton = new System.Windows.Forms.Button();
            this.BillingButton = new System.Windows.Forms.Button();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.AppointmentsButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ActiveTab = new System.Windows.Forms.TabPage();
            this.ApprovedDataGridView = new System.Windows.Forms.DataGridView();
            this.InactiveTab = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ActiveTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApprovedDataGridView)).BeginInit();
            this.InactiveTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.LogoutButton);
            this.splitContainer1.Panel1.Controls.Add(this.StaffsButton);
            this.splitContainer1.Panel1.Controls.Add(this.DoctorsButton);
            this.splitContainer1.Panel1.Controls.Add(this.BillingButton);
            this.splitContainer1.Panel1.Controls.Add(this.ClientsButton);
            this.splitContainer1.Panel1.Controls.Add(this.AppointmentsButton);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1MinSize = 278;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2MinSize = 1068;
            this.splitContainer1.Size = new System.Drawing.Size(1350, 729);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.TabIndex = 1;
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
            this.LogoutButton.Location = new System.Drawing.Point(20, 634);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(239, 66);
            this.LogoutButton.TabIndex = 6;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // StaffsButton
            // 
            this.StaffsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.StaffsButton.FlatAppearance.BorderSize = 0;
            this.StaffsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.StaffsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.StaffsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffsButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffsButton.ForeColor = System.Drawing.Color.White;
            this.StaffsButton.Location = new System.Drawing.Point(20, 352);
            this.StaffsButton.Name = "StaffsButton";
            this.StaffsButton.Size = new System.Drawing.Size(239, 66);
            this.StaffsButton.TabIndex = 5;
            this.StaffsButton.Text = "Staffs";
            this.StaffsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StaffsButton.UseVisualStyleBackColor = false;
            // 
            // DoctorsButton
            // 
            this.DoctorsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.DoctorsButton.FlatAppearance.BorderSize = 0;
            this.DoctorsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.DoctorsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.DoctorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoctorsButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorsButton.ForeColor = System.Drawing.Color.White;
            this.DoctorsButton.Location = new System.Drawing.Point(20, 265);
            this.DoctorsButton.Name = "DoctorsButton";
            this.DoctorsButton.Size = new System.Drawing.Size(239, 66);
            this.DoctorsButton.TabIndex = 4;
            this.DoctorsButton.Text = "Doctors";
            this.DoctorsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DoctorsButton.UseVisualStyleBackColor = false;
            // 
            // BillingButton
            // 
            this.BillingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.BillingButton.FlatAppearance.BorderSize = 0;
            this.BillingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.BillingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.BillingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillingButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillingButton.ForeColor = System.Drawing.Color.White;
            this.BillingButton.Location = new System.Drawing.Point(20, 178);
            this.BillingButton.Name = "BillingButton";
            this.BillingButton.Size = new System.Drawing.Size(239, 66);
            this.BillingButton.TabIndex = 3;
            this.BillingButton.Text = "Billing";
            this.BillingButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BillingButton.UseVisualStyleBackColor = false;
            // 
            // ClientsButton
            // 
            this.ClientsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.ClientsButton.FlatAppearance.BorderSize = 0;
            this.ClientsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.ClientsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.ClientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientsButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsButton.ForeColor = System.Drawing.Color.White;
            this.ClientsButton.Location = new System.Drawing.Point(20, 93);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(239, 66);
            this.ClientsButton.TabIndex = 2;
            this.ClientsButton.Text = "Clients";
            this.ClientsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ClientsButton.UseVisualStyleBackColor = false;
            // 
            // AppointmentsButton
            // 
            this.AppointmentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.AppointmentsButton.FlatAppearance.BorderSize = 0;
            this.AppointmentsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.AppointmentsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.AppointmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppointmentsButton.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentsButton.ForeColor = System.Drawing.Color.White;
            this.AppointmentsButton.Location = new System.Drawing.Point(20, 11);
            this.AppointmentsButton.Name = "AppointmentsButton";
            this.AppointmentsButton.Size = new System.Drawing.Size(239, 66);
            this.AppointmentsButton.TabIndex = 1;
            this.AppointmentsButton.Text = "Appointments";
            this.AppointmentsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AppointmentsButton.UseVisualStyleBackColor = false;
            this.AppointmentsButton.Click += new System.EventHandler(this.AppointmentsButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ActiveTab);
            this.tabControl1.Controls.Add(this.InactiveTab);
            this.tabControl1.Location = new System.Drawing.Point(37, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1002, 591);
            this.tabControl1.TabIndex = 7;
            // 
            // ActiveTab
            // 
            this.ActiveTab.Controls.Add(this.ApprovedDataGridView);
            this.ActiveTab.Location = new System.Drawing.Point(4, 22);
            this.ActiveTab.Name = "ActiveTab";
            this.ActiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.ActiveTab.Size = new System.Drawing.Size(994, 565);
            this.ActiveTab.TabIndex = 0;
            this.ActiveTab.Text = "Active";
            this.ActiveTab.UseVisualStyleBackColor = true;
            // 
            // ApprovedDataGridView
            // 
            this.ApprovedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApprovedDataGridView.Location = new System.Drawing.Point(6, 29);
            this.ApprovedDataGridView.Name = "ApprovedDataGridView";
            this.ApprovedDataGridView.Size = new System.Drawing.Size(994, 565);
            this.ApprovedDataGridView.TabIndex = 0;
            // 
            // InactiveTab
            // 
            this.InactiveTab.Controls.Add(this.dataGridView2);
            this.InactiveTab.Location = new System.Drawing.Point(4, 22);
            this.InactiveTab.Name = "InactiveTab";
            this.InactiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.InactiveTab.Size = new System.Drawing.Size(994, 565);
            this.InactiveTab.TabIndex = 1;
            this.InactiveTab.Text = "Inactive";
            this.InactiveTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 15);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(994, 565);
            this.dataGridView2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(733, 634);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(308, 66);
            this.button3.TabIndex = 10;
            this.button3.Text = "Search Client";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(383, 634);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(308, 66);
            this.button2.TabIndex = 9;
            this.button2.Text = "Update Client";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("BDO Grotesk Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(37, 634);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 66);
            this.button1.TabIndex = 8;
            this.button1.Text = "Register Client";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientsForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ActiveTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ApprovedDataGridView)).EndInit();
            this.InactiveTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button StaffsButton;
        private System.Windows.Forms.Button DoctorsButton;
        private System.Windows.Forms.Button BillingButton;
        private System.Windows.Forms.Button ClientsButton;
        private System.Windows.Forms.Button AppointmentsButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ActiveTab;
        private System.Windows.Forms.DataGridView ApprovedDataGridView;
        private System.Windows.Forms.TabPage InactiveTab;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}