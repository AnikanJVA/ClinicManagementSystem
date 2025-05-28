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
    public partial class ChooseUser : Form
    {
        private long userId;

        public ChooseUser()
        {
            InitializeComponent();
            dataGridView1.DataSource = Database.GetUsers("DOCTOR");
            SelectButton.Visible = true;
            CancelButton.Visible = true;
            CloseButton.Visible = false;
        }

        public ChooseUser(string formtype)
        {
            if (formtype.ToUpper().Equals("SEARCH"))
            {
                dataGridView1.DataSource = Database.GetUsers("DOCTOR");
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
                Database.CurrentDoctor = Database.RetrieveDoctor(Convert.ToInt64(UserIDTextBox.Text), "USERID");
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
                        string username = row.Cells["Username"].Value.ToString();
                        string doctorId = row.Cells["DoctorID"].Value.ToString();
                        string fname = row.Cells["FirstName"].Value.ToString();
                        string mname = row.Cells["MiddleName"].Value.ToString();
                        string lname = row.Cells["LastName"].Value.ToString();
                        string licenseNumber = row.Cells["LicenseNumber"].Value.ToString();
                        string contactNumber = row.Cells["ContactNumber"].Value.ToString();
                        string altContactNumber = row.Cells["AltContactNumber"].Value.ToString();
                        string emailAddress = row.Cells["EmailAddress"].Value.ToString();
                        string address = row.Cells["Address"].Value.ToString();
                        string schedule = row.Cells["Schedule"].Value.ToString();
                        string status = row.Cells["status"].Value.ToString();


                        UserIDTextBox.Text = Convert.ToString(userId);
                        UsernameTextBox.Text = Convert.ToString(username);
                        DoctorIDTextBox.Text = Convert.ToString(doctorId);
                        FirstNameTextBox.Text = fname;
                        MiddleNameTextBox.Text = mname;
                        LastNameTextBox.Text = lname;
                        LicenseNumberTextBox.Text = licenseNumber;
                        ContactNumberTextBox.Text = contactNumber;
                        AltContactNumberTextBox.Text = altContactNumber;
                        EmailAddressTextBox.Text = emailAddress;
                        AddressTextBox.Text = address;
                        ScheduleComboBox.Text = schedule;
                        StatusComboBox.Text = status;
                    }
                    else
                    {
                        UserIDTextBox.Clear();
                        UsernameTextBox.Clear();
                        DoctorIDTextBox.Clear();
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
