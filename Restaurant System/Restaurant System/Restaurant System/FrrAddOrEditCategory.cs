using ClsCategoryBusinessLayer;
using ClsUserBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace Restaurant_System
{
    public partial class FrrAddOrEditCategory : Form
    {
        ClsCategory _Category;
        int _CategoryID = -1;
        enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode = enMode.Update;

        public FrrAddOrEditCategory()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;

        }

        public FrrAddOrEditCategory(int CategoryID)
        {
            InitializeComponent();

            _CategoryID = CategoryID;

            _Mode = enMode.Update;

        }

        private void _LoadCategoryInfo()
        {
            if (_Mode == enMode.AddNew)
            {

                lblTitleMode.Text = "Add New Category";
                _Category = new ClsCategory();
                return;
            }

            _Category = ClsCategory.FindByCategoryID(_CategoryID);

            if (_Category != null)
            {
                lblTitleMode.Text = "Update Category Info";

                lblCategoryID.Text = _Category.CategoryID.ToString();
                tbCategoryName.Text = _Category.CategoryName;
                if (_Category.Description != "")
                    tbDescription.Text = _Category.Description;
                else
                    tbDescription.Text = string.Empty;
                lblCreatedAt.Text = _Category.CreatedAt.ToShortDateString();
                if (_Category.Updated != DateTime.MinValue)
                    lblUpdatedAt.Text = _Category.Updated.ToShortDateString();
                else
                    lblUpdatedAt.Text = "Not Updated Yet";


            }
        }

        private void FrrAddOrEditCategory_Load(object sender, EventArgs e)
        {
            tbCategoryName.MaxLength = 100;
            tbDescription.MaxLength = 255;
            _LoadCategoryInfo();
        }

        private void lblTitleMode_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbCategoryName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbCategoryName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCategoryName, "CategroyName Not Be Empty");
            }
            else
            {
                if (ClsCategory.IsCategoryExistByCategoryName(tbCategoryName.Text.Trim()) && tbCategoryName.Text.Trim() != _Category.CategoryName.Trim())
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbCategoryName, "CategroyName Aleardy Exists");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbCategoryName, null);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields Not Valid/Empty", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Category.CategoryName = tbCategoryName.Text;
            if (!string.IsNullOrEmpty(tbDescription.Text.Trim()))
                _Category.Description = tbDescription.Text;
            else
                _Category.Description = "";

            if (_Mode == enMode.AddNew)
            {
                _Category.CreatedAt = DateTime.Now;
                _Category.Updated = DateTime.MinValue;
            }

            if (_Mode == enMode.AddNew)
            {
                if (_Category.Save())
                {
                    lblCategoryID.Text = _Category.CategoryID.ToString();
                    lblCreatedAt.Text = _Category.CreatedAt.ToString();
                    MessageBox.Show("Category Added Successfully", "Category Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblTitleMode.Text = "Update Category Info";
                }
                else
                {
                    MessageBox.Show("Category Not Added", "Category Not Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _Category.Updated = DateTime.Now;
                lblUpdatedAt.Text = _Category.Updated.ToShortDateString();
                if (_Category.Save())
                {
                    MessageBox.Show("Category Updated Successfully", "Category Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Category Not Updated", "Category Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
