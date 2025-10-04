using ClsConnectionStringLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsUserDataAccessLayer
{
    public class ClsUserData
    {

        public static bool GetUserByID(int UserID, ref string Username, ref int Password, ref string Role, ref string FullName, ref string Phone, ref string Email)
        {
            bool isFound = false;
            string query = "SELECT * FROM Users WHERE UserID = @UserID";
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

                                Username = (string)reader["Username"];
                                Password = (int)reader["Password"];
                                Role = (string)reader["Role"];
                                FullName = (string)reader["FullName"];
                                Phone = (string)reader["Phone"];
                                Email = (string)reader["Email"];
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
        public static bool GetUserByUserID(int UserID, ref string Username, ref int Password, ref string Role, ref string FullName, ref string Phone, ref string Email)
        {
            bool isFound = false;
            string query = "SELECT * FROM Users WHERE UserID = @UserID";
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

                                Username = (string)reader["Username"];
                                Password = (int)reader["Password"];
                                Role = (string)reader["Role"];
                                FullName = (string)reader["FullName"];
                                Phone = (string)reader["Phone"];
                                Email = (string)reader["Email"];
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
        public static bool GetUserByUsername(ref int UserID, string Username, ref int Password, ref string Role, ref string FullName, ref string Phone, ref string Email)
        {
            bool isFound = false;
            string query = "SELECT * FROM Users WHERE Username = @Username";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                UserID = (int)reader["UserID"];
                                Password = (int)reader["Password"];
                                Role = (string)reader["Role"];
                                FullName = (string)reader["FullName"];
                                Phone = (string)reader["Phone"];
                                Email = (string)reader["Email"];
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
        public static bool GetUserByPassword(ref int UserID, ref string Username, int Password, ref string Role, ref string FullName, ref string Phone, ref string Email)
        {
            bool isFound = false;
            string query = "SELECT * FROM Users WHERE Password = @Password";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Password", Password);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                UserID = (int)reader["UserID"];
                                Username = (string)reader["Username"];
                                Role = (string)reader["Role"];
                                FullName = (string)reader["FullName"];
                                Phone = (string)reader["Phone"];
                                Email = (string)reader["Email"];
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
        public static bool GetUserByRole(ref int UserID, ref string Username, ref int Password, string Role, ref string FullName, ref string Phone, ref string Email)
        {
            bool isFound = false;
            string query = "SELECT * FROM Users WHERE Role = @Role";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Role", Role);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                UserID = (int)reader["UserID"];
                                Username = (string)reader["Username"];
                                Password = (int)reader["Password"];
                                FullName = (string)reader["FullName"];
                                Phone = (string)reader["Phone"];
                                Email = (string)reader["Email"];
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
        public static bool GetUserByFullName(ref int UserID, ref string Username, ref int Password, ref string Role, string FullName, ref string Phone, ref string Email)
        {
            bool isFound = false;
            string query = "SELECT * FROM Users WHERE FullName = @FullName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", FullName);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                UserID = (int)reader["UserID"];
                                Username = (string)reader["Username"];
                                Password = (int)reader["Password"];
                                Role = (string)reader["Role"];
                                Phone = (string)reader["Phone"];
                                Email = (string)reader["Email"];
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
        public static bool GetUserByPhone(ref int UserID, ref string Username, ref int Password, ref string Role, ref string FullName, string Phone, ref string Email)
        {
            bool isFound = false;
            string query = "SELECT * FROM Users WHERE Phone = @Phone";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Phone", Phone);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                UserID = (int)reader["UserID"];
                                Username = (string)reader["Username"];
                                Password = (int)reader["Password"];
                                Role = (string)reader["Role"];
                                FullName = (string)reader["FullName"];
                                Email = (string)reader["Email"];
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
        public static bool GetUserByEmail(ref int UserID, ref string Username, ref int Password, ref string Role, ref string FullName, ref string Phone, string Email)
        {
            bool isFound = false;
            string query = "SELECT * FROM Users WHERE Email = @Email";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", Email);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                UserID = (int)reader["UserID"];
                                Username = (string)reader["Username"];
                                Password = (int)reader["Password"];
                                Role = (string)reader["Role"];
                                FullName = (string)reader["FullName"];
                                Phone = (string)reader["Phone"];
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
        public static int AddNewUser(string Username, int Password, string Role, string FullName, string Phone, string Email)
        {
            int UserID = -1;
            string query = @"INSERT INTO Users (Username, Password, Role, FullName, Phone, Email)
                            VALUES (@Username, @Password, @Role, @FullName, @Phone, @Email)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@Role", Role);
                        command.Parameters.AddWithValue("@FullName", FullName);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", Email);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            UserID = insertedID;
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

            return UserID;
        }
        public static bool UpdateUser(int UserID, string Username, int Password, string Role, string FullName, string Phone, string Email)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Users  
                                        SET 
                                        Username = @Username, 
                            Password = @Password, 
                            Role = @Role, 
                            FullName = @FullName, 
                            Phone = @Phone, 
                            Email = @Email
                            WHERE UserID = @UserID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@Role", Role);
                        command.Parameters.AddWithValue("@FullName", FullName);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", Email);
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
        public static bool DeleteUser(int UserID)
        {
            int rowsAffected = 0;
            string query = @"Delete Users 
                                where UserID = @UserID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
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
        public static bool IsUserExist(int UserID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";
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
        public static bool IsUserExistByUserID(int UserID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";
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
        public static bool IsUserExistByUsername(string Username)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Users WHERE Username = @Username";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
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
        public static bool IsUserExistByPassword(int Password)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Users WHERE Password = @Password";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Password", Password);
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
        public static bool IsUserExistByRole(string Role)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Users WHERE Role = @Role";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Role", Role);
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
        public static bool IsUserExistByFullName(string FullName)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Users WHERE FullName = @FullName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", FullName);
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
        public static bool IsUserExistByPhone(string Phone)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Users WHERE Phone = @Phone";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Phone", Phone);
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
        public static bool IsUserExistByEmail(string Email)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Users WHERE Email = @Email";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", Email);
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
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Users";
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
