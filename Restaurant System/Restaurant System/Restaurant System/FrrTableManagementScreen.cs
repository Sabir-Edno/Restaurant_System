using ClsTableBusinessLayer;
using ClsUserBusinessLayer;
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
    public partial class FrrTableManagementScreen : Form
    {

        DataTable _dtTables;

        public FrrTableManagementScreen()
        {
            InitializeComponent();
        }

        private void _FillDGVTable()
        {
            cbFilter.Enabled = false;
            tbFilter.Enabled = false;

            _dtTables = ClsTable.GetTables();

            if (_dtTables.Rows.Count > 0)
            {
                cbFilter.Enabled = true;
                tbFilter.Enabled = true;

                DGVTables.DataSource = _dtTables;

                DGVTables.Columns[0].HeaderText = "TableID";
                DGVTables.Columns[0].Width = 120;

                DGVTables.Columns[1].HeaderText = "TableName";
                DGVTables.Columns[1].Width = 180;

                DGVTables.Columns[2].HeaderText = "Capacity";
                DGVTables.Columns[2].Width = 150;

                DGVTables.Columns[3].HeaderText = "Status";
                DGVTables.Columns[3].Width = 150;

                DGVTables.Columns[4].HeaderText = "CreatedAt";
                DGVTables.Columns[4].Width = 150;

                DGVTables.Columns[5].HeaderText = "Update";
                DGVTables.Columns[5].Width = 150;

            }

            lblTotalRecords.Text = _dtTables.Rows.Count.ToString();

        }

        private void FrrTableManagementScreen_Load(object sender, EventArgs e)
        {
            _FillDGVTable();
            cbFilter.Items.Add("None");
            cbFilter.Items.Add("TableID");
            cbFilter.Items.Add("TableName");
            cbFilter.Items.Add("Capacity");
            cbFilter.Items.Add("Status");

            cbFilter.SelectedIndex = 0;
        }

        private void btnAddNewTable_Click(object sender, EventArgs e)
        {
            FrrAddOrEditTableScreen frr = new FrrAddOrEditTableScreen();
            frr.ShowDialog();

            _FillDGVTable();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dtTables.DefaultView.RowFilter = "";
            tbFilter.Text = string.Empty;

            if (cbFilter.SelectedItem.ToString() == "None")
            {
                tbFilter.Visible = false;
                rbAvailable.Visible = false;
                rbOccupied.Visible = false;
                rbReserved.Visible = false;
            }
            else if(cbFilter.SelectedItem.ToString() == "Status")
            {
                tbFilter.Visible = false;
                rbAvailable.Visible = true;
                rbOccupied.Visible = true;
                rbReserved.Visible = true;
                rbAvailable_CheckedChanged(null , null);
            }
            else
            {
                tbFilter.Visible = true;
                rbAvailable.Visible = false;
                rbOccupied.Visible = false;
                rbReserved.Visible = false;
            }

        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedItem.ToString() == "TableID" || cbFilter.SelectedItem.ToString() == "Capacity")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilter.Text.Trim()))
            {
                _dtTables.DefaultView.RowFilter = "";
                return;
            }

            if (_dtTables.Rows.Count > 0)
            {
                if (cbFilter.SelectedItem.ToString() == "TableID" || cbFilter.SelectedItem.ToString() == "Capacity")
                    _dtTables.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilter.SelectedItem.ToString(), tbFilter.Text.Trim());
                else
                    _dtTables.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", cbFilter.SelectedItem.ToString(), tbFilter.Text.Trim());
            }
            else
            {
                MessageBox.Show("Table Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (_dtTables.Rows.Count > 0)
                _dtTables.DefaultView.RowFilter = string.Format("[{0}] = '{1}'", cbFilter.SelectedItem.ToString(), "Available");
            else
                MessageBox.Show("Table Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rbOccupied_CheckedChanged(object sender, EventArgs e)
        {
            if (_dtTables.Rows.Count > 0)
                _dtTables.DefaultView.RowFilter = string.Format("[{0}] = '{1}'", cbFilter.SelectedItem.ToString(), "Occupied");
            else
                MessageBox.Show("Table Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rbReserved_CheckedChanged(object sender, EventArgs e)
        {
            if (_dtTables.Rows.Count > 0)
                _dtTables.DefaultView.RowFilter = string.Format("[{0}] = '{1}'", cbFilter.SelectedItem.ToString(), "Reserved");
            else
                MessageBox.Show("Table Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowTableInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGVTables.RowCount > 0)
            {
                FrrShowTableInfo frr = new FrrShowTableInfo((int)DGVTables.CurrentRow.Cells[0].Value);
                frr.ShowDialog();
            }
        }

        private void AddNewTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrrAddOrEditTableScreen frr = new FrrAddOrEditTableScreen();
            frr.ShowDialog();

            _FillDGVTable();
        }

        private void updateTableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DGVTables.RowCount > 0)
            {
                FrrAddOrEditTableScreen frr = new FrrAddOrEditTableScreen((int)DGVTables.CurrentRow.Cells[0].Value);
                frr.ShowDialog();

                _FillDGVTable();
            }
        }

        private void deleteTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGVTables.RowCount > 0)
            {
                FrrDeleteTable frr = new FrrDeleteTable((int)DGVTables.CurrentRow.Cells[0].Value);
                frr.ShowDialog();

                _FillDGVTable();
            }
        }
    }
}
