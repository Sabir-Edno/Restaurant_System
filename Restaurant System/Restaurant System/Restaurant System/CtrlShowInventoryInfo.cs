using ClsCategoryBusinessLayer;
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
    public partial class CtrlShowInventoryInfo : UserControl
    {

        ClsInventory Inventory;

        public CtrlShowInventoryInfo()
        {
            InitializeComponent();
        }

        public void ResetValues()
        {
            Inventory = null;
            lblInventoryID.Text = "???";
            lblItemName.Text = "???";
            lblQuantity.Text = "???";
            lblUnit.Text = "???";
            lblReorderLevel.Text = "???";
            lblLastUpdate.Text = "???";
        }

        public void LoadInventoryInfo(int InventoryID)
        {
            Inventory = ClsInventory.FindByInventoryID(InventoryID);

            if (Inventory != null)
            {
                lblInventoryID.Text = InventoryID.ToString();
                //lblItemName.Text = Inventory.ItemName;
                lblQuantity.Text = Inventory.Quantity.ToString();
                lblUnit.Text = Inventory.Unit;
                lblReorderLevel.Text = Inventory.ReorderLevel.ToString();
                if (Inventory.LastUpdate != DateTime.MinValue)
                    lblLastUpdate.Text = Inventory.LastUpdate.ToShortDateString();
                else
                    lblLastUpdate.Text = "Not Updated Yet";
            }
            else
                MessageBox.Show($"Inventory With ID = {InventoryID} Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CtrlShowInventoryInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
