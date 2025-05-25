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
    public partial class UpdateDoctorForm : Form
    {
        public UpdateDoctorForm()
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
            AltContactNoTextBox.KeyPress += numOnly;
            LicenseNoTextBox.KeyPress += numOnly;
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectUserButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateDoctorButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserIDTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmailAddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(ContactNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(AltContactNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(AddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(FnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(MnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LicenseNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(StatusComboBox.Text) ||
                string.IsNullOrWhiteSpace(ScheduleComboBox.Text)
                )
            {
                MessageBox.Show("Don't leave anything empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //if (Database.AddDoctor(UsernameTextBox.Text, PasswordTextBox.Text, EmailTextBox.Text, ContactNoTextBox.Text, 
                //                        LnameTextBox.Text, AltContactNoTextBox.Text, AddressTextBox.Text))
                //{
                //    MessageBox.Show("Doctor registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    this.Close();
                //}
                //else
                //{
                //    MessageBox.Show("Error!\nDupplicate doctor detected.\nDoctor not registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }
    }
}
