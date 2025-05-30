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
            AppointmentDateTimePicker.ValueChanged += new EventHandler(AppointmentDateTimePicker_ValueChanged);

            AppointmentDateTimePicker.Format = DateTimePickerFormat.Custom;
            AppointmentDateTimePicker.CustomFormat = "yyyy'/'MM'/'dd HH':'mm"; 
            AppointmentDateTimePicker.MinDate = DateTime.Today; 

            DateTime now = DateTime.Now;
            if (now.Hour < 9)
            {
                AppointmentDateTimePicker.Value = new DateTime(now.Year, now.Month, now.Day, 9, 0, 0);
            }
            else if (now.Hour >= 17) 
            {
                AppointmentDateTimePicker.Value = new DateTime(now.Year, now.Month, now.Day, 17, 0, 0);
            }
            else
            {
                AppointmentDateTimePicker.Value = now;
            }
        }

        private void AppointmentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDateTime = AppointmentDateTimePicker.Value;

            DateTime minTime = new DateTime(selectedDateTime.Year, selectedDateTime.Month, selectedDateTime.Day, 9, 0, 0);   // 9:00 AM
            DateTime maxTime = new DateTime(selectedDateTime.Year, selectedDateTime.Month, selectedDateTime.Day, 17, 0, 0);  // 5:00 PM

            if (selectedDateTime < minTime)
            {
                AppointmentDateTimePicker.Value = minTime;
            }
            else if (selectedDateTime > maxTime)
            {
                AppointmentDateTimePicker.Value = maxTime;
            }
            
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
            DoctorIdTextBox.Text = Database.CurrentDoctor.DoctorId.ToString();
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
                if(Database.AddAppointment(Convert.ToInt64(PatientIdTextBox.Text),
                                           Convert.ToInt64(DoctorIdTextBox.Text),
                                           AppointmentDateTimePicker.Text,
                                           ReasonTextBox.Text))
                {
                    MessageBox.Show("Appointment created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error!\nAppointment date and time not available.\nAppointment not created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
