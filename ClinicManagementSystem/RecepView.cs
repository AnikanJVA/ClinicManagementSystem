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
            Appointments_SerachButton.Show();

            Patients_TabControl.Hide();
            Patients_RegisterButton.Hide();
            Patients_UpdateButton.Hide();
            Patients_SearchButton.Hide();

            Billing_DataGridView.Hide();
            Billing_CreateButton.Hide();
            Billing_Deletebutton.Hide();
            Billing_GetButton.Hide();
            Billing_BillDetailsPanel.Hide();

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
            Appointments_SerachButton.Hide();

            Patients_TabControl.Hide();
            Patients_RegisterButton.Hide();
            Patients_UpdateButton.Hide();
            Patients_SearchButton.Hide();

            Billing_DataGridView.Show();
            Billing_CreateButton.Show();
            Billing_Deletebutton.Show();
            Billing_GetButton.Show();
            Billing_BillDetailsPanel.Show();

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
            Appointments_SerachButton.Hide();

            Patients_TabControl.Hide();
            Patients_RegisterButton.Hide();
            Patients_UpdateButton.Hide();
            Patients_SearchButton.Hide();

            Billing_DataGridView.Hide();
            Billing_CreateButton.Hide();
            Billing_Deletebutton.Hide();
            Billing_GetButton.Hide();
            Billing_BillDetailsPanel.Hide();

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
            Appointments_SerachButton.Hide();

            Patients_TabControl.Show();
            Patients_RegisterButton.Show();
            Patients_UpdateButton.Show();
            Patients_SearchButton.Show();

            Billing_DataGridView.Hide();
            Billing_CreateButton.Hide();
            Billing_Deletebutton.Hide();
            Billing_GetButton.Hide();
            Billing_BillDetailsPanel.Hide();

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
            UpdatePatientForm updatePatientForm = new UpdatePatientForm();
            updatePatientForm.ShowDialog();
            UpdateDataGrids();
        }

        private void Doctors_SearchButton_Click(object sender, EventArgs e)
        {
            ChooseDoctorForm chooseDoctorForm = new ChooseDoctorForm("SEARCH");
            chooseDoctorForm.ShowDialog();
        }

        private void Apointments_UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateAppoitnment updateAppoitnment = new UpdateAppoitnment();
            updateAppoitnment.ShowDialog();
            UpdateDataGrids();
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
            Appointments_SerachButton.Hide();

            Patients_TabControl.Hide();
            Patients_RegisterButton.Hide();
            Patients_UpdateButton.Hide();
            Patients_SearchButton.Hide();

            Billing_DataGridView.Hide();
            Billing_CreateButton.Hide();
            Billing_Deletebutton.Hide();
            Billing_GetButton.Hide();
            Billing_BillDetailsPanel.Hide();

            Doctors_TabControl.Hide();
            Doctors_SearchButton.Hide();

            Dashboard_panel.Visible = true;
            NextAppointment_DateTimeLabel.Text = Database.GetNextAppointmentDateTime().ToString();
            NextAppointment_DoctorNameLabel.Text = "Dr. " + Database.GetNextAppointmentDoctor();
            NextAppointment_PatientNameLabel.Text = Database.GetNextAppointmentPatient();
        }

        private void Appointments_SerachButton_Click(object sender, EventArgs e)
        {
            ChooseAppointmentForm chooseAppointmentForm = new ChooseAppointmentForm("ALL", "SEARCH");
            chooseAppointmentForm.ShowDialog();
        }

        private void Billing_GetButton_Click(object sender, EventArgs e)
        {
            Bill bill = Database.CurrentBill;
            Patient patient = Database.CurrentPatient;
            Appointment appointment = Database.CurrentAppointment;

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
                    y += 40;

                    string middleName = patient.MiddleName;
                    char middleInitial = middleName[0];
                    string patientName = $"{patient.FirstName} {middleInitial.ToString().ToUpper()}. {patient.LastName}";
                    // Appointment info
                    gfx.DrawString("Patient Name: ", fontLabel, XBrushes.Black, leftX, y);
                    gfx.DrawString(patientName, font, XBrushes.Black, leftX + labelOffset, y);
                    gfx.DrawString("Receipt No: ", fontLabel, XBrushes.Black, rightX, y);
                    gfx.DrawString(bill.BillID.ToString(), font, XBrushes.Black, rightX + labelOffset, y);
                    y += lineHeight;

                    gfx.DrawString("Address: ", fontLabel, XBrushes.Black, leftX, y);
                    gfx.DrawString(patient.Address, font, XBrushes.Black, leftX + labelOffset, y);
                    gfx.DrawString("Appointment Date and Time: ", fontLabel, XBrushes.Black, rightX, y);
                    gfx.DrawString(appointment.DateTime, font, XBrushes.Black, rightX + (labelOffset + 10), y);
                    //y += lineHeight;

                    //gfx.DrawString("Pay Period:", fontLabel, XBrushes.Black, leftX, y);
                    //gfx.DrawString(periodDisplay, font, XBrushes.Black, leftX + labelOffset, y);
                    //gfx.DrawString("Worked Days:", fontLabel, XBrushes.Black, rightX, y);
                    //gfx.DrawString(workDays.ToString(), font, XBrushes.Black, rightX + labelOffset, y);
                    y += 30;

                    // Section Titles
                    gfx.DrawString("EARNINGS", fontBold, XBrushes.Black, leftX, y);
                    gfx.DrawString("DEDUCTIONS", fontBold, XBrushes.Black, rightX, y);
                    y += lineHeight;

                    // Earnings
                    //gfx.DrawString("Basic", font, XBrushes.Black, leftX, y);
                    //gfx.DrawString(grossPay, font, XBrushes.Black, leftX + labelOffset, y);

                    // Deductions
                    double dedY = y;
                    void DrawDeduction(string label, string value)
                    {
                        gfx.DrawString(label, font, XBrushes.Black, rightX, dedY);
                        gfx.DrawString(value, font, XBrushes.Black, rightX + labelOffset, dedY);
                        dedY += lineHeight;
                    }

                    //DrawDeduction("SSS", sss);
                    //DrawDeduction("PhilHealth", philhealth);
                    //DrawDeduction("Pag-IBIG", pagibig);
                    //dedY += 20;
                    //DrawDeduction("Total Deductions", $"₱{totalDeduction:N2}");

                    y = Math.Max(y + lineHeight, dedY + 25);

                    //// Net Pay
                    //gfx.DrawLine(XPens.Black, margin, y, page.Width - margin, y);
                    //y += 10;
                    //y += lineHeight + 1;
                    //gfx.DrawString("Net Pay:", fontBold, XBrushes.Black, leftX, y);
                    //gfx.DrawString(netPay, fontBold, XBrushes.Black, leftX + labelOffset, y);
                    //y += lineHeight + 1;
                    //gfx.DrawString(netInWords, font, XBrushes.Black, leftX, y);
                    //y += 40;

                    // Signatures
                    gfx.DrawLine(XPens.Black, leftX, y, leftX + 150, y);
                    gfx.DrawLine(XPens.Black, rightX, y, rightX + 150, y);
                    y += 15;
                    gfx.DrawString("Employer Signature", font, XBrushes.Black, leftX, y);
                    gfx.DrawString("Employee Signature", font, XBrushes.Black, rightX, y);
                    y += 30;

                    gfx.DrawString("This is a system-generated payslip.", font, XBrushes.Gray, new XRect(0, y, page.Width, 0), XStringFormats.TopCenter);

                    doc.Save(filename);
                    PdfFileUtility.ShowDocument(filename);
                }
            }
        }

        private void Billing_Deletebutton_Click(object sender, EventArgs e)
        {
            long billID = Database.CurrentBill.BillID;
            var choice = MessageBox.Show("Are you sure you want to delete Bill: " + billID + " ?", "Delete Bill?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                if (Database.DeleteBill(billID, Database.CurrentBill.AppointmentID))
                {
                    MessageBox.Show("Bill " + billID + " has beed deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error!\nDatabse error.\nBill not deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
    }
}
