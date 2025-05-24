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
    public partial class UpdatePatientForm : Form
    {
        public UpdatePatientForm()
        {
            InitializeComponent();
            keyPressHandler();
            DoBDateTimePicker.Format = DateTimePickerFormat.Custom;
            DoBDateTimePicker.CustomFormat = "yyyy'/'MM'/'dd";

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
            PatientIdTextBox.KeyPress += numOnly;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            char sex;
            if (string.IsNullOrWhiteSpace(FnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(MnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LnameTextBox.Text) ||
                !MaleRadioButton.Checked && !FemaleRadioButton.Checked ||
                string.IsNullOrWhiteSpace(ContactNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(AltContactNumberTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                string.IsNullOrWhiteSpace(AddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(PatientIdTextBox.Text))
            {
                MessageBox.Show("Don't leave anything empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (PatientIdTextBox.Text.Equals(0) || string.IsNullOrWhiteSpace(PatientIdTextBox.Text))
                {
                    MessageBox.Show("Select Patient First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sex = MaleRadioButton.Checked ? 'M' : 'F';
            }
        }


        private void SelectButton_Click(object sender, EventArgs e)
        {
            ChoosePatientsForm choosePatientsForm = new ChoosePatientsForm();
            choosePatientsForm.ShowDialog();
            PatientIdTextBox.Text = Database.CurrentPatient.ID.ToString();
            FnameTextBox.Text = Database.CurrentPatient.FirstName.ToString();
            MnameTextBox.Text = Database.CurrentPatient.MiddleName.ToString();
            LnameTextBox.Text = Database.CurrentPatient.LastName.ToString();
            DoBDateTimePicker.Text = Database.CurrentPatient.DoB.ToString();

            if (Database.CurrentPatient.Sex.ToString().Equals("M"))
            {
                MaleRadioButton.Checked = true;
                FemaleRadioButton.Checked = false;
            }
            else
            {
                MaleRadioButton.Checked = false;
                FemaleRadioButton.Checked = true;
            }
            ContactNoTextBox.Text = Database.CurrentPatient.ContactNumber.ToString();
            AltContactNumberTextBox.Text = Database.CurrentPatient.AltContactNumber.ToString();
            EmailTextBox.Text = Database.CurrentPatient.EmailAddress.ToString();
            AddressTextBox.Text = Database.CurrentPatient.Address.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
