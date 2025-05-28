using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClinicManagementSystem.LoginForm;

namespace ClinicManagementSystem
{
    public partial class UpdateAppoitnment : Form
    {
        public UpdateAppoitnment()
        {
            InitializeComponent();
            AppointmentDateTimePicker.CustomFormat = "yyyy'/'MM'/'dd HH':'mm";
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AppointmentIDTextBox.Text))
            {
                MessageBox.Show("Please select an appointment first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database.UpdateAppointment(Convert.ToInt64(AppointmentIDTextBox.Text),
                                           Convert.ToInt64(DoctorIdTextBox.Text),
                                           AppointmentDateTimePicker.Text,
                                           StatusComboBox.Text.ToUpper());
                this.Close();
            }
        }

        private void SelectAppointmentButton_Click(object sender, EventArgs e)
        {
            ChooseAppointmentForm chooseAppointmentForm = new ChooseAppointmentForm("ALL", "SELECT");
            chooseAppointmentForm.ShowDialog();

            AppointmentIDTextBox.Text = Database.CurrentAppointment.AppointmentId.ToString();
            AppointmentDateTimePicker.Text = Database.CurrentAppointment.DateTime.ToString();
            PatientIdTextBox.Text = Database.CurrentAppointment.PatientId.ToString();
            PatientNameTextBox.Text = Database.CurrentPatient.FirstName.ToString() + " " + Database.CurrentPatient.MiddleName.ToString() + " " + Database.CurrentPatient.LastName.ToString();
            DoctorIdTextBox.Text = Database.CurrentDoctor.DoctorId.ToString();
            DoctorNameTextBox.Text = Database.CurrentDoctor.FirstName.ToString() + " " + Database.CurrentDoctor.MiddleName.ToString() + " " + Database.CurrentDoctor.LastName.ToString();
            ReasonTextBox.Text = Database.CurrentAppointment.Reason.ToString();
            StatusComboBox.Text = Database.CurrentAppointment.Status.ToString();
        }

        private void SelectPatientButton_Click(object sender, EventArgs e)
        {
            ChoosePatientsForm choosePatientsForm = new ChoosePatientsForm();
            choosePatientsForm.ShowDialog();
            PatientIdTextBox.Text = Database.CurrentPatient.ID.ToString();
            PatientNameTextBox.Text = Database.CurrentPatient.FirstName.ToString() + " " +
                                      Database.CurrentPatient.MiddleName.ToString() + " " +
                                      Database.CurrentPatient.LastName.ToString();
        }

        private void SelectDoctorButton_Click(object sender, EventArgs e)
        {
            ChooseDoctorForm chooseDoctorForm = new ChooseDoctorForm();
             chooseDoctorForm.ShowDialog();
            DoctorIdTextBox.Text = Database.CurrentDoctor.DoctorId.ToString();
            DoctorNameTextBox.Text = Database.CurrentDoctor.FirstName.ToString() + " " +
                                     Database.CurrentDoctor.MiddleName.ToString() + " " +
                                     Database.CurrentDoctor.LastName.ToString();
        }
    }
}
