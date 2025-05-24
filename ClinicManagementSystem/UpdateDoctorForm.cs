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
    public partial class UpdateDoctorForm : Form
    {
        public UpdateDoctorForm()
        {
            InitializeComponent();
            keyPressHandler();
        }

        private void DoctorIdTextBox_TextChanged(object sender, EventArgs e)
        {

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
            DoctorIdTextBox.KeyPress += numOnly;
            LicenseNoTextBox.KeyPress += numOnly;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FnameTextBox.Text) ||
         string.IsNullOrWhiteSpace(MnameTextBox.Text) ||
         string.IsNullOrWhiteSpace(LnameTextBox.Text) ||
         string.IsNullOrWhiteSpace(ContactNoTextBox.Text) ||
         string.IsNullOrWhiteSpace(LicenseNoTextBox.Text) ||
         string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
         string.IsNullOrWhiteSpace(DoctorIdTextBox.Text) ||
         string.IsNullOrWhiteSpace(AddressTextBox.Text))
            {
                MessageBox.Show("Don't leave anything empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            ChooseDoctorForm chooseDoctorForm = new ChooseDoctorForm();
            chooseDoctorForm.ShowDialog();
            DoctorIdTextBox.Text = Database.CurrentDoctor.ID.ToString();
            FnameTextBox.Text = Database.CurrentDoctor.FirstName.ToString();
            MnameTextBox.Text = Database.CurrentDoctor.MiddleName.ToString();
            LnameTextBox.Text = Database.CurrentDoctor.LastName.ToString();
            LicenseNoTextBox.Text = Database.CurrentDoctor.LicenseNumber.ToString();
            ContactNoTextBox.Text = Database.CurrentDoctor.ContactNumber.ToString();
            EmailTextBox.Text = Database.CurrentDoctor.EmailAddress.ToString();
            StatusComboBox.Text = Database.CurrentDoctor.Status.ToString();
        }
    }
}
