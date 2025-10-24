using ClsCategoryDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsCategoryBusinessLayer
{
    public class ClsCategory
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int CategoryID { set; get; }
        public string CategoryName { set; get; }
        public string Description { set; get; }
        public DateTime CreatedAt { set; get; }
        public DateTime Updated { set; get; }

        public ClsCategory()
        {
            this.CategoryID = -1;
            this.CategoryName = "";
            this.Description = "";
            this.CreatedAt = DateTime.MinValue;
            this.Updated = DateTime.MinValue;
            Mode = enMode.AddNew;
        }
        private ClsCategory(int CategoryID, string CategoryName, string Description, DateTime CreatedAt, DateTime Updated)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
            this.Description = Description;
            this.CreatedAt = CreatedAt;
            this.Updated = Updated;
            Mode = enMode.Update;
        }
        private bool _AddNewCategory()
        {
            this.CategoryID = (int)ClsCategoryData.AddNewCategory(this.CategoryName, this.Description, this.CreatedAt, this.Updated);
            return (this.CategoryID != -1);
        }
        private bool _UpdateCategory()
        {
            return ClsCategoryData.UpdateCategory(this.CategoryID, this.CategoryName, this.Description, this.CreatedAt, this.Updated);
        }
        public static bool DeleteCategory(int CategoryID)
        {
            return ClsCategoryData.DeleteCategory(CategoryID);
        }
        public static bool IsCategoryExistByCategoryID(int CategoryID)
        {
            return ClsCategoryData.IsCategoryExistByCategoryID(CategoryID);
        }
        public static bool IsCategoryExistByCategoryName(string CategoryName)
        {
            return ClsCategoryData.IsCategoryExistByCategoryName(CategoryName);
        }
        public static bool IsCategoryExistByDescription(string Description)
        {
            return ClsCategoryData.IsCategoryExistByDescription(Description);
        }
        public static bool IsCategoryExistByCreatedAt(DateTime CreatedAt)
        {
            return ClsCategoryData.IsCategoryExistByCreatedAt(CreatedAt);
        }
        public static bool IsCategoryExistByUpdated(DateTime Updated)
        {
            return ClsCategoryData.IsCategoryExistByUpdated(Updated);
        }
        public static ClsCategory FindByCategoryID(int CategoryID)
        {
            string CategoryName = "";
            string Description = "";
            DateTime CreatedAt = DateTime.MinValue;
            DateTime Updated = DateTime.MinValue;

            bool IsFound = ClsCategoryData.GetCategoryByCategoryID(CategoryID, ref CategoryName, ref Description, ref CreatedAt, ref Updated);

            if (IsFound)
                return new ClsCategory(CategoryID, CategoryName, Description, CreatedAt, Updated);
            else
                return null;
        }
        public static ClsCategory FindByCategoryName(string CategoryName)
        {
            int CategoryID = -1;
            string Description = "";
            DateTime CreatedAt = DateTime.MinValue;
            DateTime Updated = DateTime.MinValue;

            bool IsFound = ClsCategoryData.GetCategoryByCategoryName(ref CategoryID, CategoryName, ref Description, ref CreatedAt, ref Updated);

            if (IsFound)
                return new ClsCategory(CategoryID, CategoryName, Description, CreatedAt, Updated);
            else
                return null;
        }
        public static ClsCategory FindByDescription(string Description)
        {
            int CategoryID = -1;
            string CategoryName = "";
            DateTime CreatedAt = DateTime.MinValue;
            DateTime Updated = DateTime.MinValue;

            bool IsFound = ClsCategoryData.GetCategoryByDescription(ref CategoryID, ref CategoryName, Description, ref CreatedAt, ref Updated);

            if (IsFound)
                return new ClsCategory(CategoryID, CategoryName, Description, CreatedAt, Updated);
            else
                return null;
        }
        public static ClsCategory FindByCreatedAt(DateTime CreatedAt)
        {
            int CategoryID = -1;
            string CategoryName = "";
            string Description = "";
            DateTime Updated = DateTime.MinValue;

            bool IsFound = ClsCategoryData.GetCategoryByCreatedAt(ref CategoryID, ref CategoryName, ref Description, CreatedAt, ref Updated);

            if (IsFound)
                return new ClsCategory(CategoryID, CategoryName, Description, CreatedAt, Updated);
            else
                return null;
        }
        public static ClsCategory FindByUpdated(DateTime Updated)
        {
            int CategoryID = -1;
            string CategoryName = "";
            string Description = "";
            DateTime CreatedAt = DateTime.MinValue;

            bool IsFound = ClsCategoryData.GetCategoryByUpdated(ref CategoryID, ref CategoryName, ref Description, ref CreatedAt, Updated);

            if (IsFound)
                return new ClsCategory(CategoryID, CategoryName, Description, CreatedAt, Updated);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCategory())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateCategory();
            }
            return false;
        }
        public static DataTable GetCategories()
        {
            return ClsCategoryData.GetAllCategories();
        }

        public static string GetCategoryNameByID(int CategoryID)
        {
            return ClsCategoryData.GetCategoryNameByID(CategoryID);
        }
        
        public static bool IsCategoryReferenceToAnyItemByID(int CategoryID)
        {
            return ClsCategoryData.IsCategoryReferenceToAnyItemByID(CategoryID);
        }
    }
}