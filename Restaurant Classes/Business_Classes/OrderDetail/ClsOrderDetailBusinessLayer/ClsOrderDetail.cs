using ClsOrderDetailDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsOrderDetailBusinessLayer
{
    public class ClsOrderDetail
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int OrderDetailID { set; get; }
        public int OrderID { set; get; }
        public int ItemID { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }
        public decimal Total { set; get; }

        public ClsOrderDetail()
        {
            this.OrderDetailID = -1;
            this.OrderID = -1;
            this.ItemID = -1;
            this.Quantity = -1;
            this.Price = -1;
            this.Total = -1;
            Mode = enMode.AddNew;
        }
        private ClsOrderDetail(int OrderDetailID, int OrderID, int ItemID, int Quantity, decimal Price, decimal Total)
        {
            this.OrderDetailID = OrderDetailID;
            this.OrderID = OrderID;
            this.ItemID = ItemID;
            this.Quantity = Quantity;
            this.Price = Price;
            this.Total = Total;
            Mode = enMode.Update;
        }
        private bool _AddNewOrderDetail()
        {
            this.OrderDetailID = (int)ClsOrderDetailData.AddNewOrderDetail(this.OrderID, this.ItemID, this.Quantity, this.Price, this.Total);
            return (this.OrderDetailID != -1);
        }
        private bool _UpdateOrderDetail()
        {
            return ClsOrderDetailData.UpdateOrderDetail(this.OrderDetailID, this.OrderID, this.ItemID, this.Quantity, this.Price, this.Total);
        }
        public static bool DeleteOrderDetail(int OrderDetailID)
        {
            return ClsOrderDetailData.DeleteOrderDetail(OrderDetailID);
        }
        public static bool IsOrderDetailExistByOrderDetailID(int OrderDetailID)
        {
            return ClsOrderDetailData.IsOrderDetailExistByOrderDetailID(OrderDetailID);
        }
        public static bool IsOrderDetailExistByOrderID(int OrderID)
        {
            return ClsOrderDetailData.IsOrderDetailExistByOrderID(OrderID);
        }
        public static bool IsOrderDetailExistByItemID(int ItemID)
        {
            return ClsOrderDetailData.IsOrderDetailExistByItemID(ItemID);
        }
        public static bool IsOrderDetailExistByQuantity(int Quantity)
        {
            return ClsOrderDetailData.IsOrderDetailExistByQuantity(Quantity);
        }
        public static bool IsOrderDetailExistByPrice(decimal Price)
        {
            return ClsOrderDetailData.IsOrderDetailExistByPrice(Price);
        }
        public static bool IsOrderDetailExistByTotal(decimal Total)
        {
            return ClsOrderDetailData.IsOrderDetailExistByTotal(Total);
        }
        public static ClsOrderDetail FindByOrderDetailID(int OrderDetailID)
        {
            int OrderID = -1;
            int ItemID = -1;
            int Quantity = -1;
            decimal Price = -1;
            decimal Total = -1;

            bool IsFound = ClsOrderDetailData.GetOrderDetailByOrderDetailID(OrderDetailID, ref OrderID, ref ItemID, ref Quantity, ref Price, ref Total);

            if (IsFound)
                return new ClsOrderDetail(OrderDetailID, OrderID, ItemID, Quantity, Price, Total);
            else
                return null;
        }
        public static ClsOrderDetail FindByOrderID(int OrderID)
        {
            int OrderDetailID = -1;
            int ItemID = -1;
            int Quantity = -1;
            decimal Price = -1;
            decimal Total = -1;

            bool IsFound = ClsOrderDetailData.GetOrderDetailByOrderID(ref OrderDetailID, OrderID, ref ItemID, ref Quantity, ref Price, ref Total);

            if (IsFound)
                return new ClsOrderDetail(OrderDetailID, OrderID, ItemID, Quantity, Price, Total);
            else
                return null;
        }
        public static ClsOrderDetail FindByItemID(int ItemID)
        {
            int OrderDetailID = -1;
            int OrderID = -1;
            int Quantity = -1;
            decimal Price = -1;
            decimal Total = -1;

            bool IsFound = ClsOrderDetailData.GetOrderDetailByItemID(ref OrderDetailID, ref OrderID, ItemID, ref Quantity, ref Price, ref Total);

            if (IsFound)
                return new ClsOrderDetail(OrderDetailID, OrderID, ItemID, Quantity, Price, Total);
            else
                return null;
        }
        public static ClsOrderDetail FindByQuantity(int Quantity)
        {
            int OrderDetailID = -1;
            int OrderID = -1;
            int ItemID = -1;
            decimal Price = -1;
            decimal Total = -1;

            bool IsFound = ClsOrderDetailData.GetOrderDetailByQuantity(ref OrderDetailID, ref OrderID, ref ItemID, Quantity, ref Price, ref Total);

            if (IsFound)
                return new ClsOrderDetail(OrderDetailID, OrderID, ItemID, Quantity, Price, Total);
            else
                return null;
        }
        public static ClsOrderDetail FindByPrice(decimal Price)
        {
            int OrderDetailID = -1;
            int OrderID = -1;
            int ItemID = -1;
            int Quantity = -1;
            decimal Total = -1;

            bool IsFound = ClsOrderDetailData.GetOrderDetailByPrice(ref OrderDetailID, ref OrderID, ref ItemID, ref Quantity, Price, ref Total);

            if (IsFound)
                return new ClsOrderDetail(OrderDetailID, OrderID, ItemID, Quantity, Price, Total);
            else
                return null;
        }
        public static ClsOrderDetail FindByTotal(decimal Total)
        {
            int OrderDetailID = -1;
            int OrderID = -1;
            int ItemID = -1;
            int Quantity = -1;
            decimal Price = -1;

            bool IsFound = ClsOrderDetailData.GetOrderDetailByTotal(ref OrderDetailID, ref OrderID, ref ItemID, ref Quantity, ref Price, Total);

            if (IsFound)
                return new ClsOrderDetail(OrderDetailID, OrderID, ItemID, Quantity, Price, Total);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewOrderDetail())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateOrderDetail();
            }
            return false;
        }
        public static DataTable GetOrderDetails()
        {
            return ClsOrderDetailData.GetAllOrderDetails();
        }
    }
}