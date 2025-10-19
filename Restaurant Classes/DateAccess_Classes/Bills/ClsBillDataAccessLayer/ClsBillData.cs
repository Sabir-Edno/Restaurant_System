using ClsConnectionStringLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsBillDataAccessLayer
{
    public class ClsBillData
    {
        public static bool GetBillByID(int BillID, ref int OrderID, ref decimal SubTotal, ref decimal Tax, ref decimal Discount, ref decimal GrandTotal, ref int PaymentMethodID, ref string PaymentStatus, ref DateTime BillDate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Bills WHERE BillID = @BillID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BillID", BillID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                OrderID = (int)reader["OrderID"];
                                SubTotal = Convert.ToDecimal(reader["SubTotal"]);
                                Tax = Convert.ToDecimal(reader["Tax"]);
                                Discount = Convert.ToDecimal(reader["Discount"]);
                                GrandTotal = Convert.ToDecimal(reader["GrandTotal"]);
                                PaymentMethodID = (int)reader["PaymentMethodID"];
                                PaymentStatus = (string)reader["PaymentStatus"];
                                BillDate = (DateTime)reader["BillDate"];
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
        public static bool GetBillByBillID(int BillID, ref int OrderID, ref decimal SubTotal, ref decimal Tax, ref decimal Discount, ref decimal GrandTotal, ref int PaymentMethodID, ref string PaymentStatus, ref DateTime BillDate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Bills WHERE BillID = @BillID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BillID", BillID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                OrderID = (int)reader["OrderID"];
                                SubTotal = Convert.ToDecimal(reader["SubTotal"]);
                                Tax = Convert.ToDecimal(reader["Tax"]);
                                Discount = Convert.ToDecimal(reader["Discount"]);
                                GrandTotal = Convert.ToDecimal(reader["GrandTotal"]);
                                PaymentMethodID = (int)reader["PaymentMethodID"];
                                PaymentStatus = (string)reader["PaymentStatus"];
                                BillDate = (DateTime)reader["BillDate"];
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
        public static bool GetBillByOrderID(ref int BillID, int OrderID, ref decimal SubTotal, ref decimal Tax, ref decimal Discount, ref decimal GrandTotal, ref int PaymentMethodID, ref string PaymentStatus, ref DateTime BillDate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Bills WHERE OrderID = @OrderID";
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

                                BillID = (int)reader["BillID"];
                                SubTotal = Convert.ToDecimal(reader["SubTotal"]);
                                Tax = Convert.ToDecimal(reader["Tax"]);
                                Discount = Convert.ToDecimal(reader["Discount"]);
                                GrandTotal = Convert.ToDecimal(reader["GrandTotal"]);
                                PaymentMethodID = (int)reader["PaymentMethodID"];
                                PaymentStatus = (string)reader["PaymentStatus"];
                                BillDate = (DateTime)reader["BillDate"];
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
        public static bool GetBillBySubTotal(ref int BillID, ref int OrderID, decimal SubTotal, ref decimal Tax, ref decimal Discount, ref decimal GrandTotal, ref int PaymentMethodID, ref string PaymentStatus, ref DateTime BillDate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Bills WHERE SubTotal = @SubTotal";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SubTotal", SubTotal);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                BillID = (int)reader["BillID"];
                                OrderID = (int)reader["OrderID"];
                                Tax = Convert.ToDecimal(reader["Tax"]);
                                Discount = Convert.ToDecimal(reader["Discount"]);
                                GrandTotal = Convert.ToDecimal(reader["GrandTotal"]);
                                PaymentMethodID = (int)reader["PaymentMethodID"];
                                PaymentStatus = (string)reader["PaymentStatus"];
                                BillDate = (DateTime)reader["BillDate"];
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
        public static bool GetBillByTax(ref int BillID, ref int OrderID, ref decimal SubTotal, decimal Tax, ref decimal Discount, ref decimal GrandTotal, ref int PaymentMethodID, ref string PaymentStatus, ref DateTime BillDate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Bills WHERE Tax = @Tax";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Tax", Tax);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                BillID = (int)reader["BillID"];
                                OrderID = (int)reader["OrderID"];
                                SubTotal = Convert.ToDecimal(reader["SubTotal"]);
                                Discount = Convert.ToDecimal(reader["Discount"]);
                                GrandTotal = Convert.ToDecimal(reader["GrandTotal"]);
                                PaymentMethodID = (int)reader["PaymentMethodID"];
                                PaymentStatus = (string)reader["PaymentStatus"];
                                BillDate = (DateTime)reader["BillDate"];
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
        public static bool GetBillByDiscount(ref int BillID, ref int OrderID, ref decimal SubTotal, ref decimal Tax, decimal Discount, ref decimal GrandTotal, ref int PaymentMethodID, ref string PaymentStatus, ref DateTime BillDate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Bills WHERE Discount = @Discount";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Discount", Discount);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                BillID = (int)reader["BillID"];
                                OrderID = (int)reader["OrderID"];
                                SubTotal = Convert.ToDecimal(reader["SubTotal"]);
                                Tax = Convert.ToDecimal(reader["Tax"]);
                                GrandTotal = Convert.ToDecimal(reader["GrandTotal"]);
                                PaymentMethodID = (int)reader["PaymentMethodID"];
                                PaymentStatus = (string)reader["PaymentStatus"];
                                BillDate = (DateTime)reader["BillDate"];
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
        public static bool GetBillByGrandTotal(ref int BillID, ref int OrderID, ref decimal SubTotal, ref decimal Tax, ref decimal Discount, decimal GrandTotal, ref int PaymentMethodID, ref string PaymentStatus, ref DateTime BillDate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Bills WHERE GrandTotal = @GrandTotal";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GrandTotal", GrandTotal);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                BillID = (int)reader["BillID"];
                                OrderID = (int)reader["OrderID"];
                                SubTotal = Convert.ToDecimal(reader["SubTotal"]);
                                Tax = Convert.ToDecimal(reader["Tax"]);
                                Discount = Convert.ToDecimal(reader["Discount"]);
                                PaymentMethodID = (int)reader["PaymentMethodID"];
                                PaymentStatus = (string)reader["PaymentStatus"];
                                BillDate = (DateTime)reader["BillDate"];
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
        public static bool GetBillByPaymentMethodID(ref int BillID, ref int OrderID, ref decimal SubTotal, ref decimal Tax, ref decimal Discount, ref decimal GrandTotal, int PaymentMethodID, ref string PaymentStatus, ref DateTime BillDate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Bills WHERE PaymentMethodID = @PaymentMethodID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                BillID = (int)reader["BillID"];
                                OrderID = (int)reader["OrderID"];
                                SubTotal = Convert.ToDecimal(reader["SubTotal"]);
                                Tax = Convert.ToDecimal(reader["Tax"]);
                                Discount = Convert.ToDecimal(reader["Discount"]);
                                GrandTotal = Convert.ToDecimal(reader["GrandTotal"]);
                                PaymentStatus = (string)reader["PaymentStatus"];
                                BillDate = (DateTime)reader["BillDate"];
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
        public static bool GetBillByPaymentStatus(ref int BillID, ref int OrderID, ref decimal SubTotal, ref decimal Tax, ref decimal Discount, ref decimal GrandTotal, ref int PaymentMethodID, string PaymentStatus, ref DateTime BillDate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Bills WHERE PaymentStatus = @PaymentStatus";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                BillID = (int)reader["BillID"];
                                OrderID = (int)reader["OrderID"];
                                SubTotal = Convert.ToDecimal(reader["SubTotal"]);
                                Tax = Convert.ToDecimal(reader["Tax"]);
                                Discount = Convert.ToDecimal(reader["Discount"]);
                                GrandTotal = Convert.ToDecimal(reader["GrandTotal"]);
                                PaymentMethodID = (int)reader["PaymentMethodID"];
                                BillDate = (DateTime)reader["BillDate"];
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
        public static bool GetBillByBillDate(ref int BillID, ref int OrderID, ref decimal SubTotal, ref decimal Tax, ref decimal Discount, ref decimal GrandTotal, ref int PaymentMethodID, ref string PaymentStatus, DateTime BillDate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Bills WHERE BillDate = @BillDate";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BillDate", BillDate);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                BillID = (int)reader["BillID"];
                                OrderID = (int)reader["OrderID"];
                                SubTotal = Convert.ToDecimal(reader["SubTotal"]);
                                Tax = Convert.ToDecimal(reader["Tax"]);
                                Discount = Convert.ToDecimal(reader["Discount"]);
                                GrandTotal = Convert.ToDecimal(reader["GrandTotal"]);
                                PaymentMethodID = (int)reader["PaymentMethodID"];
                                PaymentStatus = (string)reader["PaymentStatus"];
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
        public static int AddNewBill(int OrderID, decimal SubTotal, decimal Tax, decimal Discount, decimal GrandTotal, int PaymentMethodID, string PaymentStatus, DateTime BillDate)
        {
            int BillID = -1;
            string query = @"INSERT INTO Bills (OrderID, SubTotal, Tax, Discount, GrandTotal, PaymentMethodID, PaymentStatus, BillDate)
                            VALUES (@OrderID, @SubTotal, @Tax, @Discount, @GrandTotal, @PaymentMethodID, @PaymentStatus, @BillDate)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@OrderID", OrderID);
                        command.Parameters.AddWithValue("@SubTotal", SubTotal);
                        command.Parameters.AddWithValue("@Tax", Tax);
                        command.Parameters.AddWithValue("@Discount", Discount);
                        command.Parameters.AddWithValue("@GrandTotal", GrandTotal);
                        command.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);
                        command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
                        command.Parameters.AddWithValue("@BillDate", BillDate);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            BillID = insertedID;
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

            return BillID;
        }
        public static bool UpdateBill(int BillID, int OrderID, decimal SubTotal, decimal Tax, decimal Discount, decimal GrandTotal, int PaymentMethodID, string PaymentStatus, DateTime BillDate)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Bills  
                                        SET 
                                        OrderID = @OrderID, 
                            SubTotal = @SubTotal, 
                            Tax = @Tax, 
                            Discount = @Discount, 
                            GrandTotal = @GrandTotal, 
                            PaymentMethodID = @PaymentMethodID, 
                            PaymentStatus = @PaymentStatus, 
                            BillDate = @BillDate
                            WHERE BillID = @BillID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@BillID", BillID);
                        command.Parameters.AddWithValue("@OrderID", OrderID);
                        command.Parameters.AddWithValue("@SubTotal", SubTotal);
                        command.Parameters.AddWithValue("@Tax", Tax);
                        command.Parameters.AddWithValue("@Discount", Discount);
                        command.Parameters.AddWithValue("@GrandTotal", GrandTotal);
                        command.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);
                        command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
                        command.Parameters.AddWithValue("@BillDate", BillDate);
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
        public static bool DeleteBill(int BillID)
        {
            int rowsAffected = 0;
            string query = @"Delete Bills 
                                where BillID = @BillID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BillID", BillID);
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
        public static bool IsBillExist(int BillID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Bills WHERE BillID = @BillID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BillID", BillID);
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
        public static bool IsBillExistByBillID(int BillID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Bills WHERE BillID = @BillID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BillID", BillID);
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
        public static bool IsBillExistByOrderID(int OrderID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Bills WHERE OrderID = @OrderID";
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
        public static bool IsBillExistBySubTotal(decimal SubTotal)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Bills WHERE SubTotal = @SubTotal";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SubTotal", SubTotal);
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
        public static bool IsBillExistByTax(decimal Tax)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Bills WHERE Tax = @Tax";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Tax", Tax);
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
        public static bool IsBillExistByDiscount(decimal Discount)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Bills WHERE Discount = @Discount";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Discount", Discount);
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
        public static bool IsBillExistByGrandTotal(decimal GrandTotal)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Bills WHERE GrandTotal = @GrandTotal";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GrandTotal", GrandTotal);
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
        public static bool IsBillExistByPaymentMethodID(int PaymentMethodID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Bills WHERE PaymentMethodID = @PaymentMethodID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);
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
        public static bool IsBillExistByPaymentStatus(string PaymentStatus)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Bills WHERE PaymentStatus = @PaymentStatus";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
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
        public static bool IsBillExistByBillDate(DateTime BillDate)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Bills WHERE BillDate = @BillDate";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BillDate", BillDate);
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
        public static DataTable GetAllBills()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Bills";
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