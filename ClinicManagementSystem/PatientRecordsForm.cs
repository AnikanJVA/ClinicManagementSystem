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
    public partial class PatientRecordsForm : Form
    {
        public PatientRecordsForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Patients_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
