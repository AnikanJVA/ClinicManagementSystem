using MySqlX.XDevAPI;
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
    public partial class SelectedServicesForm : Form
    {
        public SelectedServicesForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelectServiceButton_Click(object sender, EventArgs e)
        {
            ChooseServiceForm chooseServiceForm = new ChooseServiceForm();
            chooseServiceForm.ShowDialog();
        }


        private void ConfirmButton_Click(object sender, EventArgs e)
        {
             
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            //Services_DataGridView.DataSource = Database.
        }

        private void Services_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        //    {
        //        var cell = Services_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
        //        if (cell.Value != null)
        //        {
        //            if (e.RowIndex >= 0)
        //            {
        //                DataGridViewRow row = Services_DataGridView.Rows[e.RowIndex];
        //                try
        //                {
        //                    serviceID = Convert.ToInt64(row.Cells["ServiceID"].Value.ToString());
        //                }
        //                catch (Exception ex)
        //                {

        //                }
        //                string serviceName = row.Cells["ServiceName"].Value.ToString();
        //                string serviceDescription = row.Cells["ServiceDescription"].Value.ToString();

        //                ServiceIdTextBox.Text = Convert.ToString(serviceID);
        //                ServiceNameTextBox.Text = serviceName;
        //                ServiceDescriptionTextBox.Text = serviceDescription;
        //            }
        //            else
        //            {
        //                ServiceIdTextBox.Clear();
        //                ServiceNameTextBox.Clear();
        //                ServiceDescriptionTextBox.Clear();
        //            }
        //        }
        //    }
        }

        
    }
}
