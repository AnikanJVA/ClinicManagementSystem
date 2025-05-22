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
    public partial class CreateAppointmentForm : Form
    {
        public CreateAppointmentForm()
        {
            InitializeComponent();
            AppointmentDateTimePicker.Format = DateTimePickerFormat.Custom;
            AppointmentDateTimePicker.CustomFormat = "yyyy'/'MM'/'dd HH':'mm";
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectPatientButton_Click(object sender, EventArgs e)
        {
            ChoosePatientsForm choosePatientsForm = new ChoosePatientsForm();
            choosePatientsForm.ShowDialog();
        }
    }
}
