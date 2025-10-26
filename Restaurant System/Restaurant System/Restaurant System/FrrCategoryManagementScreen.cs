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
    public partial class FrrCategoryManagementScreen : Form
    {
        DataTable _dtCategories;

        public FrrCategoryManagementScreen()
        {
            InitializeComponent();
        }

        private void _FillDGVCategories()
        {
            cbFilter.Enabled = false;
            tbFilter.Enabled = false;

            _dtCategories = ClsCategory.GetCategories();

            if (_dtCategories.Rows.Count > 0)
            {

                DGVCategories.DataSource = _dtCategories;

                DGVCategories.Columns[0].HeaderText = "CategoryID";
                DGVCategories.Columns[0].Width = 120;

                DGVCategories.Columns[1].HeaderText = "CategoryName";
                DGVCategories.Columns[1].Width = 120;

                DGVCategories.Columns[2].HeaderText = "Description";
                DGVCategories.Columns[2].Width = 180;

                DGVCategories.Columns[3].HeaderText = "CreatedAt";
                DGVCategories.Columns[3].Width = 150;

                DGVCategories.Columns[4].HeaderText = "UpdateAt";
                DGVCategories.Columns[4].Width = 150;

                cbFilter.Enabled = true;
                tbFilter.Enabled = true;

            }

            lblTotalRecords.Text = _dtCategories.Rows.Count.ToString();

        }

        private void FrrCategoryManagementScreen_Load(object sender, EventArgs e)
        {
            tbFilter.Visible = false;
            _FillDGVCategories();
            cbFilter.Items.Add("None");
            cbFilter.Items.Add("CategoryID");
            cbFilter.Items.Add("CategoryName");

            cbFilter.SelectedIndex = 0;
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            FrrAddOrEditCategory frr = new FrrAddOrEditCategory();
            frr.ShowDialog();

            _FillDGVCategories();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dtCategories.DefaultView.RowFilter = "";
            tbFilter.Text = string.Empty;

            if (cbFilter.SelectedItem.ToString() == "None")
                tbFilter.Visible = false;
            else
                tbFilter.Visible = true;
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilter.Text.Trim()))
            {
                _dtCategories.DefaultView.RowFilter = "";
                return;
            }

            if (_dtCategories.Rows.Count > 0)
            {
                if (cbFilter.SelectedItem.ToString() == "CategoryID")
                    _dtCategories.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilter.SelectedItem.ToString(), tbFilter.Text.Trim());
                else
                    _dtCategories.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", cbFilter.SelectedItem.ToString(), tbFilter.Text.Trim());
            }
            else
            {
                MessageBox.Show("Category Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedItem.ToString() == "CategoryID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AddNewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrrAddOrEditCategory frr = new FrrAddOrEditCategory();
            frr.ShowDialog();

            _FillDGVCategories();
        }

        private void updateUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DGVCategories.Rows.Count > 0)
            {
                FrrAddOrEditCategory frr = new FrrAddOrEditCategory((int)DGVCategories.CurrentRow.Cells[0].Value);
                frr.ShowDialog();

                _FillDGVCategories();
            }
        }

        private void ShowCategoryInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGVCategories.Rows.Count > 0)
            {
                FrrShowCategoryInfo frr = new FrrShowCategoryInfo((int)DGVCategories.CurrentRow.Cells[0].Value);
                frr.ShowDialog();
            }

        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGVCategories.Rows.Count > 0)
            {
                FrrDeleteCategory frr = new FrrDeleteCategory((int)DGVCategories.CurrentRow.Cells[0].Value);
                frr.ShowDialog();

                _FillDGVCategories();
            }
        }
    }
}
