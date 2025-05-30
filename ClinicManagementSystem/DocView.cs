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
    public partial class DocView : Form
    {
        public DocView()
        {
            InitializeComponent();
            AccountTypelabel.Text += "\n" + Database.CurrentLoggedDoctor.LastName;
        }

        private void DocView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database.Instance.Connection.Close();
            FormProvider.Login.Show();
            UpdateDataGrids();
        }

        private void DashBoard_NavButton_Click(object sender, EventArgs e)
        {
            DashBoard_NavButton.BackColor = Color.FromArgb(1, 34, 79);
            Appointments_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Patients_NavButton.BackColor = Color.FromArgb(0, 148, 212);

            Dashboard_panel.Visible = true;

            Appointments_TabControl.Visible = false;
            Appointments_SearchButton.Visible = false;

            Patients_DataGridView.Visible = false;
            Patients_SearchButton.Visible = false;
            UpdateDataGrids();
        }

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            DashBoard_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Appointments_NavButton.BackColor = Color.FromArgb(1, 34, 79);
            Patients_NavButton.BackColor = Color.FromArgb(0, 148, 212);

            Dashboard_panel.Visible = false;

            Appointments_TabControl.Visible = true;
            Appointments_SearchButton.Visible = true;

            Patients_DataGridView.Visible = false;
            Patients_SearchButton.Visible = false;
            UpdateDataGrids();
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            DashBoard_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Appointments_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Patients_NavButton.BackColor = Color.FromArgb(1, 34, 79);

            Dashboard_panel.Visible = false;

            Appointments_TabControl.Visible = false;
            Appointments_SearchButton.Visible = false;

            Patients_DataGridView.Visible = true;
            Patients_SearchButton.Visible = true;
            UpdateDataGrids();

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Database.Instance.Connection.Close();
            FormProvider.Login.Show();
            this.Close();
        }

        private void Patients_SearchButton_Click(object sender, EventArgs e)
        {
            ChoosePatientsForm choosePatientsForm = new ChoosePatientsForm("RECORDS");
            choosePatientsForm.ShowDialog();
        }

        private void Appointment_SearchButton_Click(object sender, EventArgs e)
        {
            ChooseAppointmentForm chooseAppointmentForm = new ChooseAppointmentForm("APPROVED", "SEARCH");
            chooseAppointmentForm.ShowDialog();
        }

        public void UpdateDataGrids()
        {
            Appointments_AllDataGridView.DataSource = Database.GetAppointments("ALL", Database.CurrentLoggedDoctor.DoctorId);
            Appointments_FinishedDataGridView.DataSource = Database.GetAppointments("FINISHED", Database.CurrentLoggedDoctor.DoctorId);

            Patients_DataGridView.DataSource = Database.GetPatients("ACTIVE", Database.CurrentLoggedDoctor.DoctorId);
        }
    }
}
