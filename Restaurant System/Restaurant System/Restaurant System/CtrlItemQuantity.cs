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
    public partial class CtrlItemQuantity : UserControl
    {
        ClsItem Item;

        public CtrlItemQuantity()
        {
            InitializeComponent();
        }

        public event Action<int> OnItemRemoved;
        protected virtual void ItemRemoved(int ItemID)
        {
            Action<int> Handler = OnItemRemoved;

            if (Handler != null)
                Handler(ItemID);
        }

        public void LoadItemInfo(int ItemID ,ref bool isItemFound)
        {
            Item = ClsItem.FindByItemID(ItemID);

            if (Item != null)
            {
                if (Item.ImagePath != "")
                    pbItemImage.ImageLocation = Item.ImagePath;

                

                isItemFound = true;
            }
            else
            {
                MessageBox.Show($"Item With ID = {ItemID} Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isItemFound = false;
            }
        }

        private void lblRemove_Click(object sender, EventArgs e)
        {
            if(Item != null)
            {
                if (OnItemRemoved != null)
                    OnItemRemoved(Item.ItemID);
            }
        }
    }
}
