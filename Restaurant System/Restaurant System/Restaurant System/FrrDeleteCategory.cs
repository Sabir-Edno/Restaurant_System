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
    public partial class FrrDeleteCategory : Form
    {
        int _CategoryID = -1;

        public FrrDeleteCategory(int CategoryID)
        {
            InitializeComponent();

            _CategoryID = CategoryID;
        }

        private void _LoadCategoryInfo()
        {
            ClsCategory Category = ClsCategory.FindByCategoryID(_CategoryID);

            if (Category != null)
            {
                ctrlShowCategoryInfo1.LoadCategoryInfo(Category.CategoryID);
                btnDelete.Enabled = true;
            }
            else
                MessageBox.Show($"Category With ID = {_CategoryID} Not Found", "Not Found");
        }

        private void FrrDeleteCategory_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            _LoadCategoryInfo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Are You Do You Want To Delete Category With ID = {_CategoryID}" , "Confirm" , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(!ClsCategory.IsCategoryReferenceToAnyItemByID(_CategoryID))
                {
                    if (ClsCategory.DeleteCategory(_CategoryID))
                        MessageBox.Show($"Category With ID = {_CategoryID} Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show($"Category With ID = {_CategoryID} Not Deleted", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show($"Category With ID = {_CategoryID} [ It has References to row on MenuItems go delete them and try again ]", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
