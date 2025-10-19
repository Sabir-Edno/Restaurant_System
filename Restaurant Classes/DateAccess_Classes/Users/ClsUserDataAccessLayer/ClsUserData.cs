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
        public static bool GetUserByID(int UserID, ref string FullName, ref string Username, ref string Password, ref int RoleID, ref string Phone, ref string Email, ref bool Status, ref DateTime CreatedAt, ref DateTime Updated)
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

                                FullName = (string)reader["FullName"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                RoleID = (int)reader["RoleID"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                Status = (bool)reader["Status"];
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
        public static bool GetUserByUserID(int UserID, ref string FullName, ref string Username, ref string Password, ref int RoleID, ref string Phone, ref string Email, ref bool Status, ref DateTime CreatedAt, ref DateTime Updated)
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

                                FullName = (string)reader["FullName"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                RoleID = (int)reader["RoleID"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                Status = (bool)reader["Status"];
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
        public static bool GetUserByFullName(ref int UserID, string FullName, ref string Username, ref string Password, ref int RoleID, ref string Phone, ref string Email, ref bool Status, ref DateTime CreatedAt, ref DateTime Updated)
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
                                Password = (string)reader["Password"];
                                RoleID = (int)reader["RoleID"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                Status = (bool)reader["Status"];
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
        public static bool GetUserByUsername(ref int UserID, ref string FullName, string Username, ref string Password, ref int RoleID, ref string Phone, ref string Email, ref bool Status, ref DateTime CreatedAt, ref DateTime Updated)
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
                                FullName = (string)reader["FullName"];
                                Password = (string)reader["Password"];
                                RoleID = (int)reader["RoleID"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                Status = (bool)reader["Status"];
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
        public static bool GetUserByPassword(ref int UserID, ref string FullName, ref string Username, string Password, ref int RoleID, ref string Phone, ref string Email, ref bool Status, ref DateTime CreatedAt, ref DateTime Updated)
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
                                FullName = (string)reader["FullName"];
                                Username = (string)reader["Username"];
                                RoleID = (int)reader["RoleID"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                Status = (bool)reader["Status"];
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
        public static bool GetUserByRoleID(ref int UserID, ref string FullName, ref string Username, ref string Password, int RoleID, ref string Phone, ref string Email, ref bool Status, ref DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM Users WHERE RoleID = @RoleID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoleID", RoleID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                UserID = (int)reader["UserID"];
                                FullName = (string)reader["FullName"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                Status = (bool)reader["Status"];
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
        public static bool GetUserByPhone(ref int UserID, ref string FullName, ref string Username, ref string Password, ref int RoleID, string Phone, ref string Email, ref bool Status, ref DateTime CreatedAt, ref DateTime Updated)
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
                                FullName = (string)reader["FullName"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                RoleID = (int)reader["RoleID"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                Status = (bool)reader["Status"];
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
        public static bool GetUserByEmail(ref int UserID, ref string FullName, ref string Username, ref string Password, ref int RoleID, ref string Phone, string Email, ref bool Status, ref DateTime CreatedAt, ref DateTime Updated)
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
                                FullName = (string)reader["FullName"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                RoleID = (int)reader["RoleID"];
                                Phone = (string)reader["Phone"];
                                Status = (bool)reader["Status"];
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
        public static bool GetUserByStatus(ref int UserID, ref string FullName, ref string Username, ref string Password, ref int RoleID, ref string Phone, ref string Email, bool Status, ref DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM Users WHERE Status = @Status";
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

                                UserID = (int)reader["UserID"];
                                FullName = (string)reader["FullName"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                RoleID = (int)reader["RoleID"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

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
        public static bool GetUserByCreatedAt(ref int UserID, ref string FullName, ref string Username, ref string Password, ref int RoleID, ref string Phone, ref string Email, ref bool Status, DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM Users WHERE CreatedAt = @CreatedAt";
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

                                UserID = (int)reader["UserID"];
                                FullName = (string)reader["FullName"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                RoleID = (int)reader["RoleID"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                Status = (bool)reader["Status"];

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
        public static bool GetUserByUpdated(ref int UserID, ref string FullName, ref string Username, ref string Password, ref int RoleID, ref string Phone, ref string Email, ref bool Status, ref DateTime CreatedAt, DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM Users WHERE Updated = @Updated";
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

                                UserID = (int)reader["UserID"];
                                FullName = (string)reader["FullName"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                RoleID = (int)reader["RoleID"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                Status = (bool)reader["Status"];
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
        public static int AddNewUser(string FullName, string Username, string Password, int RoleID, string Phone, string Email, bool Status, DateTime CreatedAt, DateTime Updated)
        {
            int UserID = -1;
            string query = @"INSERT INTO Users (FullName, Username, Password, RoleID, Phone, Email, Status, CreatedAt, Updated)
                            VALUES (@FullName, @Username, @Password, @RoleID, @Phone, @Email, @Status, @CreatedAt, @Updated)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@FullName", FullName);
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@RoleID", RoleID);
                        command.Parameters.AddWithValue("@Phone", Phone);

                        if (Email != "")
                            command.Parameters.AddWithValue("@Email", Email);
                        else
                            command.Parameters.AddWithValue("@Email", DBNull.Value);
                        command.Parameters.AddWithValue("@Status", Status);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);

                        if (Updated != DateTime.MinValue)
                            command.Parameters.AddWithValue("@Updated", Updated);
                        else
                            command.Parameters.AddWithValue("@Updated", DBNull.Value);
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
        public static bool UpdateUser(int UserID, string FullName, string Username, int RoleID, string Phone, string Email, bool Status, DateTime CreatedAt, DateTime Updated)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Users  
                                        SET 
                                        FullName = @FullName, 
                            Username = @Username, 
                            RoleID = @RoleID, 
                            Phone = @Phone, 
                            Email = @Email, 
                            Status = @Status, 
                            CreatedAt = @CreatedAt, 
                            Updated = @Updated
                            WHERE UserID = @UserID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@FullName", FullName);
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@RoleID", RoleID);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Status", Status);
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
        public static bool IsUserExistByPassword(string Password)
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
        public static bool IsUserExistByRoleID(int RoleID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Users WHERE RoleID = @RoleID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoleID", RoleID);
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
        public static bool IsUserExistByStatus(bool Status)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Users WHERE Status = @Status";
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
        public static bool IsUserExistByCreatedAt(DateTime CreatedAt)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Users WHERE CreatedAt = @CreatedAt";
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
        public static bool IsUserExistByUpdated(DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Users WHERE Updated = @Updated";
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
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            string query = "SELECT UserID , FullName , Username , RoleID , Phone , Email , Status , CreatedAt , Updated FROM Users";
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

        public static bool IsUserExistByUserNameWithRole(string Username , int RoleID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand("SP_IsUserExistByUsername", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@RoleID", RoleID);
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
        public static bool IsUsernameAndPasswordCorrect(string Username, string Password ,int RoleID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand("SP_IsUsernameAndPasswordCorrect", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@RoleID", RoleID);
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

        public static bool IsUserActive(string Username, int RoleID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand("SP_IsUserActive", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@RoleID", RoleID);
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
        public static DataTable GetAllAdmins()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllAdmins", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
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
        public static DataTable GetAllChefs()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllChefs", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
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
        public static DataTable GetAllManagers()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllManagers", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
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
        public static DataTable GetAllWaiters()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllWaiters", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
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
