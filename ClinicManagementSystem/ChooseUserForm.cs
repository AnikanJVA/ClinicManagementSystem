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
    public partial class ChooseUserForm : Form
    {
        private long userId;
        private string accType;
        public ChooseUserForm(string accType)
        {
            this.accType = accType.ToUpper();
            InitializeComponent();
            dataGridView1.DataSource = Database.GetUsers(accType);
            if (accType.ToUpper().Equals("DOCTOR"))
            {
                AccTypeIDLabel.Text = "Doctor ID:";
                AccTypeIDLabel.Location = new Point(77, 81);

                LicenseNumberLabel.Visible = true;
                LicenseNumberTextBox.Visible = true;
                ScheduleComboBox.Visible = true;
                ScheduleLabel.Visible = true;
                LicenseNumberTextBox.Visible = true;
            }
            else
            {
                AccTypeIDLabel.Text = "Receptionist ID:";
                AccTypeIDLabel.Location = new Point(35, 84);

                LicenseNumberLabel.Visible = false;
                LicenseNumberTextBox.Visible = false;
                ScheduleComboBox.Visible = false;
                ScheduleLabel.Visible = false;
                LicenseNumberTextBox.Visible = false;
            }
            
            SelectButton.Visible = true;
            CancelButton.Visible = true;
            CloseButton.Visible = false;
        }

        public ChooseUserForm(string formtype, string accType)
        {
            this.accType = accType.ToUpper();
            if (accType.ToUpper().Equals("DOCTOR"))
            {
                LicenseNumberLabel.Visible = true;
                LicenseNumberTextBox.Visible = true;
                ScheduleComboBox.Visible = true;
                ScheduleLabel.Visible = true;
                LicenseNumberTextBox.Visible = true;
            }
            else
            {
                LicenseNumberLabel.Visible = false;
                LicenseNumberTextBox.Visible = false;
                ScheduleLabel.Visible = false;
                ScheduleComboBox.Visible = false;
                LicenseNumberTextBox.Visible = false;
            }

            if (formtype.ToUpper().Equals("SEARCH"))
            { 
                dataGridView1.DataSource = Database.GetUsers(accType);
                InitializeComponent();
                SelectButton.Visible = false;
                CancelButton.Visible = false;
                CloseButton.Visible = true;
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserIDTextBox.Text))
            {
                MessageBox.Show("Please select a user first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database.CurrentUser = Database.RetrieveUser(Convert.ToInt64(UserIDTextBox.Text));
                if (accType.Equals("DOCTOR"))
                {
                    Database.CurrentDoctor = Database.RetrieveDoctor(Convert.ToInt64(UserIDTextBox.Text), "USERID");
                }
                else
                {
                    Database.CurrentReceptionist = Database.RetrieveReceptionist(Convert.ToInt64(UserIDTextBox.Text));
                }
                this.Close();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        try
                        {
                            userId = Convert.ToInt64(row.Cells["UserID"].Value.ToString());
                        }
                        catch (Exception ex)
                        {

                        }
                        string doctorId = "0";
                        string receptionistId = "0";

                        string username = row.Cells["Username"].Value.ToString();
                        if (accType.Equals("DOCTOR"))
                        {
                            doctorId = row.Cells["DoctorID"].Value.ToString();
                        }
                        else
                        {
                            receptionistId = row.Cells["ReceptionistID"].Value.ToString();
                        }
                        string fname = row.Cells["FirstName"].Value.ToString();
                        string mname = row.Cells["MiddleName"].Value.ToString();
                        string lname = row.Cells["LastName"].Value.ToString();
                        string contactNumber = row.Cells["ContactNumber"].Value.ToString();
                        string altContactNumber = row.Cells["AltContactNumber"].Value.ToString();
                        string emailAddress = row.Cells["EmailAddress"].Value.ToString();
                        string address = row.Cells["Address"].Value.ToString();
                        string status = row.Cells["status"].Value.ToString();

                        if (accType.Equals("DOCTOR"))
                        {
                            string schedule = row.Cells["Schedule"].Value.ToString();
                            string licenseNumber = row.Cells["LicenseNumber"].Value.ToString();
                            LicenseNumberTextBox.Text = licenseNumber;
                            ScheduleComboBox.Text = schedule;
                        }

                        UserIDTextBox.Text = Convert.ToString(userId);
                        UsernameTextBox.Text = Convert.ToString(username);
                        if (accType.Equals("DOCTOR"))
                        {
                            AccTypeIDTextBox.Text = Convert.ToString(doctorId);
                        }
                        else
                        {
                            AccTypeIDTextBox.Text = Convert.ToString(receptionistId);
                        }
                        FirstNameTextBox.Text = fname;
                        MiddleNameTextBox.Text = mname;
                        LastNameTextBox.Text = lname;
                        ContactNumberTextBox.Text = contactNumber;
                        AltContactNumberTextBox.Text = altContactNumber;
                        EmailAddressTextBox.Text = emailAddress;
                        AddressTextBox.Text = address;
                        StatusComboBox.Text = status;
                    }
                    else
                    {
                        UserIDTextBox.Clear();
                        UsernameTextBox.Clear();
                        AccTypeIDTextBox.Clear();
                        FirstNameTextBox.Clear();
                        MiddleNameTextBox.Clear();
                        LastNameTextBox.Clear();
                        LicenseNumberTextBox.Clear();
                        ContactNumberTextBox.Clear();
                        AltContactNumberTextBox.Clear();
                        EmailAddressTextBox.Clear();
                        AddressTextBox.Clear();
                    }
                }
            }
        }
    }
}
