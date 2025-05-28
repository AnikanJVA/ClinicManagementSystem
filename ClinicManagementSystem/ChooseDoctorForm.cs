using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static ClinicManagementSystem.LoginForm;

namespace ClinicManagementSystem
{
    public partial class ChooseDoctorForm : Form
    {
        private long doctorID;
        
        public ChooseDoctorForm()
        {
            InitializeComponent();
            Doctors_DataGridView.DataSource = Database.GetDoctors("ACTIVE");
            CloseButton.Visible = false;
            SelectButton.Visible = true;
            CancelButton.Visible = true;
        }

        public ChooseDoctorForm(string formType)
        {
            InitializeComponent();
            if (formType.ToUpper().Equals("SEARCH"))
            {
                Doctors_DataGridView.DataSource = Database.GetDoctors("ALL");
                CloseButton.Visible = true;
                SelectButton.Visible = false;
                CancelButton.Visible = false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DoctorIDTextBox.Text))
            {
                MessageBox.Show("Please select a doctor first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database.CurrentDoctor = Database.RetrieveDoctor(Convert.ToInt64(DoctorIDTextBox.Text), "DOCTORID");
                this.Close();
            }
        }

        private void Doctors_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell =  Doctors_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = Doctors_DataGridView.Rows[e.RowIndex];
                        try
                        {
                            doctorID = Convert.ToInt64(row.Cells["DoctorID"].Value.ToString());
                        }
                        catch (Exception ex)
                        {

                        }
                        string fname = row.Cells["FirstName"].Value.ToString();
                        string mname = row.Cells["MiddleName"].Value.ToString();
                        string lname = row.Cells["LastName"].Value.ToString();
                        string licenseNumber = row.Cells["LicenseNumber"].Value.ToString();
                        string contactNumber = row.Cells["ContactNumber"].Value.ToString();
                        string altContactNumber = row.Cells["AltContactNumber"].Value.ToString();
                        string emailAddress = row.Cells["emailAddress"].Value.ToString();
                        string address = row.Cells["address"].Value.ToString();
                        string status = row.Cells["status"].ToString();

                        DoctorIDTextBox.Text = Convert.ToString(doctorID);
                        FirstNameTextBox.Text = fname;
                        MiddleNameTextBox.Text = mname;
                        LastNameTextBox.Text = lname;
                        LicenseNumberTextBox.Text = licenseNumber;
                        ContactNumberTextBox.Text = contactNumber;
                        AltContactNumberTextBox.Text = altContactNumber;
                        EmailAddressTextBox.Text = emailAddress;
                        AddressTextBox.Text = address;
                        StatusComboBox.Text = status;
                    }
                    else
                    {
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

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Doctors_DataGridView.DataSource = Database.GetDoctors("ACTIVE");
        }

        private void SearchButton_Click(Object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(SearchFnameTextBox.Text) &&
               string.IsNullOrWhiteSpace(SearchMnameTextBox.Text) &&
               string.IsNullOrWhiteSpace(SearchLnameTextBox.Text))
            {
                MessageBox.Show("Search invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(SearchMnameTextBox.Text) && string.IsNullOrWhiteSpace(SearchLnameTextBox.Text))
                {
                    Doctors_DataGridView.DataSource = Database.GetSearchDoctor("F", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                }
                else if (string.IsNullOrWhiteSpace(SearchFnameTextBox.Text) && string.IsNullOrWhiteSpace(SearchLnameTextBox.Text))
                {
                    Doctors_DataGridView.DataSource = Database.GetSearchDoctor("M", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                }
                else if (string.IsNullOrWhiteSpace(SearchFnameTextBox.Text) && string.IsNullOrWhiteSpace(SearchMnameTextBox.Text))
                {
                    Doctors_DataGridView.DataSource = Database.GetSearchDoctor("L", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                }
                else if (string.IsNullOrWhiteSpace(SearchLnameTextBox.Text))
                {
                    Doctors_DataGridView.DataSource = Database.GetSearchDoctor("FM", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                }
                else if (string.IsNullOrWhiteSpace(SearchMnameTextBox.Text))
                {
                    Doctors_DataGridView.DataSource = Database.GetSearchDoctor("FL", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                }
                else if (string.IsNullOrWhiteSpace(SearchFnameTextBox.Text))
                {
                    Doctors_DataGridView.DataSource = Database.GetSearchDoctor("ML", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                }
                else
                {
                    Doctors_DataGridView.DataSource = Database.GetSearchDoctor("FML", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

    //public static bool UpdatePatient(long patientId,
    //                                             string firstName,
    //                                             string middleName,
    //                                             string lastName,
    //                                             string dob,
    //                                             char sex,
    //                                             string contactNumber,
    //                                             string altContactNumber,
    //                                             string emailAddress,
    //                                             string address,
    //                                             string status)
    //{
    //    string checkQuery = @"SELECT COUNT(*) FROM patients 
    //                                      WHERE patientId <> @patientId 
    //                                      AND (
    //                                          emailAddress = @EmailAddress 
    //                                          OR contactNumber = @ContactNumber 
    //                                          OR altContactNumber = @AltContactNumber
    //                                          OR contactNumber = @AltContactNumber
    //                                          OR altContactNumber = @ContactNumber
    //                                      )";

    //    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, Instance.connection))
    //    {
    //        checkCmd.Parameters.AddWithValue("@patientId", patientId);
    //        checkCmd.Parameters.AddWithValue("@EmailAddress", emailAddress);
    //        checkCmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
    //        checkCmd.Parameters.AddWithValue("@AltContactNumber", altContactNumber);

    //        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
    //        if (count > 0)
    //        {
    //            return false;
    //        }
    //    }

    //    string updateQuery = @"UPDATE patients SET 
    //                                    firstName = @FirstName,
    //                                    middleName = @MiddleName,
    //                                    lastName = @LastName,
    //                                    DoB = @DoB,
    //                                    sex = @Sex,
    //                                    contactNumber = @ContactNumber,
    //                                    altContactNumber = @AltContactNumber,
    //                                    emailAddress = @EmailAddress,
    //                                    address = @Address,
    //                                    status = @Status
    //                                    WHERE patientId = @PatientId";

    //    using (MySqlCommand cmd = new MySqlCommand(updateQuery, Instance.connection))
    //    {
    //        cmd.Parameters.AddWithValue("@FirstName", firstName);
    //        cmd.Parameters.AddWithValue("@MiddleName", middleName);
    //        cmd.Parameters.AddWithValue("@LastName", lastName);
    //        cmd.Parameters.AddWithValue("@DoB", dob);
    //        cmd.Parameters.AddWithValue("@Sex", sex);
    //        cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
    //        cmd.Parameters.AddWithValue("@AltContactNumber", altContactNumber);
    //        cmd.Parameters.AddWithValue("@EmailAddress", emailAddress);
    //        cmd.Parameters.AddWithValue("@Address", address);
    //        cmd.Parameters.AddWithValue("@Status", status);
    //        cmd.Parameters.AddWithValue("@PatientId", patientId);

    //        return cmd.ExecuteNonQuery() > 0;
    //    }