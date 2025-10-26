using ClsInvetoryBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;

namespace Restaurant_System
{
    public partial class FrrInventoryMangementScreen : Form
    {
        DataTable _dtInventories;

        public FrrInventoryMangementScreen()
        {
            InitializeComponent();
        }

        private void _FillDGVInventory()
        {
            cbFilter.Enabled = false;
            tbFilter.Enabled = false;

            _dtInventories = ClsInventory.GetInventory();

            if (_dtInventories.Rows.Count > 0)
            {

                DGVInventory.DataSource = _dtInventories;

                DGVInventory.Columns[0].HeaderText = "InventoryID";
                DGVInventory.Columns[0].Width = 120;

                DGVInventory.Columns[1].HeaderText = "ItemName";
                DGVInventory.Columns[1].Width = 180;

                DGVInventory.Columns[2].HeaderText = "Quantity";
                DGVInventory.Columns[2].Width = 150;

                DGVInventory.Columns[3].HeaderText = "Unit";
                DGVInventory.Columns[3].Width = 120;

                DGVInventory.Columns[4].HeaderText = "ReorderLevel";
                DGVInventory.Columns[4].Width = 120;

                DGVInventory.Columns[5].HeaderText = "Last Update";
                DGVInventory.Columns[5].Width = 150;

                cbFilter.Enabled = true;
                tbFilter.Enabled = true;

            }

            lblTotalRecords.Text = _dtInventories.Rows.Count.ToString();

        }

        private void _FillCbUnits()
        {
            DataTable _dtUnits = ClsInventory.GetAllUnits();

            if (_dtUnits.Rows.Count > 0)
            {
                foreach (DataRow item in _dtUnits.Rows)
                {
                    CbUnits.Items.Add(item["UnitSymbol"]);
                }

                CbUnits.SelectedIndex = 0;
            }
            else
                CbUnits.Enabled = false;
        }

        private void FrrInventoryMangementScreen_Load(object sender, EventArgs e)
        {
            CbUnits.Visible = false;
            tbFilter.Visible = false;
            _FillDGVInventory();
            cbFilter.Items.Add("None");
            cbFilter.Items.Add("InventoryID");
            cbFilter.Items.Add("ItemName");
            cbFilter.Items.Add("Unit");
            cbFilter.Items.Add("Quantity");
            cbFilter.Items.Add("ReorderLevel");

            cbFilter.SelectedIndex = 0;
            _FillCbUnits();
        }

        private void btnAddNewInventory_Click(object sender, EventArgs e)
        {
            FrrAddOrEditInventory frr = new FrrAddOrEditInventory();
            frr.ShowDialog();

            _FillDGVInventory();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dtInventories.DefaultView.RowFilter = "";
            tbFilter.Text = string.Empty;

            if (cbFilter.SelectedItem.ToString() == "None")
            {
                tbFilter.Visible = false;
                CbUnits.Visible = false;
            }
            else if (cbFilter.SelectedItem.ToString() == "Unit")
            {
                tbFilter.Visible = false;
                CbUnits.Visible = true;
                CbUnits_SelectedIndexChanged(null, null);
            }
            else
            {
                tbFilter.Visible = true;
                CbUnits.Visible = false;
            }
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedItem.ToString() == "InventoryID" || cbFilter.SelectedItem.ToString() == "Quantity"
            || cbFilter.SelectedItem.ToString() == "ReorderLevel")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilter.Text.Trim()))
            {
                _dtInventories.DefaultView.RowFilter = "";
                return;
            }

            if (_dtInventories.Rows.Count > 0)
            {
                if (cbFilter.SelectedItem.ToString() == "InventoryID" || cbFilter.SelectedItem.ToString() == "Quantity" 
                || cbFilter.SelectedItem.ToString() == "ReorderLevel")
                    _dtInventories.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilter.SelectedItem.ToString(), tbFilter.Text.Trim());
                else
                    _dtInventories.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", cbFilter.SelectedItem.ToString(), tbFilter.Text.Trim());
            }
            else
            {
                MessageBox.Show("Inventory Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowInventoryInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGVInventory.RowCount > 0)
            {
                FrrShowInventoryInfo frr = new FrrShowInventoryInfo((int)DGVInventory.CurrentRow.Cells[0].Value);
                frr.ShowDialog();
            }

        }

        private void AddNewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrrAddOrEditInventory frr = new FrrAddOrEditInventory();
            frr.ShowDialog();

            _FillDGVInventory();
        }

        private void updateUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DGVInventory.RowCount > 0)
            {
                FrrAddOrEditInventory frr = new FrrAddOrEditInventory((int)DGVInventory.CurrentRow.Cells[0].Value);
                frr.ShowDialog();

                _FillDGVInventory();
            }
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGVInventory.RowCount > 0)
            {
                FrrDeleteInventory frr = new FrrDeleteInventory((int)DGVInventory.CurrentRow.Cells[0].Value);
                frr.ShowDialog();
                _FillDGVInventory();
            }
        }

        private void CbUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbUnits.Enabled)
            {
                if (CbUnits.Visible)
                {
                    if (_dtInventories.Rows.Count > 0)
                        _dtInventories.DefaultView.RowFilter = string.Format("[{0}] = '{1}'", cbFilter.SelectedItem.ToString(), CbUnits.SelectedItem.ToString());
                    else
                        MessageBox.Show("There's no data to filter on it , Data messing or something else", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Data Of Units Not Found / Messing", "Units Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
