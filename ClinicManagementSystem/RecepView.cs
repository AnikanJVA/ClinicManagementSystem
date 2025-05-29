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
            UpdateDataGrids();
            AccountTypelabel.Text += "\n" + Database.CurrentLoggedReceptionist.FirstName;
        }

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            DashBoard_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Appointments_NavButton.BackColor = Color.FromArgb(1, 34, 79);
            Patients_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Billing_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Doctors_NavButton.BackColor = Color.FromArgb(0, 148, 212);

            Appointments_TabControl.Show();
            Appointments_CreateButton.Show();
            Appointments_UpdateButton.Show();

            Patients_TabControl.Hide();
            Patients_RegisterButton.Hide();
            Patients_UpdateButton.Hide();
            Patients_SearchButton.Hide();

            Billing_DataGridView.Hide();
            Billing_CreateButton.Hide();

            Doctors_TabControl.Hide();
            Doctors_SearchButton.Hide();

            Dashboard_panel.Visible = false;

            UpdateDataGrids();
        }

        private void BillingButton_Click(object sender, EventArgs e)
        {
            DashBoard_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Appointments_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Patients_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Billing_NavButton.BackColor = Color.FromArgb(1, 34, 79);
            Doctors_NavButton.BackColor = Color.FromArgb(0, 148, 212);

            Appointments_TabControl.Hide();
            Appointments_CreateButton.Hide();
            Appointments_UpdateButton.Hide();

            Patients_TabControl.Hide();
            Patients_RegisterButton.Hide();
            Patients_UpdateButton.Hide();
            Patients_SearchButton.Hide();

            Billing_DataGridView.Show();
            Billing_CreateButton.Show();

            Doctors_TabControl.Hide();
            Doctors_SearchButton.Hide();

            Dashboard_panel.Visible = false;

            UpdateDataGrids();
        }

        private void DoctorsButton_Click(object sender, EventArgs e)
        {
            DashBoard_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Appointments_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Patients_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Billing_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Doctors_NavButton.BackColor = Color.FromArgb(1, 34, 79);

            Appointments_TabControl.Hide();
            Appointments_CreateButton.Hide();
            Appointments_UpdateButton.Hide();

            Patients_TabControl.Hide();
            Patients_RegisterButton.Hide();
            Patients_UpdateButton.Hide();
            Patients_SearchButton.Hide();

            Billing_DataGridView.Hide();
            Billing_CreateButton.Hide();

            Doctors_TabControl.Show();
            Doctors_SearchButton.Show();

            Dashboard_panel.Visible = false;

            UpdateDataGrids();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Database.Instance.Connection.Close();
            FormProvider.Login.Show();
            this.Close();
        }

        private void PatientsButton_Click(object sender, EventArgs e)
        {
            DashBoard_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Appointments_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Patients_NavButton.BackColor = Color.FromArgb(1, 34, 79);
            Billing_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Doctors_NavButton.BackColor = Color.FromArgb(0, 148, 212);

            Appointments_TabControl.Hide();
            Appointments_CreateButton.Hide();
            Appointments_UpdateButton.Hide();

            Patients_TabControl.Show();
            Patients_RegisterButton.Show();
            Patients_UpdateButton.Show();
            Patients_SearchButton.Show();

            Billing_DataGridView.Hide();
            Billing_CreateButton.Hide();

            Doctors_TabControl.Hide();
            Doctors_SearchButton.Hide();

            Dashboard_panel.Visible = false;

            UpdateDataGrids();
        }

        private void createBillButton_Click(object sender, EventArgs e)
        {
            CreateBillForm createBillForm = new CreateBillForm();
            createBillForm.ShowDialog();
            UpdateDataGrids();
        }

        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
            CreateAppointmentForm createAppointmentForm = new CreateAppointmentForm();
            createAppointmentForm.ShowDialog();
            UpdateDataGrids();
        }

        private void RecepView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database.Instance.Connection.Close();
            FormProvider.Login.Show();
        }

        private void RegisterPatientButton_Click(object sender, EventArgs e)
        {
            RegisterPatientForm registerPatientForm = new RegisterPatientForm();
            registerPatientForm.ShowDialog();
            UpdateDataGrids();
        }

        private void Patients_SearchButton_Click(object sender, EventArgs e)
        {
            ChoosePatientsForm choosePatientsForm = new ChoosePatientsForm("Search");
            choosePatientsForm.ShowDialog();
        }

        private void Patients_UpdateButton_Click(object sender, EventArgs e)
        {
            UpdatePatientForm updatePatientForm = new UpdatePatientForm();
            updatePatientForm.ShowDialog();
            UpdateDataGrids();
        }

        private void Doctors_SearchButton_Click(object sender, EventArgs e)
        {
            ChooseDoctorForm chooseDoctorForm = new ChooseDoctorForm("Search");
            chooseDoctorForm.ShowDialog();
        }

        private void Apointments_UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateAppoitnment updateAppoitnment = new UpdateAppoitnment();
            updateAppoitnment.ShowDialog();
            UpdateDataGrids();
        }

        public void UpdateDataGrids()
        { 
            Appointments_AllDataGridView.DataSource = Database.GetAppointments("ALL");
            Appointments_ApprovedDataGridView.DataSource = Database.GetAppointments("APPROVED");
            Appointments_RescheduledDataGridView.DataSource = Database.GetAppointments("RESCHEDULED");
            Appointments_CanceledDataGridView.DataSource = Database.GetAppointments("CANCELED");
            Appointments_FinishedDataGridView.DataSource = Database.GetAppointments("FINISHED");

            Patients_AllDataGridView.DataSource = Database.GetPatients("ALL");
            Patients_ActiveDataGridView.DataSource = Database.GetPatients("ACTIVE");
            Patients_InactiveDataGridView.DataSource = Database.GetPatients("INACTIVE");

            Doctors_AllDataGridView.DataSource = Database.GetDoctors("ALL");
            Doctors_AvailableDataGridView.DataSource = Database.GetDoctors("AVAILABLE");
            Doctors_UnavailableDataGridView.DataSource = Database.GetDoctors("UNAVAILABLE");
            Doctors_InactiveDataGridView.DataSource = Database.GetDoctors("INACTIVE");

            Billing_DataGridView.DataSource = Database.GetBills();
        }

        private void DashBoard_NavButton_Click(object sender, EventArgs e)
        {
            DashBoard_NavButton.BackColor = Color.FromArgb(1, 34, 79);
            Appointments_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Patients_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Billing_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Doctors_NavButton.BackColor = Color.FromArgb(0, 148, 212);

            Appointments_TabControl.Hide();
            Appointments_CreateButton.Hide();
            Appointments_UpdateButton.Hide();

            Patients_TabControl.Hide();
            Patients_RegisterButton.Hide();
            Patients_UpdateButton.Hide();
            Patients_SearchButton.Hide();

            Billing_DataGridView.Hide();
            Billing_CreateButton.Hide();

            Doctors_TabControl.Hide();
            Doctors_SearchButton.Hide();

            Dashboard_panel.Visible = true;
        }
    }
}
