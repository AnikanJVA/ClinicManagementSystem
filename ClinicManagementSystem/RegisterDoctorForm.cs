using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClinicManagementSystem.LoginForm;

namespace ClinicManagementSystem
{
    public partial class RegisterDoctorForm : Form
    {
        public RegisterDoctorForm()
        {
            InitializeComponent();
            keyPressHandler();
        }
        public void textOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                e.KeyChar != '-' &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        public void numOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        public void keyPressHandler()
        {
            LnameTextBox.KeyPress += textOnly;
            FnameTextBox.KeyPress += textOnly;
            MnameTextBox.KeyPress += textOnly;

            ContactNoTextBox.KeyPress += numOnly;
            LicenseNoTextBox.KeyPress += numOnly;
            AltContactNoTextBox.KeyPress += numOnly;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text) ||
                string.IsNullOrWhiteSpace(PasswordTextBox.Text) ||
                string.IsNullOrWhiteSpace(ContactNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(AddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(FnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(MnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LicenseNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(ScheduleComboBox.Text)
                )
            {
                MessageBox.Show("Only Email Address and Alternate Contact Number are optional. All other fields must be filled out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Database.AddDoctor(UsernameTextBox.Text, 
                                       PasswordTextBox.Text, 
                                       EmailTextBox.Text, 
                                       ContactNoTextBox.Text, 
                                       AltContactNoTextBox.Text, 
                                       AddressTextBox.Text, 
                                       LicenseNoTextBox.Text, 
                                       FnameTextBox.Text, 
                                       MnameTextBox.Text, 
                                       LnameTextBox.Text, 
                                       ScheduleComboBox.Text))
                {
                    MessageBox.Show("Doctor registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                    
                else
                {
                    MessageBox.Show("Error!\nDupplicate doctor information detected.\nDoctor not registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
