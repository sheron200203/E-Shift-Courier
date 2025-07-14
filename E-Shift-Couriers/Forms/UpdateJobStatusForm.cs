using E_Shift_Couriers.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shift_Couriers.Forms
{
    public partial class UpdateJobStatusForm : Form
    {
        private int _jobId;
        private JobService _jobService = new JobService();

        public UpdateJobStatusForm(int jobId)
        {
            InitializeComponent();
            _jobId = jobId;

            cmbStatus.Items.Add("Accepted");
            cmbStatus.Items.Add("Declined");
            cmbStatus.Items.Add("Completed");
            cmbStatus.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string selectedStatus = cmbStatus.SelectedItem.ToString();
            _jobService.UpdateStatus(_jobId, selectedStatus);

            MessageBox.Show("Status updated.");
            this.Close();
        }
    }
}
