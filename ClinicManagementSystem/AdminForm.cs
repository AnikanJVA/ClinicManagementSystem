using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static ClinicManagementSystem.LoginForm;

namespace ClinicManagementSystem
{
    public partial class AdminForm : Form
    {
        private long userid;

        public AdminForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = Database.GetUsers();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Database.Instance.Connection.Close();
            loginForm.Show();
            this.Close();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernametextBox.Text) ||
                string.IsNullOrWhiteSpace(PasswordTextBox.Text) ||
                string.IsNullOrWhiteSpace(AccTypeComboBox.Text))
                
            {
                MessageBox.Show("Don't Leave anything empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (Database.AddUser(UsernametextBox.Text, PasswordTextBox.Text, AccTypeComboBox.Text))
                {
                    MessageBox.Show("User Added succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UsernametextBox.Clear();
                    PasswordTextBox.Clear();
                    dataGridView1.DataSource = Database.GetUsers();
                }
                else
                {
                    MessageBox.Show("Error!\nDupplicate account detected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Database.GetUsers();
            if (string.IsNullOrWhiteSpace(UsernametextBox.Text) ||
                string.IsNullOrWhiteSpace(AccTypeComboBox.Text))
            {
                MessageBox.Show("Can't delete a blank user!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string username = UsernametextBox.Text;
                string accType = AccTypeComboBox.Text;
                var choice = MessageBox.Show("Are you sure you want to update " + username + "'s status?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choice == DialogResult.Yes)
                {
                    if (Database.UpdateUserStatus(userid))
                    {
                        MessageBox.Show("User updated succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UsernametextBox.Clear();
                        PasswordTextBox.Clear();
                        dataGridView1.DataSource = Database.GetUsers();
                    }
                    else
                    {
                        MessageBox.Show("Error!\nUser not found.\nUser not deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        try
                        {
                            userid = Convert.ToInt64(row.Cells["Userid"].Value.ToString());

                        }catch (Exception ex) 
                        {
                            
                        }
                        string username = row.Cells["Username"].Value.ToString();
                        string accType = row.Cells["AccountType"].Value.ToString();

                        UsernametextBox.Text = Convert.ToString(username);
                        AccTypeComboBox.Text = Convert.ToString(accType);
                    }
                    else
                    {
                        userid = 000000000;
                        UsernametextBox.Clear();
                        AccTypeComboBox.SelectedIndex = -1;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
