using ClsConnectionStringLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsOrderDetailDataAccessLayer
{
    public class ClsOrderDetailData
    {
        public static bool GetOrderDetailByID(int OrderDetailID, ref int OrderID, ref int ItemID, ref int Quantity, ref decimal Price, ref decimal Total)
        {
            bool isFound = false;
            string query = "SELECT * FROM OrderDetails WHERE OrderDetailID = @OrderDetailID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderDetailID", OrderDetailID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                OrderID = (int)reader["OrderID"];
                                ItemID = (int)reader["ItemID"];
                                Quantity = (int)reader["Quantity"];
                                Price = Convert.ToDecimal(reader["Price"]);
                                Total = Convert.ToDecimal(reader["Total"]);
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
        public static bool GetOrderDetailByOrderDetailID(int OrderDetailID, ref int OrderID, ref int ItemID, ref int Quantity, ref decimal Price, ref decimal Total)
        {
            bool isFound = false;
            string query = "SELECT * FROM OrderDetails WHERE OrderDetailID = @OrderDetailID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderDetailID", OrderDetailID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                OrderID = (int)reader["OrderID"];
                                ItemID = (int)reader["ItemID"];
                                Quantity = (int)reader["Quantity"];
                                Price = Convert.ToDecimal(reader["Price"]);
                                Total = Convert.ToDecimal(reader["Total"]);
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
        public static bool GetOrderDetailByOrderID(ref int OrderDetailID, int OrderID, ref int ItemID, ref int Quantity, ref decimal Price, ref decimal Total)
        {
            bool isFound = false;
            string query = "SELECT * FROM OrderDetails WHERE OrderID = @OrderID";
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

                                OrderDetailID = (int)reader["OrderDetailID"];
                                ItemID = (int)reader["ItemID"];
                                Quantity = (int)reader["Quantity"];
                                Price = Convert.ToDecimal(reader["Price"]);
                                Total = Convert.ToDecimal(reader["Total"]);
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
        public static bool GetOrderDetailByItemID(ref int OrderDetailID, ref int OrderID, int ItemID, ref int Quantity, ref decimal Price, ref decimal Total)
        {
            bool isFound = false;
            string query = "SELECT * FROM OrderDetails WHERE ItemID = @ItemID";
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

                                OrderDetailID = (int)reader["OrderDetailID"];
                                OrderID = (int)reader["OrderID"];
                                Quantity = (int)reader["Quantity"];
                                Price = Convert.ToDecimal(reader["Price"]);
                                Total = Convert.ToDecimal(reader["Total"]);
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
        public static bool GetOrderDetailByQuantity(ref int OrderDetailID, ref int OrderID, ref int ItemID, int Quantity, ref decimal Price, ref decimal Total)
        {
            bool isFound = false;
            string query = "SELECT * FROM OrderDetails WHERE Quantity = @Quantity";
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

                                OrderDetailID = (int)reader["OrderDetailID"];
                                OrderID = (int)reader["OrderID"];
                                ItemID = (int)reader["ItemID"];
                                Price = Convert.ToDecimal(reader["Price"]);
                                Total = Convert.ToDecimal(reader["Total"]);
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
        public static bool GetOrderDetailByPrice(ref int OrderDetailID, ref int OrderID, ref int ItemID, ref int Quantity, decimal Price, ref decimal Total)
        {
            bool isFound = false;
            string query = "SELECT * FROM OrderDetails WHERE Price = @Price";
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

                                OrderDetailID = (int)reader["OrderDetailID"];
                                OrderID = (int)reader["OrderID"];
                                ItemID = (int)reader["ItemID"];
                                Quantity = (int)reader["Quantity"];
                                Total = Convert.ToDecimal(reader["Total"]);
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
        public static bool GetOrderDetailByTotal(ref int OrderDetailID, ref int OrderID, ref int ItemID, ref int Quantity, ref decimal Price, decimal Total)
        {
            bool isFound = false;
            string query = "SELECT * FROM OrderDetails WHERE Total = @Total";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Total", Total);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                OrderDetailID = (int)reader["OrderDetailID"];
                                OrderID = (int)reader["OrderID"];
                                ItemID = (int)reader["ItemID"];
                                Quantity = (int)reader["Quantity"];
                                Price = Convert.ToDecimal(reader["Price"]);
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
        public static int AddNewOrderDetail(int OrderID, int ItemID, int Quantity, decimal Price, decimal Total)
        {
            int OrderDetailID = -1;
            string query = @"INSERT INTO OrderDetails (OrderID, ItemID, Quantity, Price, Total)
                            VALUES (@OrderID, @ItemID, @Quantity, @Price, @Total)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@OrderID", OrderID);
                        command.Parameters.AddWithValue("@ItemID", ItemID);
                        command.Parameters.AddWithValue("@Quantity", Quantity);
                        command.Parameters.AddWithValue("@Price", Price);
                        command.Parameters.AddWithValue("@Total", Total);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            OrderDetailID = insertedID;
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

            return OrderDetailID;
        }
        public static bool UpdateOrderDetail(int OrderDetailID, int OrderID, int ItemID, int Quantity, decimal Price, decimal Total)
        {
            int rowsAffected = 0;
            string query = @"UPDATE OrderDetails  
                                        SET 
                                        OrderID = @OrderID, 
                            ItemID = @ItemID, 
                            Quantity = @Quantity, 
                            Price = @Price, 
                            Total = @Total
                            WHERE OrderDetailID = @OrderDetailID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@OrderDetailID", OrderDetailID);
                        command.Parameters.AddWithValue("@OrderID", OrderID);
                        command.Parameters.AddWithValue("@ItemID", ItemID);
                        command.Parameters.AddWithValue("@Quantity", Quantity);
                        command.Parameters.AddWithValue("@Price", Price);
                        command.Parameters.AddWithValue("@Total", Total);
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
        public static bool DeleteOrderDetail(int OrderDetailID)
        {
            int rowsAffected = 0;
            string query = @"Delete OrderDetails 
                                where OrderDetailID = @OrderDetailID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderDetailID", OrderDetailID);
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
        public static bool IsOrderDetailExist(int OrderDetailID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM OrderDetails WHERE OrderDetailID = @OrderDetailID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderDetailID", OrderDetailID);
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
        public static bool IsOrderDetailExistByOrderDetailID(int OrderDetailID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM OrderDetails WHERE OrderDetailID = @OrderDetailID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderDetailID", OrderDetailID);
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
        public static bool IsOrderDetailExistByOrderID(int OrderID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM OrderDetails WHERE OrderID = @OrderID";
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
        public static bool IsOrderDetailExistByItemID(int ItemID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM OrderDetails WHERE ItemID = @ItemID";
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
        public static bool IsOrderDetailExistByQuantity(int Quantity)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM OrderDetails WHERE Quantity = @Quantity";
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
        public static bool IsOrderDetailExistByPrice(decimal Price)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM OrderDetails WHERE Price = @Price";
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
        public static bool IsOrderDetailExistByTotal(decimal Total)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM OrderDetails WHERE Total = @Total";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Total", Total);
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
        public static DataTable GetAllOrderDetails()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM OrderDetails";
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