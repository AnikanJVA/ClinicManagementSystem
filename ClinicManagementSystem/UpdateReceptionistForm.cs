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
    public partial class UpdateReceptionistForm : Form
    {
        public UpdateReceptionistForm()
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
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterDoctorButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmailAddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(ContactNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(AltContactNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(AddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(FnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(MnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(UserIDTextBox.Text) ||
                string.IsNullOrWhiteSpace(StatusComboBox.Text))
            {
                MessageBox.Show("Don't leave anything empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Database.UpdateUserReceptionist(Database.CurrentUser.UserId,
                                              Database.CurrentReceptionist.ReceptionistId,
                                              EmailAddressTextBox.Text,
                                              ContactNoTextBox.Text,
                                              AltContactNoTextBox.Text,
                                              AddressTextBox.Text,
                                              FnameTextBox.Text,
                                              MnameTextBox.Text,
                                              LnameTextBox.Text,
                                              StatusComboBox.Text.ToUpper()))
                {
                    MessageBox.Show("Receptionist updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error!\nDupplicate receptionist information detected.\nReceptionist not updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SelectUserButton_Click(object sender, EventArgs e)
        {
            ChooseUserForm chooseUserForm = new ChooseUserForm("RECEPTIONIST");
            chooseUserForm.ShowDialog();
            UserIDTextBox.Text = Database.CurrentUser.UserId.ToString();
            EmailAddressTextBox.Text = Database.CurrentUser.EmailAddress;
            ContactNoTextBox.Text = Database.CurrentUser.ContactNumber.ToString();
            AltContactNoTextBox.Text = Database.CurrentUser.AltContactNumber.ToString();
            AddressTextBox.Text = Database.CurrentUser.Address;


            FnameTextBox.Text = Database.CurrentReceptionist.FirstName;
            MnameTextBox.Text = Database.CurrentReceptionist.MiddleName;
            LnameTextBox.Text = Database.CurrentReceptionist.LastName;
            StatusComboBox.Text = Database.CurrentUser.Status;
        }
    }
}
