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

namespace E_Shift_Couriers.Forms
{
    public partial class AddJobForm : Form
    {
        private JobService jobService = new JobService();
        private CustomerService customerService = new CustomerService();
        public AddJobForm()
        {
            InitializeComponent();
            LoadCustomers();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedItem == null)
            {
                MessageBox.Show("Select a customer.");
                return;
            }

            var customer = (Customer)cmbCustomer.SelectedItem;

            Job job = new Job
            {
                CustomerId = customer.Id,
                StartLocation = txtStart.Text,
                EndLocation = txtEnd.Text,
                RequestedDate = dtRequestedDate.Value,
                Status = JobStatus.Pending.ToString()
            };

            jobService.AddJob(job);
            MessageBox.Show("Job created.");
            this.Close();
        }

        private void LoadCustomers()
        {
            cmbCustomer.DataSource = null;
            cmbCustomer.DataSource = customerService.GetAllCustomers();
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "ID";
        }

    }
}
