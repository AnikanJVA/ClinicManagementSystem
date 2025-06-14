﻿using System;
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
            keyPressHandler();
            ServiceIDTextBox.Visible = false;
            UpdateButton.Visible = false;
            AddServiceButton.Visible = true;
            ServiceTypeComboBox.DataSource = Database.GetServiceTypeNames();
            ServiceTypeComboBox.DisplayMember = "serviceTypeName";
            StatusLabel.Visible = false;
            StatusComboBox.Visible = false;
            this.Text = "Add Service";
        }

        public AddNewServiceForm(string formType)
        {
            InitializeComponent();
            ServiceTypeComboBox.DataSource = Database.GetServiceTypeNames();
            ServiceTypeComboBox.DisplayMember = "serviceTypeName";
            if (formType.ToUpper().Equals("UPDATE"))
            {
                this.Text = "Update Service";
                ServiceIdLabel.Visible = true;
                ServiceIDTextBox.Visible = true;
                UpdateButton.Visible = true;
                AddServiceButton.Visible = false;
                StatusLabel.Visible = true;
                StatusComboBox.Visible = true;

                ServiceIDTextBox.Text = Database.CurrentService.ServiceID.ToString();
                ServiceNameTextBox.Text = Database.CurrentService.ServiceName;
                ServiceDescriptionTextBox.Text = Database.CurrentService.ServiceDesc;
                ServiceTypeComboBox.Text = Database.CurrentService.ServiceType;
                PriceTextBox.Text = Database.CurrentService.Price.ToString();
                StatusComboBox.Text = Database.CurrentService.Status;
            }
        }

        public void textOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                e.KeyChar != '-' &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        public void numOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        public void keyPressHandler()
        {
            ServiceNameTextBox.KeyPress += textOnly;

            PriceTextBox.KeyPress += numOnly;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ServiceIDTextBox.Text) || 
                string.IsNullOrWhiteSpace(ServiceNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(ServiceDescriptionTextBox.Text) ||
                string.IsNullOrWhiteSpace(ServiceTypeComboBox.Text) ||
                string.IsNullOrWhiteSpace(PriceTextBox.Text))
            {
                MessageBox.Show("Don't leave anything empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Database.UpdateService(Convert.ToInt64(ServiceIDTextBox.Text),
                                           ServiceNameTextBox.Text,
                                           ServiceDescriptionTextBox.Text,
                                           ServiceTypeComboBox.Text,
                                           Convert.ToDouble(PriceTextBox.Text),
                                           StatusComboBox.Text))
                {
                    MessageBox.Show("Service updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Database.CurrentService = null;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error!\nDuplicate service name detected.\nService not updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Database.CurrentService = null;
            this.Close();
        }

        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ServiceNameTextBox.Text) || 
                string.IsNullOrWhiteSpace(ServiceDescriptionTextBox.Text) || 
                string.IsNullOrWhiteSpace(ServiceTypeComboBox.Text) ||
                string.IsNullOrWhiteSpace(PriceTextBox.Text))
            {
                MessageBox.Show("Don't leave anything empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Database.AddService(ServiceNameTextBox.Text, 
                                        Database.GetServiceTypeID(ServiceTypeComboBox.Text), 
                                        ServiceDescriptionTextBox.Text,
                                        Convert.ToDouble(PriceTextBox.Text)))
                {
                    MessageBox.Show("Service added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error!\nDuplicate service detected.\nService not created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
