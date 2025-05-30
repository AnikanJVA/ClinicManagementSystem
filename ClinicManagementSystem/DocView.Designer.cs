namespace ClinicManagementSystem
{
    partial class DocView
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
            this.DashBoard_NavButton = new System.Windows.Forms.Button();
            this.AccountTypelabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.Patients_NavButton = new System.Windows.Forms.Button();
            this.Appointments_NavButton = new System.Windows.Forms.Button();
            this.Patients_DataGridView = new System.Windows.Forms.DataGridView();
            this.Patients_SearchButton = new System.Windows.Forms.Button();
            this.Appointments_TabControl = new System.Windows.Forms.TabControl();
            this.Appointments_AllTab = new System.Windows.Forms.TabPage();
            this.Appointments_AllDataGridView = new System.Windows.Forms.DataGridView();
            this.Appointments_UpcomingTab = new System.Windows.Forms.TabPage();
            this.Appointments_UpcomingDataGridView = new System.Windows.Forms.DataGridView();
            this.Appointments_FinishedTab = new System.Windows.Forms.TabPage();
            this.Appointments_FinishedDataGridView = new System.Windows.Forms.DataGridView();
            this.Dashboard_panel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Appointments_SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Patients_DataGridView)).BeginInit();
            this.Appointments_TabControl.SuspendLayout();
            this.Appointments_AllTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Appointments_AllDataGridView)).BeginInit();
            this.Appointments_UpcomingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Appointments_UpcomingDataGridView)).BeginInit();
            this.Appointments_FinishedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Appointments_FinishedDataGridView)).BeginInit();
            this.Dashboard_panel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.DashBoard_NavButton);
            this.splitContainer1.Panel1.Controls.Add(this.AccountTypelabel);
            this.splitContainer1.Panel1.Controls.Add(this.LogoutButton);
            this.splitContainer1.Panel1.Controls.Add(this.Patients_NavButton);
            this.splitContainer1.Panel1.Controls.Add(this.Appointments_NavButton);
            this.splitContainer1.Panel1MinSize = 282;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
            this.splitContainer1.Panel2.Controls.Add(this.Patients_SearchButton);
            this.splitContainer1.Panel2.Controls.Add(this.Appointments_SearchButton);
            this.splitContainer1.Panel2.Controls.Add(this.Appointments_TabControl);
            this.splitContainer1.Panel2.Controls.Add(this.Patients_DataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.Dashboard_panel);
            this.splitContainer1.Panel2MinSize = 978;
            this.splitContainer1.Size = new System.Drawing.Size(1264, 681);
            this.splitContainer1.SplitterDistance = 282;
            this.splitContainer1.TabIndex = 1;
            // 
            // DashBoard_NavButton
            // 
            this.DashBoard_NavButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.DashBoard_NavButton.FlatAppearance.BorderSize = 0;
            this.DashBoard_NavButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.DashBoard_NavButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.DashBoard_NavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashBoard_NavButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoard_NavButton.ForeColor = System.Drawing.Color.White;
            this.DashBoard_NavButton.Location = new System.Drawing.Point(20, 83);
            this.DashBoard_NavButton.Name = "DashBoard_NavButton";
            this.DashBoard_NavButton.Size = new System.Drawing.Size(239, 66);
            this.DashBoard_NavButton.TabIndex = 7;
            this.DashBoard_NavButton.Text = "Dashboard";
            this.DashBoard_NavButton.UseVisualStyleBackColor = false;
            this.DashBoard_NavButton.Click += new System.EventHandler(this.DashBoard_NavButton_Click);
            // 
            // AccountTypelabel
            // 
            this.AccountTypelabel.AutoSize = true;
            this.AccountTypelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.AccountTypelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountTypelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.AccountTypelabel.ForeColor = System.Drawing.Color.White;
            this.AccountTypelabel.Location = new System.Drawing.Point(93, 12);
            this.AccountTypelabel.Name = "AccountTypelabel";
            this.AccountTypelabel.Size = new System.Drawing.Size(86, 31);
            this.AccountTypelabel.TabIndex = 7;
            this.AccountTypelabel.Text = "Doctor";
            this.AccountTypelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.LogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(20, 578);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(239, 66);
            this.LogoutButton.TabIndex = 6;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // Patients_NavButton
            // 
            this.Patients_NavButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.Patients_NavButton.FlatAppearance.BorderSize = 0;
            this.Patients_NavButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.Patients_NavButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.Patients_NavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Patients_NavButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patients_NavButton.ForeColor = System.Drawing.Color.White;
            this.Patients_NavButton.Location = new System.Drawing.Point(20, 239);
            this.Patients_NavButton.Name = "Patients_NavButton";
            this.Patients_NavButton.Size = new System.Drawing.Size(239, 66);
            this.Patients_NavButton.TabIndex = 2;
            this.Patients_NavButton.Text = "Patients";
            this.Patients_NavButton.UseVisualStyleBackColor = false;
            this.Patients_NavButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // Appointments_NavButton
            // 
            this.Appointments_NavButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.Appointments_NavButton.FlatAppearance.BorderSize = 0;
            this.Appointments_NavButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.Appointments_NavButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.Appointments_NavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Appointments_NavButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appointments_NavButton.ForeColor = System.Drawing.Color.White;
            this.Appointments_NavButton.Location = new System.Drawing.Point(20, 161);
            this.Appointments_NavButton.Name = "Appointments_NavButton";
            this.Appointments_NavButton.Size = new System.Drawing.Size(239, 66);
            this.Appointments_NavButton.TabIndex = 1;
            this.Appointments_NavButton.Text = "Appointments";
            this.Appointments_NavButton.UseVisualStyleBackColor = false;
            this.Appointments_NavButton.Click += new System.EventHandler(this.AppointmentsButton_Click);
            // 
            // Patients_DataGridView
            // 
            this.Patients_DataGridView.AllowUserToAddRows = false;
            this.Patients_DataGridView.AllowUserToDeleteRows = false;
            this.Patients_DataGridView.AllowUserToResizeColumns = false;
            this.Patients_DataGridView.AllowUserToResizeRows = false;
            this.Patients_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Patients_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Patients_DataGridView.Location = new System.Drawing.Point(54, 46);
            this.Patients_DataGridView.MultiSelect = false;
            this.Patients_DataGridView.Name = "Patients_DataGridView";
            this.Patients_DataGridView.ReadOnly = true;
            this.Patients_DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.Patients_DataGridView.Size = new System.Drawing.Size(881, 507);
            this.Patients_DataGridView.TabIndex = 4;
            this.Patients_DataGridView.Visible = false;
            // 
            // Patients_SearchButton
            // 
            this.Patients_SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.Patients_SearchButton.FlatAppearance.BorderSize = 0;
            this.Patients_SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.Patients_SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.Patients_SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Patients_SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patients_SearchButton.ForeColor = System.Drawing.Color.White;
            this.Patients_SearchButton.Location = new System.Drawing.Point(271, 578);
            this.Patients_SearchButton.Name = "Patients_SearchButton";
            this.Patients_SearchButton.Size = new System.Drawing.Size(410, 66);
            this.Patients_SearchButton.TabIndex = 12;
            this.Patients_SearchButton.Text = "Search Patient";
            this.Patients_SearchButton.UseVisualStyleBackColor = false;
            this.Patients_SearchButton.Visible = false;
            this.Patients_SearchButton.Click += new System.EventHandler(this.Patients_SearchButton_Click);
            // 
            // Appointments_TabControl
            // 
            this.Appointments_TabControl.Controls.Add(this.Appointments_AllTab);
            this.Appointments_TabControl.Controls.Add(this.Appointments_UpcomingTab);
            this.Appointments_TabControl.Controls.Add(this.Appointments_FinishedTab);
            this.Appointments_TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Appointments_TabControl.Location = new System.Drawing.Point(50, 21);
            this.Appointments_TabControl.Name = "Appointments_TabControl";
            this.Appointments_TabControl.SelectedIndex = 0;
            this.Appointments_TabControl.Size = new System.Drawing.Size(889, 536);
            this.Appointments_TabControl.TabIndex = 8;
            this.Appointments_TabControl.Visible = false;
            // 
            // Appointments_AllTab
            // 
            this.Appointments_AllTab.Controls.Add(this.Appointments_AllDataGridView);
            this.Appointments_AllTab.Location = new System.Drawing.Point(4, 25);
            this.Appointments_AllTab.Name = "Appointments_AllTab";
            this.Appointments_AllTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Appointments_AllTab.Size = new System.Drawing.Size(881, 507);
            this.Appointments_AllTab.TabIndex = 0;
            this.Appointments_AllTab.Text = "All";
            this.Appointments_AllTab.UseVisualStyleBackColor = true;
            // 
            // Appointments_AllDataGridView
            // 
            this.Appointments_AllDataGridView.AllowUserToAddRows = false;
            this.Appointments_AllDataGridView.AllowUserToDeleteRows = false;
            this.Appointments_AllDataGridView.AllowUserToResizeColumns = false;
            this.Appointments_AllDataGridView.AllowUserToResizeRows = false;
            this.Appointments_AllDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Appointments_AllDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Appointments_AllDataGridView.Location = new System.Drawing.Point(0, 0);
            this.Appointments_AllDataGridView.MultiSelect = false;
            this.Appointments_AllDataGridView.Name = "Appointments_AllDataGridView";
            this.Appointments_AllDataGridView.ReadOnly = true;
            this.Appointments_AllDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.Appointments_AllDataGridView.Size = new System.Drawing.Size(881, 507);
            this.Appointments_AllDataGridView.TabIndex = 3;
            // 
            // Appointments_UpcomingTab
            // 
            this.Appointments_UpcomingTab.Controls.Add(this.Appointments_UpcomingDataGridView);
            this.Appointments_UpcomingTab.Location = new System.Drawing.Point(4, 25);
            this.Appointments_UpcomingTab.Name = "Appointments_UpcomingTab";
            this.Appointments_UpcomingTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Appointments_UpcomingTab.Size = new System.Drawing.Size(881, 507);
            this.Appointments_UpcomingTab.TabIndex = 1;
            this.Appointments_UpcomingTab.Text = "Upcoming";
            this.Appointments_UpcomingTab.UseVisualStyleBackColor = true;
            // 
            // Appointments_UpcomingDataGridView
            // 
            this.Appointments_UpcomingDataGridView.AllowUserToAddRows = false;
            this.Appointments_UpcomingDataGridView.AllowUserToDeleteRows = false;
            this.Appointments_UpcomingDataGridView.AllowUserToResizeColumns = false;
            this.Appointments_UpcomingDataGridView.AllowUserToResizeRows = false;
            this.Appointments_UpcomingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Appointments_UpcomingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Appointments_UpcomingDataGridView.Location = new System.Drawing.Point(0, 0);
            this.Appointments_UpcomingDataGridView.MultiSelect = false;
            this.Appointments_UpcomingDataGridView.Name = "Appointments_UpcomingDataGridView";
            this.Appointments_UpcomingDataGridView.ReadOnly = true;
            this.Appointments_UpcomingDataGridView.RowHeadersWidth = 51;
            this.Appointments_UpcomingDataGridView.Size = new System.Drawing.Size(881, 507);
            this.Appointments_UpcomingDataGridView.TabIndex = 2;
            // 
            // Appointments_FinishedTab
            // 
            this.Appointments_FinishedTab.Controls.Add(this.Appointments_FinishedDataGridView);
            this.Appointments_FinishedTab.Location = new System.Drawing.Point(4, 25);
            this.Appointments_FinishedTab.Name = "Appointments_FinishedTab";
            this.Appointments_FinishedTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Appointments_FinishedTab.Size = new System.Drawing.Size(881, 507);
            this.Appointments_FinishedTab.TabIndex = 3;
            this.Appointments_FinishedTab.Text = "Finished";
            this.Appointments_FinishedTab.UseVisualStyleBackColor = true;
            // 
            // Appointments_FinishedDataGridView
            // 
            this.Appointments_FinishedDataGridView.AllowUserToAddRows = false;
            this.Appointments_FinishedDataGridView.AllowUserToDeleteRows = false;
            this.Appointments_FinishedDataGridView.AllowUserToResizeColumns = false;
            this.Appointments_FinishedDataGridView.AllowUserToResizeRows = false;
            this.Appointments_FinishedDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Appointments_FinishedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Appointments_FinishedDataGridView.Location = new System.Drawing.Point(0, 0);
            this.Appointments_FinishedDataGridView.MultiSelect = false;
            this.Appointments_FinishedDataGridView.Name = "Appointments_FinishedDataGridView";
            this.Appointments_FinishedDataGridView.ReadOnly = true;
            this.Appointments_FinishedDataGridView.RowHeadersWidth = 51;
            this.Appointments_FinishedDataGridView.Size = new System.Drawing.Size(881, 507);
            this.Appointments_FinishedDataGridView.TabIndex = 5;
            // 
            // Dashboard_panel
            // 
            this.Dashboard_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.Dashboard_panel.Controls.Add(this.panel4);
            this.Dashboard_panel.Controls.Add(this.panel3);
            this.Dashboard_panel.Controls.Add(this.panel2);
            this.Dashboard_panel.Location = new System.Drawing.Point(13, 12);
            this.Dashboard_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dashboard_panel.Name = "Dashboard_panel";
            this.Dashboard_panel.Size = new System.Drawing.Size(953, 632);
            this.Dashboard_panel.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(337, 352);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(299, 123);
            this.panel4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(132, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "123";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Doctors Available";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(568, 154);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 104);
            this.panel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(64, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Patients";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "123213";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(155, 154);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 104);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Appointments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "1234";
            // 
            // Appointments_SearchButton
            // 
            this.Appointments_SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.Appointments_SearchButton.FlatAppearance.BorderSize = 0;
            this.Appointments_SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.Appointments_SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.Appointments_SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Appointments_SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appointments_SearchButton.ForeColor = System.Drawing.Color.White;
            this.Appointments_SearchButton.Location = new System.Drawing.Point(271, 578);
            this.Appointments_SearchButton.Name = "Appointments_SearchButton";
            this.Appointments_SearchButton.Size = new System.Drawing.Size(410, 66);
            this.Appointments_SearchButton.TabIndex = 13;
            this.Appointments_SearchButton.Text = "Search Appointment";
            this.Appointments_SearchButton.UseVisualStyleBackColor = false;
            this.Appointments_SearchButton.Visible = false;
            this.Appointments_SearchButton.Click += new System.EventHandler(this.Appointment_SearchButton_Click);
            // 
            // DocView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DocView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DENTAL CLINIC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DocView_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Patients_DataGridView)).EndInit();
            this.Appointments_TabControl.ResumeLayout(false);
            this.Appointments_AllTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Appointments_AllDataGridView)).EndInit();
            this.Appointments_UpcomingTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Appointments_UpcomingDataGridView)).EndInit();
            this.Appointments_FinishedTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Appointments_FinishedDataGridView)).EndInit();
            this.Dashboard_panel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button Patients_NavButton;
        private System.Windows.Forms.Button Appointments_NavButton;
        private System.Windows.Forms.Label AccountTypelabel;
        private System.Windows.Forms.Button DashBoard_NavButton;
        private System.Windows.Forms.Button Patients_SearchButton;
        private System.Windows.Forms.DataGridView Patients_DataGridView;
        private System.Windows.Forms.TabControl Appointments_TabControl;
        private System.Windows.Forms.TabPage Appointments_AllTab;
        private System.Windows.Forms.DataGridView Appointments_AllDataGridView;
        private System.Windows.Forms.TabPage Appointments_UpcomingTab;
        private System.Windows.Forms.DataGridView Appointments_UpcomingDataGridView;
        private System.Windows.Forms.TabPage Appointments_FinishedTab;
        private System.Windows.Forms.DataGridView Appointments_FinishedDataGridView;
        private System.Windows.Forms.Panel Dashboard_panel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Appointments_SearchButton;
    }
}