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
    public partial class AssignTransportUnitForm : Form
    {
        private int loadId;
        private TransportUnitService unitService = new TransportUnitService();
        private LoadService loadService = new LoadService();

        public AssignTransportUnitForm(int loadId)
        {
            InitializeComponent();
            this.loadId = loadId;
            LoadUnits();
        }

        private void LoadUnits()
        {
            cmbUnits.DataSource = unitService.GetAllUnits();
            cmbUnits.DisplayMember = "LorryNumber";
            cmbUnits.ValueMember = "UnitId";
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            int selectedUnitId = (int)cmbUnits.SelectedValue;
            loadService.AssignTransportUnit(loadId, selectedUnitId);
            MessageBox.Show("Transport unit assigned.");
            this.Close();
        }
    }
}
