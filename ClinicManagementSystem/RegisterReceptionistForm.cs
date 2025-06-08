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
    public partial class RegisterReceptionistForm : Form
    {
        public RegisterReceptionistForm()
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

        private void RegisterReceptionistButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text) ||
               string.IsNullOrWhiteSpace(PasswordTextBox.Text) ||
               string.IsNullOrWhiteSpace(ContactNoTextBox.Text) ||
               string.IsNullOrWhiteSpace(AddressTextBox.Text) ||
               string.IsNullOrWhiteSpace(FnameTextBox.Text) ||
               string.IsNullOrWhiteSpace(MnameTextBox.Text) ||
               string.IsNullOrWhiteSpace(LnameTextBox.Text))
            {
                MessageBox.Show("Don't leave anything empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Database.AddReceptionist(UsernameTextBox.Text, PasswordTextBox.Text, EmailAddressTextBox.Text, ContactNoTextBox.Text, AltContactNoTextBox.Text, AddressTextBox.Text, FnameTextBox.Text, MnameTextBox.Text, LnameTextBox.Text))
                {
                    MessageBox.Show("Receptionist registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error!\nDupplicate receptionist information detected.\nReceptionist not registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
