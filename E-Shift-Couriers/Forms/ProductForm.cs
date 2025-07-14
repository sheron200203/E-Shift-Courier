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
    public partial class ProductForm : Form
    {
        private ProductService productService = new ProductService();
        public ProductForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Name = txtProductName.Text,
                Description = txtProductDesc.Text
            };

            productService.AddProduct(product);
            MessageBox.Show("Product added.");
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = productService.GetAllProducts();
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
