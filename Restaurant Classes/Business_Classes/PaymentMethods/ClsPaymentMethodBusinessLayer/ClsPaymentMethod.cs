using ClsPaymentMethodDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsPaymentMethodBusinessLayer
{
    public class ClsPaymentMethod
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int PaymentMethodID { set; get; }
        public string Name { set; get; }

        public ClsPaymentMethod()
        {
            this.PaymentMethodID = -1;
            this.Name = "";
            Mode = enMode.AddNew;
        }
        private ClsPaymentMethod(int PaymentMethodID, string Name)
        {
            this.PaymentMethodID = PaymentMethodID;
            this.Name = Name;
            Mode = enMode.Update;
        }
        private bool _AddNewPaymentMethod()
        {
            this.PaymentMethodID = (int)ClsPaymentMethodData.AddNewPaymentMethod(this.Name);
            return (this.PaymentMethodID != -1);
        }
        private bool _UpdatePaymentMethod()
        {
            return ClsPaymentMethodData.UpdatePaymentMethod(this.PaymentMethodID, this.Name);
        }
        public static bool DeletePaymentMethod(int PaymentMethodID)
        {
            return ClsPaymentMethodData.DeletePaymentMethod(PaymentMethodID);
        }
        public static bool IsPaymentMethodExistByPaymentMethodID(int PaymentMethodID)
        {
            return ClsPaymentMethodData.IsPaymentMethodExistByPaymentMethodID(PaymentMethodID);
        }
        public static bool IsPaymentMethodExistByName(string Name)
        {
            return ClsPaymentMethodData.IsPaymentMethodExistByName(Name);
        }
        public static ClsPaymentMethod FindByPaymentMethodID(int PaymentMethodID)
        {
            string Name = "";

            bool IsFound = ClsPaymentMethodData.GetPaymentMethodByPaymentMethodID(PaymentMethodID, ref Name);

            if (IsFound)
                return new ClsPaymentMethod(PaymentMethodID, Name);
            else
                return null;
        }
        public static ClsPaymentMethod FindByName(string Name)
        {
            int PaymentMethodID = -1;

            bool IsFound = ClsPaymentMethodData.GetPaymentMethodByName(ref PaymentMethodID, Name);

            if (IsFound)
                return new ClsPaymentMethod(PaymentMethodID, Name);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPaymentMethod())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePaymentMethod();
            }
            return false;
        }
        public static DataTable GetPaymentMethods()
        {
            return ClsPaymentMethodData.GetAllPaymentMethods();
        }
    }
}
