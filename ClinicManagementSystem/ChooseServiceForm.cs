using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class ChooseServiceForm : Form
    {
        public ChooseServiceForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectService_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ServiceIdTextBox.Text) ||
                string.IsNullOrWhiteSpace(ServiceNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(ServiceDescriptionTextBox.Text))
            {
                MessageBox.Show("Don't leave anything empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // if ()
            }
        }
    }
}
