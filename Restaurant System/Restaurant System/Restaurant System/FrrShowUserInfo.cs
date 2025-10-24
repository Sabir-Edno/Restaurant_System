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
    public partial class FrrShowUserInfo : Form
    {
        int _UserID = -1;

        public FrrShowUserInfo(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void _LoadUserInfo()
        {
            ctrlShowUserInfo1.LoadUserInfo(_UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrrShowUserInfo_Load(object sender, EventArgs e)
        {
            _LoadUserInfo();
        }
    }
}
