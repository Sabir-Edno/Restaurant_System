using ClsMenuDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsItemBusinessLayer
{
    public class ClsItem
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int ItemID { set; get; }
        public decimal Price { set; get; }
        public bool Available { set; get; }
        public int CategoryID { set; get; }

        public ClsItem()
        {
            this.ItemID = -1;
            this.Price = -1;
            this.Available = false;
            this.CategoryID = -1;
            Mode = enMode.AddNew;
        }
        private ClsItem(int ItemID, decimal Price, bool Available, int CategoryID)
        {
            this.ItemID = ItemID;
            this.Price = Price;
            this.Available = Available;
            this.CategoryID = CategoryID;
            Mode = enMode.Update;
        }
        private bool _AddNewItem()
        {
            this.ItemID = (int)ClsItemData.AddNewItem(this.Price, this.Available, this.CategoryID);
            return (this.ItemID != -1);
        }
        private bool _UpdateItem()
        {
            return ClsItemData.UpdateItem(this.ItemID, this.Price, this.Available, this.CategoryID);
        }
        public static bool DeleteItem(int ItemID)
        {
            return ClsItemData.DeleteItem(ItemID);
        }
        public static bool IsItemExistByItemID(int ItemID)
        {
            return ClsItemData.IsItemExistByItemID(ItemID);
        }
        public static bool IsItemExistByPrice(decimal Price)
        {
            return ClsItemData.IsItemExistByPrice(Price);
        }
        public static bool IsItemExistByAvailable(bool Available)
        {
            return ClsItemData.IsItemExistByAvailable(Available);
        }
        public static bool IsItemExistByCategoryID(int CategoryID)
        {
            return ClsItemData.IsItemExistByCategoryID(CategoryID);
        }
        public static ClsItem FindByItemID(int ItemID)
        {
            decimal Price = -1;
            bool Available = false;
            int CategoryID = -1;

            bool IsFound = ClsItemData.GetItemByItemID(ItemID, ref Price, ref Available, ref CategoryID);

            if (IsFound)
                return new ClsItem(ItemID, Price, Available, CategoryID);
            else
                return null;
        }
        public static ClsItem FindByPrice(decimal Price)
        {
            int ItemID = -1;
            bool Available = false;
            int CategoryID = -1;

            bool IsFound = ClsItemData.GetItemByPrice(ref ItemID, Price, ref Available, ref CategoryID);

            if (IsFound)
                return new ClsItem(ItemID, Price, Available, CategoryID);
            else
                return null;
        }
        public static ClsItem FindByAvailable(bool Available)
        {
            int ItemID = -1;
            decimal Price = -1;
            int CategoryID = -1;

            bool IsFound = ClsItemData.GetItemByAvailable(ref ItemID, ref Price, Available, ref CategoryID);

            if (IsFound)
                return new ClsItem(ItemID, Price, Available, CategoryID);
            else
                return null;
        }
        public static ClsItem FindByCategoryID(int CategoryID)
        {
            int ItemID = -1;
            decimal Price = -1;
            bool Available = false;

            bool IsFound = ClsItemData.GetItemByCategoryID(ref ItemID, ref Price, ref Available, CategoryID);

            if (IsFound)
                return new ClsItem(ItemID, Price, Available, CategoryID);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewItem())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateItem();
            }
            return false;
        }
        public static DataTable GetMenu()
        {
            return ClsItemData.GetAllMenu();
        }
    }
}