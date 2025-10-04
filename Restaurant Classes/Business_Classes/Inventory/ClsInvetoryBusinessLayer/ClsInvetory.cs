using ClsInventoryDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsInvetoryBusinessLayer
{
    public class ClsInvetory
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int ItemID { set; get; }
        public string Name { set; get; }
        public decimal Quantity { set; get; }
        public string Unit { set; get; }
        public DateTime LastUpdate { set; get; }

        public ClsInvetory()
        {
            this.ItemID = -1;
            this.Name = "";
            this.Quantity = -1;
            this.Unit = "";
            this.LastUpdate = DateTime.MinValue;
            Mode = enMode.AddNew;
        }
        private ClsInvetory(int ItemID, string Name, decimal Quantity, string Unit, DateTime LastUpdate)
        {
            this.ItemID = ItemID;
            this.Name = Name;
            this.Quantity = Quantity;
            this.Unit = Unit;
            this.LastUpdate = LastUpdate;
            Mode = enMode.Update;
        }
        private bool _AddNewItem()
        {
            this.ItemID = (int)ClsInventoryData.AddNewItem(this.Name, this.Quantity, this.Unit, this.LastUpdate);
            return (this.ItemID != -1);
        }
        private bool _UpdateItem()
        {
            return ClsInventoryData.UpdateItem(this.ItemID, this.Name, this.Quantity, this.Unit, this.LastUpdate);
        }
        public static bool DeleteItem(int ItemID)
        {
            return ClsInventoryData.DeleteItem(ItemID);
        }
        public static bool IsItemExistByItemID(int ItemID)
        {
            return ClsInventoryData.IsItemExistByItemID(ItemID);
        }
        public static bool IsItemExistByName(string Name)
        {
            return ClsInventoryData.IsItemExistByName(Name);
        }
        public static bool IsItemExistByQuantity(decimal Quantity)
        {
            return ClsInventoryData.IsItemExistByQuantity(Quantity);
        }
        public static bool IsItemExistByUnit(string Unit)
        {
            return ClsInventoryData.IsItemExistByUnit(Unit);
        }
        public static bool IsItemExistByLastUpdate(DateTime LastUpdate)
        {
            return ClsInventoryData.IsItemExistByLastUpdate(LastUpdate);
        }
        public static ClsInvetory FindByItemID(int ItemID)
        {
            string Name = "";
            decimal Quantity = -1;
            string Unit = "";
            DateTime LastUpdate = DateTime.MinValue;

            bool IsFound = ClsInventoryData.GetItemByItemID(ItemID, ref Name, ref Quantity, ref Unit, ref LastUpdate);

            if (IsFound)
                return new ClsInvetory(ItemID, Name, Quantity, Unit, LastUpdate);
            else
                return null;
        }
        public static ClsInvetory FindByName(string Name)
        {
            int ItemID = -1;
            decimal Quantity = -1;
            string Unit = "";
            DateTime LastUpdate = DateTime.MinValue;

            bool IsFound = ClsInventoryData.GetItemByName(ref ItemID, Name, ref Quantity, ref Unit, ref LastUpdate);

            if (IsFound)
                return new ClsInvetory(ItemID, Name, Quantity, Unit, LastUpdate);
            else
                return null;
        }
        public static ClsInvetory FindByQuantity(decimal Quantity)
        {
            int ItemID = -1;
            string Name = "";
            string Unit = "";
            DateTime LastUpdate = DateTime.MinValue;

            bool IsFound = ClsInventoryData.GetItemByQuantity(ref ItemID, ref Name, Quantity, ref Unit, ref LastUpdate);

            if (IsFound)
                return new ClsInvetory(ItemID, Name, Quantity, Unit, LastUpdate);
            else
                return null;
        }
        public static ClsInvetory FindByUnit(string Unit)
        {
            int ItemID = -1;
            string Name = "";
            decimal Quantity = -1;
            DateTime LastUpdate = DateTime.MinValue;

            bool IsFound = ClsInventoryData.GetItemByUnit(ref ItemID, ref Name, ref Quantity, Unit, ref LastUpdate);

            if (IsFound)
                return new ClsInvetory(ItemID, Name, Quantity, Unit, LastUpdate);
            else
                return null;
        }
        public static ClsInvetory FindByLastUpdate(DateTime LastUpdate)
        {
            int ItemID = -1;
            string Name = "";
            decimal Quantity = -1;
            string Unit = "";

            bool IsFound = ClsInventoryData.GetItemByLastUpdate(ref ItemID, ref Name, ref Quantity, ref Unit, LastUpdate);

            if (IsFound)
                return new ClsInvetory(ItemID, Name, Quantity, Unit, LastUpdate);
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
        public static DataTable GetInventory()
        {
            return ClsInventoryData.GetAllInventory();
        }
    }
}
