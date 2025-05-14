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
            MedicinesButton.BackColor = Color.FromArgb(0, 148, 212);
            ServicesButton.BackColor = Color.FromArgb(0, 148, 212);

            AppointmentTabControl.Show();
            createAppointmentButton.Show();
            updateApointmentButton.Show();

            DoctorTabControl.Hide();
            RegisterDoctorButton.Hide();
            UpdateDoctorButton.Hide();

            billingDataGridView.Hide();
            createBillButton.Hide();

        }

        private void BillingButton_Click(object sender, EventArgs e)
        {
            AppointmentsButton.BackColor = Color.FromArgb(0, 148, 212);
            PatientsButton.BackColor = Color.FromArgb(0, 148, 212);
            BillingButton.BackColor = Color.FromArgb(1, 34, 79);
            DoctorsButton.BackColor = Color.FromArgb(0, 148, 212);
            MedicinesButton.BackColor = Color.FromArgb(0, 148, 212);
            ServicesButton.BackColor = Color.FromArgb(0, 148, 212);

            AppointmentTabControl.Hide();
            createAppointmentButton.Hide();
            updateApointmentButton.Hide();

            DoctorTabControl.Hide();
            RegisterDoctorButton.Hide();
            UpdateDoctorButton.Hide();

            billingDataGridView.Show();
            createBillButton.Show();
        }

        private void DoctorsButton_Click(object sender, EventArgs e)
        {
            AppointmentsButton.BackColor = Color.FromArgb(0, 148, 212);
            PatientsButton.BackColor = Color.FromArgb(0, 148, 212);
            BillingButton.BackColor = Color.FromArgb(0, 148, 212);
            DoctorsButton.BackColor = Color.FromArgb(1, 34, 79);
            MedicinesButton.BackColor = Color.FromArgb(0, 148, 212);
            ServicesButton.BackColor = Color.FromArgb(0, 148, 212);

            AppointmentTabControl.Hide();
            createAppointmentButton.Hide();
            updateApointmentButton.Hide();

            DoctorTabControl.Show();
            RegisterDoctorButton.Show();
            UpdateDoctorButton.Show();

            billingDataGridView.Hide();
            createBillButton.Hide();
        } 
        
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Database.Instance.Connection.Close();
            loginForm.Show();
            this.Close();
        }

        private void PatientsButton_Click(object sender, EventArgs e)
        {
            AppointmentsButton.BackColor = Color.FromArgb(0, 148, 212);
            PatientsButton.BackColor = Color.FromArgb(1, 34, 79);
            BillingButton.BackColor = Color.FromArgb(0, 148, 212);
            DoctorsButton.BackColor = Color.FromArgb(0, 148, 212);
            MedicinesButton.BackColor = Color.FromArgb(0, 148, 212);
            ServicesButton.BackColor = Color.FromArgb(0, 148, 212);

            AppointmentTabControl.Hide();
            createAppointmentButton.Hide();
            updateApointmentButton.Hide();

            DoctorTabControl.Hide();
            RegisterDoctorButton.Hide();
            UpdateDoctorButton.Hide();

            billingDataGridView.Hide();
            createBillButton.Hide();
        }

        private void RegisterDoctorButton_Click(object sender, EventArgs e)
        {
            RegisterDoctorForm doctorDetailsForm = new RegisterDoctorForm();
            doctorDetailsForm.ShowDialog();
        }

        private void Medicines_Click(object sender, EventArgs e)
        {
            AppointmentsButton.BackColor = Color.FromArgb(0, 148, 212);
            PatientsButton.BackColor = Color.FromArgb(0, 148, 212);
            BillingButton.BackColor = Color.FromArgb(0, 148, 212);
            DoctorsButton.BackColor = Color.FromArgb(0, 148, 212);
            MedicinesButton.BackColor = Color.FromArgb(1, 34, 79);
            ServicesButton.BackColor = Color.FromArgb(0, 148, 212);

            AppointmentTabControl.Hide();
            createAppointmentButton.Hide();
            updateApointmentButton.Hide();

            DoctorTabControl.Hide();
            RegisterDoctorButton.Hide();
            UpdateDoctorButton.Hide();

            billingDataGridView.Hide();
            createBillButton.Hide();

            UpdateMedicineForm medicineView = new UpdateMedicineForm();
            medicineView.ShowDialog();
        }

        private void ServicesButton_Click(object sender, EventArgs e)
        {
            AppointmentsButton.BackColor = Color.FromArgb(0, 148, 212);
            PatientsButton.BackColor = Color.FromArgb(0, 148, 212);
            BillingButton.BackColor = Color.FromArgb(0, 148, 212);
            DoctorsButton.BackColor = Color.FromArgb(0, 148, 212);
            MedicinesButton.BackColor = Color.FromArgb(0, 148, 212);
            ServicesButton.BackColor = Color.FromArgb(1, 34, 79);

            AppointmentTabControl.Hide();
            createAppointmentButton.Hide();
            updateApointmentButton.Hide();

            DoctorTabControl.Hide();
            RegisterDoctorButton.Hide();
            UpdateDoctorButton.Hide();

            billingDataGridView.Hide();
            createBillButton.Hide();
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
        }
    }
}
