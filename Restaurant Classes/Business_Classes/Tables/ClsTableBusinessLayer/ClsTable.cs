using ClsTableDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsTableBusinessLayer
{
    public class ClsTable
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int TableID { set; get; }
        public string TableName { set; get; }
        public string Status { set; get; }

        public ClsTable()
        {
            this.TableID = -1;
            this.TableName = "";
            this.Status = "";
            Mode = enMode.AddNew;
        }
        private ClsTable(int TableID, string TableName, string Status)
        {
            this.TableID = TableID;
            this.TableName = TableName;
            this.Status = Status;
            Mode = enMode.Update;
        }
        private bool _AddNewTable()
        {
            this.TableID = (int)ClsTableData.AddNewTable(this.TableName, this.Status);
            return (this.TableID != -1);
        }
        private bool _UpdateTable()
        {
            return ClsTableData.UpdateTable(this.TableID, this.TableName, this.Status);
        }
        public static bool DeleteTable(int TableID)
        {
            return ClsTableData.DeleteTable(TableID);
        }
        public static bool IsTableExistByTableID(int TableID)
        {
            return ClsTableData.IsTableExistByTableID(TableID);
        }
        public static bool IsTableExistByTableName(string TableName)
        {
            return ClsTableData.IsTableExistByTableName(TableName);
        }
        public static bool IsTableExistByStatus(string Status)
        {
            return ClsTableData.IsTableExistByStatus(Status);
        }
        public static ClsTable FindByTableID(int TableID)
        {
            string TableName = "";
            string Status = "";

            bool IsFound = ClsTableData.GetTableByTableID(TableID, ref TableName, ref Status);

            if (IsFound)
                return new ClsTable(TableID, TableName, Status);
            else
                return null;
        }
        public static ClsTable FindByTableName(string TableName)
        {
            int TableID = -1;
            string Status = "";

            bool IsFound = ClsTableData.GetTableByTableName(ref TableID, TableName, ref Status);

            if (IsFound)
                return new ClsTable(TableID, TableName, Status);
            else
                return null;
        }
        public static ClsTable FindByStatus(string Status)
        {
            int TableID = -1;
            string TableName = "";

            bool IsFound = ClsTableData.GetTableByStatus(ref TableID, ref TableName, Status);

            if (IsFound)
                return new ClsTable(TableID, TableName, Status);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTable())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateTable();
            }
            return false;
        }
        public static DataTable GetTables()
        {
            return ClsTableData.GetAllTables();
        }
    }
}
