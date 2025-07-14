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
    public partial class CustomerDashboardForm : Form
    {
        public CustomerDashboardForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerLoadForm loadForm = new CustomerLoadForm();
            loadForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerJobForm jobForm = new CustomerJobForm();
            jobForm.Show();
        }

    }
}
