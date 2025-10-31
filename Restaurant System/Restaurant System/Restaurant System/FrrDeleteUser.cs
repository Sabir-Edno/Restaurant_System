using ClsInvetoryBusinessLayer;
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
    public partial class FrrDeleteUser : Form
    {
        int _UserID = -1;

        public FrrDeleteUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void _LoadUserInfo()
        {
            ClsUser User = ClsUser.FindByUserID(_UserID);

            if (User != null)
            {
                ctrlShowUserInfo1.LoadUserInfo(User.UserID);
                btnDelete.Enabled = true;
            }
            else
                MessageBox.Show($"User With ID = {_UserID} Not Found", "Not Found");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrrDeleteUser_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            _LoadUserInfo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Do You Want To Delete User With ID = {_UserID}", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (!ClsUser.IsUserReferenceToAnyOrderByID(_UserID))
                {
                    if (ClsUser.DeleteUser(_UserID))
                    {
                        MessageBox.Show($"User With ID = {_UserID} Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ctrlShowUserInfo1.ResetValues();
                    }
                    else
                        MessageBox.Show($"User With ID = {_UserID} Not Deleted", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show($"User With ID = {_UserID} [ It has References to rows on Orders go delete them and try again ]", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
