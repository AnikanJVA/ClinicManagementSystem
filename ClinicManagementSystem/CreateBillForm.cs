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
using static ClinicManagementSystem.RecepView;


namespace ClinicManagementSystem
{
    public partial class CreateBillForm : Form
    {
        public CreateBillForm()
        {
            InitializeComponent();
            BillingDateTimePicker.Format = DateTimePickerFormat.Custom;
            BillingDateTimePicker.CustomFormat = "yyyy'/'MM'/'dd HH':'mm";
            BillingDateTimePicker.MinDate = DateTime.Today;
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateUpdateBillButton_Click(object sender, EventArgs e)
        {

        }

        private void SelectServiceButton_Click(object sender, EventArgs e)
        {
            SelectedServicesForm selectedServicesForm = new SelectedServicesForm();
            selectedServicesForm.ShowDialog();
            string servicesPerformed = "";
            foreach (Service service in Database.ServicesPerformedList)
            {
                servicesPerformed += service.ServiceName + ", ";
            }
            
            ServicesPerformedTextBox.Text = servicesPerformed;
        }

        private void SelectAppointmentButton_Click(object sender, EventArgs e)
        {
            ChooseAppointmentForm chooseAppointmentForm = new ChooseAppointmentForm("FINISHED", "BILLING");
            chooseAppointmentForm.ShowDialog();
            AppointmentIDTextBox.Text = Database.CurrentAppointment.AppointmentId.ToString();
            PatientIDTextBox.Text = Database.CurrentAppointment.AppointmentId.ToString();
            PatientNameTextBox.Text = $"{Database.CurrentPatient.FirstName.ToString()} " +
                                      $"{Database.CurrentPatient.MiddleName.ToString()} {Database.CurrentPatient.LastName.ToString()}";
        }
    }
}
