using ClsCategoryBusinessLayer;
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
    public partial class FrrShowCategoryInfo : Form
    {
        int _CategoryID = -1;

        public FrrShowCategoryInfo(int CategoryID)
        {
            InitializeComponent();

            _CategoryID = CategoryID;
        }

        private void _LoadCategoryInfo()
        {
            ctrlShowCategoryInfo1.LoadCategoryInfo(_CategoryID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrrShowCategoryInfo_Load(object sender, EventArgs e)
        {
            _LoadCategoryInfo();
        }
    }
}
