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
    public partial class FrrShowInventoryInfo : Form
    {
        int _InventoryID = -1;

        public FrrShowInventoryInfo(int InventoryID)
        {
            InitializeComponent();

            _InventoryID = InventoryID;
        }

        private void _LoadInventoryInfo()
        {
            ctrlShowInventoryInfo1.LoadInventoryInfo(_InventoryID);
        }

        private void FrrShowInventoryInfo_Load(object sender, EventArgs e)
        {
            _LoadInventoryInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
