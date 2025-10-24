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
        public int Capacity { set; get; }
        public string Status { set; get; }
        public DateTime CreatedAt { set; get; }
        public DateTime Updated { set; get; }

        public ClsTable()
        {
            this.TableID = -1;
            this.TableName = "";
            this.Capacity = -1;
            this.Status = "";
            this.CreatedAt = DateTime.MinValue;
            this.Updated = DateTime.MinValue;
            Mode = enMode.AddNew;
        }
        private ClsTable(int TableID, string TableName, int Capacity, string Status, DateTime CreatedAt, DateTime Updated)
        {
            this.TableID = TableID;
            this.TableName = TableName;
            this.Capacity = Capacity;
            this.Status = Status;
            this.CreatedAt = CreatedAt;
            this.Updated = Updated;
            Mode = enMode.Update;
        }
        private bool _AddNewTable()
        {
            this.TableID = (int)ClsTableData.AddNewTable(this.TableName, this.Capacity, this.Status, this.CreatedAt, this.Updated);
            return (this.TableID != -1);
        }
        private bool _UpdateTable()
        {
            return ClsTableData.UpdateTable(this.TableID, this.TableName, this.Capacity, this.Status, this.CreatedAt, this.Updated);
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
        public static bool IsTableExistByCapacity(int Capacity)
        {
            return ClsTableData.IsTableExistByCapacity(Capacity);
        }
        public static bool IsTableExistByStatus(string Status)
        {
            return ClsTableData.IsTableExistByStatus(Status);
        }
        public static bool IsTableExistByCreatedAt(DateTime CreatedAt)
        {
            return ClsTableData.IsTableExistByCreatedAt(CreatedAt);
        }
        public static bool IsTableExistByUpdated(DateTime Updated)
        {
            return ClsTableData.IsTableExistByUpdated(Updated);
        }
        public static ClsTable FindByTableID(int TableID)
        {
            string TableName = "";
            int Capacity = -1;
            string Status = "";
            DateTime CreatedAt = DateTime.MinValue;
            DateTime Updated = DateTime.MinValue;

            bool IsFound = ClsTableData.GetTableByTableID(TableID, ref TableName, ref Capacity, ref Status, ref CreatedAt, ref Updated);

            if (IsFound)
                return new ClsTable(TableID, TableName, Capacity, Status, CreatedAt, Updated);
            else
                return null;
        }
        public static ClsTable FindByTableName(string TableName)
        {
            int TableID = -1;
            int Capacity = -1;
            string Status = "";
            DateTime CreatedAt = DateTime.MinValue;
            DateTime Updated = DateTime.MinValue;

            bool IsFound = ClsTableData.GetTableByTableName(ref TableID, TableName, ref Capacity, ref Status, ref CreatedAt, ref Updated);

            if (IsFound)
                return new ClsTable(TableID, TableName, Capacity, Status, CreatedAt, Updated);
            else
                return null;
        }
        public static ClsTable FindByCapacity(int Capacity)
        {
            int TableID = -1;
            string TableName = "";
            string Status = "";
            DateTime CreatedAt = DateTime.MinValue;
            DateTime Updated = DateTime.MinValue;

            bool IsFound = ClsTableData.GetTableByCapacity(ref TableID, ref TableName, Capacity, ref Status, ref CreatedAt, ref Updated);

            if (IsFound)
                return new ClsTable(TableID, TableName, Capacity, Status, CreatedAt, Updated);
            else
                return null;
        }
        public static ClsTable FindByStatus(string Status)
        {
            int TableID = -1;
            string TableName = "";
            int Capacity = -1;
            DateTime CreatedAt = DateTime.MinValue;
            DateTime Updated = DateTime.MinValue;

            bool IsFound = ClsTableData.GetTableByStatus(ref TableID, ref TableName, ref Capacity, Status, ref CreatedAt, ref Updated);

            if (IsFound)
                return new ClsTable(TableID, TableName, Capacity, Status, CreatedAt, Updated);
            else
                return null;
        }
        public static ClsTable FindByCreatedAt(DateTime CreatedAt)
        {
            int TableID = -1;
            string TableName = "";
            int Capacity = -1;
            string Status = "";
            DateTime Updated = DateTime.MinValue;

            bool IsFound = ClsTableData.GetTableByCreatedAt(ref TableID, ref TableName, ref Capacity, ref Status, CreatedAt, ref Updated);

            if (IsFound)
                return new ClsTable(TableID, TableName, Capacity, Status, CreatedAt, Updated);
            else
                return null;
        }
        public static ClsTable FindByUpdated(DateTime Updated)
        {
            int TableID = -1;
            string TableName = "";
            int Capacity = -1;
            string Status = "";
            DateTime CreatedAt = DateTime.MinValue;

            bool IsFound = ClsTableData.GetTableByUpdated(ref TableID, ref TableName, ref Capacity, ref Status, ref CreatedAt, Updated);

            if (IsFound)
                return new ClsTable(TableID, TableName, Capacity, Status, CreatedAt, Updated);
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

        public static bool IsItemReferenceToAnyOrderByID(int TableID)
        {
            return ClsTableData.IsItemReferenceToAnyOrderByID(TableID);
        }

        
    }
}