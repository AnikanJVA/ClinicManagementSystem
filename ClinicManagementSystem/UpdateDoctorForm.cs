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
using static ClinicManagementSystem.LoginForm;

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
            ChooseUserForm chooseUserForm = new ChooseUserForm("DOCTOR");
            chooseUserForm.ShowDialog();
            UserIDTextBox.Text = Database.CurrentUser.UserId.ToString();
            EmailAddressTextBox.Text = Database.CurrentUser.EmailAddress;
            ContactNoTextBox.Text = Database.CurrentUser.ContactNumber.ToString();
            AltContactNoTextBox.Text = Database.CurrentUser.AltContactNumber.ToString();
            AddressTextBox.Text = Database.CurrentUser.Address;


            LicenseNoTextBox.Text = Database.CurrentDoctor.LicenseNumber.ToString();
            FnameTextBox.Text = Database.CurrentDoctor.FirstName;
            MnameTextBox.Text = Database.CurrentDoctor.MiddleName;
            LnameTextBox.Text = Database.CurrentDoctor.LastName;
            StatusComboBox.Text = Database.CurrentUser.Status;
            ScheduleComboBox.Text = Database.CurrentDoctor.Schedule;
        }

        private void UpdateDoctorButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserIDTextBox.Text) ||
                string.IsNullOrWhiteSpace(FnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(MnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LicenseNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(ContactNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(AddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(ScheduleComboBox.Text) ||
                string.IsNullOrWhiteSpace(StatusComboBox.Text))
            {
                MessageBox.Show("Only Email Address and Alternate Contact Number are optional. All other fields must be filled out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Database.UpdateUserDoctor(Database.CurrentUser.UserId, 
                                              Database.CurrentDoctor.DoctorId, 
                                              EmailAddressTextBox.Text, 
                                              ContactNoTextBox.Text,
                                              AltContactNoTextBox.Text,
                                              AddressTextBox.Text,
                                              LicenseNoTextBox.Text,
                                              FnameTextBox.Text,
                                              MnameTextBox.Text,
                                              LnameTextBox.Text,
                                              StatusComboBox.Text.ToUpper(),
                                              ScheduleComboBox.Text
                                              ))
                {
                    MessageBox.Show("Doctor updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); 
                }

                else
                {
                    MessageBox.Show("Error!\nDupplicate doctor information detected.\nDoctor not updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
