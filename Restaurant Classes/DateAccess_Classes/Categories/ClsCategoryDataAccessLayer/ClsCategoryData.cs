using ClsConnectionStringLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsCategoryDataAccessLayer
{
    public class ClsCategoryData
    {
        public static bool GetCategoryByID(int CategoryID, ref string CategoryName, ref string Description, ref DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM Categories WHERE CategoryID = @CategoryID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryID", CategoryID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                CategoryName = (string)reader["CategoryName"];

                                if (reader["Description"] != DBNull.Value)
                                    Description = (string)reader["Description"];
                                else
                                    Description = "";

                                CreatedAt = (DateTime)reader["CreatedAt"];

                                if (reader["Updated"] != DBNull.Value)
                                    Updated = (DateTime)reader["Updated"];
                                else
                                    Updated = DateTime.MinValue;

                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetCategoryByCategoryID(int CategoryID, ref string CategoryName, ref string Description, ref DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM Categories WHERE CategoryID = @CategoryID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryID", CategoryID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                CategoryName = (string)reader["CategoryName"];

                                if (reader["Description"] != DBNull.Value)
                                    Description = (string)reader["Description"];
                                else
                                    Description = "";

                                CreatedAt = (DateTime)reader["CreatedAt"];

                                if (reader["Updated"] != DBNull.Value)
                                    Updated = (DateTime)reader["Updated"];
                                else
                                    Updated = DateTime.MinValue;

                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetCategoryByCategoryName(ref int CategoryID, string CategoryName, ref string Description, ref DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM Categories WHERE CategoryName = @CategoryName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryName", CategoryName);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                CategoryID = (int)reader["CategoryID"];

                                if (reader["Description"] != DBNull.Value)
                                    Description = (string)reader["Description"];
                                else
                                    Description = "";

                                CreatedAt = (DateTime)reader["CreatedAt"];

                                if (reader["Updated"] != DBNull.Value)
                                    Updated = (DateTime)reader["Updated"];
                                else
                                    Updated = DateTime.MinValue;

                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetCategoryByDescription(ref int CategoryID, ref string CategoryName, string Description, ref DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM Categories WHERE Description = @Description";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Description", Description);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                CategoryID = (int)reader["CategoryID"];
                                CategoryName = (string)reader["CategoryName"];
                                CreatedAt = (DateTime)reader["CreatedAt"];

                                if (reader["Updated"] != DBNull.Value)
                                    Updated = (DateTime)reader["Updated"];
                                else
                                    Updated = DateTime.MinValue;

                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetCategoryByCreatedAt(ref int CategoryID, ref string CategoryName, ref string Description, DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM Categories WHERE CreatedAt = @CreatedAt";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                CategoryID = (int)reader["CategoryID"];
                                CategoryName = (string)reader["CategoryName"];

                                if (reader["Description"] != DBNull.Value)
                                    Description = (string)reader["Description"];
                                else
                                    Description = "";


                                if (reader["Updated"] != DBNull.Value)
                                    Updated = (DateTime)reader["Updated"];
                                else
                                    Updated = DateTime.MinValue;

                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetCategoryByUpdated(ref int CategoryID, ref string CategoryName, ref string Description, ref DateTime CreatedAt, DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM Categories WHERE Updated = @Updated";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Updated", Updated);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                CategoryID = (int)reader["CategoryID"];
                                CategoryName = (string)reader["CategoryName"];

                                if (reader["Description"] != DBNull.Value)
                                    Description = (string)reader["Description"];
                                else
                                    Description = "";

                                CreatedAt = (DateTime)reader["CreatedAt"];
                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static int AddNewCategory(string CategoryName, string Description, DateTime CreatedAt, DateTime Updated)
        {
            int CategoryID = -1;
            string query = @"INSERT INTO Categories (CategoryName, Description, CreatedAt, Updated)
                            VALUES (@CategoryName, @Description, @CreatedAt, @Updated)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@CategoryName", CategoryName);

                        if (Description != "")
                            command.Parameters.AddWithValue("@Description", Description);
                        else
                            command.Parameters.AddWithValue("@Description", DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);

                        if (Updated != DateTime.MinValue)
                            command.Parameters.AddWithValue("@Updated", Updated);
                        else
                            command.Parameters.AddWithValue("@Updated", DBNull.Value);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            CategoryID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

            return CategoryID;
        }
        public static bool UpdateCategory(int CategoryID, string CategoryName, string Description, DateTime CreatedAt, DateTime Updated)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Categories  
                                        SET 
                                        CategoryName = @CategoryName, 
                            Description = @Description, 
                            CreatedAt = @CreatedAt, 
                            Updated = @Updated
                            WHERE CategoryID = @CategoryID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@CategoryID", CategoryID);
                        command.Parameters.AddWithValue("@CategoryName", CategoryName);
                        command.Parameters.AddWithValue("@Description", Description);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@Updated", Updated);
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            finally
            {

            }

            return (rowsAffected > 0);
        }
        public static bool DeleteCategory(int CategoryID)
        {
            int rowsAffected = 0;
            string query = @"Delete Categories 
                                where CategoryID = @CategoryID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryID", CategoryID);
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {

            }
            return (rowsAffected > 0);
        }
        public static bool IsCategoryExist(int CategoryID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Categories WHERE CategoryID = @CategoryID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryID", CategoryID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsCategoryExistByCategoryID(int CategoryID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Categories WHERE CategoryID = @CategoryID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryID", CategoryID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsCategoryExistByCategoryName(string CategoryName)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Categories WHERE CategoryName = @CategoryName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryName", CategoryName);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsCategoryExistByDescription(string Description)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Categories WHERE Description = @Description";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Description", Description);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsCategoryExistByCreatedAt(DateTime CreatedAt)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Categories WHERE CreatedAt = @CreatedAt";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsCategoryExistByUpdated(DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Categories WHERE Updated = @Updated";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Updated", Updated);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static DataTable GetAllCategories()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Categories";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

            return dt;
        }

        public static string GetCategoryNameByID(int CategoryID)
        {
            string CategoryName = "";

            string query = "SELECT CategoryName FROM Categories WHERE CategoryID = @CategoryID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryID", CategoryID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                                CategoryName = (string)reader["CategoryName"];

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "";
            }

            return CategoryName;
        }

        public static bool IsCategoryReferenceToAnyItemByID(int CategoryID)
        {
            bool IsFound = false;

            string query = "select top 1 found = 1 from MenuItems where CategoryID = @CategoryID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryID", CategoryID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            IsFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return IsFound;
            }

            return IsFound;
        }
    }
}