using MySqlX.XDevAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClinicManagementSystem.LoginForm;

namespace ClinicManagementSystem
{
    public partial class SelectedServicesForm : Form
    {
        private Service service;

        public SelectedServicesForm()
        {
            InitializeComponent();
            foreach (Service service in Database.ServicesPerformedList)
            {
                SelectedServices_DataGridView.Rows.Add(service.ServiceID, service.ServiceName, service.Price);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelectServiceButton_Click(object sender, EventArgs e)
        {
            ChooseServiceForm chooseServiceForm = new ChooseServiceForm();
            chooseServiceForm.ShowDialog();
            service = Database.CurrentService;

            foreach (DataGridViewRow row in SelectedServices_DataGridView.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value != null && row.Cells[0].Value.ToString() == service.ServiceID.ToString()) // checker kung na add na ang service sa data grid
                {
                    if (!row.IsNewRow && row.Cells[0].Value != null && row.Cells[0].Value.ToString() == "0") // checker kung gi close ang choose service para dili mag add sa data grid
                    {
                        return;
                    }
                    MessageBox.Show("This service is already selected.", "Duplicate Service", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (service.ServiceID != 0)
            {
                SelectedServices_DataGridView.Rows.Add(service.ServiceID, service.ServiceName, service.Price);
            }
        }


        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            List<Service> selectedServices = new List<Service>();

            foreach (DataGridViewRow row in SelectedServices_DataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cellValue = row.Cells["ServiceID"].Value?.ToString();
                    if (!string.IsNullOrEmpty(cellValue))
                    {
                        selectedServices.Add(Database.RetrieveService(Convert.ToInt64(cellValue)));
                    }
                }
            }
            Database.ServicesPerformedList = selectedServices;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            var choice = MessageBox.Show("Are you sure you want to clear selected services?", "Clear selected services", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                SelectedServices_DataGridView.Rows.Clear();
            }
        }
    }
}
