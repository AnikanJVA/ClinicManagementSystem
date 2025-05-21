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
    public partial class RegisterPatientForm : Form
    {
        public RegisterPatientForm()
        {
            InitializeComponent();
            DoBDateTimePicker.Format = DateTimePickerFormat.Custom;
            DoBDateTimePicker.CustomFormat = "MMMM '/' dd '/' yyyy";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
