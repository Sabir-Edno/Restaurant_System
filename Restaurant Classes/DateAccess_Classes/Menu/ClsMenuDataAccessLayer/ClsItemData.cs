using ClsConnectionStringLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsMenuDataAccessLayer
{
    public class ClsItemData
    {
        public static bool GetItemByID(int ItemID, ref int CategoryID, ref string ItemName, ref string Description, ref decimal Price, ref bool Availability, ref string ImagePath, ref DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM MenuItems WHERE ItemID = @ItemID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ItemID", ItemID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                CategoryID = (int)reader["CategoryID"];

                                if (reader["ItemName"] != DBNull.Value)
                                    ItemName = (string)reader["ItemName"];
                                else
                                    ItemName = "";


                                if (reader["Description"] != DBNull.Value)
                                    Description = (string)reader["Description"];
                                else
                                    Description = "";

                                Price = Convert.ToDecimal(reader["Price"]);
                                Availability = (bool)reader["Availability"];

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

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
        public static bool GetItemByItemID(int ItemID, ref int CategoryID, ref string ItemName, ref string Description, ref decimal Price, ref bool Availability, ref string ImagePath, ref DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM MenuItems WHERE ItemID = @ItemID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ItemID", ItemID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                CategoryID = (int)reader["CategoryID"];

                                if (reader["ItemName"] != DBNull.Value)
                                    ItemName = (string)reader["ItemName"];
                                else
                                    ItemName = "";


                                if (reader["Description"] != DBNull.Value)
                                    Description = (string)reader["Description"];
                                else
                                    Description = "";

                                Price = Convert.ToDecimal(reader["Price"]);
                                Availability = (bool)reader["Availability"];

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

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
        public static bool GetItemByCategoryID(ref int ItemID, int CategoryID, ref string ItemName, ref string Description, ref decimal Price, ref bool Availability, ref string ImagePath, ref DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM MenuItems WHERE CategoryID = @CategoryID";
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

                                ItemID = (int)reader["ItemID"];

                                if (reader["ItemName"] != DBNull.Value)
                                    ItemName = (string)reader["ItemName"];
                                else
                                    ItemName = "";


                                if (reader["Description"] != DBNull.Value)
                                    Description = (string)reader["Description"];
                                else
                                    Description = "";

                                Price = Convert.ToDecimal(reader["Price"]);
                                Availability = (bool)reader["Availability"];

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

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
        public static bool GetItemByItemName(ref int ItemID, ref int CategoryID, string ItemName, ref string Description, ref decimal Price, ref bool Availability, ref string ImagePath, ref DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM MenuItems WHERE ItemName = @ItemName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ItemName", ItemName);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                ItemID = (int)reader["ItemID"];
                                CategoryID = (int)reader["CategoryID"];

                                if (reader["Description"] != DBNull.Value)
                                    Description = (string)reader["Description"];
                                else
                                    Description = "";

                                Price = Convert.ToDecimal(reader["Price"]);
                                Availability = (bool)reader["Availability"];

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

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
        public static bool GetItemByDescription(ref int ItemID, ref int CategoryID, ref string ItemName, string Description, ref decimal Price, ref bool Availability, ref string ImagePath, ref DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM MenuItems WHERE Description = @Description";
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

                                ItemID = (int)reader["ItemID"];
                                CategoryID = (int)reader["CategoryID"];

                                if (reader["ItemName"] != DBNull.Value)
                                    ItemName = (string)reader["ItemName"];
                                else
                                    ItemName = "";

                                Price = Convert.ToDecimal(reader["Price"]);
                                Availability = (bool)reader["Availability"];

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

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
        public static bool GetItemByPrice(ref int ItemID, ref int CategoryID, ref string ItemName, ref string Description, decimal Price, ref bool Availability, ref string ImagePath, ref DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM MenuItems WHERE Price = @Price";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Price", Price);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                ItemID = (int)reader["ItemID"];
                                CategoryID = (int)reader["CategoryID"];

                                if (reader["ItemName"] != DBNull.Value)
                                    ItemName = (string)reader["ItemName"];
                                else
                                    ItemName = "";


                                if (reader["Description"] != DBNull.Value)
                                    Description = (string)reader["Description"];
                                else
                                    Description = "";

                                Availability = (bool)reader["Availability"];

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

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
        public static bool GetItemByAvailability(ref int ItemID, ref int CategoryID, ref string ItemName, ref string Description, ref decimal Price, bool Availability, ref string ImagePath, ref DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM MenuItems WHERE Availability = @Availability";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Availability", Availability);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                ItemID = (int)reader["ItemID"];
                                CategoryID = (int)reader["CategoryID"];

                                if (reader["ItemName"] != DBNull.Value)
                                    ItemName = (string)reader["ItemName"];
                                else
                                    ItemName = "";


                                if (reader["Description"] != DBNull.Value)
                                    Description = (string)reader["Description"];
                                else
                                    Description = "";

                                Price = Convert.ToDecimal(reader["Price"]);

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

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
        public static bool GetItemByImagePath(ref int ItemID, ref int CategoryID, ref string ItemName, ref string Description, ref decimal Price, ref bool Availability, string ImagePath, ref DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM MenuItems WHERE ImagePath = @ImagePath";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                ItemID = (int)reader["ItemID"];
                                CategoryID = (int)reader["CategoryID"];

                                if (reader["ItemName"] != DBNull.Value)
                                    ItemName = (string)reader["ItemName"];
                                else
                                    ItemName = "";


                                if (reader["Description"] != DBNull.Value)
                                    Description = (string)reader["Description"];
                                else
                                    Description = "";

                                Price = Convert.ToDecimal(reader["Price"]);
                                Availability = (bool)reader["Availability"];
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
        public static bool GetItemByCreatedAt(ref int ItemID, ref int CategoryID, ref string ItemName, ref string Description, ref decimal Price, ref bool Availability, ref string ImagePath, DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM MenuItems WHERE CreatedAt = @CreatedAt";
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

                                ItemID = (int)reader["ItemID"];
                                CategoryID = (int)reader["CategoryID"];

                                if (reader["ItemName"] != DBNull.Value)
                                    ItemName = (string)reader["ItemName"];
                                else
                                    ItemName = "";


                                if (reader["Description"] != DBNull.Value)
                                    Description = (string)reader["Description"];
                                else
                                    Description = "";

                                Price = Convert.ToDecimal(reader["Price"]);
                                Availability = (bool)reader["Availability"];

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";


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
        public static bool GetItemByUpdated(ref int ItemID, ref int CategoryID, ref string ItemName, ref string Description, ref decimal Price, ref bool Availability, ref string ImagePath, ref DateTime CreatedAt, DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM MenuItems WHERE Updated = @Updated";
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

                                ItemID = (int)reader["ItemID"];
                                CategoryID = (int)reader["CategoryID"];

                                if (reader["ItemName"] != DBNull.Value)
                                    ItemName = (string)reader["ItemName"];
                                else
                                    ItemName = "";


                                if (reader["Description"] != DBNull.Value)
                                    Description = (string)reader["Description"];
                                else
                                    Description = "";

                                Price = Convert.ToDecimal(reader["Price"]);
                                Availability = (bool)reader["Availability"];

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

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
        public static int AddNewItem(int CategoryID, string ItemName, string Description, decimal Price, bool Availability, string ImagePath, DateTime CreatedAt, DateTime Updated)
        {
            int ItemID = -1;
            string query = @"INSERT INTO MenuItems (CategoryID, ItemName, Description, Price, Availability, ImagePath, CreatedAt, Updated)
                            VALUES (@CategoryID, @ItemName, @Description, @Price, @Availability, @ImagePath, @CreatedAt, @Updated)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@CategoryID", CategoryID);

                        if (ItemName != "")
                            command.Parameters.AddWithValue("@ItemName", ItemName);
                        else
                            command.Parameters.AddWithValue("@ItemName", DBNull.Value);

                        if (Description != "")
                            command.Parameters.AddWithValue("@Description", Description);
                        else
                            command.Parameters.AddWithValue("@Description", DBNull.Value);
                        command.Parameters.AddWithValue("@Price", Price);
                        command.Parameters.AddWithValue("@Availability", Availability);

                        if (ImagePath != "")
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);

                        if (Updated != DateTime.MinValue)
                            command.Parameters.AddWithValue("@Updated", Updated);
                        else
                            command.Parameters.AddWithValue("@Updated", DBNull.Value);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            ItemID = insertedID;
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

            return ItemID;
        }
        public static bool UpdateItem(int ItemID, int CategoryID, string ItemName, string Description, decimal Price, bool Availability, string ImagePath, DateTime CreatedAt, DateTime Updated)
        {
            int rowsAffected = 0;
            string query = @"UPDATE MenuItems  
                                        SET 
                                        CategoryID = @CategoryID, 
                            ItemName = @ItemName, 
                            Description = @Description, 
                            Price = @Price, 
                            Availability = @Availability, 
                            ImagePath = @ImagePath, 
                            CreatedAt = @CreatedAt, 
                            Updated = @Updated
                            WHERE ItemID = @ItemID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@ItemID", ItemID);
                        command.Parameters.AddWithValue("@CategoryID", CategoryID);
                        command.Parameters.AddWithValue("@ItemName", ItemName);
                        command.Parameters.AddWithValue("@Description", Description);
                        command.Parameters.AddWithValue("@Price", Price);
                        command.Parameters.AddWithValue("@Availability", Availability);
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
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
        public static bool DeleteItem(int ItemID)
        {
            int rowsAffected = 0;
            string query = @"Delete MenuItems 
                                where ItemID = @ItemID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ItemID", ItemID);
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
        public static bool IsItemExist(int ItemID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM MenuItems WHERE ItemID = @ItemID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ItemID", ItemID);
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
        public static bool IsItemExistByItemID(int ItemID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM MenuItems WHERE ItemID = @ItemID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ItemID", ItemID);
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
        public static bool IsItemExistByCategoryID(int CategoryID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM MenuItems WHERE CategoryID = @CategoryID";
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
        public static bool IsItemExistByItemName(string ItemName)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM MenuItems WHERE ItemName = @ItemName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ItemName", ItemName);
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
        public static bool IsItemExistByDescription(string Description)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM MenuItems WHERE Description = @Description";
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
        public static bool IsItemExistByPrice(decimal Price)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM MenuItems WHERE Price = @Price";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Price", Price);
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
        public static bool IsItemExistByAvailability(bool Availability)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM MenuItems WHERE Availability = @Availability";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Availability", Availability);
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
        public static bool IsItemExistByImagePath(string ImagePath)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM MenuItems WHERE ImagePath = @ImagePath";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
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
        public static bool IsItemExistByCreatedAt(DateTime CreatedAt)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM MenuItems WHERE CreatedAt = @CreatedAt";
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
        public static bool IsItemExistByUpdated(DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM MenuItems WHERE Updated = @Updated";
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
        public static DataTable GetAllMenuItems()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM MenuItems";
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
    }
}