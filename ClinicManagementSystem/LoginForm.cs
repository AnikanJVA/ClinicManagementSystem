using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = button1;
            this.Controls.Add(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Username and Password must not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string usernmae = UsernameTextBox.Text.Trim();

                if (usernmae.Equals("admin") && PasswordTextBox.Text.Equals("123"))
                {
                    MessageBox.Show("Login Successful!", "Success");
                    AppointmentsForm appointments = new AppointmentsForm();
                    appointments.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }




        // TODO: database class and methods
    }
}
