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
    public partial class CreateAppointmentForm : Form
    {
        public CreateAppointmentForm()
        {
            InitializeComponent();
            AppointmentDateTimePicker.Format = DateTimePickerFormat.Custom;
            AppointmentDateTimePicker.CustomFormat = "yyyy'/'MM'/'dd HH':'mm";
            AppointmentDateTimePicker.MinDate = DateTime.Today;
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            DoctorIdTextBox.Text = Database.CurrentDoctor.ID.ToString();
            DoctorNameTextBox.Text = Database.CurrentDoctor.FirstName.ToString() + " " +
                                     Database.CurrentDoctor.MiddleName.ToString() + " " +
                                     Database.CurrentDoctor.LastName.ToString();
        }

        private void CreateAppoitnmentButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PatientIdTextBox.Text) ||
                string.IsNullOrWhiteSpace(DoctorIdTextBox.Text) ||
                string.IsNullOrWhiteSpace(ReasonTextBox.Text))
            {
                MessageBox.Show("Don't leave anything empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // check if date or doctor is available 
                // database update method 
            }
        }
    }
}
