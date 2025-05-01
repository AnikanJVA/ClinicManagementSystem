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
    public partial class AppointmentsForm : Form
    {
        public AppointmentsForm()
        {
            InitializeComponent();
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.Show();
            this.Close();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Database.Instance.Connection.Close();
            loginForm.Show();
            this.Close();
        }
    }
}
