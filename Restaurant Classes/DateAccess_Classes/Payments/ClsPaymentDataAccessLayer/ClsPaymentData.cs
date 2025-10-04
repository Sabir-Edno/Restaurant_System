using ClsConnectionStringLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsPaymentDataAccessLayer
{
    public class ClsPaymentData
    {
        public static bool GetPaymentByID(int PaymentID, ref int OrderID, ref decimal Amount, ref string Method, ref DateTime PaidAt)
        {
            bool isFound = false;
            string query = "SELECT * FROM Payments WHERE PaymentID = @PaymentID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;


                                if (reader["OrderID"] != DBNull.Value)
                                    OrderID = (int)reader["OrderID"];
                                else
                                    OrderID = -1;

                                Amount = Convert.ToDecimal(reader["Amount"]);
                                Method = (string)reader["Method"];
                                PaidAt = (DateTime)reader["PaidAt"];
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
        public static bool GetPaymentByPaymentID(int PaymentID, ref int OrderID, ref decimal Amount, ref string Method, ref DateTime PaidAt)
        {
            bool isFound = false;
            string query = "SELECT * FROM Payments WHERE PaymentID = @PaymentID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;


                                if (reader["OrderID"] != DBNull.Value)
                                    OrderID = (int)reader["OrderID"];
                                else
                                    OrderID = -1;

                                Amount = Convert.ToDecimal(reader["Amount"]);
                                Method = (string)reader["Method"];
                                PaidAt = (DateTime)reader["PaidAt"];
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
        public static bool GetPaymentByOrderID(ref int PaymentID, int OrderID, ref decimal Amount, ref string Method, ref DateTime PaidAt)
        {
            bool isFound = false;
            string query = "SELECT * FROM Payments WHERE OrderID = @OrderID";
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

                                PaymentID = (int)reader["PaymentID"];
                                Amount = Convert.ToDecimal(reader["Amount"]);
                                Method = (string)reader["Method"];
                                PaidAt = (DateTime)reader["PaidAt"];
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
        public static bool GetPaymentByAmount(ref int PaymentID, ref int OrderID, decimal Amount, ref string Method, ref DateTime PaidAt)
        {
            bool isFound = false;
            string query = "SELECT * FROM Payments WHERE Amount = @Amount";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Amount", Amount);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                PaymentID = (int)reader["PaymentID"];

                                if (reader["OrderID"] != DBNull.Value)
                                    OrderID = (int)reader["OrderID"];
                                else
                                    OrderID = -1;

                                Method = (string)reader["Method"];
                                PaidAt = (DateTime)reader["PaidAt"];
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
        public static bool GetPaymentByMethod(ref int PaymentID, ref int OrderID, ref decimal Amount, string Method, ref DateTime PaidAt)
        {
            bool isFound = false;
            string query = "SELECT * FROM Payments WHERE Method = @Method";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Method", Method);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                PaymentID = (int)reader["PaymentID"];

                                if (reader["OrderID"] != DBNull.Value)
                                    OrderID = (int)reader["OrderID"];
                                else
                                    OrderID = -1;

                                Amount = Convert.ToDecimal(reader["Amount"]);
                                PaidAt = (DateTime)reader["PaidAt"];
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
        public static bool GetPaymentByPaidAt(ref int PaymentID, ref int OrderID, ref decimal Amount, ref string Method, DateTime PaidAt)
        {
            bool isFound = false;
            string query = "SELECT * FROM Payments WHERE PaidAt = @PaidAt";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaidAt", PaidAt);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                PaymentID = (int)reader["PaymentID"];

                                if (reader["OrderID"] != DBNull.Value)
                                    OrderID = (int)reader["OrderID"];
                                else
                                    OrderID = -1;

                                Amount = Convert.ToDecimal(reader["Amount"]);
                                Method = (string)reader["Method"];
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
        public static int AddNewPayment(int OrderID, decimal Amount, string Method, DateTime PaidAt)
        {
            int PaymentID = -1;
            string query = @"INSERT INTO Payments (OrderID, Amount, Method, PaidAt)
                            VALUES (@OrderID, @Amount, @Method, @PaidAt)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        if (OrderID != -1)
                            command.Parameters.AddWithValue("@OrderID", OrderID);
                        else
                            command.Parameters.AddWithValue("@OrderID", DBNull.Value);
                        command.Parameters.AddWithValue("@Amount", Amount);
                        command.Parameters.AddWithValue("@Method", Method);
                        command.Parameters.AddWithValue("@PaidAt", PaidAt);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            PaymentID = insertedID;
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

            return PaymentID;
        }
        public static bool UpdatePayment(int PaymentID, int OrderID, decimal Amount, string Method, DateTime PaidAt)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Payments  
                                        SET 
                                        OrderID = @OrderID, 
                            Amount = @Amount, 
                            Method = @Method, 
                            PaidAt = @PaidAt
                            WHERE PaymentID = @PaymentID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PaymentID", PaymentID);
                        command.Parameters.AddWithValue("@OrderID", OrderID);
                        command.Parameters.AddWithValue("@Amount", Amount);
                        command.Parameters.AddWithValue("@Method", Method);
                        command.Parameters.AddWithValue("@PaidAt", PaidAt);
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
        public static bool DeletePayment(int PaymentID)
        {
            int rowsAffected = 0;
            string query = @"Delete Payments 
                                where PaymentID = @PaymentID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);
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
        public static bool IsPaymentExist(int PaymentID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Payments WHERE PaymentID = @PaymentID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);
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
        public static bool IsPaymentExistByPaymentID(int PaymentID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Payments WHERE PaymentID = @PaymentID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);
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
        public static bool IsPaymentExistByOrderID(int OrderID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Payments WHERE OrderID = @OrderID";
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
        public static bool IsPaymentExistByAmount(decimal Amount)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Payments WHERE Amount = @Amount";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Amount", Amount);
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
        public static bool IsPaymentExistByMethod(string Method)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Payments WHERE Method = @Method";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Method", Method);
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
        public static bool IsPaymentExistByPaidAt(DateTime PaidAt)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Payments WHERE PaidAt = @PaidAt";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaidAt", PaidAt);
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
        public static DataTable GetAllPayments()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Payments";
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
