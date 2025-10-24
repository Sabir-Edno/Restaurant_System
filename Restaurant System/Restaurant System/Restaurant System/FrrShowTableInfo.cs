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
    public partial class FrrShowTableInfo : Form
    {
        int _TalbeID = -1;

        public FrrShowTableInfo(int TableID)
        {
            InitializeComponent();

            _TalbeID = TableID;
        }

        private void _LoadTableInfo()
        {
            ctrlShowTableInfo1.LoadTableInfo(_TalbeID);
        }

        private void FrrShowTableInfo_Load(object sender, EventArgs e)
        {
            _LoadTableInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
