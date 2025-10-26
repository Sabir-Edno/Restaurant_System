using ClsUserDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Password_Lib;

namespace ClsUserBusinessLayer
{
    public class ClsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int UserID { set; get; }
        public string FullName { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public int RoleID { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public bool Status { set; get; }
        public DateTime CreatedAt { set; get; }
        public DateTime Updated { set; get; }

        public ClsUser()
        {
            this.UserID = -1;
            this.FullName = "";
            this.Username = "";
            this.Password = "";
            this.RoleID = -1;
            this.Phone = "";
            this.Email = "";
            this.Status = false;
            this.CreatedAt = DateTime.MinValue;
            this.Updated = DateTime.MinValue;
            Mode = enMode.AddNew;
        }
        private ClsUser(int UserID, string FullName, string Username, string Password, int RoleID, string Phone, string Email, bool Status, DateTime CreatedAt, DateTime Updated)
        {
            this.UserID = UserID;
            this.FullName = FullName;
            this.Username = Username;
            this.Password = Password;
            this.RoleID = RoleID;
            this.Phone = Phone;
            this.Email = Email;
            this.Status = Status;
            this.CreatedAt = CreatedAt;
            this.Updated = Updated;
            Mode = enMode.Update;
        }
        private bool _AddNewUser()
        {
            this.UserID = (int)ClsUserData.AddNewUser(this.FullName, this.Username, PasswordLib.ComputeHash(this.Password), this.RoleID, this.Phone, this.Email, this.Status, this.CreatedAt, this.Updated);
            return (this.UserID != -1);
        }
        private bool _UpdateUser()
        {
            return ClsUserData.UpdateUser(this.UserID, this.FullName, this.Username, this.RoleID, this.Phone, this.Email, this.Status, this.CreatedAt, this.Updated);
        }
        public static bool DeleteUser(int UserID)
        {
            return ClsUserData.DeleteUser(UserID);
        }
        public static bool IsUserExistByUserID(int UserID)
        {
            return ClsUserData.IsUserExistByUserID(UserID);
        }
        public static bool IsUserExistByFullName(string FullName)
        {
            return ClsUserData.IsUserExistByFullName(FullName);
        }
        public static bool IsUserExistByUsername(string Username)
        {
            return ClsUserData.IsUserExistByUsername(Username);
        }
        public static bool IsUserExistByPassword(string Password)
        {
            return ClsUserData.IsUserExistByPassword(Password);
        }
        public static bool IsUserExistByRoleID(int RoleID)
        {
            return ClsUserData.IsUserExistByRoleID(RoleID);
        }
        public static bool IsUserExistByPhone(string Phone)
        {
            return ClsUserData.IsUserExistByPhone(Phone);
        }
        public static bool IsUserExistByEmail(string Email)
        {
            return ClsUserData.IsUserExistByEmail(Email);
        }
        public static bool IsUserExistByStatus(bool Status)
        {
            return ClsUserData.IsUserExistByStatus(Status);
        }
        public static bool IsUserExistByCreatedAt(DateTime CreatedAt)
        {
            return ClsUserData.IsUserExistByCreatedAt(CreatedAt);
        }
        public static bool IsUserExistByUpdated(DateTime Updated)
        {
            return ClsUserData.IsUserExistByUpdated(Updated);
        }
        public static ClsUser FindByUserID(int UserID)
        {
            string FullName = "";
            string Username = "";
            string Password = "";
            int RoleID = -1;
            string Phone = "";
            string Email = "";
            bool Status = false;
            DateTime CreatedAt = DateTime.MinValue;
            DateTime Updated = DateTime.MinValue;

            bool IsFound = ClsUserData.GetUserByUserID(UserID, ref FullName, ref Username, ref Password, ref RoleID, ref Phone, ref Email, ref Status, ref CreatedAt, ref Updated);

            if (IsFound)
                return new ClsUser(UserID, FullName, Username, Password, RoleID, Phone, Email, Status, CreatedAt, Updated);
            else
                return null;
        }
        public static ClsUser FindByFullName(string FullName)
        {
            int UserID = -1;
            string Username = "";
            string Password = "";
            int RoleID = -1;
            string Phone = "";
            string Email = "";
            bool Status = false;
            DateTime CreatedAt = DateTime.MinValue;
            DateTime Updated = DateTime.MinValue;

            bool IsFound = ClsUserData.GetUserByFullName(ref UserID, FullName, ref Username, ref Password, ref RoleID, ref Phone, ref Email, ref Status, ref CreatedAt, ref Updated);

            if (IsFound)
                return new ClsUser(UserID, FullName, Username, Password, RoleID, Phone, Email, Status, CreatedAt, Updated);
            else
                return null;
        }
        public static ClsUser FindByUsername(string Username)
        {
            int UserID = -1;
            string FullName = "";
            string Password = "";
            int RoleID = -1;
            string Phone = "";
            string Email = "";
            bool Status = false;
            DateTime CreatedAt = DateTime.MinValue;
            DateTime Updated = DateTime.MinValue;

            bool IsFound = ClsUserData.GetUserByUsername(ref UserID, ref FullName, Username, ref Password, ref RoleID, ref Phone, ref Email, ref Status, ref CreatedAt, ref Updated);

            if (IsFound)
                return new ClsUser(UserID, FullName, Username, Password, RoleID, Phone, Email, Status, CreatedAt, Updated);
            else
                return null;
        }
        public static ClsUser FindByPassword(string Password)
        {
            int UserID = -1;
            string FullName = "";
            string Username = "";
            int RoleID = -1;
            string Phone = "";
            string Email = "";
            bool Status = false;
            DateTime CreatedAt = DateTime.MinValue;
            DateTime Updated = DateTime.MinValue;

            bool IsFound = ClsUserData.GetUserByPassword(ref UserID, ref FullName, ref Username, Password, ref RoleID, ref Phone, ref Email, ref Status, ref CreatedAt, ref Updated);

            if (IsFound)
                return new ClsUser(UserID, FullName, Username, Password, RoleID, Phone, Email, Status, CreatedAt, Updated);
            else
                return null;
        }
        public static ClsUser FindByRoleID(int RoleID)
        {
            int UserID = -1;
            string FullName = "";
            string Username = "";
            string Password = "";
            string Phone = "";
            string Email = "";
            bool Status = false;
            DateTime CreatedAt = DateTime.MinValue;
            DateTime Updated = DateTime.MinValue;

            bool IsFound = ClsUserData.GetUserByRoleID(ref UserID, ref FullName, ref Username, ref Password, RoleID, ref Phone, ref Email, ref Status, ref CreatedAt, ref Updated);

            if (IsFound)
                return new ClsUser(UserID, FullName, Username, Password, RoleID, Phone, Email, Status, CreatedAt, Updated);
            else
                return null;
        }
        public static ClsUser FindByPhone(string Phone)
        {
            int UserID = -1;
            string FullName = "";
            string Username = "";
            string Password = "";
            int RoleID = -1;
            string Email = "";
            bool Status = false;
            DateTime CreatedAt = DateTime.MinValue;
            DateTime Updated = DateTime.MinValue;

            bool IsFound = ClsUserData.GetUserByPhone(ref UserID, ref FullName, ref Username, ref Password, ref RoleID, Phone, ref Email, ref Status, ref CreatedAt, ref Updated);

            if (IsFound)
                return new ClsUser(UserID, FullName, Username, Password, RoleID, Phone, Email, Status, CreatedAt, Updated);
            else
                return null;
        }
        public static ClsUser FindByEmail(string Email)
        {
            int UserID = -1;
            string FullName = "";
            string Username = "";
            string Password = "";
            int RoleID = -1;
            string Phone = "";
            bool Status = false;
            DateTime CreatedAt = DateTime.MinValue;
            DateTime Updated = DateTime.MinValue;

            bool IsFound = ClsUserData.GetUserByEmail(ref UserID, ref FullName, ref Username, ref Password, ref RoleID, ref Phone, Email, ref Status, ref CreatedAt, ref Updated);

            if (IsFound)
                return new ClsUser(UserID, FullName, Username, Password, RoleID, Phone, Email, Status, CreatedAt, Updated);
            else
                return null;
        }
        public static ClsUser FindByStatus(bool Status)
        {
            int UserID = -1;
            string FullName = "";
            string Username = "";
            string Password = "";
            int RoleID = -1;
            string Phone = "";
            string Email = "";
            DateTime CreatedAt = DateTime.MinValue;
            DateTime Updated = DateTime.MinValue;

            bool IsFound = ClsUserData.GetUserByStatus(ref UserID, ref FullName, ref Username, ref Password, ref RoleID, ref Phone, ref Email, Status, ref CreatedAt, ref Updated);

            if (IsFound)
                return new ClsUser(UserID, FullName, Username, Password, RoleID, Phone, Email, Status, CreatedAt, Updated);
            else
                return null;
        }
        public static ClsUser FindByCreatedAt(DateTime CreatedAt)
        {
            int UserID = -1;
            string FullName = "";
            string Username = "";
            string Password = "";
            int RoleID = -1;
            string Phone = "";
            string Email = "";
            bool Status = false;
            DateTime Updated = DateTime.MinValue;

            bool IsFound = ClsUserData.GetUserByCreatedAt(ref UserID, ref FullName, ref Username, ref Password, ref RoleID, ref Phone, ref Email, ref Status, CreatedAt, ref Updated);

            if (IsFound)
                return new ClsUser(UserID, FullName, Username, Password, RoleID, Phone, Email, Status, CreatedAt, Updated);
            else
                return null;
        }
        public static ClsUser FindByUpdated(DateTime Updated)
        {
            int UserID = -1;
            string FullName = "";
            string Username = "";
            string Password = "";
            int RoleID = -1;
            string Phone = "";
            string Email = "";
            bool Status = false;
            DateTime CreatedAt = DateTime.MinValue;

            bool IsFound = ClsUserData.GetUserByUpdated(ref UserID, ref FullName, ref Username, ref Password, ref RoleID, ref Phone, ref Email, ref Status, ref CreatedAt, Updated);

            if (IsFound)
                return new ClsUser(UserID, FullName, Username, Password, RoleID, Phone, Email, Status, CreatedAt, Updated);
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
        public static DataTable GetAllUsers()
        {
            return ClsUserData.GetAllUsers();
        }

        public static bool IsUserExistByUserNameWithRole(string Username ,int RoleID)
        {
            return ClsUserData.IsUserExistByUserNameWithRole(Username ,RoleID);
        }

        public static bool IsUsernameAndPasswordCorrect(string Username, string Password, int RoleID)
        {
            return ClsUserData.IsUsernameAndPasswordCorrect(Username, PasswordLib.ComputeHash(Password), RoleID);
        }

        public static bool IsUserActive(string Username, int RoleID)
        {
            return ClsUserData.IsUserActive(Username,RoleID);
        }

        public static DataTable GetAllAdmins()
        {
            return ClsUserData.GetAllAdmins();
        }
        public static DataTable GetAllChefs()
        {
            return ClsUserData.GetAllChefs();
        }
        public static DataTable GetAllWaiters()
        {
            return ClsUserData.GetAllWaiters();
        }
        public static DataTable GetAllManagers()
        {
            return ClsUserData.GetAllManagers();
        }
        public static bool IsUserReferenceToAnyOrderByID(int UserID)
        {
            return ClsUserData.IsUserReferenceToAnyOrderByID(UserID);
        }

    }
}