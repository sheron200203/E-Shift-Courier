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
using System.Xml.Linq;

namespace E_Shift_Couriers.Forms
{
    public partial class CustomerForm : Form
    {
        private readonly CustomerService _customerService = new CustomerService();

        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            var customers = _customerService.GetAllCustomers();
            dataGridView1.DataSource = customers;
            dataGridView1.Columns["PasswordHash"].Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text
            };

            _customerService.AddCustomer(customer);
            ClearFields();
            LoadCustomers();
            MessageBox.Show("Customer added!");
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }


    }
}
