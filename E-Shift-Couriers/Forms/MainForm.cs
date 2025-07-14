using E_Shift_Couriers.Auth;
using E_Shift_Couriers.Enums;
using E_Shift_Couriers.Models;
using E_Shift_Couriers.Repositories;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadForm loadForm = new LoadForm();
            loadForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JobForm jobForm = new JobForm();
            jobForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TransportUnitForm transportUnitForm = new TransportUnitForm();
            transportUnitForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var user = Session.CurrentUser;
            if (user == null || user.Role != UserRole.Admin)
            {
                MessageBox.Show("Access denied or invalid user.");
                return;
            }


            var adminRepo = new AdminRepository();

            // Fetch full Admin object by Id
            Admin adminUser = adminRepo.GetById(user.Id);

            if (adminUser == null)
            {
                MessageBox.Show("Admin user not found.");
                return;
            }

            AdminProfileForm form = new AdminProfileForm(adminUser);
            form.ShowDialog();
        }
    }
}
