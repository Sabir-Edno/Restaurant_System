using ClsCategoryBusinessLayer;
using ClsMenuItemBusinessLayer;
using ClsRoleBusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using UtilLibLayer;

namespace Restaurant_System
{
    public partial class FrrAddOrEditItem : Form
    {
        ClsItem _Item;
        int _ItemID = -1;
        enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode = enMode.Update;

        public FrrAddOrEditItem()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public FrrAddOrEditItem(int ItemID)
        {
            InitializeComponent();

            _ItemID = ItemID;

            _Mode = enMode.Update;
        }

        private void _FillCbCategories()
        {
            DataTable _dtCategories = ClsCategory.GetCategories();

            if (_dtCategories.Rows.Count > 0)
            {
                foreach (DataRow Role in _dtCategories.Rows)
                {
                    cbCategories.Items.Add(Role["CategoryName"]);
                    cbCategories.SelectedIndex = 0;
                }
            }
        }

        private void _LoadItemInfo()
        {
            if (_Mode == enMode.AddNew)
            {

                lblTitleMode.Text = "Add New Item";
                _Item = new ClsItem();
                btnRemove.Enabled = false;
                return;
            }

            _Item = ClsItem.FindByItemID(_ItemID);

            if (_Item != null)
            {
                lblTitleMode.Text = "Update Item Info";

                lblItemID.Text = _Item.ItemID.ToString(); 
                cbCategories.SelectedIndex = _Item.CategoryID - 1;
                tbItemName.Text = _Item.ItemName.ToString();
                tbPrice.Text = _Item.Price.ToString();
                if (_Item.Description != "")
                    tbDescription.Text = _Item.Description;
                else
                    tbDescription.Text = "Not Adding Yet";
                if (_Item.Availability)
                    rbActive.Checked = true;
                else
                    rbInActive.Checked = false;

                lblCreatedAt.Text = _Item.CreatedAt.ToShortDateString();

                if (_Item.Updated != DateTime.MinValue)
                    lblUpdatedAt.Text = _Item.Updated.ToShortDateString();
                else
                    lblUpdatedAt.Text = "Not Updated Yet";

                if (_Item.ImagePath != "")
                {
                    pbItemImage.ImageLocation = _Item.ImagePath;
                    btnRemove.Enabled = true;
                }
                else
                {
                    pbItemImage.ImageLocation = null;
                    btnRemove.Enabled = false;
                }

            }
        }

        private void FrrAddOrEditItem_Load(object sender, EventArgs e)
        {
            _FillCbCategories();
            _LoadItemInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbItemName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbItemName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbItemName, "ItemName Not Be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbItemName, null);
            }
        }

        private void tbDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbDescription.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbDescription, "Description Not Be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbDescription, null);
            }
        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPrice.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPrice, "Price Not Be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbPrice, null);
            }
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pbItemImage.ImageLocation = null;

            btnRemove.Enabled = false;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Select a Image";
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = @"C:\";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                btnRemove.Enabled = true;
            }
        }

        private bool _HandleItemImage()
        {
            if (_Item.ImagePath != pbItemImage.ImageLocation)
            {
                if (_Mode == enMode.Update)
                {
                    if (_Item.ImagePath != null)
                    {

                        try
                        {
                            File.Delete(_Item.ImagePath);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Error : Image Not Deleted From File Error Message : " + e.Message);
                        }
                    }
                }

                if (pbItemImage.ImageLocation != null)
                {
                    string SourceImageFile = pbItemImage.ImageLocation.ToString();
                    if (MyUtilLib.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbItemImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image , Error ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields Not Valid/Empty", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_HandleItemImage())
                return;

            _Item.ItemName = tbItemName.Text;
            _Item.CategoryID = cbCategories.SelectedIndex + 1;
            _Item.ItemName = tbItemName.Text;
            if (!string.IsNullOrEmpty(tbDescription.Text.Trim()))
                _Item.Description = tbDescription.Text;
            else
                _Item.Description = "Not Adding Yet";
            _Item.Price = Convert.ToInt32(tbPrice.Text);

            if (rbActive.Checked)
                _Item.Availability = true;
            else
                _Item.Availability = false;

            if (pbItemImage.ImageLocation != null)
                _Item.ImagePath = pbItemImage.ImageLocation;
            else
                _Item.ImagePath = "";

            _Item.CreatedAt = DateTime.Now;

            if (_Mode == enMode.AddNew)
            {
                if (_Item.Save())
                {
                    lblItemID.Text = _Item.ItemID.ToString();
                    MessageBox.Show("Item Added Successfully", "Item Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Item Not Added", "Item Not Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _Item.Updated = DateTime.Now;
                if (_Item.Save())
                {

                    MessageBox.Show("Item Updated Successfully", "Item Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Item Not Updated", "Item Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
