using ClsInventoryDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsInvetoryBusinessLayer
{
    public class ClsInventory
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int InventoryID { set; get; }
        public string ItemName { set; get; }
        public decimal Quantity { set; get; }
        public string Unit { set; get; }
        public decimal ReorderLevel { set; get; }
        public DateTime LastUpdate { set; get; }

        public ClsInventory()
        {
            this.InventoryID = -1;
            this.ItemName = "";
            this.Quantity = -1;
            this.Unit = "";
            this.ReorderLevel = -1;
            this.LastUpdate = DateTime.MinValue;
            Mode = enMode.AddNew;
        }
        private ClsInventory(int InventoryID, string ItemName, decimal Quantity, string Unit, decimal ReorderLevel, DateTime LastUpdate)
        {
            this.InventoryID = InventoryID;
            this.ItemName = ItemName;
            this.Quantity = Quantity;
            this.Unit = Unit;
            this.ReorderLevel = ReorderLevel;
            this.LastUpdate = LastUpdate;
            Mode = enMode.Update;
        }
        private bool _AddNewInventory()
        {
            this.InventoryID = (int)ClsInventoryData.AddNewInventory(this.ItemName, this.Quantity, this.Unit, this.ReorderLevel, this.LastUpdate);
            return (this.InventoryID != -1);
        }
        private bool _UpdateInventory()
        {
            return ClsInventoryData.UpdateInventory(this.InventoryID, this.ItemName, this.Quantity, this.Unit, this.ReorderLevel, this.LastUpdate);
        }
        public static bool DeleteInventory(int InventoryID)
        {
            return ClsInventoryData.DeleteInventory(InventoryID);
        }
        public static bool IsInventoryExistByInventoryID(int InventoryID)
        {
            return ClsInventoryData.IsInventoryExistByInventoryID(InventoryID);
        }
        public static bool IsInventoryExistByItemName(string ItemName)
        {
            return ClsInventoryData.IsInventoryExistByItemName(ItemName);
        }
        public static bool IsInventoryExistByQuantity(decimal Quantity)
        {
            return ClsInventoryData.IsInventoryExistByQuantity(Quantity);
        }
        public static bool IsInventoryExistByUnit(string Unit)
        {
            return ClsInventoryData.IsInventoryExistByUnit(Unit);
        }
        public static bool IsInventoryExistByReorderLevel(decimal ReorderLevel)
        {
            return ClsInventoryData.IsInventoryExistByReorderLevel(ReorderLevel);
        }
        public static bool IsInventoryExistByLastUpdate(DateTime LastUpdate)
        {
            return ClsInventoryData.IsInventoryExistByLastUpdate(LastUpdate);
        }
        public static ClsInventory FindByInventoryID(int InventoryID)
        {
            string ItemName = "";
            decimal Quantity = -1;
            string Unit = "";
            decimal ReorderLevel = -1;
            DateTime LastUpdate = DateTime.MinValue;

            bool IsFound = ClsInventoryData.GetInventoryByInventoryID(InventoryID, ref ItemName, ref Quantity, ref Unit, ref ReorderLevel, ref LastUpdate);

            if (IsFound)
                return new ClsInventory(InventoryID, ItemName, Quantity, Unit, ReorderLevel, LastUpdate);
            else
                return null;
        }
        public static ClsInventory FindByItemName(string ItemName)
        {
            int InventoryID = -1;
            decimal Quantity = -1;
            string Unit = "";
            decimal ReorderLevel = -1;
            DateTime LastUpdate = DateTime.MinValue;

            bool IsFound = ClsInventoryData.GetInventoryByItemName(ref InventoryID, ItemName, ref Quantity, ref Unit, ref ReorderLevel, ref LastUpdate);

            if (IsFound)
                return new ClsInventory(InventoryID, ItemName, Quantity, Unit, ReorderLevel, LastUpdate);
            else
                return null;
        }
        public static ClsInventory FindByQuantity(decimal Quantity)
        {
            int InventoryID = -1;
            string ItemName = "";
            string Unit = "";
            decimal ReorderLevel = -1;
            DateTime LastUpdate = DateTime.MinValue;

            bool IsFound = ClsInventoryData.GetInventoryByQuantity(ref InventoryID, ref ItemName, Quantity, ref Unit, ref ReorderLevel, ref LastUpdate);

            if (IsFound)
                return new ClsInventory(InventoryID, ItemName, Quantity, Unit, ReorderLevel, LastUpdate);
            else
                return null;
        }
        public static ClsInventory FindByUnit(string Unit)
        {
            int InventoryID = -1;
            string ItemName = "";
            decimal Quantity = -1;
            decimal ReorderLevel = -1;
            DateTime LastUpdate = DateTime.MinValue;

            bool IsFound = ClsInventoryData.GetInventoryByUnit(ref InventoryID, ref ItemName, ref Quantity, Unit, ref ReorderLevel, ref LastUpdate);

            if (IsFound)
                return new ClsInventory(InventoryID, ItemName, Quantity, Unit, ReorderLevel, LastUpdate);
            else
                return null;
        }
        public static ClsInventory FindByReorderLevel(decimal ReorderLevel)
        {
            int InventoryID = -1;
            string ItemName = "";
            decimal Quantity = -1;
            string Unit = "";
            DateTime LastUpdate = DateTime.MinValue;

            bool IsFound = ClsInventoryData.GetInventoryByReorderLevel(ref InventoryID, ref ItemName, ref Quantity, ref Unit, ReorderLevel, ref LastUpdate);

            if (IsFound)
                return new ClsInventory(InventoryID, ItemName, Quantity, Unit, ReorderLevel, LastUpdate);
            else
                return null;
        }
        public static ClsInventory FindByLastUpdate(DateTime LastUpdate)
        {
            int InventoryID = -1;
            string ItemName = "";
            decimal Quantity = -1;
            string Unit = "";
            decimal ReorderLevel = -1;

            bool IsFound = ClsInventoryData.GetInventoryByLastUpdate(ref InventoryID, ref ItemName, ref Quantity, ref Unit, ref ReorderLevel, LastUpdate);

            if (IsFound)
                return new ClsInventory(InventoryID, ItemName, Quantity, Unit, ReorderLevel, LastUpdate);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInventory())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateInventory();
            }
            return false;
        }
        public static DataTable GetInventory()
        {
            return ClsInventoryData.GetAllInventory();
        }
    }
}
