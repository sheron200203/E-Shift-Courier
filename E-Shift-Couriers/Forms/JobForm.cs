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
    public partial class JobForm : Form
    {
        private JobService jobService = new JobService();
        private CustomerService customerService = new CustomerService();
        public JobForm()
        {
            InitializeComponent();
            LoadCustomers();
            LoadJobs();
        }

        private void button1_Click(object sender, EventArgs e)
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
                RequestedDate = dtRequestedDate.Value
            };

            jobService.AddJob(job);
            MessageBox.Show("Job created.");
            LoadJobs();
        }

        private void LoadCustomers()
        {
            cmbCustomer.DataSource = null;
            cmbCustomer.DataSource = customerService.GetAllCustomers();
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "ID";
        }

        private void LoadJobs()
        {
            dgvJobs.DataSource = null;
            dgvJobs.DataSource = jobService.GetAllJobs();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
