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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ClinicManagementSystem
{
    public partial class AddNewServiceForm : Form
    {
        public AddNewServiceForm()
        {
            InitializeComponent();
            UpdateButton.Text = "Add Service";
            SelectButton.Visible = false;
            ServiceIDTextBox.Visible = false;
        }
        public AddNewServiceForm(string formType)
        {
            InitializeComponent();
            if (formType.ToUpper().Equals("UPDATE"))
            {
                UpdateButton.Text = "Update Service";
                label1.Visible = true;
                ServiceIDTextBox.Visible = true;
                SelectButton.Visible = true;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            ChooseServiceForm chooseServiceForm = new ChooseServiceForm("UPDATE");
            chooseServiceForm.ShowDialog();
        }
    }
}
