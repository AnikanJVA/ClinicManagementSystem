using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static ClinicManagementSystem.LoginForm;

namespace ClinicManagementSystem
{
    public partial class ChooseAppointmentForm : Form
    {
        private string status;

        private long appointmentID;
        //public ChooseAppointmentForm()
        //{
        //    InitializeComponent();
        //    Appointments_DataGridView.DataSource = Database.GetAppointments("ALL");
        //    CloseButton.Visible = false;
        //    SelectButton.Visible = true;
        //    CancelButton.Visible = true;
        //}

        public ChooseAppointmentForm(string status, string formType)
        {
            InitializeComponent();
            this.status = status;
            AppointmentDateTimePicker.Format = DateTimePickerFormat.Custom;
            AppointmentDateTimePicker.CustomFormat = "yyyy'/'MM'/'dd HH':'mm";
            Appointments_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Appointments_DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Appointments_DataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            if (formType.ToUpper().Equals("SEARCH"))
            {
                CloseButton.Visible = true;
                SelectButton.Visible = false;
                CancelButton.Visible = false;
                Appointments_DataGridView.DataSource = Database.GetAppointments(status);

            }
            else if (formType.ToUpper().Equals("BILLING"))
            {
                CloseButton.Visible = false;
                SelectButton.Visible = true;
                CancelButton.Visible = true;
                Appointments_DataGridView.DataSource = Database.GetAppointments(status, false);
            }
            else
            {
                CloseButton.Visible = false;
                SelectButton.Visible = true;
                CancelButton.Visible = true;
                Appointments_DataGridView.DataSource = Database.GetAppointments(status);

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectButton_Click(Object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AppointmentIDTextBox.Text))
            {
                MessageBox.Show("Please select a appointment first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database.CurrentAppointment = Database.RetrieveAppointment(Convert.ToInt64(AppointmentIDTextBox.Text));
                Database.CurrentPatient = Database.RetrievePatient(Database.CurrentAppointment.PatientId);
                Database.CurrentDoctor = Database.RetrieveDoctor(Database.CurrentAppointment.DoctorId, "DOCTORID");
                this.Close();
            }
        }

        private void Appointments_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = Appointments_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = Appointments_DataGridView.Rows[e.RowIndex];
                        try
                        {
                            appointmentID = Convert.ToInt64(row.Cells["AppointmentID"].Value.ToString());
                        }
                        catch (Exception ex)
                        {

                        }
                        string patientName = row.Cells["Patient"].Value.ToString();
                        string doctorName = row.Cells["Doctor"].Value.ToString();

                        Database.CurrentAppointment = Database.RetrieveAppointment(appointmentID);
                        AppointmentIDTextBox.Text = appointmentID.ToString();
                        AppointmentDateTextBox.Text = Database.CurrentAppointment.DateTime;
                        PatientIDTextBox.Text = Database.CurrentAppointment.PatientId.ToString();
                        PatientNameTextBox.Text = patientName;
                        DoctorIDTextBox.Text = Database.CurrentAppointment.DoctorId.ToString();
                        DoctorNameTextBox.Text = doctorName;
                        ReasonTextBox.Text = Database.CurrentAppointment.Reason;
                        StatusTextBox.Text = Database.CurrentAppointment.Status;
                    }
                    else
                    {
                        AppointmentIDTextBox.Clear();
                        AppointmentDateTextBox.Clear();
                        PatientIDTextBox.Clear();
                        PatientNameTextBox.Clear();
                        DoctorIDTextBox.Clear();
                        DoctorNameTextBox.Clear();
                        ReasonTextBox.Clear();
                        StatusTextBox.Clear();
                    }
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchFnameTextBox.Text) &&
               string.IsNullOrWhiteSpace(SearchMnameTextBox.Text) &&
               string.IsNullOrWhiteSpace(SearchLnameTextBox.Text))
            {
                MessageBox.Show("Search invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //if (DateCheckBox.Checked)
                //{
                //    if (string.IsNullOrWhiteSpace(SearchMnameTextBox.Text) && string.IsNullOrWhiteSpace(SearchLnameTextBox.Text))
                //    {
                //        Appointments_DataGridView.DataSource = Database.GetSearchAppointment("FD", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                //    }
                //    else if (string.IsNullOrWhiteSpace(SearchFnameTextBox.Text) && string.IsNullOrWhiteSpace(SearchLnameTextBox.Text))
                //    {
                //        Appointments_DataGridView.DataSource = Database.GetSearchAppointment("MD", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                //    }
                //    else if (string.IsNullOrWhiteSpace(SearchFnameTextBox.Text) && string.IsNullOrWhiteSpace(SearchMnameTextBox.Text))
                //    {
                //        Appointments_DataGridView.DataSource = Database.GetSearchAppointment("LD", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                //    }
                //    else if (string.IsNullOrWhiteSpace(SearchLnameTextBox.Text))
                //    {
                //        Appointments_DataGridView.DataSource = Database.GetSearchAppointment("FMD", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                //    }
                //    else if (string.IsNullOrWhiteSpace(SearchMnameTextBox.Text))
                //    {
                //        Appointments_DataGridView.DataSource = Database.GetSearchAppointment("FLD", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                //    }
                //    else if (string.IsNullOrWhiteSpace(SearchFnameTextBox.Text))
                //    {
                //        Appointments_DataGridView.DataSource = Database.GetSearchAppointment("MLD", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                //    }
                //    else
                //    {
                //        Appointments_DataGridView.DataSource = Database.GetSearchAppointment("FMLD", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                //    }
                //}
                //else
                //{
                    if (string.IsNullOrWhiteSpace(SearchMnameTextBox.Text) && string.IsNullOrWhiteSpace(SearchLnameTextBox.Text))
                    {
                        Appointments_DataGridView.DataSource = Database.GetSearchAppointment("F", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                    }
                    else if (string.IsNullOrWhiteSpace(SearchFnameTextBox.Text) && string.IsNullOrWhiteSpace(SearchLnameTextBox.Text))
                    {
                        Appointments_DataGridView.DataSource = Database.GetSearchAppointment("M", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                    }
                    else if (string.IsNullOrWhiteSpace(SearchFnameTextBox.Text) && string.IsNullOrWhiteSpace(SearchMnameTextBox.Text))
                    {
                        Appointments_DataGridView.DataSource = Database.GetSearchAppointment("L", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                    }
                    else if (string.IsNullOrWhiteSpace(SearchLnameTextBox.Text))
                    {
                        Appointments_DataGridView.DataSource = Database.GetSearchAppointment("FM", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                    }
                    else if (string.IsNullOrWhiteSpace(SearchMnameTextBox.Text))
                    {
                        Appointments_DataGridView.DataSource = Database.GetSearchAppointment("FL", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                    }
                    else if (string.IsNullOrWhiteSpace(SearchFnameTextBox.Text))
                    {
                        Appointments_DataGridView.DataSource = Database.GetSearchAppointment("ML", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                    }
                    else
                    {
                        Appointments_DataGridView.DataSource = Database.GetSearchAppointment("FML", SearchFnameTextBox.Text, SearchMnameTextBox.Text, SearchLnameTextBox.Text);
                    }
                //}
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Appointments_DataGridView.DataSource = Database.GetAppointments(status);
        }
    }
}
