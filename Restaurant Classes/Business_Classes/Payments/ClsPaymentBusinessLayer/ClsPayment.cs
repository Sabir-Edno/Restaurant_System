using ClsPaymentDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsPaymentBusinessLayer
{
    public class ClsPayment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int PaymentID { set; get; }
        public int OrderID { set; get; }
        public decimal Amount { set; get; }
        public string Method { set; get; }
        public DateTime PaidAt { set; get; }

        public ClsPayment()
        {
            this.PaymentID = -1;
            this.OrderID = -1;
            this.Amount = -1;
            this.Method = "";
            this.PaidAt = DateTime.MinValue;
            Mode = enMode.AddNew;
        }
        private ClsPayment(int PaymentID, int OrderID, decimal Amount, string Method, DateTime PaidAt)
        {
            this.PaymentID = PaymentID;
            this.OrderID = OrderID;
            this.Amount = Amount;
            this.Method = Method;
            this.PaidAt = PaidAt;
            Mode = enMode.Update;
        }
        private bool _AddNewPayment()
        {
            this.PaymentID = (int)ClsPaymentData.AddNewPayment(this.OrderID, this.Amount, this.Method, this.PaidAt);
            return (this.PaymentID != -1);
        }
        private bool _UpdatePayment()
        {
            return ClsPaymentData.UpdatePayment(this.PaymentID, this.OrderID, this.Amount, this.Method, this.PaidAt);
        }
        public static bool DeletePayment(int PaymentID)
        {
            return ClsPaymentData.DeletePayment(PaymentID);
        }
        public static bool IsPaymentExistByPaymentID(int PaymentID)
        {
            return ClsPaymentData.IsPaymentExistByPaymentID(PaymentID);
        }
        public static bool IsPaymentExistByOrderID(int OrderID)
        {
            return ClsPaymentData.IsPaymentExistByOrderID(OrderID);
        }
        public static bool IsPaymentExistByAmount(decimal Amount)
        {
            return ClsPaymentData.IsPaymentExistByAmount(Amount);
        }
        public static bool IsPaymentExistByMethod(string Method)
        {
            return ClsPaymentData.IsPaymentExistByMethod(Method);
        }
        public static bool IsPaymentExistByPaidAt(DateTime PaidAt)
        {
            return ClsPaymentData.IsPaymentExistByPaidAt(PaidAt);
        }
        public static ClsPayment FindByPaymentID(int PaymentID)
        {
            int OrderID = -1;
            decimal Amount = -1;
            string Method = "";
            DateTime PaidAt = DateTime.MinValue;

            bool IsFound = ClsPaymentData.GetPaymentByPaymentID(PaymentID, ref OrderID, ref Amount, ref Method, ref PaidAt);

            if (IsFound)
                return new ClsPayment(PaymentID, OrderID, Amount, Method, PaidAt);
            else
                return null;
        }
        public static ClsPayment FindByOrderID(int OrderID)
        {
            int PaymentID = -1;
            decimal Amount = -1;
            string Method = "";
            DateTime PaidAt = DateTime.MinValue;

            bool IsFound = ClsPaymentData.GetPaymentByOrderID(ref PaymentID, OrderID, ref Amount, ref Method, ref PaidAt);

            if (IsFound)
                return new ClsPayment(PaymentID, OrderID, Amount, Method, PaidAt);
            else
                return null;
        }
        public static ClsPayment FindByAmount(decimal Amount)
        {
            int PaymentID = -1;
            int OrderID = -1;
            string Method = "";
            DateTime PaidAt = DateTime.MinValue;

            bool IsFound = ClsPaymentData.GetPaymentByAmount(ref PaymentID, ref OrderID, Amount, ref Method, ref PaidAt);

            if (IsFound)
                return new ClsPayment(PaymentID, OrderID, Amount, Method, PaidAt);
            else
                return null;
        }
        public static ClsPayment FindByMethod(string Method)
        {
            int PaymentID = -1;
            int OrderID = -1;
            decimal Amount = -1;
            DateTime PaidAt = DateTime.MinValue;

            bool IsFound = ClsPaymentData.GetPaymentByMethod(ref PaymentID, ref OrderID, ref Amount, Method, ref PaidAt);

            if (IsFound)
                return new ClsPayment(PaymentID, OrderID, Amount, Method, PaidAt);
            else
                return null;
        }
        public static ClsPayment FindByPaidAt(DateTime PaidAt)
        {
            int PaymentID = -1;
            int OrderID = -1;
            decimal Amount = -1;
            string Method = "";

            bool IsFound = ClsPaymentData.GetPaymentByPaidAt(ref PaymentID, ref OrderID, ref Amount, ref Method, PaidAt);

            if (IsFound)
                return new ClsPayment(PaymentID, OrderID, Amount, Method, PaidAt);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPayment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePayment();
            }
            return false;
        }
        public static DataTable GetPayments()
        {
            return ClsPaymentData.GetAllPayments();
        }
    }
}
