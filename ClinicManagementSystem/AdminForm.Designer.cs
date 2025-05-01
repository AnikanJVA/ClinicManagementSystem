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
            this.UsernametextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.AccTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernametextBox
            // 
            this.UsernametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UsernametextBox.Location = new System.Drawing.Point(50, 48);
            this.UsernametextBox.Name = "UsernametextBox";
            this.UsernametextBox.Size = new System.Drawing.Size(345, 26);
            this.UsernametextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PasswordTextBox.Location = new System.Drawing.Point(50, 107);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '•';
            this.PasswordTextBox.Size = new System.Drawing.Size(345, 26);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // AccTypeComboBox
            // 
            this.AccTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AccTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AccTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AccTypeComboBox.FormattingEnabled = true;
            this.AccTypeComboBox.Items.AddRange(new object[] {
            "Doctor",
            "Receptionist"});
            this.AccTypeComboBox.Location = new System.Drawing.Point(50, 168);
            this.AccTypeComboBox.Name = "AccTypeComboBox";
            this.AccTypeComboBox.Size = new System.Drawing.Size(345, 28);
            this.AccTypeComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Account Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.CreateButton.FlatAppearance.BorderSize = 0;
            this.CreateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.CreateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("BDO Grotesk Light", 15F);
            this.CreateButton.ForeColor = System.Drawing.Color.White;
            this.CreateButton.Location = new System.Drawing.Point(50, 216);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(345, 43);
            this.CreateButton.TabIndex = 5;
            this.CreateButton.Text = "Create User";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(426, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(507, 397);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.LogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("BDO Grotesk Light", 15F);
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(50, 376);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(345, 43);
            this.LogoutButton.TabIndex = 7;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(122)))));
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("BDO Grotesk Light", 15F);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(50, 278);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(345, 43);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete User";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(962, 445);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccTypeComboBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernametextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernametextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.ComboBox AccTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button deleteButton;
    }
}