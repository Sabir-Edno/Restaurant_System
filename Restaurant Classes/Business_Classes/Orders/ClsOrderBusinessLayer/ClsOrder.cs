using ClsOrderDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsOrderBusinessLayer
{
    public class ClsOrder
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int OrderID { set; get; }
        public int TableID { set; get; }
        public int UserID { set; get; }
        public string OrderType { set; get; }
        public string Status { set; get; }
        public DateTime CreatedAt { set; get; }

        public ClsOrder()
        {
            this.OrderID = -1;
            this.TableID = -1;
            this.UserID = -1;
            this.OrderType = "";
            this.Status = "";
            this.CreatedAt = DateTime.MinValue;
            Mode = enMode.AddNew;
        }
        private ClsOrder(int OrderID, int TableID, int UserID, string OrderType, string Status, DateTime CreatedAt)
        {
            this.OrderID = OrderID;
            this.TableID = TableID;
            this.UserID = UserID;
            this.OrderType = OrderType;
            this.Status = Status;
            this.CreatedAt = CreatedAt;
            Mode = enMode.Update;
        }
        private bool _AddNewOrder()
        {
            this.OrderID = (int)ClsOrderData.AddNewOrder(this.TableID, this.UserID, this.OrderType, this.Status, this.CreatedAt);
            return (this.OrderID != -1);
        }
        private bool _UpdateOrder()
        {
            return ClsOrderData.UpdateOrder(this.OrderID, this.TableID, this.UserID, this.OrderType, this.Status, this.CreatedAt);
        }
        public static bool DeleteOrder(int OrderID)
        {
            return ClsOrderData.DeleteOrder(OrderID);
        }
        public static bool IsOrderExistByOrderID(int OrderID)
        {
            return ClsOrderData.IsOrderExistByOrderID(OrderID);
        }
        public static bool IsOrderExistByTableID(int TableID)
        {
            return ClsOrderData.IsOrderExistByTableID(TableID);
        }
        public static bool IsOrderExistByUserID(int UserID)
        {
            return ClsOrderData.IsOrderExistByUserID(UserID);
        }
        public static bool IsOrderExistByOrderType(string OrderType)
        {
            return ClsOrderData.IsOrderExistByOrderType(OrderType);
        }
        public static bool IsOrderExistByStatus(string Status)
        {
            return ClsOrderData.IsOrderExistByStatus(Status);
        }
        public static bool IsOrderExistByCreatedAt(DateTime CreatedAt)
        {
            return ClsOrderData.IsOrderExistByCreatedAt(CreatedAt);
        }
        public static ClsOrder FindByOrderID(int OrderID)
        {
            int TableID = -1;
            int UserID = -1;
            string OrderType = "";
            string Status = "";
            DateTime CreatedAt = DateTime.MinValue;

            bool IsFound = ClsOrderData.GetOrderByOrderID(OrderID, ref TableID, ref UserID, ref OrderType, ref Status, ref CreatedAt);

            if (IsFound)
                return new ClsOrder(OrderID, TableID, UserID, OrderType, Status, CreatedAt);
            else
                return null;
        }
        public static ClsOrder FindByTableID(int TableID)
        {
            int OrderID = -1;
            int UserID = -1;
            string OrderType = "";
            string Status = "";
            DateTime CreatedAt = DateTime.MinValue;

            bool IsFound = ClsOrderData.GetOrderByTableID(ref OrderID, TableID, ref UserID, ref OrderType, ref Status, ref CreatedAt);

            if (IsFound)
                return new ClsOrder(OrderID, TableID, UserID, OrderType, Status, CreatedAt);
            else
                return null;
        }
        public static ClsOrder FindByUserID(int UserID)
        {
            int OrderID = -1;
            int TableID = -1;
            string OrderType = "";
            string Status = "";
            DateTime CreatedAt = DateTime.MinValue;

            bool IsFound = ClsOrderData.GetOrderByUserID(ref OrderID, ref TableID, UserID, ref OrderType, ref Status, ref CreatedAt);

            if (IsFound)
                return new ClsOrder(OrderID, TableID, UserID, OrderType, Status, CreatedAt);
            else
                return null;
        }
        public static ClsOrder FindByOrderType(string OrderType)
        {
            int OrderID = -1;
            int TableID = -1;
            int UserID = -1;
            string Status = "";
            DateTime CreatedAt = DateTime.MinValue;

            bool IsFound = ClsOrderData.GetOrderByOrderType(ref OrderID, ref TableID, ref UserID, OrderType, ref Status, ref CreatedAt);

            if (IsFound)
                return new ClsOrder(OrderID, TableID, UserID, OrderType, Status, CreatedAt);
            else
                return null;
        }
        public static ClsOrder FindByStatus(string Status)
        {
            int OrderID = -1;
            int TableID = -1;
            int UserID = -1;
            string OrderType = "";
            DateTime CreatedAt = DateTime.MinValue;

            bool IsFound = ClsOrderData.GetOrderByStatus(ref OrderID, ref TableID, ref UserID, ref OrderType, Status, ref CreatedAt);

            if (IsFound)
                return new ClsOrder(OrderID, TableID, UserID, OrderType, Status, CreatedAt);
            else
                return null;
        }
        public static ClsOrder FindByCreatedAt(DateTime CreatedAt)
        {
            int OrderID = -1;
            int TableID = -1;
            int UserID = -1;
            string OrderType = "";
            string Status = "";

            bool IsFound = ClsOrderData.GetOrderByCreatedAt(ref OrderID, ref TableID, ref UserID, ref OrderType, ref Status, CreatedAt);

            if (IsFound)
                return new ClsOrder(OrderID, TableID, UserID, OrderType, Status, CreatedAt);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewOrder())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateOrder();
            }
            return false;
        }
        public static DataTable GetOrders()
        {
            return ClsOrderData.GetAllOrders();
        }
    }
}
