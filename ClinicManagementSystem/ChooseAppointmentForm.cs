using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static ClinicManagementSystem.LoginForm;

namespace ClinicManagementSystem
{
    public partial class ChooseAppointmentForm : Form
    {
        private long appointmentID;
        public ChooseAppointmentForm()
        {
            InitializeComponent();
            Appointments_DataGridView.DataSource = Database.GetAppointments("ACTIVE");
            CloseButton.Visible = false;
            SelectButton.Visible = true;
            CancelButton.Visible = true;
        }

        public ChooseAppointmentForm(string formType)
        {
            InitializeComponent();
            if (formType.ToUpper().Equals("SEARCH"))
            {
                Appointments_DataGridView.DataSource = Database.GetAppointments("ALL");
                CloseButton.Visible = true;
                SelectButton.Visible = false;
                CancelButton.Visible = false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectButton_Click(Object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AppointmentIDTextBox.Text))
            {
                MessageBox.Show("Please select a appointment first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database.CurrentAppointment = Database.RetrieveAppointment(Convert.ToInt64(AppointmentIDTextBox.Text));
                this.Close();
            }
        }

        private void Appointments_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = Appointments_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = Appointments_DataGridView.Rows[e.RowIndex];
                        try
                        {
                            appointmentID = Convert.ToInt64(row.Cells["AppointmentID"].Value.ToString());
                        }
                        catch (Exception ex)
                        {

                        }
                        string appointmentDate = row.Cells["AppointmentDate"].Value.ToString();
                        string patientID = row.Cells["PatientID"].Value.ToString();
                        string patientName = row.Cells["PatientName"].Value.ToString();
                        string doctorID = row.Cells["DoctorID"].Value.ToString();
                        string doctorName = row.Cells["DoctorName"].Value.ToString();
                        string service = row.Cells["Service"].Value.ToString();
                        string status = row.Cells["Status"].Value.ToString();

                        AppointmentIDTextBox.Text = Convert.ToString(appointmentID);
                        AppointmentDateTextBox.Text = appointmentDate;
                        PatientIDTextBox.Text = patientID;
                        PatientNameTextBox.Text = patientName;
                        DoctorIDTextBox.Text = doctorID;
                        DoctorNameTextBox.Text = doctorName;
                        ServiceTextBox.Text = service;
                        StatusTextBox.Text = status;
                    }
                    else
                    {
                        AppointmentIDTextBox.Clear();
                        AppointmentDateTextBox.Clear();
                        PatientIDTextBox.Clear();
                        PatientNameTextBox.Clear();
                        DoctorIDTextBox.Clear();
                        DoctorNameTextBox.Clear();
                        ServiceTextBox.Clear();
                        StatusTextBox.Clear();
                    }
                }
            }

        }
    }
}
