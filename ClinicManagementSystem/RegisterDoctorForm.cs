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
                string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                string.IsNullOrWhiteSpace(ContactNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(AltContactNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(AddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(FnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(MnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LicenseNoTextBox.Text) ||
                (!MCheckBox.Checked && !TCheckBox.Checked && !WCheckBox.Checked &&
                !ThCheckBox.Checked && !FCheckBox.Checked && !SCheckBox.Checked)
                )
            {
                MessageBox.Show("Don't leave anything empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string schedule = "";
                List<String> selectedDays = new List<String>();
                if (MCheckBox.Checked) { selectedDays.Add("M"); }
                if (TCheckBox.Checked) { selectedDays.Add("T"); }
                if (WCheckBox.Checked) { selectedDays.Add("W"); }
                if (ThCheckBox.Checked) { selectedDays.Add("Th"); }
                if (FCheckBox.Checked) { selectedDays.Add("F"); }
                if (SCheckBox.Checked) { selectedDays.Add("S"); }



                for (int i = 0; i < selectedDays.Count(); i++)
                {
                    if (i != (selectedDays.Count() - 1))
                    {
                        schedule += selectedDays[i] + ", ";
                    }
                    else
                    {
                        schedule += selectedDays[i];
                    }
                }

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
                                       schedule))
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
