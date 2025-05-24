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
    public partial class ChooseDoctorForm : Form
    {
        private long doctorID;
        
        public ChooseDoctorForm()
        {
            InitializeComponent();
            Doctors_DataGridView.DataSource = Database.GetDoctors("ACTIVE");
        }

        public ChooseDoctorForm(string status)
        {
            InitializeComponent();
            Doctors_DataGridView.DataSource = Database.GetDoctors("ALL");
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
                Database.CurrentDoctor = Database.RetrieveDoctor(Convert.ToInt64(DoctorIDTextBox.Text));
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
                        string contactNumber = row.Cells["ContactNumber"].Value.ToString();
                        string licenseNumber = row.Cells["LicenseNumber"].Value.ToString();

                        DoctorIDTextBox.Text = Convert.ToString(doctorID);
                        FirstNameTextBox.Text = fname;
                        MiddleNameTextBox.Text = mname;
                        LastNameTextBox.Text = lname;
                        ContactNumberTextBox.Text = contactNumber;
                        LicenseNumberTextBox.Text = licenseNumber;
                    }
                    else
                    {
                        DoctorIDTextBox.Clear();
                        FirstNameTextBox.Clear();
                        MiddleNameTextBox.Clear();
                        LastNameTextBox.Clear();
                        ContactNumberTextBox.Clear();
                        LicenseNumberTextBox.Clear();
                    }
                }

            }
        }
    }
}
