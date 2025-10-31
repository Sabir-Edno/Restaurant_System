using ClsMenuItemBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_System
{
    public partial class FrrItemSelector : Form
    {
        DataTable _dtItems;
        int _SelectedItemID = -1;

        public FrrItemSelector()
        {
            InitializeComponent();
        }

        public FrrItemSelector(int ItemID)
        {
            InitializeComponent();

            _SelectedItemID = ItemID;

            OnItemSelected(_SelectedItemID);
        }

        public delegate void DatabackEventHandler(object sender, int ItemID);
        public DatabackEventHandler DataBack;

        private void _LoadAllItems()
        {
            FLPListItems.Controls.Clear();

            _dtItems = ClsItem.GetMenuItems();

            if (_dtItems.Rows.Count > 0)
            {
                foreach (DataRow item in _dtItems.Rows)
                {
                    CtrlItemIcon ctrlItemIcon = new CtrlItemIcon();

                    ctrlItemIcon.LoadItemInfo(Convert.ToInt32(item["ItemID"]));

                    ctrlItemIcon.OnItemSelected += OnItemSelected;

                    FLPListItems.Controls.Add(ctrlItemIcon);
                }

                lblTotalItems.Text = FLPListItems.Controls.Count.ToString();
            }
            else
                MessageBox.Show("Items Not Found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnItemSelected(int ItemID)
        {
            if (ClsItem.IsItemExistByItemID(ItemID))
            {
                CtrlItemIconSelected.LoadItemInfo(ItemID);
                btnSelect.Enabled = true;
                _SelectedItemID = ItemID;
            }
            else
            {
                btnSelect.Enabled = false;
                _SelectedItemID = -1;
                MessageBox.Show("Item Selected Not Found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrrItemSelector_Load(object sender, EventArgs e)
        {
            btnSelect.Enabled = false;
            _LoadAllItems();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, _SelectedItemID);
            this.Close();
        }

        private void btnReferesh_Click(object sender, EventArgs e)
        {
            _LoadAllItems();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, _SelectedItemID);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            int TotalItems = 0;

            if (string.IsNullOrEmpty(tbSearch.Text.Trim()))
            {
                foreach (var item in FLPListItems.Controls)
                {
                    var Ctrl = (CtrlItemIcon)item;
                    Ctrl.Visible = true;
                }
                lblTotalItems.Text = FLPListItems.Controls.Count.ToString();
                return;
            }


            foreach (var item in FLPListItems.Controls)
            {
                var Ctrl = (CtrlItemIcon)item;
                Ctrl.Visible = Ctrl.IName.ToLower().Contains(tbSearch.Text.Trim().ToLower());
                if(Ctrl.Visible)
                    TotalItems++;
            }
            lblTotalItems.Text = TotalItems.ToString();
            TotalItems = 0;

        }

        private void btnRemoveItemSelected_Click(object sender, EventArgs e)
        {
            CtrlItemIconSelected.ResetItemValues();
            btnSelect.Enabled = false;
            _SelectedItemID = -1;
        }
    }
}
