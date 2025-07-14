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

        public LoadForm()
        {
            InitializeComponent();

            LoadLoads();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var addForm = new AddLoadForm();
            addForm.FormClosed += (s, args) => LoadLoads(); // Refresh table when add form closes
            addForm.ShowDialog();
        }



        private void LoadLoads()
        {
            var loads = loadService.GetAllLoads();

            dgvLoads.DataSource = null;
            dgvLoads.AutoGenerateColumns = true;
            dgvLoads.DataSource = loads;

            dgvLoads.Columns["LoadId"].Visible = false;

            // Add Assign button column only if it's not already added
            if (!dgvLoads.Columns.Contains("Assign"))
            {
                DataGridViewButtonColumn assignBtn = new DataGridViewButtonColumn();
                assignBtn.Name = "Assign";
                assignBtn.HeaderText = "Action";
                assignBtn.Text = "Assign";
                assignBtn.UseColumnTextForButtonValue = true;
                dgvLoads.Columns.Add(assignBtn);
            }

            dgvLoads.Columns["Assign"].DisplayIndex = dgvLoads.Columns.Count - 1;
            dgvLoads.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void dgvLoads_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if Assign column clicked
            if (dgvLoads.Columns[e.ColumnIndex].Name == "Assign" && e.RowIndex >= 0)
            {
                var loadView = dgvLoads.Rows[e.RowIndex].DataBoundItem as LoadView;
                if (loadView == null) return;

                // Open AssignTransportUnitForm, passing the LoadId
                var assignForm = new AssignTransportUnitForm(loadView.LoadId);
                assignForm.FormClosed += (s, args) => LoadLoads(); // Refresh after assigning
                assignForm.ShowDialog();
            }
        }
    }
}

