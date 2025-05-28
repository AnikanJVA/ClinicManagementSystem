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

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database.Instance.Connection.Close();
            FormProvider.Login.Show();
        }

        private void UpdateDoctorButton_Click(object sender, EventArgs e)
        {
           UpdateDoctorForm updateDoctorForm = new UpdateDoctorForm();
           updateDoctorForm.ShowDialog();
            dataGridView1.DataSource = Database.GetUsers();
        }

        private void UpdateReceptionistButton_Click(object sender, EventArgs e)
        {
            UpdateReceptionistForm updateReceptionistForm = new UpdateReceptionistForm();
            updateReceptionistForm.ShowDialog();
            dataGridView1.DataSource = Database.GetUsers();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterReceptionistButton_Click(object sender, EventArgs e)
        {
            RegisterReceptionistForm registerReceptionistForm = new RegisterReceptionistForm();
            registerReceptionistForm.ShowDialog();
            dataGridView1.DataSource = Database.GetUsers();
        }
    }
}
