using ClsCategoryBusinessLayer;
using ClsInvetoryBusinessLayer;
using ClsMenuItemBusinessLayer;
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
    public partial class CtrlShowItemInfo : UserControl
    {
        ClsItem Item;

        public CtrlShowItemInfo()
        {
            InitializeComponent();
        }

        public void ResetValues()
        {
            Item = null;
            lblItemID.Text = "???";
            lblCategory.Text = "???";
            lblDescription.Text = "???";
            lblPrice.Text = "???";
            lblAvailability.Text = "???";
            pbItemImage.ImageLocation = null;
            lblCreatedAt.Text = "???";
            lblUpdatedAt.Text = "???";
        }

        public void LoadItemInfo(int ItemID)
        {
            Item = ClsItem.FindByItemID(ItemID);

            if (Item != null)
            {
                lblItemID.Text = ItemID.ToString();
                string CategoryName = ClsCategory.GetCategoryNameByID(Item.CategoryID);
                if (CategoryName != "")
                    lblCategory.Text = CategoryName;
                else
                {
                    lblCategory.Text = Item.CategoryID.ToString();
                    MessageBox.Show("Category Naem Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                lblItemName.Text = Item.ItemName;
                if (Item.Description != "")
                    lblDescription.Text = Item.Description;
                else
                    lblDescription.Text = "Not Added Yet";

                lblPrice.Text = Item.Price.ToString();
                if (Item.Availability)
                    lblAvailability.Text = "True";
                else
                    lblAvailability.Text = "False";

                if (Item.ImagePath != "")
                    pbItemImage.ImageLocation = Item.ImagePath;

                lblCreatedAt.Text = Item.CreatedAt.ToShortDateString();

                if (Item.Updated != DateTime.MinValue)
                    lblUpdatedAt.Text = Item.Updated.ToShortDateString();
                else
                    lblUpdatedAt.Text = "Not Updated Yet";
            }
            else
                MessageBox.Show($"Item With ID = {ItemID} Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CtrlShowItemInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
