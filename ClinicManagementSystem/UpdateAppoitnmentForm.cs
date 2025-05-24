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
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void SelectAppointmentButton_Click(object sender, EventArgs e)
        {
            
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
    }
}
