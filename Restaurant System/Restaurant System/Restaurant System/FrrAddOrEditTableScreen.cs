using ClsCategoryBusinessLayer;
using ClsTableBusinessLayer;
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
    public partial class FrrAddOrEditTableScreen : Form
    {
        ClsTable _Table;
        int _TableID = -1;
        enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode = enMode.Update;

        public FrrAddOrEditTableScreen()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public FrrAddOrEditTableScreen(int TableID)
        {
            InitializeComponent();

            _TableID = TableID;
            _Mode = enMode.AddNew;
        }

        private void _FillCbStatus()
        {
            cbStatus.Items.Add("Available");
            cbStatus.Items.Add("Occupied");
            cbStatus.Items.Add("Reserved");

            cbStatus.SelectedIndex = 0;
        }

        private void _LoadTableInfo()
        {
            if (_Mode == enMode.AddNew)
            {

                lblTitleMode.Text = "Add New Table";
                _Table = new ClsTable();
                return;
            }

            _Table = ClsTable.FindByTableID(_TableID);

            if (_Table != null)
            {
                lblTitleMode.Text = "Update Table Info";

                lblTableID.Text = _Table.TableID.ToString();
                tbTableName.Text = _Table.TableName;
                tbCapacity.Text = _Table.Capacity.ToString();
                cbStatus.SelectedItem = _Table.Status;
                lblCreatedAt.Text = _Table.CreatedAt.ToShortDateString();

                if (_Table.Updated != DateTime.MinValue)
                    lblUpdatedAt.Text = _Table.Updated.ToShortDateString();
                else
                    lblUpdatedAt.Text = "Not Adding Yet";


            }
        }

        private void FrrAddOrEditTableScreen_Load(object sender, EventArgs e)
        {
            _FillCbStatus();
            _LoadTableInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbTableName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTableName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbTableName, "TableName Not Be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbTableName, null);
            }
        }

        private void tbCapacity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCapacity.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCapacity, "Capacity Not Be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbCapacity, null);
            }
        }

        private void tbCapacity_KeyPress(object sender, KeyPressEventArgs e)
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

            _Table.TableName = tbTableName.Text;
            _Table.Capacity = Convert.ToInt32(tbCapacity.Text);
            _Table.Status = cbStatus.SelectedItem.ToString();
            _Table.CreatedAt = DateTime.Now;

            if (_Mode == enMode.AddNew)
            {
                if (_Table.Save())
                {
                    lblTableID.Text = _Table.TableID.ToString();
                    lblCreatedAt.Text = _Table.CreatedAt.ToString();
                    MessageBox.Show("Table Added Successfully", "Table Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Table Not Added", "Table Not Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _Table.Updated = DateTime.Now;
                if (_Table.Save())
                {

                    MessageBox.Show("Table Updated Successfully", "Table Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Table Not Updated", "Table Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
