using ClsRoleDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsRoleBusinessLayer
{
    public class ClsRole
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int RoleID { set; get; }
        public string Name { set; get; }
        public int Permission { set; get; }

        public ClsRole()
        {
            this.RoleID = -1;
            this.Name = "";
            this.Permission = -1;
            Mode = enMode.AddNew;
        }
        private ClsRole(int RoleID, string Name, int Permission)
        {
            this.RoleID = RoleID;
            this.Name = Name;
            this.Permission = Permission;
            Mode = enMode.Update;
        }
        private bool _AddNewRole()
        {
            this.RoleID = (int)ClsRoleData.AddNewRole(this.Name, this.Permission);
            return (this.RoleID != -1);
        }
        private bool _UpdateRole()
        {
            return ClsRoleData.UpdateRole(this.RoleID, this.Name, this.Permission);
        }
        public static bool DeleteRole(int RoleID)
        {
            return ClsRoleData.DeleteRole(RoleID);
        }
        public static bool IsRoleExistByRoleID(int RoleID)
        {
            return ClsRoleData.IsRoleExistByRoleID(RoleID);
        }
        public static bool IsRoleExistByName(string Name)
        {
            return ClsRoleData.IsRoleExistByName(Name);
        }
        public static bool IsRoleExistByPermission(int Permission)
        {
            return ClsRoleData.IsRoleExistByPermission(Permission);
        }
        public static ClsRole FindByRoleID(int RoleID)
        {
            string Name = "";
            int Permission = -1;

            bool IsFound = ClsRoleData.GetRoleByRoleID(RoleID, ref Name, ref Permission);

            if (IsFound)
                return new ClsRole(RoleID, Name, Permission);
            else
                return null;
        }
        public static ClsRole FindByName(string Name)
        {
            int RoleID = -1;
            int Permission = -1;

            bool IsFound = ClsRoleData.GetRoleByName(ref RoleID, Name, ref Permission);

            if (IsFound)
                return new ClsRole(RoleID, Name, Permission);
            else
                return null;
        }
        public static ClsRole FindByPermission(int Permission)
        {
            int RoleID = -1;
            string Name = "";

            bool IsFound = ClsRoleData.GetRoleByPermission(ref RoleID, ref Name, Permission);

            if (IsFound)
                return new ClsRole(RoleID, Name, Permission);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRole())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateRole();
            }
            return false;
        }
        public static DataTable GetRoles()
        {
            return ClsRoleData.GetAllRoles();
        }
    }
}
