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
        public string Name { set; get; }

        public ClsCategory()
        {
            this.CategoryID = -1;
            this.Name = "";
            Mode = enMode.AddNew;
        }
        private ClsCategory(int CategoryID, string Name)
        {
            this.CategoryID = CategoryID;
            this.Name = Name;
            Mode = enMode.Update;
        }
        private bool _AddNewCategory()
        {
            this.CategoryID = (int)ClsCategoryData.AddNewCategory(this.Name);
            return (this.CategoryID != -1);
        }
        private bool _UpdateCategory()
        {
            return ClsCategoryData.UpdateCategory(this.CategoryID, this.Name);
        }
        public static bool DeleteCategory(int CategoryID)
        {
            return ClsCategoryData.DeleteCategory(CategoryID);
        }
        public static bool IsCategoryExistByCategoryID(int CategoryID)
        {
            return ClsCategoryData.IsCategoryExistByCategoryID(CategoryID);
        }
        public static bool IsCategoryExistByName(string Name)
        {
            return ClsCategoryData.IsCategoryExistByName(Name);
        }
        public static ClsCategory FindByCategoryID(int CategoryID)
        {
            string Name = "";

            bool IsFound = ClsCategoryData.GetCategoryByCategoryID(CategoryID, ref Name);

            if (IsFound)
                return new ClsCategory(CategoryID, Name);
            else
                return null;
        }
        public static ClsCategory FindByName(string Name)
        {
            int CategoryID = -1;

            bool IsFound = ClsCategoryData.GetCategoryByName(ref CategoryID, Name);

            if (IsFound)
                return new ClsCategory(CategoryID, Name);
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
    }
}
