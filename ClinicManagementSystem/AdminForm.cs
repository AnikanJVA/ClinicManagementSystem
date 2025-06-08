using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static ClinicManagementSystem.LoginForm;

namespace ClinicManagementSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = Database.GetUsers();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database.Instance.Connection.Close();
            FormProvider.Login.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Database.Instance.Connection.Close();
            FormProvider.Login.Show();
            this.Close();
        }

        private void RegisterDoctorButton_Click(object sender, EventArgs e)
        {
            RegisterDoctorForm registerDoctorForm = new RegisterDoctorForm();
            registerDoctorForm.ShowDialog();
            dataGridView1.DataSource = Database.GetUsers();
        }

        private void RegisterReceptionistButton_Click(object sender, EventArgs e)
        {
            RegisterReceptionistForm registerReceptionistForm = new RegisterReceptionistForm();
            registerReceptionistForm.ShowDialog();
            dataGridView1.DataSource = Database.GetUsers();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserIDTextBox.Text))
            {
                MessageBox.Show("Please select a user first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Database.CurrentUser.AccType.Equals("DOCTOR"))
                {
                    UpdateDoctorForm updateDoctorForm = new UpdateDoctorForm();
                    updateDoctorForm.ShowDialog();
                }
                else
                {
                    UpdateReceptionistForm updateReceptionistForm = new UpdateReceptionistForm();
                    updateReceptionistForm.ShowDialog();
                }
                dataGridView1.DataSource = Database.GetUsers();
            }
            UserIDTextBox.Clear();
            AccTypeTextBox.Clear();
            EmailAddressTextBox.Clear();
            ContactNoTextBox.Clear();
            AltContactNoTextBox.Clear();
            AddressTextBox.Clear();
            FnameTextBox.Clear();
            MnameTextBox.Clear();
            LnameTextBox.Clear();
            LicenseNumberTextBox.Clear();
            ScheduleTextBox.Clear();
            StatusTextBox.Clear();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long userID = -1;
            string firstName = null;
            string middleName = null;
            string lastName = null;
            string licenseNumber = null;
            string schedule = null;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        try
                        {
                            userID = Convert.ToInt64(row.Cells["UserID"].Value.ToString());
                            Database.CurrentUser = Database.RetrieveUser(userID);
                            if (Database.CurrentUser.AccType.Equals("DOCTOR"))
                            {
                                LicenseNumberLabel.Visible = true;
                                LicenseNumberTextBox.Visible = true;
                                ScheduleLabel.Visible = true;
                                ScheduleTextBox.Visible = true;
                                Database.CurrentDoctor = Database.RetrieveDoctor(userID, "USERID");
                                firstName = Database.CurrentDoctor.FirstName;
                                middleName = Database.CurrentDoctor.MiddleName;
                                lastName = Database.CurrentDoctor.LastName;
                                licenseNumber = Database.CurrentDoctor.LicenseNumber;
                                schedule = Database.CurrentDoctor.Schedule;
                            }
                            else
                            {
                                LicenseNumberLabel.Visible = false;
                                LicenseNumberTextBox.Visible = false;
                                ScheduleLabel.Visible = false;
                                ScheduleTextBox.Visible = false;
                                Database.CurrentReceptionist = Database.RetrieveReceptionist(userID);
                                firstName = Database.CurrentDoctor.FirstName;
                                middleName = Database.CurrentDoctor.MiddleName;
                                lastName = Database.CurrentDoctor.LastName;
                            }
                        }
                        catch (Exception ex)
                        {

                        }

                        UserIDTextBox.Text = userID.ToString();
                        AccTypeTextBox.Text = Database.CurrentUser.AccType;
                        EmailAddressTextBox.Text = Database.CurrentUser.EmailAddress;
                        ContactNoTextBox.Text = Database.CurrentUser.ContactNumber.ToString();
                        AltContactNoTextBox.Text = Database.CurrentUser.AltContactNumber.ToString();
                        AddressTextBox.Text = Database.CurrentUser.Address;
                        FnameTextBox.Text = firstName;
                        MnameTextBox.Text = middleName;
                        LnameTextBox.Text = lastName;
                        StatusTextBox.Text = Database.CurrentUser.Status;
                        LicenseNumberTextBox.Text = licenseNumber;
                        ScheduleTextBox.Text = schedule;
                    }
                    else
                    {
                        UserIDTextBox.Clear();
                        AccTypeTextBox.Clear();
                        EmailAddressTextBox.Clear();
                        ContactNoTextBox.Clear();
                        AltContactNoTextBox.Clear();
                        AddressTextBox.Clear();
                        FnameTextBox.Clear();
                        MnameTextBox.Clear();
                        LnameTextBox.Clear();
                        LicenseNumberTextBox.Clear();
                        ScheduleTextBox.Clear();
                        StatusTextBox.Clear();
                    }
                }
            }
        }
    }
}
