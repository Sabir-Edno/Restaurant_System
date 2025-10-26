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
    public partial class FrrAddOrEditInventory : Form
    {
        ClsInventory _Inventory;
        int _InventoryID = -1;
        enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode = enMode.Update;

        public FrrAddOrEditInventory()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public FrrAddOrEditInventory(int InventoryID)
        {
            InitializeComponent();

            _InventoryID = InventoryID;

            _Mode = enMode.Update;
        }

        private void _FillCbUnits()
        {
            DataTable _dtUnits = ClsInventory.GetAllUnits();

            if (_dtUnits.Rows.Count > 0)
            {
                foreach (DataRow item in _dtUnits.Rows)
                {
                    cbUnits.Items.Add(item["UnitSymbol"]);
                }

                cbUnits.SelectedIndex = 0;  
            }
            else
                cbUnits.Enabled = false;
        }

        private void _LoadInventoryInfo()
        {
            if (_Mode == enMode.AddNew)
            {

                lblTitleMode.Text = "Add New Inventory";
                _Inventory = new ClsInventory();
                return;
            }

            _Inventory = ClsInventory.FindByInventoryID(_InventoryID);

            if (_Inventory != null)
            {
                lblTitleMode.Text = "Update Inventory Info";

                lblInventoryID.Text = _Inventory.InventoryID.ToString();
                tbItemName.Text = _Inventory.ItemName;
                tbQuantity.Text = _Inventory.Quantity.ToString();

                if (cbUnits.Enabled)
                    cbUnits.SelectedItem = _Inventory.Unit;

                tbReorderLevel.Text = _Inventory.ReorderLevel.ToString();
                if (_Inventory.LastUpdate != DateTime.MinValue)
                    lblLastUpdate.Text = _Inventory.LastUpdate.ToShortDateString();
                else
                    lblLastUpdate.Text = "Not Updated Yet";



            }
        }

        private void FrrAddOrEditInventory_Load(object sender, EventArgs e)
        {
            tbItemName.MaxLength = 100;
            _FillCbUnits();
            _LoadInventoryInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbItemName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbItemName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbItemName, "ItemName Not Be Empty");
            }
            else
            {
                if (ClsInventory.IsInventoryExistByItemName(tbItemName.Text.Trim()) && tbItemName.Text != _Inventory.ItemName)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbItemName, "ItemName Aleardy Exits");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbItemName, null);
                }
            }
        }

        private void tbQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbQuantity.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbQuantity, "Quantity Not Be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbQuantity, null);
            }
        }

        private void tbReorderLevel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbReorderLevel.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbReorderLevel, "ReorderLevel Not Be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbReorderLevel, null);
            }
        }

        private void tbReorderLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields Not Valid/Empty", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!cbUnits.Enabled)
            {
                MessageBox.Show("Data Units Don't Found. You Can Add This Data Without it", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Inventory.ItemName = tbItemName.Text;
            _Inventory.Quantity = Convert.ToDecimal(tbQuantity.Text);
            _Inventory.Unit = cbUnits.SelectedItem.ToString();
            _Inventory.ReorderLevel = Convert.ToDecimal(tbReorderLevel.Text);


            if (_Mode == enMode.AddNew)
            {
                if (_Inventory.Save())
                {
                    lblInventoryID.Text = _Inventory.InventoryID.ToString();
                    MessageBox.Show("Inventory Added Successfully", "Inventory Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblTitleMode.Text = "Update Inventory Info";
                }
                else
                {
                    MessageBox.Show("Inventory Not Added", "Inventory Not Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _Inventory.LastUpdate = DateTime.Now;
                if (_Inventory.Save())
                {

                    MessageBox.Show("Inventory Updated Successfully", "Inventory Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Inventory Not Updated", "Inventory Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
