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
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateUpdateBillButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AppointmentIDTextBox.Text))
            {
                MessageBox.Show("Select appoinment first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(ServicesPerformedTextBox.Text))
                {
                    MessageBox.Show("Select a service first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (AmountTextBox.Text.Equals("0") || string.IsNullOrWhiteSpace(AmountTextBox.Text))
                    {
                        MessageBox.Show("Calculate total amount first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (Database.AddBill(Convert.ToInt64(AppointmentIDTextBox.Text), Database.GetTotalAmount(Database.ServicesPerformedList), Database.ServicesPerformedList))
                        {
                            MessageBox.Show("Bill created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error!\nDatabse error.\nBill not udpated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private void SelectServiceButton_Click(object sender, EventArgs e)
        {
            SelectedServicesForm selectedServicesForm = new SelectedServicesForm();
            selectedServicesForm.ShowDialog();

            string servicesPerformed = "";
            int count = Database.ServicesPerformedList.Count;
            int index = 0;

            foreach (Service service in Database.ServicesPerformedList)
            {
                servicesPerformed += service.ServiceName;
                index++;

                if (index < count)
                {
                    servicesPerformed += ", ";
                }
                
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
            AppointmentDateTimeTextBox.Text = Database.CurrentAppointment.DateTime;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            AmountTextBox.Text = Database.GetTotalAmount(Database.ServicesPerformedList).ToString("C");
            MessageBox.Show(AmountTextBox.Text);
        }
    }
}
