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
using System.IO;

namespace Restaurant_System
{
    public partial class FrrDeleteItem : Form
    {
        int _ItemID = -1;
        ClsItem Item;

        public FrrDeleteItem(int ItemID)
        {
            InitializeComponent();

            _ItemID = ItemID;
        }

        private void _LoadItemInfo()
        {
            Item = ClsItem.FindByItemID(_ItemID);

            if (Item != null)
            {
                ctrlShowItemInfo1.LoadItemInfo(Item.ItemID);
                btnDelete.Enabled = true;
            }
            else
                MessageBox.Show($"Item With ID = {_ItemID} Not Found", "Not Found");
        }

        private void FrrDeleteItem_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            _LoadItemInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Do You Want To Delete Item With ID = {_ItemID}", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (!ClsItem.IsItemReferenceToAnyOrderDetailByID(_ItemID))
                {
                    if (ClsItem.DeleteItem(_ItemID))
                    {
                        MessageBox.Show($"Item With ID = {_ItemID} Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ctrlShowItemInfo1.ResetValues();

                        if (Item.ImagePath != "")
                        {
                            try
                            {
                                File.Delete(Item.ImagePath);
                            }
                            catch
                            {
                                MessageBox.Show("Error : To Delete Image Item After Deleted Item");
                            }
                        }
                    }
                    else
                        MessageBox.Show($"Item With ID = {_ItemID} Not Deleted", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show($"Item With ID = {_ItemID} [ It has References to rows on OrderDetails go delete them and try again ]", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
