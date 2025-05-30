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
                                Database.CurrentAppointment = Database.RetrieveAppointment(Convert.ToInt64(row.Cells["AppointmentID"].Value.ToString()));
                        }
                        catch (Exception ex)
                        {

                        }
                        ServicesPerformed_DataGridView.DataSource = Database.GetServices(Database.CurrentAppointment.AppointmentId);
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

        private void PastAppointmentRecords_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ServicesPerformed_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = ServicesPerformed_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell != null)
                {
                    DataGridViewRow row = ServicesPerformed_DataGridView.Rows[e.RowIndex];
                    try
                    {
                        Database.CurrentService = Database.RetrieveService(Convert.ToInt64(row.Cells["ServiceID"].Value.ToString()));
                    }
                    catch (Exception ex) 
                    {

                    }              
                }
            }
        }
    }
}


