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
            ChooseUser chooseUserForm = new ChooseUser();
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
                string.IsNullOrWhiteSpace(AltContactNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmailAddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(AddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(ScheduleComboBox.Text) ||
                string.IsNullOrWhiteSpace(StatusComboBox.Text))
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
