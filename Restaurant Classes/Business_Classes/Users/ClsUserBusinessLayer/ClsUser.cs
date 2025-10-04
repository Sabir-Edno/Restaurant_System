using ClsUserDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsUserBusinessLayer
{
    public class ClsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int UserID { set; get; }
        public string Username { set; get; }
        public int Password { set; get; }
        public string Role { set; get; }
        public string FullName { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }

        public ClsUser()
        {
            this.UserID = -1;
            this.Username = "";
            this.Password = -1;
            this.Role = "";
            this.FullName = "";
            this.Phone = "";
            this.Email = "";
            Mode = enMode.AddNew;
        }
        private ClsUser(int UserID, string Username, int Password, string Role, string FullName, string Phone, string Email)
        {
            this.UserID = UserID;
            this.Username = Username;
            this.Password = Password;
            this.Role = Role;
            this.FullName = FullName;
            this.Phone = Phone;
            this.Email = Email;
            Mode = enMode.Update;
        }
        private bool _AddNewUser()
        {
            this.UserID = (int)ClsUserData.AddNewUser(this.Username, this.Password, this.Role, this.FullName, this.Phone, this.Email);
            return (this.UserID != -1);
        }
        private bool _UpdateUser()
        {
            return ClsUserData.UpdateUser(this.UserID, this.Username, this.Password, this.Role, this.FullName, this.Phone, this.Email);
        }
        public static bool DeleteUser(int UserID)
        {
            return ClsUserData.DeleteUser(UserID);
        }
        public static bool IsUserExistByUserID(int UserID)
        {
            return ClsUserData.IsUserExistByUserID(UserID);
        }
        public static bool IsUserExistByUsername(string Username)
        {
            return ClsUserData.IsUserExistByUsername(Username);
        }
        public static bool IsUserExistByPassword(int Password)
        {
            return ClsUserData.IsUserExistByPassword(Password);
        }
        public static bool IsUserExistByRole(string Role)
        {
            return ClsUserData.IsUserExistByRole(Role);
        }
        public static bool IsUserExistByFullName(string FullName)
        {
            return ClsUserData.IsUserExistByFullName(FullName);
        }
        public static bool IsUserExistByPhone(string Phone)
        {
            return ClsUserData.IsUserExistByPhone(Phone);
        }
        public static bool IsUserExistByEmail(string Email)
        {
            return ClsUserData.IsUserExistByEmail(Email);
        }
        public static ClsUser FindByUserID(int UserID)
        {
            string Username = "";
            int Password = -1;
            string Role = "";
            string FullName = "";
            string Phone = "";
            string Email = "";

            bool IsFound = ClsUserData.GetUserByUserID(UserID, ref Username, ref Password, ref Role, ref FullName, ref Phone, ref Email);

            if (IsFound)
                return new ClsUser(UserID, Username, Password, Role, FullName, Phone, Email);
            else
                return null;
        }
        public static ClsUser FindByUsername(string Username)
        {
            int UserID = -1;
            int Password = -1;
            string Role = "";
            string FullName = "";
            string Phone = "";
            string Email = "";

            bool IsFound = ClsUserData.GetUserByUsername(ref UserID, Username, ref Password, ref Role, ref FullName, ref Phone, ref Email);

            if (IsFound)
                return new ClsUser(UserID, Username, Password, Role, FullName, Phone, Email);
            else
                return null;
        }
        public static ClsUser FindByPassword(int Password)
        {
            int UserID = -1;
            string Username = "";
            string Role = "";
            string FullName = "";
            string Phone = "";
            string Email = "";

            bool IsFound = ClsUserData.GetUserByPassword(ref UserID, ref Username, Password, ref Role, ref FullName, ref Phone, ref Email);

            if (IsFound)
                return new ClsUser(UserID, Username, Password, Role, FullName, Phone, Email);
            else
                return null;
        }
        public static ClsUser FindByRole(string Role)
        {
            int UserID = -1;
            string Username = "";
            int Password = -1;
            string FullName = "";
            string Phone = "";
            string Email = "";

            bool IsFound = ClsUserData.GetUserByRole(ref UserID, ref Username, ref Password, Role, ref FullName, ref Phone, ref Email);

            if (IsFound)
                return new ClsUser(UserID, Username, Password, Role, FullName, Phone, Email);
            else
                return null;
        }
        public static ClsUser FindByFullName(string FullName)
        {
            int UserID = -1;
            string Username = "";
            int Password = -1;
            string Role = "";
            string Phone = "";
            string Email = "";

            bool IsFound = ClsUserData.GetUserByFullName(ref UserID, ref Username, ref Password, ref Role, FullName, ref Phone, ref Email);

            if (IsFound)
                return new ClsUser(UserID, Username, Password, Role, FullName, Phone, Email);
            else
                return null;
        }
        public static ClsUser FindByPhone(string Phone)
        {
            int UserID = -1;
            string Username = "";
            int Password = -1;
            string Role = "";
            string FullName = "";
            string Email = "";

            bool IsFound = ClsUserData.GetUserByPhone(ref UserID, ref Username, ref Password, ref Role, ref FullName, Phone, ref Email);

            if (IsFound)
                return new ClsUser(UserID, Username, Password, Role, FullName, Phone, Email);
            else
                return null;
        }
        public static ClsUser FindByEmail(string Email)
        {
            int UserID = -1;
            string Username = "";
            int Password = -1;
            string Role = "";
            string FullName = "";
            string Phone = "";

            bool IsFound = ClsUserData.GetUserByEmail(ref UserID, ref Username, ref Password, ref Role, ref FullName, ref Phone, Email);

            if (IsFound)
                return new ClsUser(UserID, Username, Password, Role, FullName, Phone, Email);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }
        public static DataTable GetUsers()
        {
            return ClsUserData.GetAllUsers();
        }
    }
}
