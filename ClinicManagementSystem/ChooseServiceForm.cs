using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClinicManagementSystem.LoginForm;

namespace ClinicManagementSystem
{
    public partial class ChooseServiceForm : Form
    {
        private long serviceID;

        public ChooseServiceForm()
        {
            InitializeComponent();
            Services_DataGridView.DataSource = Database.GetServices();
            CancelButton.Visible = true;
            SelectServiceButton.Visible = true;
        }

        public ChooseServiceForm(string formType)
        {
            InitializeComponent();
            Services_DataGridView.DataSource = Database.GetServices();
            if (formType.ToUpper().Equals("UPDATE"))
            {
                UpdateServiceButton.Visible = false;
                AddNewServiceButton.Visible = false;
                SelectServiceButton.Visible = true;
            }
            else
            {
                UpdateServiceButton.Visible = true;
                AddNewServiceButton.Visible = true;
                CloseButton.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Services_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = Services_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = Services_DataGridView.Rows[e.RowIndex];
                        try
                        {
                            serviceID = Convert.ToInt64(row.Cells["ServiceID"].Value.ToString());
                        }
                        catch (Exception ex)
                        {

                        }
                        string serviceName = row.Cells["ServiceName"].Value.ToString();
                        string serviceType = row.Cells["ServiceType"].Value.ToString();
                        string serviceDescription= row.Cells["ServiceDesc"].Value.ToString();
                        double price = 0;
                        try
                        {
                            price = Convert.ToDouble(row.Cells["Price"].Value.ToString());
                        }
                        catch (Exception ex)
                        {

                        }

                        ServiceIdTextBox.Text = Convert.ToString(serviceID);
                        ServiceNameTextBox.Text = serviceName;
                        ServiceTypeTextBox.Text = serviceType;
                        ServiceDescriptionTextBox.Text = serviceDescription;
                        PriceTextBox.Text = price.ToString();
                    }
                    else
                    {
                        ServiceIdTextBox.Clear();
                        ServiceNameTextBox.Clear();
                        ServiceDescriptionTextBox.Clear();
                    }
                }
            }
        }

        private void SelectService_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ServiceIdTextBox.Text) ||
                string.IsNullOrWhiteSpace(ServiceNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(ServiceDescriptionTextBox.Text))
            {
                MessageBox.Show("Select a service first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                Database.CurrentService = Database.RetrieveService(Convert.ToInt64(ServiceIdTextBox.Text));
                this.Close();
            }
        }

        private void AddNewService_Click(object sender, EventArgs e)
        {
            AddNewServiceForm addNewServiceForm = new AddNewServiceForm();
            addNewServiceForm.ShowDialog();
            Services_DataGridView.DataSource = Database.GetServices();
        }

        private void UpdateService_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ServiceIdTextBox.Text))
            {
                MessageBox.Show("Select a service first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                AddNewServiceForm addNewServiceForm = new AddNewServiceForm("UPDATE");
                Database.CurrentService = Database.RetrieveService(Convert.ToInt64(ServiceIdTextBox.Text));
                addNewServiceForm.ShowDialog();
                Services_DataGridView.DataSource = Database.GetServices();
            }
        }
    }
}
