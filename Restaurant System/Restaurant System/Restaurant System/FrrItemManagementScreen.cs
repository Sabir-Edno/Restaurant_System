using ClsCategoryBusinessLayer;
using ClsMenuItemBusinessLayer;
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
    public partial class FrrItemManagementScreen : Form
    {
        DataTable _dtItems;

        public FrrItemManagementScreen()
        {
            InitializeComponent();
        }

        private void _FillDGVItems()
        {
            cbFilter.Enabled = false;
            tbFilter.Enabled = false;

            _dtItems = ClsItem.GetMenuItems();

            if (_dtItems.Rows.Count > 0)
            {

                DGVItems.DataSource = _dtItems;

                DGVItems.Columns[0].HeaderText = "ItemID";
                DGVItems.Columns[0].Width = 120;

                DGVItems.Columns[1].HeaderText = "CategoryID";
                DGVItems.Columns[1].Width = 120;

                DGVItems.Columns[2].HeaderText = "ItemName";
                DGVItems.Columns[2].Width = 120;

                DGVItems.Columns[3].HeaderText = "Description";
                DGVItems.Columns[3].Width = 180;

                DGVItems.Columns[4].HeaderText = "Price";
                DGVItems.Columns[4].Width = 180;

                DGVItems.Columns[5].HeaderText = "Availability";
                DGVItems.Columns[5].Width = 180;

                DGVItems.Columns[6].HeaderText = "CreatedAt";
                DGVItems.Columns[6].Width = 150;

                DGVItems.Columns[7].HeaderText = "UpdateAt";
                DGVItems.Columns[7].Width = 150;

                cbFilter.Enabled = true;
                tbFilter.Enabled = true;

            }

            lblTotalRecords.Text = _dtItems.Rows.Count.ToString();

        }

        private void FrrMenuItemManagementScreen_Load(object sender, EventArgs e)
        {
            tbFilter.Visible = false;
            _FillDGVItems();
            cbFilter.Items.Add("None");
            cbFilter.Items.Add("ItemID");
            cbFilter.Items.Add("CategoryID");
            cbFilter.Items.Add("ItemName");
            cbFilter.Items.Add("Availability");

            cbFilter.SelectedIndex = 0;
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            FrrAddOrEditItem frr = new FrrAddOrEditItem();
            frr.ShowDialog();
            _FillDGVItems();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dtItems.DefaultView.RowFilter = "";
            tbFilter.Text = string.Empty;

            if (cbFilter.SelectedItem.ToString() == "None")
            {
                tbFilter.Visible = false;
                rbInStock.Visible = false;
                rbOutOfStock.Visible = false;
            }
            else if(cbFilter.SelectedItem.ToString() == "Availability")
            {
                tbFilter.Visible = false;
                rbInStock.Visible = true;
                rbOutOfStock.Visible = true;
                rbInStock_CheckedChanged(null, null);
            }
            else
            {
                tbFilter.Visible = true;
                rbInStock.Visible = false;
                rbOutOfStock.Visible = false;
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilter.Text.Trim()))
            {
                _dtItems.DefaultView.RowFilter = "";
                return;
            }

            if (_dtItems.Rows.Count > 0)
            {
                if (cbFilter.SelectedItem.ToString() == "ItemID" || cbFilter.SelectedItem.ToString() == "CategoryID")
                    _dtItems.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilter.SelectedItem.ToString(), tbFilter.Text.Trim());
                else
                    _dtItems.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", cbFilter.SelectedItem.ToString(), tbFilter.Text.Trim());
            }
            else
            {
                MessageBox.Show("Category Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedItem.ToString() == "ItemID" || cbFilter.SelectedItem.ToString() == "CategoryID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ShowItemInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGVItems.Rows.Count > 0)
            {
                FrrShowItemInfo frr = new FrrShowItemInfo((int)DGVItems.CurrentRow.Cells[0].Value);
                frr.ShowDialog();
                _FillDGVItems();
            }
        }

        private void AddNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrrAddOrEditItem frr = new FrrAddOrEditItem();
            frr.ShowDialog();
            _FillDGVItems();
        }

        private void UpdateItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DGVItems.Rows.Count > 0)
            {
                FrrAddOrEditItem frr = new FrrAddOrEditItem((int)DGVItems.CurrentRow.Cells[0].Value);
                frr.ShowDialog();
                _FillDGVItems();
            }
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGVItems.Rows.Count > 0)
            {
                FrrDeleteItem frr = new FrrDeleteItem((int)DGVItems.CurrentRow.Cells[0].Value);
                frr.ShowDialog();
                _FillDGVItems();
            }
        }

        private void rbInStock_CheckedChanged(object sender, EventArgs e)
        {
            _dtItems.DefaultView.RowFilter = "";

            if (rbInStock.Checked)
            {
                if (DGVItems.Rows.Count > 0)
                    _dtItems.DefaultView.RowFilter = string.Format("[{0}] = '{1}'", cbFilter.SelectedItem.ToString(), true);
                else
                    MessageBox.Show("Items Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbOutOfStock_CheckedChanged(object sender, EventArgs e)
        {
            _dtItems.DefaultView.RowFilter = "";

            if (rbOutOfStock.Checked)
            {
                if (DGVItems.Rows.Count > 0)
                    _dtItems.DefaultView.RowFilter = string.Format("[{0}] = '{1}'", cbFilter.SelectedItem.ToString(), false);
                else
                    MessageBox.Show("Items Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
