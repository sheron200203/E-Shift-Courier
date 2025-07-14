using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Shift_Couriers.Services;

namespace E_Shift_Couriers.Forms
{
    public partial class ReportsForm : Form
    {
        private readonly ReportService reportService = new ReportService();

        public ReportsForm()
        {
            InitializeComponent();
            LoadReports();
        }

        private void LoadReports()
        {
            dgvJobSummary.DataSource = reportService.GetJobSummaries();
            dgvJobSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCustomerJobs.DataSource = reportService.GetCustomerJobCounts();
            dgvCustomerJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTransportUtil.DataSource = reportService.GetTransportUtilizations();
            dgvTransportUtil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
