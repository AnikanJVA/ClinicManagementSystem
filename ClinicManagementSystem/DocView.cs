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
        private string patientName = "";
        private string doctorName = ""; 
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
            Appointments_DetailsPanel.Visible = false;

            Patients_DataGridView.Visible = false;
            Patients_ViewRecordsButton.Visible = false;
            Patients_DetailsPanel.Visible = false;

            Services_DataGridView.Visible = false;
            Services_UpdateButton.Visible = false;
            Services_AddButton.Visible = false;
            Services_DeleteButton.Visible = false;
            Services_ServiceDetailsPanel.Visible = false;
        }

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            DashBoard_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Appointments_NavButton.BackColor = Color.FromArgb(1, 34, 79);
            Patients_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Services_NavButton.BackColor = Color.FromArgb(0, 148, 212);

            Dashboard_panel.Visible = false;

            Appointments_TabControl.Visible = true;
            Appointments_DetailsPanel.Visible = true;

            Patients_DataGridView.Visible = false;
            Patients_ViewRecordsButton.Visible = false;
            Patients_DetailsPanel.Visible = false;

            Services_DataGridView.Visible = false;
            Services_UpdateButton.Visible = false;
            Services_AddButton.Visible = false;
            Services_DeleteButton.Visible = false;
            Services_ServiceDetailsPanel.Visible = false;
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            DashBoard_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Appointments_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Patients_NavButton.BackColor = Color.FromArgb(1, 34, 79);
            Services_NavButton.BackColor = Color.FromArgb(0, 148, 212);

            Dashboard_panel.Visible = false;

            Appointments_TabControl.Visible = false;
            Appointments_DetailsPanel.Visible = false;

            Patients_DataGridView.Visible = true;
            Patients_ViewRecordsButton.Visible = true;
            Patients_DetailsPanel.Visible = true;

            Services_DataGridView.Visible = false;
            Services_UpdateButton.Visible = false;
            Services_AddButton.Visible = false;
            Services_DeleteButton.Visible = false;
            Services_ServiceDetailsPanel.Visible = false;
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
            UpdateDataGrids();
        }

        private void ServicesButton_Click(object sender, EventArgs e)
        {
            DashBoard_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Appointments_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Patients_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Services_NavButton.BackColor = Color.FromArgb(1, 34, 79);

            Dashboard_panel.Visible = false;

            Appointments_TabControl.Visible = false;
            Appointments_DetailsPanel.Visible = false;

            Patients_DataGridView.Visible = false;
            Patients_ViewRecordsButton.Visible = false;
            Patients_DetailsPanel.Visible = false;

            Services_DataGridView.Visible = true;
            Services_UpdateButton.Visible = true;
            Services_AddButton.Visible = true;
            Services_DeleteButton.Visible = true;
            Services_ServiceDetailsPanel.Visible = true;

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
       
        private void Services_AddButton_Click(object sender, EventArgs e)
        {
            AddNewServiceForm addNewServiceForm = new AddNewServiceForm();
            addNewServiceForm.ShowDialog();
            UpdateDataGrids();
        }

        private void Services_UpdateButton_Click(object sender, EventArgs e)
        {
            if (Database.CurrentService.ServiceID == 0 || Database.CurrentService == null)
            {
                MessageBox.Show("Select a service first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                AddNewServiceForm addNewServiceForm = new AddNewServiceForm("UPDATE");
                addNewServiceForm.ShowDialog();
                UpdateDataGrids();
            }
        }

        private void Services_DeleteButton_Click(object sender, EventArgs e)
        {
            if (Database.CurrentService.ServiceID == 0 || Database.CurrentService == null)
            {
                MessageBox.Show("Select a service first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var choice = MessageBox.Show("Are you sure you want to delete service: " + Database.CurrentService.ServiceName + " ?", "Delete Service?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choice == DialogResult.Yes)
                {
                    UpdateDataGrids();
                }
            }
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

        private void Services_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long serviceID = -1;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = Services_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = Services_DataGridView.Rows[e.RowIndex];
                        try
                        {
                            serviceID = Convert.ToInt64(row.Cells["ServiceID"].Value.ToString());
                            Database.CurrentService = Database.RetrieveService(serviceID);
                        }
                        catch (Exception ex)
                        {

                        }

                        Services_ServiceIDTextBox.Text = serviceID.ToString();
                        Services_ServiceNameTextBox.Text = Database.CurrentService.ServiceName;
                        Services_ServiceDescriptionTextBox.Text = Database.CurrentService.ServiceDesc;
                        Services_ServiceTypeTextBox.Text = Database.CurrentService.ServiceType;
                        Services_PriceTextBox.Text = Database.CurrentService.Price.ToString();
                    }
                }
            }
        }

        private void Appointments_AllDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long appointmentID = 0;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = Appointments_AllDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = Appointments_AllDataGridView.Rows[e.RowIndex];
                        try
                        {
                            appointmentID = Convert.ToInt64(row.Cells["AppointmentID"].Value.ToString());
                            Database.CurrentAppointment = Database.RetrieveAppointment(appointmentID);
                            Database.CurrentPatient = Database.RetrievePatient(Database.CurrentAppointment.PatientId);
                            Database.CurrentDoctor = Database.RetrieveDoctor(Database.CurrentAppointment.DoctorId, "DOCTORID");
                        }
                        catch (Exception ex)
                        {

                        }
                        patientName = row.Cells["Patient"].Value.ToString();
                        doctorName = row.Cells["Doctor"].Value.ToString();

                        Appointments_AutoFill();
                    }
                    else
                    {
                        Appointments_ClearAutoFill();
                    }
                }
            }
        }

        private void Appointments_UpcomingDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long appointmentID = 0;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = Appointments_UpcomingDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = Appointments_UpcomingDataGridView.Rows[e.RowIndex];
                        try
                        {
                            appointmentID = Convert.ToInt64(row.Cells["AppointmentID"].Value.ToString());
                            Database.CurrentAppointment = Database.RetrieveAppointment(appointmentID);
                            Database.CurrentPatient = Database.RetrievePatient(Database.CurrentAppointment.PatientId);
                            Database.CurrentDoctor = Database.RetrieveDoctor(Database.CurrentAppointment.DoctorId, "DOCTORID");
                        }
                        catch (Exception ex)
                        {

                        }
                        patientName = row.Cells["Patient"].Value.ToString();
                        doctorName = row.Cells["Doctor"].Value.ToString();

                        Appointments_AutoFill();
                    }
                    else
                    {
                        Appointments_ClearAutoFill();
                    }
                }
            }
        }

        private void Appointments_FinishedDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long appointmentID = 0;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = Appointments_FinishedDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = Appointments_FinishedDataGridView.Rows[e.RowIndex];
                        try
                        {
                            appointmentID = Convert.ToInt64(row.Cells["AppointmentID"].Value.ToString());
                            Database.CurrentAppointment = Database.RetrieveAppointment(appointmentID);
                            Database.CurrentPatient = Database.RetrievePatient(Database.CurrentAppointment.PatientId);
                            Database.CurrentDoctor = Database.RetrieveDoctor(Database.CurrentAppointment.DoctorId, "DOCTORID");
                        }
                        catch (Exception ex)
                        {

                        }
                        patientName = row.Cells["Patient"].Value.ToString();
                        doctorName = row.Cells["Doctor"].Value.ToString();

                        Appointments_AutoFill();
                    }
                    else
                    {
                        Appointments_ClearAutoFill();
                    }
                }
            }
        }

        public void Appointments_AutoFill()
        {
            Appointments_AppointmentIDTextBox.Text = Database.CurrentAppointment.AppointmentId.ToString();
            Appointments_AppointmentDateTextBox.Text = Database.CurrentAppointment.DateTime;
            Appointments_PatientIDTextBox.Text = Database.CurrentAppointment.PatientId.ToString();
            Appointments_PatientNameTextBox.Text = patientName;
            Appointments_DoctorIDTextBox.Text = Database.CurrentAppointment.DoctorId.ToString();
            Appointments_DoctorNameTextBox.Text = doctorName;
            Appointments_ReasonTextBox.Text = Database.CurrentAppointment.Reason;
            Appointments_StatusTextBox.Text = Database.CurrentAppointment.Status;
        }

        public void Appointments_ClearAutoFill()
        {
            Appointments_AppointmentIDTextBox.Clear();
            Appointments_AppointmentDateTextBox.Clear();
            Appointments_PatientIDTextBox.Clear();
            Appointments_PatientNameTextBox.Clear();
            Appointments_DoctorIDTextBox.Clear();
            Appointments_DoctorNameTextBox.Clear();
            Appointments_ReasonTextBox.Clear();
            Appointments_StatusTextBox.Clear();
        }
        private void Patients_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long patientID = 0;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = Patients_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = Patients_DataGridView.Rows[e.RowIndex];
                        try
                        {
                            patientID = Convert.ToInt64(row.Cells["PatientID"].Value.ToString());
                            Database.CurrentPatient = Database.RetrievePatient(patientID);
                        }
                        catch (Exception ex)
                        {

                        }
                        Patients_AutoFill();
                    }
                    else
                    {
                        Patients_ClearAutoFill();
                    }
                }
            }
        }

        public void Patients_AutoFill()
        {
            Patients_PatientIDTextBox.Text = Database.CurrentPatient.ID.ToString();
            Patients_FirstNameTextBox.Text = Database.CurrentPatient.FirstName;
            Patients_MiddleNameTextBox.Text = Database.CurrentPatient.MiddleName;
            Patients_LastNameTextBox.Text = Database.CurrentPatient.LastName;
            Patients_DoBTextBox.Text = Database.CurrentPatient.DoB;
            Patients_SexTextBox.Text = Database.CurrentPatient.Sex;
            Patients_ContactNumberTextBox.Text = Database.CurrentPatient.ContactNumber;
            Patients_AltContactNumberTextBox.Text = Database.CurrentPatient.AltContactNumber;
            Patients_EmailAddressTextBox.Text = Database.CurrentPatient.EmailAddress;
            Patients_AddressTextBox.Text = Database.CurrentPatient.Address;
            Patients_StatusTextBox.Text = Database.CurrentPatient.Status;
        }

        public void Patients_ClearAutoFill()
        {
            Patients_PatientIDTextBox.Clear();
            Patients_FirstNameTextBox.Clear();
            Patients_MiddleNameTextBox.Clear();
            Patients_LastNameTextBox.Clear();
            Patients_DoBTextBox.Clear();
            Patients_SexTextBox.Clear();
            Patients_ContactNumberTextBox.Clear();
            Patients_AltContactNumberTextBox.Clear();
            Patients_EmailAddressTextBox.Clear();
            Patients_AddressTextBox.Clear();
            Patients_StatusTextBox.Clear();
        }


        private void Patients_ViewRecordsButton_Click(object sender, EventArgs e)
        {
            if (Database.CurrentPatient.ID == 0 || Database.CurrentPatient == null)
            {
                MessageBox.Show("Select a patient first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                PatientRecordsForm patientRecordsForm = new PatientRecordsForm();
                patientRecordsForm.ShowDialog();
            }
        }
    }
}
