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
    public partial class PatientRecordsForm : Form
    {
        private long patientID;
        public PatientRecordsForm()
        {
            InitializeComponent();
            PatientIDTextBox.Text = Database.CurrentPatient.ID.ToString();
            PatientNameTextBox.Text = Database.CurrentPatient.FirstName.ToString() + " " +
                                      Database.CurrentPatient.MiddleName.ToString() + " " +
                                      Database.CurrentPatient.LastName.ToString();
            DoBTextBox.Text = Database.CurrentPatient.DoB.ToString();
            SexTextBox.Text = Database.CurrentPatient.Sex.ToString();
            Patients_DataGridView.DataSource = Database.GetPatientRecords(Database.CurrentPatient.ID);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Patients_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Patients_DataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
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
                        string patientName = row.Cells["PatientName"].Value.ToString();
                        string DoB = row.Cells["DoB"].Value.ToString();
                        string sex = row.Cells["Sex"].Value.ToString();

                        PatientIDTextBox.Text = Convert.ToString(patientID);
                        PatientNameTextBox.Text = patientName;
                        DoBTextBox.Text = DoB;
                        SexTextBox.Text = sex;
                    }
                    else
                    {
                        PatientIDTextBox.Clear();
                        PatientNameTextBox.Clear();
                        DoBTextBox.Clear();
                        SexTextBox.Clear();
                    }
                }
            }
        }

        private void PatientIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
