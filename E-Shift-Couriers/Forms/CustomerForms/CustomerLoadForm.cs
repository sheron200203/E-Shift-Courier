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
    public partial class CustomerLoadForm : Form
    {
      
        private LoadService loadService = new LoadService();
        private JobService jobService = new JobService();
        private ProductService productService = new ProductService();

        public CustomerLoadForm()
        {
            InitializeComponent();
            LoadCombos();
            LoadLoads();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbJob.SelectedItem == null || cmbProduct.SelectedItem == null)
            {
                MessageBox.Show("Select all fields.");
                return;
            }

            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Enter a valid quantity greater than zero.");
                return;
            }

            Load load = new Load
            {
                JobId = (int)cmbJob.SelectedValue,
                ProductId = (int)cmbProduct.SelectedValue,
                TransportUnitId = null,
                Quantity = quantity
            };

            loadService.AddLoad(load);
            MessageBox.Show("Load assigned.");
            LoadLoads();
        }

        private void LoadCombos()
        {
            // Load Jobs
            var jobs = jobService.GetAllJobs();
            cmbJob.DataSource = null;
            cmbJob.DataSource = jobs;
            cmbJob.DisplayMember = "JobId";
            cmbJob.ValueMember = "JobId";

            // Load Products
            var products = productService.GetAllProducts();
            cmbProduct.DataSource = null;
            cmbProduct.DataSource = products;
            cmbProduct.DisplayMember = "Name";
            cmbProduct.ValueMember = "ProductId";
        }

        private void LoadLoads()
        {
            // Get loads with joined display info instead of just IDs
            var loads = loadService.GetAllLoads();

            dgvLoads.DataSource = null;
            dgvLoads.DataSource = loads;

            dgvLoads.Columns["LoadId"].Visible = false;
             
            dgvLoads.Columns["LorryNumber"].Visible = false;
            dgvLoads.Columns["DriverName"].Visible = false;
            dgvLoads.Columns["AssistantName"].Visible = false;
        }
    }
}
