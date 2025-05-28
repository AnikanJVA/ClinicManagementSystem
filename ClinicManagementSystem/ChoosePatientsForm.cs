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
    public partial class ChoosePatientsForm : Form
    {
        private long patientID;
        private string formType;
        public ChoosePatientsForm()
        {
            InitializeComponent();
            formType = "CHOOSE";
            Patients_DataGridView.DataSource = Database.GetPatients("ACTIVE");
            CloseButton.Visible = false;
            SelectButton.Visible = true;
            CancelButton.Visible = true;
            RegisterNewPatientButton.Visible = true;
        }

        public ChoosePatientsForm(string formType)
        {
            InitializeComponent();
            this.formType = formType.ToUpper();
            if (formType.ToUpper().Equals("SEARCH"))
            {
                Patients_DataGridView.DataSource = Database.GetPatients("ALL");
                CloseButton.Visible = true;
                SelectButton.Visible = false;
                CancelButton.Visible = false;
                RegisterNewPatientButton.Visible = false;
            }

        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PatientIDTextBox.Text))
            {
                MessageBox.Show("Please select a patient first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                Database.CurrentPatient = Database.RetrievePatient(Convert.ToInt64(PatientIDTextBox.Text));
                this.Close();
            }
        }

        private void Patients_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = Patients_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = Patients_DataGridView.Rows[e.RowIndex];
                        try
                        {
                            patientID = Convert.ToInt64(row.Cells["PatientID"].Value.ToString());
                        }
                        catch (Exception ex)
                        {

                        }
                        string fname = row.Cells["FirstName"].Value.ToString();
                        string mname = row.Cells["MiddleName"].Value.ToString();
                        string lname = row.Cells["LastName"].Value.ToString();
                        string DoB = row.Cells["DoB"].Value.ToString();
                        string sex = row.Cells["Sex"].Value.ToString();
                        string contactNumber = row.Cells["ContactNumber"].Value.ToString();
                        string altContactNumber = row.Cells["AltContactNumber"].Value.ToString();
                        string emailAddress = row.Cells["EmailAddress"].Value.ToString();
                        string address = row.Cells["Address"].Value.ToString();
                        string status = row.Cells["Status"].Value.ToString();

                        PatientIDTextBox.Text = Convert.ToString(patientID);
                        FirstNameTextBox.Text = fname;
                        MiddleNameTextBox.Text = mname;
                        LastNameTextBox.Text = lname;
                        DoBTextBox.Text = DoB;
                        SexTextBox.Text = sex;
                        ContactNumberTextBox.Text = contactNumber;
                        AltContactNumberTextBox.Text = altContactNumber;
                        EmailAddressTextBox.Text = emailAddress;
                        AddressTextBox.Text = address;
                        StatusTextBox.Text = status;
                    }
                    else
                    {
                        PatientIDTextBox.Clear();
                        FirstNameTextBox.Clear();
                        MiddleNameTextBox.Clear();
                        LastNameTextBox.Clear();
                        DoBTextBox.Clear();
                        SexTextBox.Clear();
                        ContactNumberTextBox.Clear();
                    }
                }
            }
        }

        private void RegisterNewPatientButton_Click(object sender, EventArgs e)
        {
            RegisterPatientForm registerPatientForm = new RegisterPatientForm();
            registerPatientForm.ShowDialog();
            Patients_DataGridView.DataSource = Database.GetPatients("ACTIVE");
        }



        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (formType.Equals("CHOOSE"))
            {
                Patients_DataGridView.DataSource = Database.GetPatients("ACTIVE");
            }
            else
            {
                Patients_DataGridView.DataSource = Database.GetPatients("ALL");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchFnameTextBox.Text) &&
                string.IsNullOrWhiteSpace(SearchMnameTextBox.Text) &&
                string.IsNullOrWhiteSpace(SearchLnameTextBox.Text))
            {
                MessageBox.Show("Search invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(SearchMnameTextBox.Text) && string.IsNullOrWhiteSpace(SearchLnameTextBox.Text))
                {
                    Patients_DataGridView.DataSource = Database.GetSearchPatient("F", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                }
                else if (string.IsNullOrWhiteSpace(SearchFnameTextBox.Text) && string.IsNullOrWhiteSpace(SearchLnameTextBox.Text))
                {
                    Patients_DataGridView.DataSource = Database.GetSearchPatient("M", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                }
                else if (string.IsNullOrWhiteSpace(SearchFnameTextBox.Text) && string.IsNullOrWhiteSpace(SearchMnameTextBox.Text))
                {
                    Patients_DataGridView.DataSource = Database.GetSearchPatient("L", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                }
                else if (string.IsNullOrWhiteSpace(SearchLnameTextBox.Text))
                {
                    Patients_DataGridView.DataSource = Database.GetSearchPatient("FM", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                }
                else if (string.IsNullOrWhiteSpace(SearchMnameTextBox.Text))
                {
                    Patients_DataGridView.DataSource = Database.GetSearchPatient("FL", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                }
                else if (string.IsNullOrWhiteSpace(SearchFnameTextBox.Text))
                {
                    Patients_DataGridView.DataSource = Database.GetSearchPatient("ML", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                }
                else
                {
                    Patients_DataGridView.DataSource = Database.GetSearchPatient("FML", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
