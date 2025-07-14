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
    public partial class LoadForm : Form
    {
        private LoadService loadService = new LoadService();
        private JobService jobService = new JobService();
        private ProductService productService = new ProductService();
        private TransportUnitService unitService = new TransportUnitService();

        public LoadForm()
        {
            InitializeComponent();
            LoadCombos();
            LoadLoads();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbJob.SelectedItem == null || cmbProduct.SelectedItem == null || cmbUnit.SelectedItem == null)
            {
                MessageBox.Show("Select all fields.");
                return;
            }

            Load load = new Load
            {
                JobId = (int)cmbJob.SelectedValue,
                ProductId = (int)cmbProduct.SelectedValue,
                TransportUnitId = (int)cmbUnit.SelectedValue,
                Quantity = Convert.ToInt32(txtQuantity.Text)
            };

            loadService.AddLoad(load);
            MessageBox.Show("Load assigned.");
            LoadLoads();
        }

        private void LoadCombos()
        {
            cmbJob.DataSource = jobService.GetAllJobs();
            cmbJob.DisplayMember = "JobId";
            cmbJob.ValueMember = "JobId";

            cmbProduct.DataSource = productService.GetAllProducts();
            cmbProduct.DisplayMember = "Name";
            cmbProduct.ValueMember = "ProductId";

            cmbUnit.DataSource = unitService.GetAllUnits();
            cmbUnit.DisplayMember = "LorryNumber";
            cmbUnit.ValueMember = "UnitId";
        }

        private void LoadLoads()
        {
            dgvLoads.DataSource = null;
            dgvLoads.DataSource = loadService.GetAllLoads();
        }
    }
}
