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
    public partial class AddLoadForm : Form
    {
        private LoadService loadService = new LoadService();
        private JobService jobService = new JobService();
        private ProductService productService = new ProductService();
        private TransportUnitService unitService = new TransportUnitService();

        public AddLoadForm()
        {
            InitializeComponent();
            LoadCombos();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbJob.SelectedItem == null || cmbProduct.SelectedItem == null)
            {
                MessageBox.Show("Select all required fields.");
                return;
            }

            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Enter a valid quantity.");
                return;
            }

            var load = new Load
            {
                JobId = (int)cmbJob.SelectedValue,
                ProductId = (int)cmbProduct.SelectedValue,
                TransportUnitId = cmbUnit.SelectedItem != null ? (int?)cmbUnit.SelectedValue : null,
                Quantity = quantity
            };

            loadService.AddLoad(load);
            MessageBox.Show("Load added.");
            this.Close();
        }

        private void LoadCombos()
        {
            cmbJob.DataSource = jobService.GetAllJobs();
            cmbJob.DisplayMember = "JobCode";
            cmbJob.ValueMember = "JobId";

            cmbProduct.DataSource = productService.GetAllProducts();
            cmbProduct.DisplayMember = "Name";
            cmbProduct.ValueMember = "ProductId";

            cmbUnit.DataSource = unitService.GetAllUnits();
            cmbUnit.DisplayMember = "LorryNumber";
            cmbUnit.ValueMember = "UnitId";
        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
