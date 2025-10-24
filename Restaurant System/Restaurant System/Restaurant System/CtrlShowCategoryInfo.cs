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
    public partial class CtrlShowCategoryInfo : UserControl
    {
        ClsCategory Category;
        
        public CtrlShowCategoryInfo()
        {
            InitializeComponent();
        }

        public void ResetValues()
        {
            Category = null;
            lblCategoryID.Text = "???";
            lblCategoryName.Text = "???";
            lblDescription.Text = "???";
            lblCreatedAt.Text = "???";
            lblUpdatedAt.Text = "???";
        }

        public void LoadCategoryInfo(int CategoryID)
        {
            Category = ClsCategory.FindByCategoryID(CategoryID);

            if (Category != null)
            {
                lblCategoryID.Text = CategoryID.ToString();
                lblCategoryName.Text = Category.CategoryName;
                if (Category.Description != "")
                    lblDescription.Text = Category.Description;
                else
                    lblDescription.Text = "Not Added Yet";
                lblCreatedAt.Text = Category.CreatedAt.ToShortDateString();
                if (Category.Updated != DateTime.MinValue)
                    lblUpdatedAt.Text = Category.Updated.ToShortDateString();
                else
                    lblUpdatedAt.Text = "Not Updated Yet";
            }
            else
                MessageBox.Show($"Category With ID = {CategoryID} Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CtrlShowCategoryInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
