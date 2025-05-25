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
    public partial class RegisterReceptionistForm : Form
    {
        public RegisterReceptionistForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterReceptionistButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text) ||
               string.IsNullOrWhiteSpace(PasswordTextBox.Text) ||
               string.IsNullOrWhiteSpace(EmailAddressTextBox.Text) ||
               string.IsNullOrWhiteSpace(ContactNoTextBox.Text) ||
               string.IsNullOrWhiteSpace(AltContactNoTextBox.Text) ||
               string.IsNullOrWhiteSpace(AddressTextBox.Text) ||
               string.IsNullOrWhiteSpace(FnameTextBox.Text) ||
               string.IsNullOrWhiteSpace(MnameTextBox.Text) ||
               string.IsNullOrWhiteSpace(LnameTextBox.Text))
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
