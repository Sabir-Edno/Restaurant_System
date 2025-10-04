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
        public static bool GetItemByID(int ItemID, ref string Name, ref decimal Quantity, ref string Unit, ref DateTime LastUpdate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Inventory WHERE ItemID = @ItemID";
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

                                Name = (string)reader["Name"];
                                Quantity = Convert.ToDecimal(reader["Quantity"]);
                                Unit = (string)reader["Unit"];
                                LastUpdate = (DateTime)reader["LastUpdate"];
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
        public static bool GetItemByItemID(int ItemID, ref string Name, ref decimal Quantity, ref string Unit, ref DateTime LastUpdate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Inventory WHERE ItemID = @ItemID";
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

                                Name = (string)reader["Name"];
                                Quantity = Convert.ToDecimal(reader["Quantity"]);
                                Unit = (string)reader["Unit"];
                                LastUpdate = (DateTime)reader["LastUpdate"];
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
        public static bool GetItemByName(ref int ItemID, string Name, ref decimal Quantity, ref string Unit, ref DateTime LastUpdate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Inventory WHERE Name = @Name";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", Name);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                ItemID = (int)reader["ItemID"];
                                Quantity = Convert.ToDecimal(reader["Quantity"]);
                                Unit = (string)reader["Unit"];
                                LastUpdate = (DateTime)reader["LastUpdate"];
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
        public static bool GetItemByQuantity(ref int ItemID, ref string Name, decimal Quantity, ref string Unit, ref DateTime LastUpdate)
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

                                ItemID = (int)reader["ItemID"];
                                Name = (string)reader["Name"];
                                Unit = (string)reader["Unit"];
                                LastUpdate = (DateTime)reader["LastUpdate"];
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
        public static bool GetItemByUnit(ref int ItemID, ref string Name, ref decimal Quantity, string Unit, ref DateTime LastUpdate)
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

                                ItemID = (int)reader["ItemID"];
                                Name = (string)reader["Name"];
                                Quantity = Convert.ToDecimal(reader["Quantity"]);
                                LastUpdate = (DateTime)reader["LastUpdate"];
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
        public static bool GetItemByLastUpdate(ref int ItemID, ref string Name, ref decimal Quantity, ref string Unit, DateTime LastUpdate)
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

                                ItemID = (int)reader["ItemID"];
                                Name = (string)reader["Name"];
                                Quantity = Convert.ToDecimal(reader["Quantity"]);
                                Unit = (string)reader["Unit"];
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
        public static int AddNewItem(string Name, decimal Quantity, string Unit, DateTime LastUpdate)
        {
            int ItemID = -1;
            string query = @"INSERT INTO Inventory (Name, Quantity, Unit, LastUpdate)
                            VALUES (@Name, @Quantity, @Unit, @LastUpdate)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Quantity", Quantity);
                        command.Parameters.AddWithValue("@Unit", Unit);
                        command.Parameters.AddWithValue("@LastUpdate", LastUpdate);
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
        public static bool UpdateItem(int ItemID, string Name, decimal Quantity, string Unit, DateTime LastUpdate)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Inventory  
                                        SET 
                                        Name = @Name, 
                            Quantity = @Quantity, 
                            Unit = @Unit, 
                            LastUpdate = @LastUpdate
                            WHERE ItemID = @ItemID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@ItemID", ItemID);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Quantity", Quantity);
                        command.Parameters.AddWithValue("@Unit", Unit);
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
        public static bool DeleteItem(int ItemID)
        {
            int rowsAffected = 0;
            string query = @"Delete Inventory 
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
            string query = "SELECT Found=1 FROM Inventory WHERE ItemID = @ItemID";
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
            string query = "SELECT Found=1 FROM Inventory WHERE ItemID = @ItemID";
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
        public static bool IsItemExistByName(string Name)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Inventory WHERE Name = @Name";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", Name);
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
        public static bool IsItemExistByQuantity(decimal Quantity)
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
        public static bool IsItemExistByUnit(string Unit)
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
        public static bool IsItemExistByLastUpdate(DateTime LastUpdate)
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
