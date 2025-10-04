using ClsConnectionStringLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsOrderDataAccessLayer
{
    public class ClsOrderData
    {
        public static bool GetOrderByID(int OrderID, ref int TableID, ref int UserID, ref string OrderType, ref string Status, ref DateTime CreatedAt)
        {
            bool isFound = false;
            string query = "SELECT * FROM Orders WHERE OrderID = @OrderID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", OrderID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                TableID = (int)reader["TableID"];
                                UserID = (int)reader["UserID"];
                                OrderType = (string)reader["OrderType"];
                                Status = (string)reader["Status"];
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
        public static bool GetOrderByOrderID(int OrderID, ref int TableID, ref int UserID, ref string OrderType, ref string Status, ref DateTime CreatedAt)
        {
            bool isFound = false;
            string query = "SELECT * FROM Orders WHERE OrderID = @OrderID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", OrderID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                TableID = (int)reader["TableID"];
                                UserID = (int)reader["UserID"];
                                OrderType = (string)reader["OrderType"];
                                Status = (string)reader["Status"];
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
        public static bool GetOrderByTableID(ref int OrderID, int TableID, ref int UserID, ref string OrderType, ref string Status, ref DateTime CreatedAt)
        {
            bool isFound = false;
            string query = "SELECT * FROM Orders WHERE TableID = @TableID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TableID", TableID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                OrderID = (int)reader["OrderID"];
                                UserID = (int)reader["UserID"];
                                OrderType = (string)reader["OrderType"];
                                Status = (string)reader["Status"];
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
        public static bool GetOrderByUserID(ref int OrderID, ref int TableID, int UserID, ref string OrderType, ref string Status, ref DateTime CreatedAt)
        {
            bool isFound = false;
            string query = "SELECT * FROM Orders WHERE UserID = @UserID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                OrderID = (int)reader["OrderID"];
                                TableID = (int)reader["TableID"];
                                OrderType = (string)reader["OrderType"];
                                Status = (string)reader["Status"];
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
        public static bool GetOrderByOrderType(ref int OrderID, ref int TableID, ref int UserID, string OrderType, ref string Status, ref DateTime CreatedAt)
        {
            bool isFound = false;
            string query = "SELECT * FROM Orders WHERE OrderType = @OrderType";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderType", OrderType);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                OrderID = (int)reader["OrderID"];
                                TableID = (int)reader["TableID"];
                                UserID = (int)reader["UserID"];
                                Status = (string)reader["Status"];
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
        public static bool GetOrderByStatus(ref int OrderID, ref int TableID, ref int UserID, ref string OrderType, string Status, ref DateTime CreatedAt)
        {
            bool isFound = false;
            string query = "SELECT * FROM Orders WHERE Status = @Status";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", Status);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                OrderID = (int)reader["OrderID"];
                                TableID = (int)reader["TableID"];
                                UserID = (int)reader["UserID"];
                                OrderType = (string)reader["OrderType"];
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
        public static bool GetOrderByCreatedAt(ref int OrderID, ref int TableID, ref int UserID, ref string OrderType, ref string Status, DateTime CreatedAt)
        {
            bool isFound = false;
            string query = "SELECT * FROM Orders WHERE CreatedAt = @CreatedAt";
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

                                OrderID = (int)reader["OrderID"];
                                TableID = (int)reader["TableID"];
                                UserID = (int)reader["UserID"];
                                OrderType = (string)reader["OrderType"];
                                Status = (string)reader["Status"];
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
        public static int AddNewOrder(int TableID, int UserID, string OrderType, string Status, DateTime CreatedAt)
        {
            int OrderID = -1;
            string query = @"INSERT INTO Orders (TableID, UserID, OrderType, Status, CreatedAt)
                            VALUES (@TableID, @UserID, @OrderType, @Status, @CreatedAt)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@TableID", TableID);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@OrderType", OrderType);
                        command.Parameters.AddWithValue("@Status", Status);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            OrderID = insertedID;
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

            return OrderID;
        }
        public static bool UpdateOrder(int OrderID, int TableID, int UserID, string OrderType, string Status, DateTime CreatedAt)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Orders  
                                        SET 
                                        TableID = @TableID, 
                            UserID = @UserID, 
                            OrderType = @OrderType, 
                            Status = @Status, 
                            CreatedAt = @CreatedAt
                            WHERE OrderID = @OrderID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@OrderID", OrderID);
                        command.Parameters.AddWithValue("@TableID", TableID);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@OrderType", OrderType);
                        command.Parameters.AddWithValue("@Status", Status);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
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
        public static bool DeleteOrder(int OrderID)
        {
            int rowsAffected = 0;
            string query = @"Delete Orders 
                                where OrderID = @OrderID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", OrderID);
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
        public static bool IsOrderExist(int OrderID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Orders WHERE OrderID = @OrderID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", OrderID);
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
        public static bool IsOrderExistByOrderID(int OrderID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Orders WHERE OrderID = @OrderID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", OrderID);
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
        public static bool IsOrderExistByTableID(int TableID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Orders WHERE TableID = @TableID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TableID", TableID);
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
        public static bool IsOrderExistByUserID(int UserID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Orders WHERE UserID = @UserID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
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
        public static bool IsOrderExistByOrderType(string OrderType)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Orders WHERE OrderType = @OrderType";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderType", OrderType);
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
        public static bool IsOrderExistByStatus(string Status)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Orders WHERE Status = @Status";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", Status);
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
        public static bool IsOrderExistByCreatedAt(DateTime CreatedAt)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Orders WHERE CreatedAt = @CreatedAt";
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
        public static DataTable GetAllOrders()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Orders";
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
