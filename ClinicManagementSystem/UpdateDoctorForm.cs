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

            if (Database.CurrentDoctor.Schedule.Contains("M")) { MCheckBox.Checked = true; }
            if (Database.CurrentDoctor.Schedule.Contains("T")) { TCheckBox.Checked = true; }
            if (Database.CurrentDoctor.Schedule.Contains("W")) { WCheckBox.Checked = true; }
            if (Database.CurrentDoctor.Schedule.Contains("Th")) { ThCheckBox.Checked = true; }
            if (Database.CurrentDoctor.Schedule.Contains("F")) { FCheckBox.Checked = true; }
            if (Database.CurrentDoctor.Schedule.Contains("S")) { SCheckBox.Checked = true; }

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

        private void UpdateDoctorButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserIDTextBox.Text) ||
                string.IsNullOrWhiteSpace(FnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(MnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LicenseNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(ContactNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(AddressTextBox.Text) ||
                (!MCheckBox.Checked && !TCheckBox.Checked && !WCheckBox.Checked && 
                !ThCheckBox.Checked && !FCheckBox.Checked && !SCheckBox.Checked) ||
                string.IsNullOrWhiteSpace(StatusComboBox.Text))
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
                                              schedule
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
