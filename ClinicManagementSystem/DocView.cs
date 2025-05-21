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
        }

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            AppointmentsButton.BackColor = Color.FromArgb(1, 34, 79);
            PatientsButton.BackColor = Color.FromArgb(0, 148, 212);
            DoctorsButton.BackColor = Color.FromArgb(0, 148, 212);
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            AppointmentsButton.BackColor = Color.FromArgb(0, 148, 212);
            PatientsButton.BackColor = Color.FromArgb(1, 34, 79);
            DoctorsButton.BackColor = Color.FromArgb(0, 148, 212);
        }

        private void DoctorsButton_Click(object sender, EventArgs e)
        {
            AppointmentsButton.BackColor = Color.FromArgb(0, 148, 212);
            PatientsButton.BackColor = Color.FromArgb(0, 148, 212);
            DoctorsButton.BackColor = Color.FromArgb(1, 34, 79);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Database.Instance.Connection.Close();
            FormProvider.Login.Show();
            this.Close();
        }

        private void DocView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database.Instance.Connection.Close();
            FormProvider.Login.Show();
        }
    }
}
