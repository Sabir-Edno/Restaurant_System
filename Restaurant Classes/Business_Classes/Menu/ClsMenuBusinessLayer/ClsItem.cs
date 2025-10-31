using ClsMenuDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsMenuItemBusinessLayer
{
    public class ClsItem
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int ItemID { set; get; }
        public int CategoryID { set; get; }
        public string ItemName { set; get; }
        public string Description { set; get; }
        public decimal Price { set; get; }
        public bool Availability { set; get; }
        public string ImagePath { set; get; }
        public DateTime CreatedAt { set; get; }
        public DateTime UpdatedAt { set; get; }

        public ClsItem()
        {
            this.ItemID = -1;
            this.CategoryID = -1;
            this.ItemName = "";
            this.Description = "";
            this.Price = -1;
            this.Availability = false;
            this.ImagePath = "";
            this.CreatedAt = DateTime.MinValue;
            this.UpdatedAt = DateTime.MinValue;
            Mode = enMode.AddNew;
        }
        private ClsItem(int ItemID, int CategoryID, string ItemName, string Description, decimal Price, bool Availability, string ImagePath, DateTime CreatedAt, DateTime UpdatedAt)
        {
            this.ItemID = ItemID;
            this.CategoryID = CategoryID;
            this.ItemName = ItemName;
            this.Description = Description;
            this.Price = Price;
            this.Availability = Availability;
            this.ImagePath = ImagePath;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            Mode = enMode.Update;
        }
        private bool _AddNewItem()
        {
            this.ItemID = (int)ClsItemData.AddNewItem(this.CategoryID, this.ItemName, this.Description, this.Price, this.Availability, this.ImagePath, this.CreatedAt, this.UpdatedAt);
            return (this.ItemID != -1);
        }
        private bool _UpdateItem()
        {
            return ClsItemData.UpdateItem(this.ItemID, this.CategoryID, this.ItemName, this.Description, this.Price, this.Availability, this.ImagePath, this.CreatedAt, this.UpdatedAt);
        }
        public static bool DeleteItem(int ItemID)
        {
            return ClsItemData.DeleteItem(ItemID);
        }
        public static bool IsItemExistByItemID(int ItemID)
        {
            return ClsItemData.IsItemExistByItemID(ItemID);
        }
        public static bool IsItemExistByCategoryID(int CategoryID)
        {
            return ClsItemData.IsItemExistByCategoryID(CategoryID);
        }
        public static bool IsItemExistByItemName(string ItemName)
        {
            return ClsItemData.IsItemExistByItemName(ItemName);
        }
        public static bool IsItemExistByDescription(string Description)
        {
            return ClsItemData.IsItemExistByDescription(Description);
        }
        public static bool IsItemExistByPrice(decimal Price)
        {
            return ClsItemData.IsItemExistByPrice(Price);
        }
        public static bool IsItemExistByAvailability(bool Availability)
        {
            return ClsItemData.IsItemExistByAvailability(Availability);
        }
        public static bool IsItemExistByImagePath(string ImagePath)
        {
            return ClsItemData.IsItemExistByImagePath(ImagePath);
        }
        public static bool IsItemExistByCreatedAt(DateTime CreatedAt)
        {
            return ClsItemData.IsItemExistByCreatedAt(CreatedAt);
        }
        public static bool IsItemExistByUpdatedAt(DateTime UpdatedAt)
        {
            return ClsItemData.IsItemExistByUpdatedAt(UpdatedAt);
        }
        public static ClsItem FindByItemID(int ItemID)
        {
            int CategoryID = -1;
            string ItemName = "";
            string Description = "";
            decimal Price = -1;
            bool Availability = false;
            string ImagePath = "";
            DateTime CreatedAt = DateTime.MinValue;
            DateTime UpdatedAt = DateTime.MinValue;

            bool IsFound = ClsItemData.GetItemByItemID(ItemID, ref CategoryID, ref ItemName, ref Description, ref Price, ref Availability, ref ImagePath, ref CreatedAt, ref UpdatedAt);

            if (IsFound)
                return new ClsItem(ItemID, CategoryID, ItemName, Description, Price, Availability, ImagePath, CreatedAt, UpdatedAt);
            else
                return null;
        }
        public static ClsItem FindByCategoryID(int CategoryID)
        {
            int ItemID = -1;
            string ItemName = "";
            string Description = "";
            decimal Price = -1;
            bool Availability = false;
            string ImagePath = "";
            DateTime CreatedAt = DateTime.MinValue;
            DateTime UpdatedAt = DateTime.MinValue;

            bool IsFound = ClsItemData.GetItemByCategoryID(ref ItemID, CategoryID, ref ItemName, ref Description, ref Price, ref Availability, ref ImagePath, ref CreatedAt, ref UpdatedAt);

            if (IsFound)
                return new ClsItem(ItemID, CategoryID, ItemName, Description, Price, Availability, ImagePath, CreatedAt, UpdatedAt);
            else
                return null;
        }
        public static ClsItem FindByItemName(string ItemName)
        {
            int ItemID = -1;
            int CategoryID = -1;
            string Description = "";
            decimal Price = -1;
            bool Availability = false;
            string ImagePath = "";
            DateTime CreatedAt = DateTime.MinValue;
            DateTime UpdatedAt = DateTime.MinValue;

            bool IsFound = ClsItemData.GetItemByItemName(ref ItemID, ref CategoryID, ItemName, ref Description, ref Price, ref Availability, ref ImagePath, ref CreatedAt, ref UpdatedAt);

            if (IsFound)
                return new ClsItem(ItemID, CategoryID, ItemName, Description, Price, Availability, ImagePath, CreatedAt, UpdatedAt);
            else
                return null;
        }
        public static ClsItem FindByDescription(string Description)
        {
            int ItemID = -1;
            int CategoryID = -1;
            string ItemName = "";
            decimal Price = -1;
            bool Availability = false;
            string ImagePath = "";
            DateTime CreatedAt = DateTime.MinValue;
            DateTime UpdatedAt = DateTime.MinValue;

            bool IsFound = ClsItemData.GetItemByDescription(ref ItemID, ref CategoryID, ref ItemName, Description, ref Price, ref Availability, ref ImagePath, ref CreatedAt, ref UpdatedAt);

            if (IsFound)
                return new ClsItem(ItemID, CategoryID, ItemName, Description, Price, Availability, ImagePath, CreatedAt, UpdatedAt);
            else
                return null;
        }
        public static ClsItem FindByPrice(decimal Price)
        {
            int ItemID = -1;
            int CategoryID = -1;
            string ItemName = "";
            string Description = "";
            bool Availability = false;
            string ImagePath = "";
            DateTime CreatedAt = DateTime.MinValue;
            DateTime UpdatedAt = DateTime.MinValue;

            bool IsFound = ClsItemData.GetItemByPrice(ref ItemID, ref CategoryID, ref ItemName, ref Description, Price, ref Availability, ref ImagePath, ref CreatedAt, ref UpdatedAt);

            if (IsFound)
                return new ClsItem(ItemID, CategoryID, ItemName, Description, Price, Availability, ImagePath, CreatedAt, UpdatedAt);
            else
                return null;
        }
        public static ClsItem FindByAvailability(bool Availability)
        {
            int ItemID = -1;
            int CategoryID = -1;
            string ItemName = "";
            string Description = "";
            decimal Price = -1;
            string ImagePath = "";
            DateTime CreatedAt = DateTime.MinValue;
            DateTime UpdatedAt = DateTime.MinValue;

            bool IsFound = ClsItemData.GetItemByAvailability(ref ItemID, ref CategoryID, ref ItemName, ref Description, ref Price, Availability, ref ImagePath, ref CreatedAt, ref UpdatedAt);

            if (IsFound)
                return new ClsItem(ItemID, CategoryID, ItemName, Description, Price, Availability, ImagePath, CreatedAt, UpdatedAt);
            else
                return null;
        }
        public static ClsItem FindByImagePath(string ImagePath)
        {
            int ItemID = -1;
            int CategoryID = -1;
            string ItemName = "";
            string Description = "";
            decimal Price = -1;
            bool Availability = false;
            DateTime CreatedAt = DateTime.MinValue;
            DateTime UpdatedAt = DateTime.MinValue;

            bool IsFound = ClsItemData.GetItemByImagePath(ref ItemID, ref CategoryID, ref ItemName, ref Description, ref Price, ref Availability, ImagePath, ref CreatedAt, ref UpdatedAt);

            if (IsFound)
                return new ClsItem(ItemID, CategoryID, ItemName, Description, Price, Availability, ImagePath, CreatedAt, UpdatedAt);
            else
                return null;
        }
        public static ClsItem FindByCreatedAt(DateTime CreatedAt)
        {
            int ItemID = -1;
            int CategoryID = -1;
            string ItemName = "";
            string Description = "";
            decimal Price = -1;
            bool Availability = false;
            string ImagePath = "";
            DateTime UpdatedAt = DateTime.MinValue;

            bool IsFound = ClsItemData.GetItemByCreatedAt(ref ItemID, ref CategoryID, ref ItemName, ref Description, ref Price, ref Availability, ref ImagePath, CreatedAt, ref UpdatedAt);

            if (IsFound)
                return new ClsItem(ItemID, CategoryID, ItemName, Description, Price, Availability, ImagePath, CreatedAt, UpdatedAt);
            else
                return null;
        }
        public static ClsItem FindByUpdatedAt(DateTime UpdatedAt)
        {
            int ItemID = -1;
            int CategoryID = -1;
            string ItemName = "";
            string Description = "";
            decimal Price = -1;
            bool Availability = false;
            string ImagePath = "";
            DateTime CreatedAt = DateTime.MinValue;

            bool IsFound = ClsItemData.GetItemByUpdatedAt(ref ItemID, ref CategoryID, ref ItemName, ref Description, ref Price, ref Availability, ref ImagePath, ref CreatedAt, UpdatedAt);

            if (IsFound)
                return new ClsItem(ItemID, CategoryID, ItemName, Description, Price, Availability, ImagePath, CreatedAt, UpdatedAt);
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
        public static DataTable GetMenuItems()
        {
            return ClsItemData.GetAllMenuItems();
        }

        public static bool IsItemReferenceToAnyOrderDetailByID(int ItemID)
        {
            return ClsItemData.IsItemReferenceToAnyOrderDetailByID(ItemID);
        }
    }
}