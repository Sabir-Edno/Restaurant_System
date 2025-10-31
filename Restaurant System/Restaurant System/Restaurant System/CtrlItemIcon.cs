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
    public partial class CtrlItemIcon : UserControl
    {
        ClsItem Item;

        public CtrlItemIcon()
        {
            InitializeComponent();
        }

        public event Action<int> OnItemSelected;

        public string IName
        {
            get
            {
                return Item.ItemName;
            }
        }

        public void ResetItemValues()
        {
            pbItemImage.ImageLocation = null;
            lblItemName.Text = "???";
        }
        protected virtual void ItemClicked(int ItemID)
        {
            Action<int> Handler = OnItemSelected;

            if(Handler != null)
                Handler(ItemID);
        }
        public void LoadItemInfo(int ItemID)
        {
            Item = ClsItem.FindByItemID(ItemID);

            if (Item != null)
            {
                if (Item.ImagePath != "")
                    pbItemImage.ImageLocation = Item.ImagePath;

                lblItemName.Text = Item.ItemName;
            }
            else
                MessageBox.Show($"Item With ID = {ItemID} Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void CtrlItem_Load(object sender, EventArgs e)
        {

        }

        private void CtrlItemIcon_Click(object sender, EventArgs e)
        {
            if (Item != null)
            {
                if (OnItemSelected != null)
                    OnItemSelected(Item.ItemID);
            }
        }
    }
}
