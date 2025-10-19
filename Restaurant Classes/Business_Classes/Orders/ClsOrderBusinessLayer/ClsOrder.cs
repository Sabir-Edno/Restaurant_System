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
        public DateTime OrderDate { set; get; }
        public string Status { set; get; }
        public string Notes { set; get; }

        public ClsOrder()
        {
            this.OrderID = -1;
            this.TableID = -1;
            this.UserID = -1;
            this.OrderDate = DateTime.MinValue;
            this.Status = "";
            this.Notes = "";
            Mode = enMode.AddNew;
        }
        private ClsOrder(int OrderID, int TableID, int UserID, DateTime OrderDate, string Status, string Notes)
        {
            this.OrderID = OrderID;
            this.TableID = TableID;
            this.UserID = UserID;
            this.OrderDate = OrderDate;
            this.Status = Status;
            this.Notes = Notes;
            Mode = enMode.Update;
        }
        private bool _AddNewOrder()
        {
            this.OrderID = (int)ClsOrderData.AddNewOrder(this.TableID, this.UserID, this.OrderDate, this.Status, this.Notes);
            return (this.OrderID != -1);
        }
        private bool _UpdateOrder()
        {
            return ClsOrderData.UpdateOrder(this.OrderID, this.TableID, this.UserID, this.OrderDate, this.Status, this.Notes);
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
        public static bool IsOrderExistByOrderDate(DateTime OrderDate)
        {
            return ClsOrderData.IsOrderExistByOrderDate(OrderDate);
        }
        public static bool IsOrderExistByStatus(string Status)
        {
            return ClsOrderData.IsOrderExistByStatus(Status);
        }
        public static bool IsOrderExistByNotes(string Notes)
        {
            return ClsOrderData.IsOrderExistByNotes(Notes);
        }
        public static ClsOrder FindByOrderID(int OrderID)
        {
            int TableID = -1;
            int UserID = -1;
            DateTime OrderDate = DateTime.MinValue;
            string Status = "";
            string Notes = "";

            bool IsFound = ClsOrderData.GetOrderByOrderID(OrderID, ref TableID, ref UserID, ref OrderDate, ref Status, ref Notes);

            if (IsFound)
                return new ClsOrder(OrderID, TableID, UserID, OrderDate, Status, Notes);
            else
                return null;
        }
        public static ClsOrder FindByTableID(int TableID)
        {
            int OrderID = -1;
            int UserID = -1;
            DateTime OrderDate = DateTime.MinValue;
            string Status = "";
            string Notes = "";

            bool IsFound = ClsOrderData.GetOrderByTableID(ref OrderID, TableID, ref UserID, ref OrderDate, ref Status, ref Notes);

            if (IsFound)
                return new ClsOrder(OrderID, TableID, UserID, OrderDate, Status, Notes);
            else
                return null;
        }
        public static ClsOrder FindByUserID(int UserID)
        {
            int OrderID = -1;
            int TableID = -1;
            DateTime OrderDate = DateTime.MinValue;
            string Status = "";
            string Notes = "";

            bool IsFound = ClsOrderData.GetOrderByUserID(ref OrderID, ref TableID, UserID, ref OrderDate, ref Status, ref Notes);

            if (IsFound)
                return new ClsOrder(OrderID, TableID, UserID, OrderDate, Status, Notes);
            else
                return null;
        }
        public static ClsOrder FindByOrderDate(DateTime OrderDate)
        {
            int OrderID = -1;
            int TableID = -1;
            int UserID = -1;
            string Status = "";
            string Notes = "";

            bool IsFound = ClsOrderData.GetOrderByOrderDate(ref OrderID, ref TableID, ref UserID, OrderDate, ref Status, ref Notes);

            if (IsFound)
                return new ClsOrder(OrderID, TableID, UserID, OrderDate, Status, Notes);
            else
                return null;
        }
        public static ClsOrder FindByStatus(string Status)
        {
            int OrderID = -1;
            int TableID = -1;
            int UserID = -1;
            DateTime OrderDate = DateTime.MinValue;
            string Notes = "";

            bool IsFound = ClsOrderData.GetOrderByStatus(ref OrderID, ref TableID, ref UserID, ref OrderDate, Status, ref Notes);

            if (IsFound)
                return new ClsOrder(OrderID, TableID, UserID, OrderDate, Status, Notes);
            else
                return null;
        }
        public static ClsOrder FindByNotes(string Notes)
        {
            int OrderID = -1;
            int TableID = -1;
            int UserID = -1;
            DateTime OrderDate = DateTime.MinValue;
            string Status = "";

            bool IsFound = ClsOrderData.GetOrderByNotes(ref OrderID, ref TableID, ref UserID, ref OrderDate, ref Status, Notes);

            if (IsFound)
                return new ClsOrder(OrderID, TableID, UserID, OrderDate, Status, Notes);
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
