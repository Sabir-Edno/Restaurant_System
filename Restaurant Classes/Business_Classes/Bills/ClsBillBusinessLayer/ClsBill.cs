using ClsBillDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsBillBusinessLayer
{
    public class ClsBill
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int BillID { set; get; }
        public int OrderID { set; get; }
        public decimal SubTotal { set; get; }
        public decimal Tax { set; get; }
        public decimal Discount { set; get; }
        public decimal GrandTotal { set; get; }
        public int PaymentMethodID { set; get; }
        public string PaymentStatus { set; get; }
        public DateTime BillDate { set; get; }

        public ClsBill()
        {
            this.BillID = -1;
            this.OrderID = -1;
            this.SubTotal = -1;
            this.Tax = -1;
            this.Discount = -1;
            this.GrandTotal = -1;
            this.PaymentMethodID = -1;
            this.PaymentStatus = "";
            this.BillDate = DateTime.MinValue;
            Mode = enMode.AddNew;
        }
        private ClsBill(int BillID, int OrderID, decimal SubTotal, decimal Tax, decimal Discount, decimal GrandTotal, int PaymentMethodID, string PaymentStatus, DateTime BillDate)
        {
            this.BillID = BillID;
            this.OrderID = OrderID;
            this.SubTotal = SubTotal;
            this.Tax = Tax;
            this.Discount = Discount;
            this.GrandTotal = GrandTotal;
            this.PaymentMethodID = PaymentMethodID;
            this.PaymentStatus = PaymentStatus;
            this.BillDate = BillDate;
            Mode = enMode.Update;
        }
        private bool _AddNewBill()
        {
            this.BillID = (int)ClsBillData.AddNewBill(this.OrderID, this.SubTotal, this.Tax, this.Discount, this.GrandTotal, this.PaymentMethodID, this.PaymentStatus, this.BillDate);
            return (this.BillID != -1);
        }
        private bool _UpdateBill()
        {
            return ClsBillData.UpdateBill(this.BillID, this.OrderID, this.SubTotal, this.Tax, this.Discount, this.GrandTotal, this.PaymentMethodID, this.PaymentStatus, this.BillDate);
        }
        public static bool DeleteBill(int BillID)
        {
            return ClsBillData.DeleteBill(BillID);
        }
        public static bool IsBillExistByBillID(int BillID)
        {
            return ClsBillData.IsBillExistByBillID(BillID);
        }
        public static bool IsBillExistByOrderID(int OrderID)
        {
            return ClsBillData.IsBillExistByOrderID(OrderID);
        }
        public static bool IsBillExistBySubTotal(decimal SubTotal)
        {
            return ClsBillData.IsBillExistBySubTotal(SubTotal);
        }
        public static bool IsBillExistByTax(decimal Tax)
        {
            return ClsBillData.IsBillExistByTax(Tax);
        }
        public static bool IsBillExistByDiscount(decimal Discount)
        {
            return ClsBillData.IsBillExistByDiscount(Discount);
        }
        public static bool IsBillExistByGrandTotal(decimal GrandTotal)
        {
            return ClsBillData.IsBillExistByGrandTotal(GrandTotal);
        }
        public static bool IsBillExistByPaymentMethodID(int PaymentMethodID)
        {
            return ClsBillData.IsBillExistByPaymentMethodID(PaymentMethodID);
        }
        public static bool IsBillExistByPaymentStatus(string PaymentStatus)
        {
            return ClsBillData.IsBillExistByPaymentStatus(PaymentStatus);
        }
        public static bool IsBillExistByBillDate(DateTime BillDate)
        {
            return ClsBillData.IsBillExistByBillDate(BillDate);
        }
        public static ClsBill FindByBillID(int BillID)
        {
            int OrderID = -1;
            decimal SubTotal = -1;
            decimal Tax = -1;
            decimal Discount = -1;
            decimal GrandTotal = -1;
            int PaymentMethodID = -1;
            string PaymentStatus = "";
            DateTime BillDate = DateTime.MinValue;

            bool IsFound = ClsBillData.GetBillByBillID(BillID, ref OrderID, ref SubTotal, ref Tax, ref Discount, ref GrandTotal, ref PaymentMethodID, ref PaymentStatus, ref BillDate);

            if (IsFound)
                return new ClsBill(BillID, OrderID, SubTotal, Tax, Discount, GrandTotal, PaymentMethodID, PaymentStatus, BillDate);
            else
                return null;
        }
        public static ClsBill FindByOrderID(int OrderID)
        {
            int BillID = -1;
            decimal SubTotal = -1;
            decimal Tax = -1;
            decimal Discount = -1;
            decimal GrandTotal = -1;
            int PaymentMethodID = -1;
            string PaymentStatus = "";
            DateTime BillDate = DateTime.MinValue;

            bool IsFound = ClsBillData.GetBillByOrderID(ref BillID, OrderID, ref SubTotal, ref Tax, ref Discount, ref GrandTotal, ref PaymentMethodID, ref PaymentStatus, ref BillDate);

            if (IsFound)
                return new ClsBill(BillID, OrderID, SubTotal, Tax, Discount, GrandTotal, PaymentMethodID, PaymentStatus, BillDate);
            else
                return null;
        }
        public static ClsBill FindBySubTotal(decimal SubTotal)
        {
            int BillID = -1;
            int OrderID = -1;
            decimal Tax = -1;
            decimal Discount = -1;
            decimal GrandTotal = -1;
            int PaymentMethodID = -1;
            string PaymentStatus = "";
            DateTime BillDate = DateTime.MinValue;

            bool IsFound = ClsBillData.GetBillBySubTotal(ref BillID, ref OrderID, SubTotal, ref Tax, ref Discount, ref GrandTotal, ref PaymentMethodID, ref PaymentStatus, ref BillDate);

            if (IsFound)
                return new ClsBill(BillID, OrderID, SubTotal, Tax, Discount, GrandTotal, PaymentMethodID, PaymentStatus, BillDate);
            else
                return null;
        }
        public static ClsBill FindByTax(decimal Tax)
        {
            int BillID = -1;
            int OrderID = -1;
            decimal SubTotal = -1;
            decimal Discount = -1;
            decimal GrandTotal = -1;
            int PaymentMethodID = -1;
            string PaymentStatus = "";
            DateTime BillDate = DateTime.MinValue;

            bool IsFound = ClsBillData.GetBillByTax(ref BillID, ref OrderID, ref SubTotal, Tax, ref Discount, ref GrandTotal, ref PaymentMethodID, ref PaymentStatus, ref BillDate);

            if (IsFound)
                return new ClsBill(BillID, OrderID, SubTotal, Tax, Discount, GrandTotal, PaymentMethodID, PaymentStatus, BillDate);
            else
                return null;
        }
        public static ClsBill FindByDiscount(decimal Discount)
        {
            int BillID = -1;
            int OrderID = -1;
            decimal SubTotal = -1;
            decimal Tax = -1;
            decimal GrandTotal = -1;
            int PaymentMethodID = -1;
            string PaymentStatus = "";
            DateTime BillDate = DateTime.MinValue;

            bool IsFound = ClsBillData.GetBillByDiscount(ref BillID, ref OrderID, ref SubTotal, ref Tax, Discount, ref GrandTotal, ref PaymentMethodID, ref PaymentStatus, ref BillDate);

            if (IsFound)
                return new ClsBill(BillID, OrderID, SubTotal, Tax, Discount, GrandTotal, PaymentMethodID, PaymentStatus, BillDate);
            else
                return null;
        }
        public static ClsBill FindByGrandTotal(decimal GrandTotal)
        {
            int BillID = -1;
            int OrderID = -1;
            decimal SubTotal = -1;
            decimal Tax = -1;
            decimal Discount = -1;
            int PaymentMethodID = -1;
            string PaymentStatus = "";
            DateTime BillDate = DateTime.MinValue;

            bool IsFound = ClsBillData.GetBillByGrandTotal(ref BillID, ref OrderID, ref SubTotal, ref Tax, ref Discount, GrandTotal, ref PaymentMethodID, ref PaymentStatus, ref BillDate);

            if (IsFound)
                return new ClsBill(BillID, OrderID, SubTotal, Tax, Discount, GrandTotal, PaymentMethodID, PaymentStatus, BillDate);
            else
                return null;
        }
        public static ClsBill FindByPaymentMethodID(int PaymentMethodID)
        {
            int BillID = -1;
            int OrderID = -1;
            decimal SubTotal = -1;
            decimal Tax = -1;
            decimal Discount = -1;
            decimal GrandTotal = -1;
            string PaymentStatus = "";
            DateTime BillDate = DateTime.MinValue;

            bool IsFound = ClsBillData.GetBillByPaymentMethodID(ref BillID, ref OrderID, ref SubTotal, ref Tax, ref Discount, ref GrandTotal, PaymentMethodID, ref PaymentStatus, ref BillDate);

            if (IsFound)
                return new ClsBill(BillID, OrderID, SubTotal, Tax, Discount, GrandTotal, PaymentMethodID, PaymentStatus, BillDate);
            else
                return null;
        }
        public static ClsBill FindByPaymentStatus(string PaymentStatus)
        {
            int BillID = -1;
            int OrderID = -1;
            decimal SubTotal = -1;
            decimal Tax = -1;
            decimal Discount = -1;
            decimal GrandTotal = -1;
            int PaymentMethodID = -1;
            DateTime BillDate = DateTime.MinValue;

            bool IsFound = ClsBillData.GetBillByPaymentStatus(ref BillID, ref OrderID, ref SubTotal, ref Tax, ref Discount, ref GrandTotal, ref PaymentMethodID, PaymentStatus, ref BillDate);

            if (IsFound)
                return new ClsBill(BillID, OrderID, SubTotal, Tax, Discount, GrandTotal, PaymentMethodID, PaymentStatus, BillDate);
            else
                return null;
        }
        public static ClsBill FindByBillDate(DateTime BillDate)
        {
            int BillID = -1;
            int OrderID = -1;
            decimal SubTotal = -1;
            decimal Tax = -1;
            decimal Discount = -1;
            decimal GrandTotal = -1;
            int PaymentMethodID = -1;
            string PaymentStatus = "";

            bool IsFound = ClsBillData.GetBillByBillDate(ref BillID, ref OrderID, ref SubTotal, ref Tax, ref Discount, ref GrandTotal, ref PaymentMethodID, ref PaymentStatus, BillDate);

            if (IsFound)
                return new ClsBill(BillID, OrderID, SubTotal, Tax, Discount, GrandTotal, PaymentMethodID, PaymentStatus, BillDate);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBill())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateBill();
            }
            return false;
        }
        public static DataTable GetBills()
        {
            return ClsBillData.GetAllBills();
        }
    }
}