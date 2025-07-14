using E_Shift_Couriers.Auth;
using E_Shift_Couriers.Enums;
using E_Shift_Couriers.Forms.CustomerForms;
using E_Shift_Couriers.Models;
using E_Shift_Couriers.Repositories;
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
    public partial class LoginForm : Form
    {
        private AuthService _authService;
        public LoginForm()
        {
            InitializeComponent();
            var conn = DbConnection.GetConnection();
            var adminRepo = new AdminRepository(conn.ToString());
            var customerRepo = new CustomerRepository();
            _authService = new AuthService(adminRepo, customerRepo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            var user = _authService.Login(username, password);

            if (user == null)
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Session.CurrentUser = new User
            {
                Id = user.Id,
                Username = user.Username, 
                Role = user.Role
            };

            if (user.Role == UserRole.Admin)
            {
                var adminDashboard = new MainForm();
                adminDashboard.Show();
            }
            else if (user.Role == UserRole.Customer)
            {
                //var customerDashboard = new CustomerDashboardForm(user as Customer);
                //customerDashboard.Show();
                var customerDashboard = new CustomerDashboardForm();
                customerDashboard.Show();
            }

            this.Hide();
      
    }
    }
}
