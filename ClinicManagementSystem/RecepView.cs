using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
using PdfSharp.Quality;
using System.IO;
using static ClinicManagementSystem.LoginForm;

namespace ClinicManagementSystem
{
    public partial class RecepView : Form
    {
        private string patientName = "";
        private string doctorName = "";

        public RecepView()
        {
            InitializeComponent();
            UpdateDataGrids();

            string currentDay = DateTime.Now.ToString("dddd");
            if (currentDay.Equals("Monday")) { currentDay = "M"; }
            else if (currentDay.Equals("Tuesday")) { currentDay = "T"; }
            else if (currentDay.Equals("Wednesday")) { currentDay = "W"; }
            else if (currentDay.Equals("Thursday")) { currentDay = "Th"; }
            else if (currentDay.Equals("Friday")) { currentDay = "F"; }
            else if (currentDay.Equals("Saturday")) { currentDay = "S"; }
            Database.UpdateDoctorAvailabilityStatus(currentDay);

            AccountTypelabel.Text += "\n" + Database.CurrentLoggedReceptionist.LastName;

            greetingsLabel.Text += " " + Database.CurrentLoggedReceptionist.LastName;
            TotalAppointmentsLabel.Text = Database.GetTotalAppointments().ToString();
            TotalDoctorsLabel.Text = Database.GetTotalDoctors().ToString();
            TotalPatientsLabel.Text = Database.GetTotalPatients().ToString();

            NextAppointment_DateTimeLabel.Text = Database.GetNextAppointmentDateTime().ToString();
            NextAppointment_DoctorNameLabel.Text = "Dr. " + Database.GetNextAppointmentDoctor();
            NextAppointment_PatientNameLabel.Text = Database.GetNextAppointmentPatient();

            FormatDataGridViews();
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
            Appointments_DetailsPanel.Show();

            Patients_TabControl.Hide();
            Patients_RegisterButton.Hide();
            Patients_UpdateButton.Hide();
            Patients_DetailsPanel.Hide();

            Billing_DataGridView.Hide();
            Billing_CreateButton.Hide();
            Billing_Deletebutton.Hide();
            Billing_GetButton.Hide();
            Billing_DetailsPanel.Hide();

            Doctors_TabControl.Hide();
            Doctors_SearchButton.Hide();

            Dashboard_panel.Visible = false;

            //UpdateDataGrids();
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
            Appointments_DetailsPanel.Hide();

            Patients_TabControl.Hide();
            Patients_RegisterButton.Hide();
            Patients_UpdateButton.Hide();
            Patients_DetailsPanel.Hide();

            Billing_DataGridView.Show();
            Billing_CreateButton.Show();
            Billing_Deletebutton.Show();
            Billing_GetButton.Show();
            Billing_DetailsPanel.Show();

            Doctors_TabControl.Hide();
            Doctors_SearchButton.Hide();

            Dashboard_panel.Visible = false;

            //UpdateDataGrids();
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
            Appointments_DetailsPanel.Hide();

            Patients_TabControl.Hide();
            Patients_RegisterButton.Hide();
            Patients_UpdateButton.Hide();
            Patients_DetailsPanel.Hide();

            Billing_DataGridView.Hide();
            Billing_CreateButton.Hide();
            Billing_Deletebutton.Hide();
            Billing_GetButton.Hide();
            Billing_DetailsPanel.Hide();

            Doctors_TabControl.Show();
            Doctors_SearchButton.Show();

            Dashboard_panel.Visible = false;

            //UpdateDataGrids();
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
            Appointments_DetailsPanel.Hide();

            Patients_TabControl.Show();
            Patients_RegisterButton.Show();
            Patients_UpdateButton.Show();
            Patients_DetailsPanel.Show();

            Billing_DataGridView.Hide();
            Billing_CreateButton.Hide();
            Billing_Deletebutton.Hide();
            Billing_GetButton.Hide();
            Billing_DetailsPanel.Hide();

            Doctors_TabControl.Hide();
            Doctors_SearchButton.Hide();

            Dashboard_panel.Visible = false;

            //UpdateDataGrids();
        }

        private void Billing_CreateButton_Click(object sender, EventArgs e)
        {
            Database.ServicesPerformedList.Clear();
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
            ChoosePatientsForm choosePatientsForm = new ChoosePatientsForm("SEARCH");
            choosePatientsForm.ShowDialog();
        }

        private void Patients_UpdateButton_Click(object sender, EventArgs e)
        {
            if (Database.CurrentPatient.ID == 0 || Database.CurrentPatient == null)
            {
                MessageBox.Show("Select a patient first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                UpdatePatientForm updatePatientForm = new UpdatePatientForm();
                updatePatientForm.ShowDialog();
                UpdateDataGrids();
            }
        }

        private void Doctors_SearchButton_Click(object sender, EventArgs e)
        {
            ChooseDoctorForm chooseDoctorForm = new ChooseDoctorForm("SEARCH");
            chooseDoctorForm.ShowDialog();
        }

        private void Appointments_UpdateButton_Click(object sender, EventArgs e)
        {
            if (Database.CurrentAppointment.AppointmentId == 0 || Database.CurrentAppointment == null)
            {
                MessageBox.Show("Select an appointment first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                UpdateAppoitnment updateAppoitnment = new UpdateAppoitnment();
                updateAppoitnment.ShowDialog();
                UpdateDataGrids();
            }
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
            Appointments_DetailsPanel.Hide();

            Patients_TabControl.Hide();
            Patients_RegisterButton.Hide();
            Patients_UpdateButton.Hide();
            Patients_DetailsPanel.Hide();

            Billing_DataGridView.Hide();
            Billing_CreateButton.Hide();
            Billing_Deletebutton.Hide();
            Billing_GetButton.Hide();
            Billing_DetailsPanel.Hide();

            Doctors_TabControl.Hide();
            Doctors_SearchButton.Hide();

            Dashboard_panel.Visible = true;
            NextAppointment_DateTimeLabel.Text = Database.GetNextAppointmentDateTime().ToString();
            NextAppointment_DoctorNameLabel.Text = "Dr. " + Database.GetNextAppointmentDoctor();
            NextAppointment_PatientNameLabel.Text = Database.GetNextAppointmentPatient();
        }

        private void Billing_GetButton_Click(object sender, EventArgs e)
        {
            Bill bill = Database.CurrentBill;
            Patient patient = Database.CurrentPatient;
            Appointment appointment = Database.CurrentAppointment;
            List<Service> servicesPerformed = Database.ServicesPerformedList;

            if (Database.CurrentBill.BillID == 0 || Database.CurrentBill == null ||
                Database.CurrentPatient == null || Database.CurrentAppointment == null)
            {
                MessageBox.Show("Select a bill first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string filename = $"Bill_{Database.CurrentBill.BillID.ToString()}.pdf";
                if (File.Exists(filename))
                {
                    PdfFileUtility.ShowDocument(filename);
                }
                else
                {
                    GlobalFontSettings.UseWindowsFontsUnderWindows = true;
                    var doc = new PdfDocument();
                    var page = doc.AddPage();
                    var gfx = XGraphics.FromPdfPage(page);

                    var fontTitle = new XFont("Times New Roman", 20, XFontStyleEx.Bold);
                    var font = new XFont("Arial", 10, XFontStyleEx.Regular);
                    var fontLabel = new XFont("Arial", 10, XFontStyleEx.Bold);
                    var fontBold = new XFont("Arial", 11, XFontStyleEx.Bold);

                    double margin = 40;
                    double y = margin + 20;
                    double leftX = margin;
                    double rightX = page.Width / 2 + 10;
                    double labelOffset = 130;
                    double lineHeight = 18;

                    // Header
                    gfx.DrawString("RECEIPT", fontTitle, XBrushes.Black, new XRect(0, y, page.Width, 0), XStringFormats.TopCenter);
                    y += 30;
                    gfx.DrawString("Dental Clinic", fontBold, XBrushes.Black, new XRect(0, y, page.Width, 0), XStringFormats.TopCenter);
                    y += 70;

                    string middleName = patient.MiddleName;
                    char middleInitial = middleName[0];
                    string patientName = $"{patient.FirstName} {middleInitial.ToString().ToUpper()}. {patient.LastName}";

                    // Appointment info
                    gfx.DrawString("Patient Name: ", fontLabel, XBrushes.Black, leftX, y);
                    gfx.DrawString(patientName, font, XBrushes.Black, leftX + (labelOffset - 50), y);
                    gfx.DrawString("Receipt No: ", fontLabel, XBrushes.Black, rightX, y);
                    gfx.DrawString(bill.BillID.ToString(), font, XBrushes.Black, rightX + (labelOffset + 10), y);
                    y += lineHeight;

                    gfx.DrawString("Address: ", fontLabel, XBrushes.Black, leftX, y);
                    gfx.DrawString(patient.Address, font, XBrushes.Black, leftX + (labelOffset - 50), y);
                    gfx.DrawString("Appointment Date and Time: ", fontLabel, XBrushes.Black, rightX, y);
                    gfx.DrawString(appointment.DateTime, font, XBrushes.Black, rightX + (labelOffset + 10), y);
                    y += lineHeight;

                    gfx.DrawLine(XPens.Black, 38, y, rightX + 252, y);
                    y += lineHeight + 10;

                    gfx.DrawString("Services Performed", fontLabel, XBrushes.Black, leftX, y);
                    gfx.DrawString("Price", fontLabel, XBrushes.Black, rightX + (labelOffset), y);

                    y += 10;
                    foreach (Service service in servicesPerformed)
                    {
                        y += 20;
                        gfx.DrawString(service.ServiceName, font, XBrushes.Black, leftX, y);
                        gfx.DrawString(service.Price.ToString(), font, XBrushes.Black, rightX + (labelOffset), y);
                    }
                    y += 30;

                    gfx.DrawLine(XPens.Black, rightX + (labelOffset - 35), 585, 552, 585);
                    y += lineHeight;
                    gfx.DrawString("Total: ", fontLabel, XBrushes.Black, rightX + (labelOffset - 30), 600);
                    gfx.DrawString(Database.GetTotalAmount(servicesPerformed).ToString(), fontLabel, XBrushes.Black, rightX + (labelOffset), 600);

                    // Signatures
                    y = 750;
                    gfx.DrawLine(XPens.Black, leftX, y, leftX + 150, y);
                    gfx.DrawLine(XPens.Black, rightX + 95, y, rightX + 235, y);
                    y += 15;
                    gfx.DrawString("Doctor Signature", font, XBrushes.Black, leftX + 35, y);
                    gfx.DrawString("Receptionist Signature", font, XBrushes.Black, rightX + 115, y);

                    y += 30;
                    gfx.DrawString("This is a system-generated receipt.", font, XBrushes.Gray, new XRect(0, y, page.Width, 0), XStringFormats.TopCenter);

                    doc.Save(filename);
                    PdfFileUtility.ShowDocument(filename);
                }
            }
        }

        private void Billing_Deletebutton_Click(object sender, EventArgs e)
        {
            string filename = $"Bill_{Database.CurrentBill.BillID.ToString()}.pdf";
            long billID = Database.CurrentBill.BillID;
            var choice = MessageBox.Show("Are you sure you want to delete Bill: " + billID + " ?", "Delete Bill?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                if (Database.DeleteBill(billID, Database.CurrentBill.AppointmentID))
                {
                    if (File.Exists(filename))
                    {
                        File.Delete(filename);
                    }
                    MessageBox.Show("Bill " + billID + " has beed deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error!\nDatabse error.\nBill not deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            UpdateDataGrids();
        }

       

        private void Appointments_AllDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long appointmentID = -1;

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

        private void Appointments_RescheduledDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long appointmentID = -1;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = Appointments_RescheduledDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = Appointments_RescheduledDataGridView.Rows[e.RowIndex];
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

        private void Appointments_CanceledDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long appointmentID = -1;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = Appointments_CanceledDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = Appointments_CanceledDataGridView.Rows[e.RowIndex];
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

        private void Appointments_ApprovedDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long appointmentID = -1;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = Appointments_ApprovedDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = Appointments_ApprovedDataGridView.Rows[e.RowIndex];
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
            long appointmentID = -1;

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


        private void Patients_AllDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long patientID = -1;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = Patients_AllDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = Patients_AllDataGridView.Rows[e.RowIndex];
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

        private void Patients_ActiveDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long patientID = -1;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = Patients_ActiveDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = Patients_ActiveDataGridView.Rows[e.RowIndex];
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

        private void Patients_InactiveDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long patientID = -1;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = Patients_InactiveDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = Patients_InactiveDataGridView.Rows[e.RowIndex];
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

        private void Billing_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long billID = -1;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = Billing_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = Billing_DataGridView.Rows[e.RowIndex];
                        try
                        {
                            billID = Convert.ToInt64(row.Cells["BillID"].Value.ToString());
                            Database.CurrentBill = Database.RetrieveBill(billID);
                            Database.CurrentAppointment = Database.RetrieveAppointment(Database.CurrentBill.AppointmentID);
                            Database.CurrentPatient = Database.RetrievePatient(Database.CurrentAppointment.PatientId);
                            Database.ServicesPerformedList = Database.RetrieveServicesPerformed(Database.CurrentAppointment.AppointmentId);
                        }
                        catch (Exception ex)
                        {

                        }

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

                        Billing_BillIDTextBox.Text = billID.ToString();
                        Billing_PatientNameTextBox.Text = $"{Database.CurrentPatient.FirstName.ToString()} " +
                                                          $"{Database.CurrentPatient.MiddleName.ToString()} " +
                                                          $"{Database.CurrentPatient.LastName.ToString()}";
                        Billing_AppointmentIDTextBox.Text = Database.CurrentAppointment.AppointmentId.ToString();
                        Billing_AppointmentDateTimeTextBox.Text = Database.CurrentAppointment.DateTime;
                        BIlling_BillingDateTextBox.Text = Database.CurrentBill.BillingDate;
                        Billing_ServicesPerformedTextBox.Text = servicesPerformed;
                        Billing_AmountTextBox.Text = Database.CurrentBill.TotalAmount.ToString();
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

        public void Patients_AutoFill()
        {
            PatientIDTextBox.Text = Database.CurrentPatient.ID.ToString();
            FirstNameTextBox.Text = Database.CurrentPatient.FirstName;
            MiddleNameTextBox.Text = Database.CurrentPatient.MiddleName;
            LastNameTextBox.Text = Database.CurrentPatient.LastName;
            DoBTextBox.Text = Database.CurrentPatient.DoB;
            SexTextBox.Text = Database.CurrentPatient.Sex;
            ContactNumberTextBox.Text = Database.CurrentPatient.ContactNumber;
            AltContactNumberTextBox.Text = Database.CurrentPatient.AltContactNumber;
            EmailAddressTextBox.Text = Database.CurrentPatient.EmailAddress;
            AddressTextBox.Text = Database.CurrentPatient.Address;
            StatusTextBox.Text = Database.CurrentPatient.Status;
        }

        public void Patients_ClearAutoFill()
        {
            PatientIDTextBox.Clear();
            FirstNameTextBox.Clear();
            MiddleNameTextBox.Clear();
            LastNameTextBox.Clear();
            DoBTextBox.Clear();
            SexTextBox.Clear();
            ContactNumberTextBox.Clear(); 
            AltContactNumberTextBox.Clear();
            EmailAddressTextBox.Clear();
            AddressTextBox.Clear();
            StatusTextBox.Clear();
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

        public void FormatDataGridViews()
        {
            Appointments_AllDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Appointments_AllDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Appointments_AllDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Patients_AllDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            Appointments_ApprovedDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Appointments_ApprovedDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Appointments_ApprovedDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Appointments_ApprovedDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            Appointments_RescheduledDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Appointments_RescheduledDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Appointments_RescheduledDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Appointments_RescheduledDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            Appointments_CanceledDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Appointments_CanceledDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Appointments_CanceledDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Appointments_CanceledDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            Appointments_FinishedDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Appointments_FinishedDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Appointments_FinishedDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Appointments_FinishedDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            Patients_AllDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Patients_AllDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Patients_AllDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Patients_AllDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            Patients_ActiveDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Patients_ActiveDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Patients_ActiveDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Patients_ActiveDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            Patients_InactiveDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Patients_InactiveDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Patients_InactiveDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Patients_InactiveDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            Doctors_AllDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Doctors_AllDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Doctors_AllDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Doctors_AllDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            Doctors_AvailableDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Doctors_AvailableDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Doctors_AvailableDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Doctors_AvailableDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            Doctors_UnavailableDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Doctors_UnavailableDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Doctors_UnavailableDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Doctors_UnavailableDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            Doctors_InactiveDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Doctors_InactiveDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Doctors_InactiveDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Doctors_InactiveDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            Billing_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Billing_DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Billing_DataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Billing_DataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            Billing_DataGridView.ReadOnly = true;
            Billing_DataGridView.AllowUserToAddRows = false;
            Billing_DataGridView.AllowUserToDeleteRows = false;
        }
    }
}
