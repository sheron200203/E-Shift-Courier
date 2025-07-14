using E_Shift_Couriers.Auth;
using E_Shift_Couriers.Enums;
using E_Shift_Couriers.Models;
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

namespace E_Shift_Couriers.Forms.CustomerForms
{
    public partial class CustomerJobForm : Form
    {
        private JobService jobService = new JobService();
        private CustomerService customerService = new CustomerService();
        public CustomerJobForm()
        {
            InitializeComponent();
            LoadJobs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Job job = new Job
            {
                CustomerId = Session.CurrentUser.Id,
                StartLocation = txtStart.Text,
                EndLocation = txtEnd.Text,
                RequestedDate = dtRequestedDate.Value,
                Status = JobStatus.Pending.ToString()
            };

            jobService.AddJob(job);
            MessageBox.Show("Job created.");
            LoadJobs();
        }

        private void LoadJobs()
        {
            dgvJobs.DataSource = null;
            dgvJobs.DataSource = jobService.GetAllJobs();
        }
    }
}
