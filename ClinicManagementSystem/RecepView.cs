﻿using System;
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
        }

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            Appointments_NavButton.BackColor = Color.FromArgb(1, 34, 79);
            Patients_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Billing_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Doctors_NavButton.BackColor = Color.FromArgb(0, 148, 212);

            Appointments_TabControl.Show();
            Appointments_CreateButton.Show();
            Apointments_UpdateButton.Show();

            Patients_TabControl.Hide();
            Patients_RegisterButton.Hide();
            Patients_UpdateButton.Hide();
            Patients_SearchButton.Hide();

            Billing_DataGridView.Hide();
            Billing_CreateButton.Hide();

            Doctor_TabControl.Hide();
            Doctors_RegisterButton.Hide();
            Doctors_UpdateButton.Hide();

            UpdateDataGrids();
        }

        private void BillingButton_Click(object sender, EventArgs e)
        {
            Appointments_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Patients_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Billing_NavButton.BackColor = Color.FromArgb(1, 34, 79);
            Doctors_NavButton.BackColor = Color.FromArgb(0, 148, 212);

            Appointments_TabControl.Hide();
            Appointments_CreateButton.Hide();
            Apointments_UpdateButton.Hide();

            Patients_TabControl.Hide();
            Patients_RegisterButton.Hide();
            Patients_UpdateButton.Hide();
            Patients_SearchButton.Hide();

            Billing_DataGridView.Show();
            Billing_CreateButton.Show();

            Doctor_TabControl.Hide();
            Doctors_RegisterButton.Hide();
            Doctors_UpdateButton.Hide();

            UpdateDataGrids();
        }

        private void DoctorsButton_Click(object sender, EventArgs e)
        {
            Appointments_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Patients_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Billing_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Doctors_NavButton.BackColor = Color.FromArgb(1, 34, 79);

            Appointments_TabControl.Hide();
            Appointments_CreateButton.Hide();
            Apointments_UpdateButton.Hide();

            Patients_TabControl.Hide();
            Patients_RegisterButton.Hide();
            Patients_UpdateButton.Hide();
            Patients_SearchButton.Hide();

            Billing_DataGridView.Hide();
            Billing_CreateButton.Hide();

            Doctor_TabControl.Show();
            Doctors_RegisterButton.Show();
            Doctors_UpdateButton.Show();

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
            Appointments_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Patients_NavButton.BackColor = Color.FromArgb(1, 34, 79);
            Billing_NavButton.BackColor = Color.FromArgb(0, 148, 212);
            Doctors_NavButton.BackColor = Color.FromArgb(0, 148, 212);

            Appointments_TabControl.Hide();
            Appointments_CreateButton.Hide();
            Apointments_UpdateButton.Hide();

            Patients_TabControl.Show();
            Patients_RegisterButton.Show();
            Patients_UpdateButton.Show();
            Patients_SearchButton.Show();

            Billing_DataGridView.Hide();
            Billing_CreateButton.Hide();

            Doctor_TabControl.Hide();
            Doctors_RegisterButton.Hide();
            Doctors_UpdateButton.Hide();

            UpdateDataGrids();
        }

        private void RegisterDoctorButton_Click(object sender, EventArgs e)
        {
            RegisterDoctorForm doctorDetailsForm = new RegisterDoctorForm();
            doctorDetailsForm.ShowDialog();
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

        }

        private void Patients_UpdateButton_Click(object sender, EventArgs e)
        {
            UpdatePatientForm updatePatientForm = new UpdatePatientForm();
            updatePatientForm.ShowDialog();
            UpdateDataGrids();
        }

        private void Doctors_UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateDoctorForm updateDoctorForm = new UpdateDoctorForm();
            updateDoctorForm.ShowDialog();
            UpdateDataGrids();
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
            Appointments_PendingDataGridView.DataSource = Database.GetAppointments("PENDING");
            Appointments_RescheduledDataGridView.DataSource = Database.GetAppointments("RESCHEDULED");
            Appointments_CanceledDataGridView.DataSource = Database.GetAppointments("CANCELED");
            Appointments_FinishedDataGridView.DataSource = Database.GetAppointments("FINISHED");

            Patients_AllDataGridView.DataSource = Database.GetPatients("ALL");
            Patients_ActiveDataGridView.DataSource = Database.GetPatients("ACTIVE");
            Patients_InactiveDataGridView.DataSource = Database.GetPatients("INACTIVE");

            Doctors_AllDataGridView.DataSource = Database.GetDoctors("ALL");
            Doctors_ActiveDataGridView.DataSource = Database.GetDoctors("ACTIVE");
            Doctors_InactiveDataGridView.DataSource = Database.GetDoctors("INACTIVE");
        }
    }
}
