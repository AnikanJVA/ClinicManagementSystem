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
        //public ChooseAppointmentForm()
        //{
        //    InitializeComponent();
        //    Appointments_DataGridView.DataSource = Database.GetAppointments("ALL");
        //    CloseButton.Visible = false;
        //    SelectButton.Visible = true;
        //    CancelButton.Visible = true;
        //}

        public ChooseAppointmentForm(string status, string formType)
        {
            InitializeComponent();
            if (formType.ToUpper().Equals("SEARCH"))
            {
                Appointments_DataGridView.DataSource = Database.GetAppointments("ALL");
                CloseButton.Visible = true;
                SelectButton.Visible = false;
                CancelButton.Visible = false;
            }
            else
            {
                Appointments_DataGridView.DataSource = Database.GetAppointments("ALL");
                CloseButton.Visible = false;
                SelectButton.Visible = true;
                CancelButton.Visible = true;
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
                Database.CurrentPatient = Database.RetrievePatient(Database.CurrentAppointment.PatientId);
                Database.CurrentDoctor = Database.RetrieveDoctor(Database.CurrentAppointment.DoctorId, "DOCTORID");
                this.Close();
            }
        }

        private void Appointments_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = Appointments_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
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
                        string patientName = row.Cells["Patient"].Value.ToString();
                        string doctorName = row.Cells["Doctor"].Value.ToString();

                        Database.CurrentAppointment = Database.RetrieveAppointment(appointmentID);
                        AppointmentIDTextBox.Text = appointmentID.ToString();
                        AppointmentDateTextBox.Text = Database.CurrentAppointment.DateTime;
                        PatientIDTextBox.Text = Database.CurrentAppointment.PatientId.ToString();
                        PatientNameTextBox.Text = patientName;
                        DoctorIDTextBox.Text = Database.CurrentAppointment.DoctorId.ToString();
                        DoctorNameTextBox.Text = doctorName;
                        ReasonTextBox.Text = Database.CurrentAppointment.Reason;
                        StatusTextBox.Text = Database.CurrentAppointment.Status;
                    }
                    else
                    {
                        AppointmentIDTextBox.Clear();
                        AppointmentDateTextBox.Clear();
                        PatientIDTextBox.Clear();
                        PatientNameTextBox.Clear();
                        DoctorIDTextBox.Clear();
                        DoctorNameTextBox.Clear();
                        ReasonTextBox.Clear();
                        StatusTextBox.Clear();
                    }
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
