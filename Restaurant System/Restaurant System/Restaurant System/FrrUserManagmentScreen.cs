using ClsUserBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web.WebSockets;
using System.Windows.Forms;

namespace Restaurant_System
{
    public partial class FrrUserManagmentScreen : Form
    {
        DataTable _dtAdmins;
        DataTable _dtWaiters;
        DataTable _dtChefs;
        DataTable _dtManagers;

        enum UserRole { Admin = 1, Waiter = 2, Chef = 3, Manager = 4 }
        UserRole _UserRole;

        public FrrUserManagmentScreen()
        {
            InitializeComponent();
        }

        private void _FillDGVAdmins()
        {
            _UserRole = UserRole.Admin;

            pbVisibleIconAdmins.Visible = true;
            pbVisibleIconChefs.Visible = false;
            pbVisibleIconManagers.Visible = false;
            pbVisibleIconWaiters.Visible = false;

            _dtAdmins = ClsUser.GetAllAdmins();

            if(_dtAdmins.Rows.Count > 0)
            {
                DGVUsers.DataSource = _dtAdmins;

                DGVUsers.Columns[0].HeaderText = "UserID";
                DGVUsers.Columns[0].Width = 120;

                DGVUsers.Columns[1].HeaderText = "FullName";
                DGVUsers.Columns[1].Width = 180;

                DGVUsers.Columns[2].HeaderText = "Username";
                DGVUsers.Columns[2].Width = 150;

                DGVUsers.Columns[3].HeaderText = "RoleID";
                DGVUsers.Columns[3].Width = 120;

                DGVUsers.Columns[4].HeaderText = "Phone";
                DGVUsers.Columns[4].Width = 150;

                DGVUsers.Columns[5].HeaderText = "Email";
                DGVUsers.Columns[5].Width = 150;

                DGVUsers.Columns[6].HeaderText = "Status";
                DGVUsers.Columns[6].Width = 120;

                DGVUsers.Columns[7].HeaderText = "CreatedAt";
                DGVUsers.Columns[7].Width = 150;

                DGVUsers.Columns[8].HeaderText = "Update";
                DGVUsers.Columns[8].Width = 150;

                cbFilter.SelectedItem = "None";
                cbFilter.Enabled = true;
            }

            lblTotalRecords.Text = _dtAdmins.Rows.Count.ToString();

            if (_dtAdmins.Rows.Count <= 0)
            {
                pbVisibleIconChefs.Visible = false;
                pbVisibleIconManagers.Visible = false;
                pbVisibleIconWaiters.Visible = false;
                cbFilter.SelectedItem = "None";
                cbFilter.Enabled = false;
                DGVUsers.DataSource = null;
            }
        }
        private void _FillDGVWaiters()
        {
            _UserRole = UserRole.Waiter;

            pbVisibleIconWaiters.Visible = true;
            pbVisibleIconAdmins.Visible = false;
            pbVisibleIconChefs.Visible = false;
            pbVisibleIconManagers.Visible = false;

            _dtWaiters = ClsUser.GetAllWaiters();

            if (_dtWaiters.Rows.Count > 0)
            {
                DGVUsers.DataSource = _dtWaiters;

                DGVUsers.Columns[0].HeaderText = "UserID";
                DGVUsers.Columns[0].Width = 120;

                DGVUsers.Columns[1].HeaderText = "FullName";
                DGVUsers.Columns[1].Width = 180;

                DGVUsers.Columns[2].HeaderText = "Username";
                DGVUsers.Columns[2].Width = 150;

                DGVUsers.Columns[3].HeaderText = "RoleID";
                DGVUsers.Columns[3].Width = 120;

                DGVUsers.Columns[4].HeaderText = "Phone";
                DGVUsers.Columns[4].Width = 150;

                DGVUsers.Columns[5].HeaderText = "Email";
                DGVUsers.Columns[5].Width = 150;

                DGVUsers.Columns[6].HeaderText = "Status";
                DGVUsers.Columns[6].Width = 120;

                DGVUsers.Columns[7].HeaderText = "CreatedAt";
                DGVUsers.Columns[7].Width = 150;

                DGVUsers.Columns[8].HeaderText = "Update";
                DGVUsers.Columns[8].Width = 150;

                cbFilter.SelectedItem = "None";
                cbFilter.Enabled = true;
            }

            lblTotalRecords.Text = _dtWaiters.Rows.Count.ToString();

            if (_dtWaiters.Rows.Count <= 0)
            {
                pbVisibleIconAdmins.Visible = false;
                pbVisibleIconChefs.Visible = false;
                pbVisibleIconManagers.Visible = false;
                cbFilter.SelectedItem = "None";
                cbFilter.Enabled = false;
                DGVUsers.DataSource = null;

            }
        }
        private void _FillDGVManagers()
        {
            _UserRole = UserRole.Manager;

            pbVisibleIconAdmins.Visible = false;
            pbVisibleIconChefs.Visible = false;
            pbVisibleIconManagers.Visible = true;
            pbVisibleIconWaiters.Visible = false;

            _dtManagers = ClsUser.GetAllManagers();

            if (_dtManagers.Rows.Count > 0)
            {
                DGVUsers.DataSource = _dtManagers;

                DGVUsers.Columns[0].HeaderText = "UserID";
                DGVUsers.Columns[0].Width = 120;

                DGVUsers.Columns[1].HeaderText = "FullName";
                DGVUsers.Columns[1].Width = 180;

                DGVUsers.Columns[2].HeaderText = "Username";
                DGVUsers.Columns[2].Width = 150;

                DGVUsers.Columns[3].HeaderText = "RoleID";
                DGVUsers.Columns[3].Width = 120;

                DGVUsers.Columns[4].HeaderText = "Phone";
                DGVUsers.Columns[4].Width = 150;

                DGVUsers.Columns[5].HeaderText = "Email";
                DGVUsers.Columns[5].Width = 150;

                DGVUsers.Columns[6].HeaderText = "Status";
                DGVUsers.Columns[6].Width = 120;

                DGVUsers.Columns[7].HeaderText = "CreatedAt";
                DGVUsers.Columns[7].Width = 150;

                DGVUsers.Columns[8].HeaderText = "Update";
                DGVUsers.Columns[8].Width = 150;

                cbFilter.SelectedItem = "None";
                cbFilter.Enabled = true;
            }

            lblTotalRecords.Text = _dtManagers.Rows.Count.ToString();

            if (_dtManagers.Rows.Count <= 0)
            {
                pbVisibleIconAdmins.Visible = false;
                pbVisibleIconChefs.Visible = false;
                pbVisibleIconWaiters.Visible = false;
                cbFilter.SelectedItem = "None";
                cbFilter.Enabled = false;
                DGVUsers.DataSource = null;
            }
        }
        private void _FillDGVChefs()
        {
            _UserRole = UserRole.Chef;

            pbVisibleIconAdmins.Visible = false;
            pbVisibleIconChefs.Visible = true;
            pbVisibleIconManagers.Visible = false;
            pbVisibleIconWaiters.Visible = false;

            _dtChefs = ClsUser.GetAllChefs();

            if (_dtChefs.Rows.Count > 0)
            {
                DGVUsers.DataSource = _dtChefs;

                DGVUsers.Columns[0].HeaderText = "UserID";
                DGVUsers.Columns[0].Width = 120;

                DGVUsers.Columns[1].HeaderText = "FullName";
                DGVUsers.Columns[1].Width = 180;

                DGVUsers.Columns[2].HeaderText = "Username";
                DGVUsers.Columns[2].Width = 150;

                DGVUsers.Columns[3].HeaderText = "RoleID";
                DGVUsers.Columns[3].Width = 120;

                DGVUsers.Columns[4].HeaderText = "Phone";
                DGVUsers.Columns[4].Width = 150;

                DGVUsers.Columns[5].HeaderText = "Email";
                DGVUsers.Columns[5].Width = 150;

                DGVUsers.Columns[6].HeaderText = "Status";
                DGVUsers.Columns[6].Width = 120;

                DGVUsers.Columns[7].HeaderText = "CreatedAt";
                DGVUsers.Columns[7].Width = 150;

                DGVUsers.Columns[8].HeaderText = "Update";
                DGVUsers.Columns[8].Width = 150;

                cbFilter.SelectedItem = "None";
                cbFilter.Enabled = true;
            }

            lblTotalRecords.Text = _dtChefs.Rows.Count.ToString();

            if(_dtChefs.Rows.Count <= 0)
            {
                pbVisibleIconAdmins.Visible = false;
                pbVisibleIconManagers.Visible = false;
                pbVisibleIconWaiters.Visible = false;
                cbFilter.SelectedItem = "None";
                cbFilter.Enabled = false;
                DGVUsers.DataSource = null;
            }
        }

        private void FrrUserManagmentScreen_Load(object sender, EventArgs e)
        {
            cbFilter.Items.Add("None");
            cbFilter.Items.Add("UserID");
            cbFilter.Items.Add("Username");
            cbFilter.Items.Add("FullName");
            cbFilter.Items.Add("Phone");
            cbFilter.Items.Add("Email");
            cbFilter.Items.Add("Status");

            cbFilter.SelectedIndex = 0;

            cbFilter.Enabled = false;
        }

        private void btnAdmins_Click(object sender, EventArgs e)
        {
            _FillDGVAdmins();
        }

        private void btnWaiters_Click(object sender, EventArgs e)
        {
            _FillDGVWaiters();
        }

        private void btnChefs_Click(object sender, EventArgs e)
        {
            _FillDGVChefs();
        }

        private void btnManagers_Click(object sender, EventArgs e)
        {
            _FillDGVManagers();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (_UserRole == UserRole.Admin)
                _dtAdmins.DefaultView.RowFilter = "";
            else if(_UserRole == UserRole.Waiter)
                _dtWaiters.DefaultView.RowFilter = "";
            else if (_UserRole == UserRole.Chef)
                _dtChefs.DefaultView.RowFilter = "";
            else if (_UserRole == UserRole.Manager)
                _dtManagers.DefaultView.RowFilter = "";

            tbFilter.Text = string.Empty;

            if (cbFilter.SelectedItem.ToString() == "None")
            {
                tbFilter.Visible = false;
                rbActive.Visible = false;
                rbInActive.Visible = false;
            }
            else if (cbFilter.SelectedItem.ToString() == "Status")
            {
                tbFilter.Visible = false;
                rbActive.Visible = true;
                rbInActive.Visible = true;
                rbActive.Checked = true;
                rbActive_CheckedChanged(null, null);
            }
            else
            {
                tbFilter.Visible = true;
                rbActive.Visible = false;
                rbInActive.Visible = false;
            }
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedItem.ToString() == "UserID" || cbFilter.SelectedItem.ToString() == "Phone")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AdminFiltering()
        {
            if (string.IsNullOrEmpty(tbFilter.Text.Trim()))
            {
                _dtAdmins.DefaultView.RowFilter = "";
                return;
            }

            if (_dtAdmins.Rows.Count > 0)
            {
                if (cbFilter.SelectedItem.ToString() == "UserID")
                    _dtAdmins.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilter.SelectedItem.ToString(), tbFilter.Text.Trim());
                else
                    _dtAdmins.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", cbFilter.SelectedItem.ToString(), tbFilter.Text.Trim());
            }
            else
            {
                MessageBox.Show("Admins Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void WaiterFiltering()
        {
            if (string.IsNullOrEmpty(tbFilter.Text.Trim()))
            {
                _dtWaiters.DefaultView.RowFilter = "";
                return;
            }

            if (_dtWaiters.Rows.Count > 0)
            {
                if (cbFilter.SelectedItem.ToString() == "UserID")
                    _dtWaiters.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilter.SelectedItem.ToString(), tbFilter.Text.Trim());
                else
                    _dtWaiters.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", cbFilter.SelectedItem.ToString(), tbFilter.Text.Trim());
            }
            else
            {
                MessageBox.Show("Waiter Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ChefFiltering()
        {
            if (string.IsNullOrEmpty(tbFilter.Text.Trim()))
            {
                _dtChefs.DefaultView.RowFilter = "";
                return;
            }

            if (_dtChefs.Rows.Count > 0)
            {
                if (cbFilter.SelectedItem.ToString() == "UserID")
                    _dtChefs.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilter.SelectedItem.ToString(), tbFilter.Text.Trim());
                else
                    _dtChefs.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", cbFilter.SelectedItem.ToString(), tbFilter.Text.Trim());
            }
            else
            {
                MessageBox.Show("Waiter Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ManagerFiltering()
        {
            if (string.IsNullOrEmpty(tbFilter.Text.Trim()))
            {
                _dtManagers.DefaultView.RowFilter = "";
                return;
            }

            if (_dtManagers.Rows.Count > 0)
            {
                if (cbFilter.SelectedItem.ToString() == "UserID")
                    _dtManagers.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilter.SelectedItem.ToString(), tbFilter.Text.Trim());
                else
                    _dtManagers.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", cbFilter.SelectedItem.ToString(), tbFilter.Text.Trim());
            }
            else
            {
                MessageBox.Show("Waiter Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
           switch(_UserRole)
           {
                case UserRole.Admin:
                    AdminFiltering();
                    break;

                case UserRole.Waiter:
                    WaiterFiltering();
                    break;

                case UserRole.Chef:
                    ChefFiltering();
                    break;

                case UserRole.Manager:
                    ManagerFiltering();
                    break;
            }
        }

        private void AdminStatusActiveFilter()
        {
            _dtAdmins.DefaultView.RowFilter = "";

            if (rbActive.Checked)
            {
                if (_dtAdmins.Rows.Count > 0)
                    _dtAdmins.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilter.SelectedItem.ToString(), 1);
                else
                    MessageBox.Show("Admins Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void WaiterStatusActiveFilter()
        {
            _dtWaiters.DefaultView.RowFilter = "";

            if (rbActive.Checked)
            {
                if (_dtWaiters.Rows.Count > 0)
                    _dtWaiters.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilter.SelectedItem.ToString(), 1);
                else
                    MessageBox.Show("Waiters Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ChefStatusActiveFilter()
        {
            _dtChefs.DefaultView.RowFilter = "";

            if (rbActive.Checked)
            {

                if (_dtChefs.Rows.Count > 0)
                    _dtChefs.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilter.SelectedItem.ToString(), 1);
                else
                    MessageBox.Show("Chefs Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ManagerStatusActiveFilter()
        {
            _dtManagers.DefaultView.RowFilter = "";

            if (rbActive.Checked)
            {
                if (_dtManagers.Rows.Count > 0)
                    _dtManagers.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilter.SelectedItem.ToString(), 1);
                else
                    MessageBox.Show("Managers Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UserStatusActiveFilter()
        {
            switch (_UserRole)
            {
                case UserRole.Admin:
                    AdminStatusActiveFilter();
                    break;

                case UserRole.Waiter:
                    WaiterStatusActiveFilter();
                    break;

                case UserRole.Chef:
                    ChefStatusActiveFilter();
                    break;

                case UserRole.Manager:
                    ManagerStatusActiveFilter();
                    break;

            }

        }
        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {
            UserStatusActiveFilter();
        }

        private void AdminStatusInActiveFilter()
        {
            _dtAdmins.DefaultView.RowFilter = "";

            if (rbInActive.Checked)
            {
                if (_dtAdmins.Rows.Count > 0)
                    _dtAdmins.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilter.SelectedItem.ToString(), 0);
                else
                    MessageBox.Show("Admins Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void WaiterStatusInActiveFilter()
        {
            _dtWaiters.DefaultView.RowFilter = "";

            if (rbInActive.Checked)
            {
                if (_dtWaiters.Rows.Count > 0)
                    _dtWaiters.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilter.SelectedItem.ToString(), 0);
                else
                    MessageBox.Show("Waiters Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ChefStatusInActiveFilter()
        {
            _dtChefs.DefaultView.RowFilter = "";

            if (rbInActive.Checked)
            {
                if (_dtChefs.Rows.Count > 0)
                    _dtChefs.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilter.SelectedItem.ToString(), 0);
                else
                    MessageBox.Show("Chefs Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ManagerStatusInActiveFilter()
        {
            _dtManagers.DefaultView.RowFilter = "";

            if (rbInActive.Checked)
            {
                if (_dtManagers.Rows.Count > 0)
                    _dtManagers.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilter.SelectedItem.ToString(), 0);
                else
                    MessageBox.Show("Managers Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UserStatusInActiveFilter()
        {
            switch (_UserRole)
            {
                case UserRole.Admin:
                    AdminStatusInActiveFilter();
                    break;

                case UserRole.Waiter:
                    WaiterStatusInActiveFilter();
                    break;

                case UserRole.Chef:
                    ChefStatusInActiveFilter();
                    break;

                case UserRole.Manager:
                    ManagerStatusInActiveFilter();
                    break;

            }

        }
        private void rbInActive_CheckedChanged(object sender, EventArgs e)
        {
            UserStatusInActiveFilter();
        }

        private void RefreshDGVBasedOnRoleID(object Sender , int RoleID)
        {
            switch(RoleID)
            {
                case 1:
                    _FillDGVAdmins();
                    break;

                case 2:
                    _FillDGVWaiters();
                    break;

                case 3:
                    _FillDGVChefs();
                    break;

                case 4:
                    _FillDGVManagers();
                    break;
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            FrrAddOrEditUserScreen frr = new FrrAddOrEditUserScreen();

            frr.DataBack += RefreshDGVBasedOnRoleID;

            frr.ShowDialog();
            
        }

        private void ShowUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGVUsers.RowCount > 0)
            {
                FrrShowUserInfo frr = new FrrShowUserInfo((int)DGVUsers.CurrentRow.Cells[0].Value);
                frr.ShowDialog();
            }
        }

        private void AddNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrrAddOrEditUserScreen frr = new FrrAddOrEditUserScreen();

            frr.DataBack += RefreshDGVBasedOnRoleID;

            frr.ShowDialog();
        }

        private void updateUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DGVUsers.RowCount > 0)
            {
                FrrAddOrEditUserScreen frr = new FrrAddOrEditUserScreen((int)DGVUsers.CurrentRow.Cells[0].Value);

                frr.DataBack += RefreshDGVBasedOnRoleID;

                frr.ShowDialog();
            }
        }

        private void RefereshBasedOnUserRole()
        {
            switch (_UserRole)
            {
                case UserRole.Admin:
                    _FillDGVAdmins();
                    break;

                case UserRole.Waiter:
                    _FillDGVWaiters();
                    break;

                case UserRole.Chef:
                    _FillDGVChefs();
                    break;

                case UserRole.Manager:
                    _FillDGVManagers();
                    break;
            }
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGVUsers.RowCount > 0)
            {
                FrrDeleteUser frr = new FrrDeleteUser((int)DGVUsers.CurrentRow.Cells[0].Value);
                frr.ShowDialog();
                RefereshBasedOnUserRole();
            }
        }
    }
}
