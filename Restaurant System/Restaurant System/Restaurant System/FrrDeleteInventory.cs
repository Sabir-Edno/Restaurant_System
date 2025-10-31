using ClsInvetoryBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_System
{
    public partial class FrrDeleteInventory : Form
    {
        int _InventoryID = -1;

        public FrrDeleteInventory(int InventoryID)
        {
            InitializeComponent();

            _InventoryID = InventoryID;
        }

        private void _LoadInventoryInfo()
        {
            ClsInventory Inventory = ClsInventory.FindByInventoryID(_InventoryID);

            if (Inventory != null)
            {
                ctrlShowInventoryInfo1.LoadInventoryInfo(Inventory.InventoryID);
                btnDelete.Enabled = true;
            }
            else
                MessageBox.Show($"Inventory With ID = {_InventoryID} Not Found", "Not Found");
        }

        private void FrrDeleteInventory_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            _LoadInventoryInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Do You Want To Delete Inventory With ID = {_InventoryID}", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ClsInventory.DeleteInventory(_InventoryID))
                {
                    MessageBox.Show($"Inventory With ID = {_InventoryID} Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrlShowInventoryInfo1.ResetValues();
                }
                else
                    MessageBox.Show($"Inventory With ID = {_InventoryID} Not Deleted", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
