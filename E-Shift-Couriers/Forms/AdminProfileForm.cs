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
using E_Shift_Couriers.Utils;
namespace E_Shift_Couriers.Forms
{
    public partial class AdminProfileForm : Form
    {
        private readonly Admin _admin;
        private AdminService adminService = new AdminService();

        public AdminProfileForm(Admin admin)
        {
            InitializeComponent();
            _admin = admin;
            LoadAdminData();
        }

        private void LoadAdminData()
        {
            txtUsername.Text = _admin.Username;
        }
        private void Update_Click(object sender, EventArgs e)
        {
            _admin.Username = txtUsername.Text;

            if (!string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                if (txtNewPassword.Text == txtConfirmPassword.Text)
                    _admin.PasswordHash = PasswordHasher.Hash(txtNewPassword.Text);
                else
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }
            }

            bool success = adminService.UpdateAdmin(_admin);

            MessageBox.Show(success ? "Updated successfully!" : "Failed to update.");
            this.Hide();

        }
    }
}
