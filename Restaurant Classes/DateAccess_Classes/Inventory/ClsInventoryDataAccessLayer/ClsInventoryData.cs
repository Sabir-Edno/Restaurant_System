using ClsConnectionStringLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsInventoryDataAccessLayer
{
    public class ClsInventoryData
    {
        public static bool GetInventoryByID(int InventoryID, ref string ItemName, ref decimal Quantity, ref string Unit, ref decimal ReorderLevel, ref DateTime LastUpdate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Inventory WHERE InventoryID = @InventoryID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InventoryID", InventoryID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                ItemName = (string)reader["ItemName"];
                                Quantity = Convert.ToDecimal(reader["Quantity"]);
                                Unit = (string)reader["Unit"];
                                ReorderLevel = Convert.ToDecimal(reader["ReorderLevel"]);

                                if (reader["LastUpdate"] != DBNull.Value)
                                    LastUpdate = (DateTime)reader["LastUpdate"];
                                else
                                    LastUpdate = DateTime.MinValue;

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
        public static bool GetInventoryByInventoryID(int InventoryID, ref string ItemName, ref decimal Quantity, ref string Unit, ref decimal ReorderLevel, ref DateTime LastUpdate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Inventory WHERE InventoryID = @InventoryID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InventoryID", InventoryID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                ItemName = (string)reader["ItemName"];
                                Quantity = Convert.ToDecimal(reader["Quantity"]);
                                Unit = (string)reader["Unit"];
                                ReorderLevel = Convert.ToDecimal(reader["ReorderLevel"]);

                                if (reader["LastUpdate"] != DBNull.Value)
                                    LastUpdate = (DateTime)reader["LastUpdate"];
                                else
                                    LastUpdate = DateTime.MinValue;

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
        public static bool GetInventoryByItemName(ref int InventoryID, string ItemName, ref decimal Quantity, ref string Unit, ref decimal ReorderLevel, ref DateTime LastUpdate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Inventory WHERE ItemName = @ItemName";
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

                                InventoryID = (int)reader["InventoryID"];
                                Quantity = Convert.ToDecimal(reader["Quantity"]);
                                Unit = (string)reader["Unit"];
                                ReorderLevel = Convert.ToDecimal(reader["ReorderLevel"]);

                                if (reader["LastUpdate"] != DBNull.Value)
                                    LastUpdate = (DateTime)reader["LastUpdate"];
                                else
                                    LastUpdate = DateTime.MinValue;

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
        public static bool GetInventoryByQuantity(ref int InventoryID, ref string ItemName, decimal Quantity, ref string Unit, ref decimal ReorderLevel, ref DateTime LastUpdate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Inventory WHERE Quantity = @Quantity";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Quantity", Quantity);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                InventoryID = (int)reader["InventoryID"];
                                ItemName = (string)reader["ItemName"];
                                Unit = (string)reader["Unit"];
                                ReorderLevel = Convert.ToDecimal(reader["ReorderLevel"]);

                                if (reader["LastUpdate"] != DBNull.Value)
                                    LastUpdate = (DateTime)reader["LastUpdate"];
                                else
                                    LastUpdate = DateTime.MinValue;

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
        public static bool GetInventoryByUnit(ref int InventoryID, ref string ItemName, ref decimal Quantity, string Unit, ref decimal ReorderLevel, ref DateTime LastUpdate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Inventory WHERE Unit = @Unit";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Unit", Unit);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                InventoryID = (int)reader["InventoryID"];
                                ItemName = (string)reader["ItemName"];
                                Quantity = Convert.ToDecimal(reader["Quantity"]);
                                ReorderLevel = Convert.ToDecimal(reader["ReorderLevel"]);

                                if (reader["LastUpdate"] != DBNull.Value)
                                    LastUpdate = (DateTime)reader["LastUpdate"];
                                else
                                    LastUpdate = DateTime.MinValue;

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
        public static bool GetInventoryByReorderLevel(ref int InventoryID, ref string ItemName, ref decimal Quantity, ref string Unit, decimal ReorderLevel, ref DateTime LastUpdate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Inventory WHERE ReorderLevel = @ReorderLevel";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReorderLevel", ReorderLevel);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                InventoryID = (int)reader["InventoryID"];
                                ItemName = (string)reader["ItemName"];
                                Quantity = Convert.ToDecimal(reader["Quantity"]);
                                Unit = (string)reader["Unit"];

                                if (reader["LastUpdate"] != DBNull.Value)
                                    LastUpdate = (DateTime)reader["LastUpdate"];
                                else
                                    LastUpdate = DateTime.MinValue;

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
        public static bool GetInventoryByLastUpdate(ref int InventoryID, ref string ItemName, ref decimal Quantity, ref string Unit, ref decimal ReorderLevel, DateTime LastUpdate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Inventory WHERE LastUpdate = @LastUpdate";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LastUpdate", LastUpdate);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                InventoryID = (int)reader["InventoryID"];
                                ItemName = (string)reader["ItemName"];
                                Quantity = Convert.ToDecimal(reader["Quantity"]);
                                Unit = (string)reader["Unit"];
                                ReorderLevel = Convert.ToDecimal(reader["ReorderLevel"]);
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
        public static int AddNewInventory(string ItemName, decimal Quantity, string Unit, decimal ReorderLevel, DateTime LastUpdate)
        {
            int InventoryID = -1;
            string query = @"INSERT INTO Inventory (ItemName, Quantity, Unit, ReorderLevel, LastUpdate)
                            VALUES (@ItemName, @Quantity, @Unit, @ReorderLevel, @LastUpdate)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@ItemName", ItemName);
                        command.Parameters.AddWithValue("@Quantity", Quantity);
                        command.Parameters.AddWithValue("@Unit", Unit);
                        command.Parameters.AddWithValue("@ReorderLevel", ReorderLevel);

                        if (LastUpdate != DateTime.MinValue)
                            command.Parameters.AddWithValue("@LastUpdate", LastUpdate);
                        else
                            command.Parameters.AddWithValue("@LastUpdate", DBNull.Value);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            InventoryID = insertedID;
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

            return InventoryID;
        }
        public static bool UpdateInventory(int InventoryID, string ItemName, decimal Quantity, string Unit, decimal ReorderLevel, DateTime LastUpdate)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Inventory  
                                        SET 
                                        ItemName = @ItemName, 
                            Quantity = @Quantity, 
                            Unit = @Unit, 
                            ReorderLevel = @ReorderLevel, 
                            LastUpdate = @LastUpdate
                            WHERE InventoryID = @InventoryID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@InventoryID", InventoryID);
                        command.Parameters.AddWithValue("@ItemName", ItemName);
                        command.Parameters.AddWithValue("@Quantity", Quantity);
                        command.Parameters.AddWithValue("@Unit", Unit);
                        command.Parameters.AddWithValue("@ReorderLevel", ReorderLevel);
                        command.Parameters.AddWithValue("@LastUpdate", LastUpdate);
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
        public static bool DeleteInventory(int InventoryID)
        {
            int rowsAffected = 0;
            string query = @"Delete Inventory 
                                where InventoryID = @InventoryID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InventoryID", InventoryID);
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
        public static bool IsInventoryExist(int InventoryID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Inventory WHERE InventoryID = @InventoryID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InventoryID", InventoryID);
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
        public static bool IsInventoryExistByInventoryID(int InventoryID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Inventory WHERE InventoryID = @InventoryID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InventoryID", InventoryID);
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
        public static bool IsInventoryExistByItemName(string ItemName)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Inventory WHERE ItemName = @ItemName";
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
        public static bool IsInventoryExistByQuantity(decimal Quantity)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Inventory WHERE Quantity = @Quantity";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Quantity", Quantity);
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
        public static bool IsInventoryExistByUnit(string Unit)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Inventory WHERE Unit = @Unit";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Unit", Unit);
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
        public static bool IsInventoryExistByReorderLevel(decimal ReorderLevel)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Inventory WHERE ReorderLevel = @ReorderLevel";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReorderLevel", ReorderLevel);
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
        public static bool IsInventoryExistByLastUpdate(DateTime LastUpdate)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Inventory WHERE LastUpdate = @LastUpdate";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LastUpdate", LastUpdate);
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
        public static DataTable GetAllInventory()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Inventory";
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