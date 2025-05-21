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
    public partial class RecepView : Form
    {
        public RecepView()
        {
            InitializeComponent();
        }

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            AppointmentsButton.BackColor = Color.FromArgb(1, 34, 79);
            PatientsButton.BackColor = Color.FromArgb(0, 148, 212);
            BillingButton.BackColor = Color.FromArgb(0, 148, 212);
            DoctorsButton.BackColor = Color.FromArgb(0, 148, 212);

            AppointmentTabControl.Show();
            createAppointmentButton.Show();
            updateApointmentButton.Show();

            PatientsTabControl.Hide();
            RegisterPatientButton.Hide();
            UpdatePatientButton.Hide();
            SearchPatientButton.Hide();

            billingDataGridView.Hide();
            createBillButton.Hide();

            DoctorTabControl.Hide();
            RegisterDoctorButton.Hide();
            UpdateDoctorButton.Hide();
        }

        private void BillingButton_Click(object sender, EventArgs e)
        {
            AppointmentsButton.BackColor = Color.FromArgb(0, 148, 212);
            PatientsButton.BackColor = Color.FromArgb(0, 148, 212);
            BillingButton.BackColor = Color.FromArgb(1, 34, 79);
            DoctorsButton.BackColor = Color.FromArgb(0, 148, 212);

            AppointmentTabControl.Hide();
            createAppointmentButton.Hide();
            updateApointmentButton.Hide();

            PatientsTabControl.Hide();
            RegisterPatientButton.Hide();
            UpdatePatientButton.Hide();
            SearchPatientButton.Hide();

            billingDataGridView.Show();
            createBillButton.Show();

            DoctorTabControl.Hide();
            RegisterDoctorButton.Hide();
            UpdateDoctorButton.Hide();
        }

        private void DoctorsButton_Click(object sender, EventArgs e)
        {
            AppointmentsButton.BackColor = Color.FromArgb(0, 148, 212);
            PatientsButton.BackColor = Color.FromArgb(0, 148, 212);
            BillingButton.BackColor = Color.FromArgb(0, 148, 212);
            DoctorsButton.BackColor = Color.FromArgb(1, 34, 79);

            AppointmentTabControl.Hide();
            createAppointmentButton.Hide();
            updateApointmentButton.Hide();

            PatientsTabControl.Hide();
            RegisterPatientButton.Hide();
            UpdatePatientButton.Hide();
            SearchPatientButton.Hide();

            billingDataGridView.Hide();
            createBillButton.Hide();

            DoctorTabControl.Show();
            RegisterDoctorButton.Show();
            UpdateDoctorButton.Show();
        } 
        
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Database.Instance.Connection.Close();
            FormProvider.Login.Show();
            this.Close();
        }

        private void PatientsButton_Click(object sender, EventArgs e)
        {
            AppointmentsButton.BackColor = Color.FromArgb(0, 148, 212);
            PatientsButton.BackColor = Color.FromArgb(1, 34, 79);
            BillingButton.BackColor = Color.FromArgb(0, 148, 212);
            DoctorsButton.BackColor = Color.FromArgb(0, 148, 212);

            AppointmentTabControl.Hide();
            createAppointmentButton.Hide();
            updateApointmentButton.Hide();

            PatientsTabControl.Show();
            RegisterPatientButton.Show();
            UpdatePatientButton.Show();
            SearchPatientButton.Show();

            billingDataGridView.Hide();
            createBillButton.Hide();

            DoctorTabControl.Hide();
            RegisterDoctorButton.Hide();
            UpdateDoctorButton.Hide();
        }

        private void RegisterDoctorButton_Click(object sender, EventArgs e)
        {
            RegisterDoctorForm doctorDetailsForm = new RegisterDoctorForm();
            doctorDetailsForm.ShowDialog();
        }

        private void createBillButton_Click(object sender, EventArgs e)
        {
            CreateBillForm createBillForm = new CreateBillForm();
            createBillForm.ShowDialog();
        }

        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
            CreateAppointmentForm createAppointmentForm = new CreateAppointmentForm();
            createAppointmentForm.ShowDialog();
            //ChoosePatientsForm choosePatientsForm = new ChoosePatientsForm();
            //choosePatientsForm.ShowDialog();
        }

        private void RecepView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database.Instance.Connection.Close();
            FormProvider.Login.Show();
        }

        private void RegisterPatientButton_Click(object sender, EventArgs e)
        {

        }
    }
}
