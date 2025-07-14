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
    public partial class JobForm : Form
    {
        private JobService jobService = new JobService();
        private CustomerService customerService = new CustomerService();
        public JobForm()
        {
            InitializeComponent();
            LoadCustomers();
            LoadJobs();
            dgvJobs.CellClick += dgvJobs_CellClick;
        }

        private void dgvJobs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvJobs.Columns[e.ColumnIndex].Name != "StatusAction") return;

            var job = dgvJobs.Rows[e.RowIndex].DataBoundItem as JobView;
            if (job == null) return;

            var updateForm = new UpdateJobStatusForm(job.JobId);
            updateForm.FormClosed += (s, args) => LoadJobs(); // refresh after update
            updateForm.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddJobForm addForm = new AddJobForm();
            addForm.FormClosed += (s, args) => LoadJobs(); // Refresh table when add form closes
            addForm.ShowDialog();
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
            dgvJobs.Columns.Clear(); // Clear old columns
            dgvJobs.DataSource = null;
            dgvJobs.DataSource = jobService.GetAllJobs();
            dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var btnCol = new DataGridViewButtonColumn();
            btnCol.Name = "StatusAction";
            btnCol.HeaderText = "Change Status";
            btnCol.Text = "Update";
            btnCol.UseColumnTextForButtonValue = true;
            dgvJobs.Columns.Add(btnCol);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedItem == null) return;

            int customerId = (int)cmbCustomer.SelectedValue;
            var jobs = jobService.filterJobsByCustomer(customerId);
            dgvJobs.DataSource = jobs;
        }
    }
}
