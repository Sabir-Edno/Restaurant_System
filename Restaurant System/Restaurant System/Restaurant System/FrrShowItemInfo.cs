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
    public partial class FrrShowItemInfo : Form
    {
        int _ItemID = -1;

        public FrrShowItemInfo(int ItemID)
        {
            InitializeComponent();

            _ItemID = ItemID;
        }

        private void _LoadItemInfo()
        {
            ctrlShowItemInfo1.LoadItemInfo(_ItemID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrrShowItemInfo_Load(object sender, EventArgs e)
        {
            _LoadItemInfo();
        }
    }
}
