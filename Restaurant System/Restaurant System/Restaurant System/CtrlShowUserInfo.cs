using ClsInvetoryBusinessLayer;
using ClsRoleBusinessLayer;
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
    public partial class CtrlShowUserInfo : UserControl
    {
        ClsUser User;

        public CtrlShowUserInfo()
        {
            InitializeComponent();
        }

        public void ResetValues()
        {
            User = null;
            lblUserID.Text = "???";
            lblFullName.Text = "???";
            lblUsername.Text = "???";
            lblRole.Text = "???";
            lblPhone.Text = "???";
            lblEmail.Text = "???";
            lblStatus.Text = "???";
            lblCreatedAt.Text = "???";
            lblUpdatedAt.Text = "???";
        }

        public void LoadUserInfo(int UserID)
        {
            User = ClsUser.FindByUserID(UserID);

            if (User != null)
            {
                lblUserID.Text = UserID.ToString();
                lblFullName.Text = User.FullName;
                lblUsername.Text = User.Username;
                string RoleName = ClsRole.GetRoleNameByID(User.RoleID);
                if (RoleName != "")
                    lblRole.Text = RoleName;
                else
                {
                    lblRole.Text = User.RoleID.ToString();
                    MessageBox.Show("RoleName Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                lblPhone.Text = User.Phone;
                lblEmail.Text = User.Email;
                if (User.Status)
                    lblStatus.Text = "Active";
                else
                    lblStatus.Text = "InActive";

                lblCreatedAt.Text = User.CreatedAt.ToShortDateString();

                if (User.Updated != DateTime.MinValue)
                    lblUpdatedAt.Text = User.Updated.ToShortDateString();
                else
                    lblUpdatedAt.Text = "Not Updated Yet";
            }
            else
                MessageBox.Show($"User With ID = {UserID} Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void CtrlShowUserInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
