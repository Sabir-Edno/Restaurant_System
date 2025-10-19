using ClsRoleBusinessLayer;
using ClsUserBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using ValidationLibLayer;

namespace Restaurant_System
{
    public partial class FrrAddOrEditUserScreen : Form
    {
        enum enMode { AddNew = 1 , Update = 2 }
        enMode _Mode = enMode.Update;

        ClsUser _User;
        int _UserID = -1;

        public delegate void DataBackEventHandler(object Sender, int AddedUserRoleID);
        public DataBackEventHandler DataBack;

        public FrrAddOrEditUserScreen()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public FrrAddOrEditUserScreen(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;

            _Mode = enMode.Update;
        }
        
        private void _FillCbRoles()
        {
            DataTable _dtRoles = ClsRole.GetRoles();

            if(_dtRoles.Rows.Count > 0)
            {
                foreach (DataRow Role in _dtRoles.Rows)
                {
                    cbRoles.Items.Add(Role["Name"]);
                }
            }
        }

        private void _LoadUserInfo()
        {
            if(_Mode == enMode.AddNew)
            {

                lblTitleMode.Text = "Add New User";
                _User = new ClsUser();
                return;
            }

            _User = ClsUser.FindByUserID(_UserID);

            if(_User != null)
            {
                tbPassword.Visible = false;
                lblPassword.Visible = false;
                lblTitleMode.Text = "Edit User Info";
                lblUserID.Text = _User.UserID.ToString();
                tbUsername.Text = _User.Username;
                tbFullName.Text = _User.FullName;
                tbPhone.Text = _User.Phone;

                if (_User.Email != "")
                    tbEmail.Text = _User.Email;
                else
                    tbEmail.Text = string.Empty;

                cbRoles.SelectedIndex = _User.RoleID;

                if(_User.Status)
                    rbActive.Checked = true;
                else
                    rbInActive.Checked = true;

                lblCreatedAt.Text = _User.CreatedAt.ToShortDateString();

                if(_User.Updated != DateTime.MinValue)
                    lblUpdatedAt.Text = _User.Updated.ToShortDateString();
                else
                    lblUpdatedAt.Text = "Not Updated Yet";
            }
        }

        private void FrrAddOrEditUserScreen_Load(object sender, EventArgs e)
        {
            cbRoles.Items.Add("None");
            cbRoles.SelectedIndex = 0;

            _FillCbRoles();
            _LoadUserInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbUsername.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbUsername, "Username Should Not Be Empty");
            }
            else
            {
                if(ClsUser.IsUserExistByUsername(tbUsername.Text.Trim()) && tbUsername.Text.Trim() != _User.Username)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbUsername, "Username Is Aleardy Exist");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbUsername, null);
                }
            }
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPhone.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPhone, "Phone Should Not Be Empty");
            }
            else
            {
                if (ClsUser.IsUserExistByPhone(tbPhone.Text.Trim()) && tbPhone.Text.Trim() != _User.Phone)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbPhone, "Phone Is Aleardy Exist");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbPhone, null);
                }
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmail.Text.Trim()))
            {
                return;
            }
            else
            {
                if (!ValidationLib.ValidateEmail(tbEmail.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbEmail, "Email Not Valid");
                }
                else
                {
                    if (ClsUser.IsUserExistByEmail(tbEmail.Text.Trim()) && tbEmail.Text.Trim() != _User.Email)
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(tbEmail, "Email Is Aleardy Exist");
                    }
                    else
                    {
                        e.Cancel = false;
                        errorProvider1.SetError(tbEmail, null);
                    }
                }
               
            }
        }

        private void tbFullName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFullName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbFullName, "FullName Should Not Be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbFullName, null);
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPassword, "Password Should Not Be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbPassword, null);
            }
        }

        private void cbRoles_Validating(object sender, CancelEventArgs e)
        {
            if(cbRoles.SelectedItem.ToString() == "None")
            {
                e.Cancel = true;
                errorProvider1.SetError(cbRoles, "Choose The Role");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbRoles, null);
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields Not Valid/Empty", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Username = tbUsername.Text.Trim();
            _User.FullName = tbFullName.Text.Trim();
            _User.Phone = tbPhone.Text.Trim();

            if (!string.IsNullOrEmpty(tbEmail.Text.Trim()))
                _User.Email = tbEmail.Text.Trim();
            else
                _User.Email = "";

            _User.RoleID = cbRoles.SelectedIndex;

            if (rbActive.Checked)
                _User.Status = true;
            else
                _User.Status = false;

            if (_Mode == enMode.AddNew)
            {
                _User.CreatedAt = DateTime.Now;
                _User.Updated = DateTime.MinValue;
                _User.Password = tbPassword.Text.Trim();
            }

            if(_Mode == enMode.AddNew)
            {
                if (_User.Save())
                {
                    lblUserID.Text = _User.UserID.ToString();
                    lblCreatedAt.Text = _User.CreatedAt.ToString();
                    lblTitleMode.Text = "Edit User Info";
                    _Mode = enMode.Update;
                    DataBack?.Invoke(this, _User.RoleID);
                    MessageBox.Show("User Added Successfully", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User Not Added", "User Not Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _User.Updated = DateTime.Now;
                if (_User.Save())
                {
                    DataBack?.Invoke(this, _User.RoleID);
                    MessageBox.Show("User Updated Successfully", "User Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User Not Updated", "User Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
