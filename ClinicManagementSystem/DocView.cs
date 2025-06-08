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
            greetingsLabel.Text += " " + Database.CurrentLoggedDoctor.LastName;
            TotalAppointmentsLabel.Text = Database.GetTotalAppointmentsByDoctor(Database.CurrentLoggedDoctor.DoctorId).ToString();
            TotalPatientsLabel.Text = Database.GetTotalPatientsByDoctor(Database.CurrentLoggedDoctor.DoctorId).ToString();
            NextAppointment_DateTimeLabel.Text = Database.GetNextAppointmentDateByDoctor(Database.CurrentLoggedDoctor.DoctorId).ToString();
            NextAppointment_PatientNameLabel.Text = Database.GetNextPatientNameByDoctor(Database.CurrentLoggedDoctor.DoctorId);

            UpdateDataGrids();
            FormatDataGridViews();
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
            Services_NavButton.BackColor = Color.FromArgb(0, 148, 212);

            Dashboard_panel.Visible = true;

            Appointments_TabControl.Visible = false;
            Appointments_SearchButton.Visible = false;

            Patients_DataGridView.Visible = false;
            Patients_SearchButton.Visible = false;

            Services_DataGridView.Visible = false;
            Services_EditButton.Visible = false;

            UpdateDataGrids();
        }

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            DashBoard_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Appointments_NavButton.BackColor = Color.FromArgb(1, 34, 79);
            Patients_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Services_NavButton.BackColor = Color.FromArgb(0, 148, 212);

            Dashboard_panel.Visible = false;

            Appointments_TabControl.Visible = true;
            Appointments_SearchButton.Visible = true;

            Patients_DataGridView.Visible = false;
            Patients_SearchButton.Visible = false;

            Services_DataGridView.Visible = false;
            Services_EditButton.Visible = false;

            UpdateDataGrids();
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            DashBoard_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Appointments_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Patients_NavButton.BackColor = Color.FromArgb(1, 34, 79);
            Services_NavButton.BackColor = Color.FromArgb(0, 148, 212);

            Dashboard_panel.Visible = false;

            Appointments_TabControl.Visible = false;
            Appointments_SearchButton.Visible = false;

            Patients_DataGridView.Visible = true;
            Patients_SearchButton.Visible = true;

            Services_DataGridView.Visible = false;
            Services_EditButton.Visible = false;

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

        private void ServicesButton_Click(object sender, EventArgs e)
        {
            DashBoard_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Appointments_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Patients_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Services_NavButton.BackColor = Color.FromArgb(1, 34, 79);

            Dashboard_panel.Visible = false;

            Appointments_TabControl.Visible = false;
            Appointments_SearchButton.Visible = false;

            Patients_DataGridView.Visible = false;
            Patients_SearchButton.Visible = false;

            Services_DataGridView.Visible = true;
            Services_EditButton.Visible = true;

            UpdateDataGrids();
        }

        public void UpdateDataGrids()
        {
            Appointments_AllDataGridView.DataSource = Database.GetAppointments("ALL", Database.CurrentLoggedDoctor.DoctorId);
            Appointments_UpcomingDataGridView.DataSource = Database.GetAppointments("UPCOMING", Database.CurrentLoggedDoctor.DoctorId);
            Appointments_FinishedDataGridView.DataSource = Database.GetAppointments("FINISHED", Database.CurrentLoggedDoctor.DoctorId);

            Patients_DataGridView.DataSource = Database.GetPatients("ACTIVE", Database.CurrentLoggedDoctor.DoctorId);

            Services_DataGridView.DataSource = Database.GetServices();
        }

        private void Services_EditButton_Click(object sender, EventArgs e)
        {
            ChooseServiceForm chooseServiceForm = new ChooseServiceForm("DOCTOR");
            chooseServiceForm.ShowDialog();
            UpdateDataGrids();
        }

        public void FormatDataGridViews()
        {
            Appointments_AllDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Appointments_AllDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Appointments_AllDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Appointments_AllDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            Appointments_UpcomingDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Appointments_UpcomingDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Appointments_UpcomingDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Appointments_UpcomingDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            Appointments_FinishedDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Appointments_FinishedDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Appointments_FinishedDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Appointments_FinishedDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            Patients_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Patients_DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Patients_DataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Patients_DataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            Services_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Services_DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Services_DataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Services_DataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
        }
    }
}
