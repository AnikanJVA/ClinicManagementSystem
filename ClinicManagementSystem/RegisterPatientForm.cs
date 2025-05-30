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
    public partial class RegisterPatientForm : Form
    {
        public RegisterPatientForm()
        {
            InitializeComponent();
            DoBDateTimePicker.Format = DateTimePickerFormat.Custom;
            DoBDateTimePicker.CustomFormat = "yyyy'/'MM'/'dd";
            keyPressHandler();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            AltContactNumberTextBox.KeyPress += numOnly;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            char sex;
            if (string.IsNullOrWhiteSpace(FnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(MnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LnameTextBox.Text) ||
                !MaleRadioButton.Checked && !FemaleRadioButton.Checked ||
                string.IsNullOrWhiteSpace(ContactNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(AddressTextBox.Text))
            {
                MessageBox.Show("Only Email Address and Alternate Contact Number are optional. All other fields must be filled out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sex = MaleRadioButton.Checked ? 'M' : 'F';
                if (Database.AddPatient(FnameTextBox.Text, 
                                        MnameTextBox.Text,
                                        LnameTextBox.Text,
                                        DoBDateTimePicker.Text,
                                        sex,
                                        ContactNoTextBox.Text,
                                        AltContactNumberTextBox.Text,
                                        EmailTextBox.Text,
                                        AddressTextBox.Text))
                {
                    MessageBox.Show("Patient registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Error!\nDupplicate patient information detected.\nPatient not registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
