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
    public partial class TransportUnitForm : Form
    {
        private TransportUnitService unitService = new TransportUnitService();

        public TransportUnitForm()
        {
            InitializeComponent();
            LoadUnits();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransportUnit unit = new TransportUnit
            {
                LorryNumber = txtLorry.Text,
                DriverName = txtDriver.Text,
                AssistantName = txtAssistant.Text,
                ContainerType = txtContainer.Text
            };

            unitService.AddUnit(unit);
            MessageBox.Show("Unit added.");
            LoadUnits();
        }

        private void LoadUnits()
        {
            dgvUnits.DataSource = null;
            dgvUnits.DataSource = unitService.GetAllUnits();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
