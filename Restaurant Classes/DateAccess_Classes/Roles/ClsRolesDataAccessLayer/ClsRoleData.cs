using ClsConnectionStringLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsRoleDataAccessLayer
{
    public class ClsRoleData
    {
        public static bool GetRoleByID(int RoleID, ref string Name, ref int Permission)
        {
            bool isFound = false;
            string query = "SELECT * FROM Roles WHERE RoleID = @RoleID";
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

                                Name = (string)reader["Name"];
                                Permission = (int)reader["Permission"];
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
        public static bool GetRoleByRoleID(int RoleID, ref string Name, ref int Permission)
        {
            bool isFound = false;
            string query = "SELECT * FROM Roles WHERE RoleID = @RoleID";
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

                                Name = (string)reader["Name"];
                                Permission = (int)reader["Permission"];
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
        public static bool GetRoleByName(ref int RoleID, string Name, ref int Permission)
        {
            bool isFound = false;
            string query = "SELECT * FROM Roles WHERE Name = @Name";
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

                                RoleID = (int)reader["RoleID"];
                                Permission = (int)reader["Permission"];
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
        public static bool GetRoleByPermission(ref int RoleID, ref string Name, int Permission)
        {
            bool isFound = false;
            string query = "SELECT * FROM Roles WHERE Permission = @Permission";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Permission", Permission);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                RoleID = (int)reader["RoleID"];
                                Name = (string)reader["Name"];
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
        public static int AddNewRole(string Name, int Permission)
        {
            int RoleID = -1;
            string query = @"INSERT INTO Roles (Name, Permission)
                            VALUES (@Name, @Permission)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Permission", Permission);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            RoleID = insertedID;
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

            return RoleID;
        }
        public static bool UpdateRole(int RoleID, string Name, int Permission)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Roles  
                                        SET 
                                        Name = @Name, 
                            Permission = @Permission
                            WHERE RoleID = @RoleID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@RoleID", RoleID);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Permission", Permission);
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
        public static bool DeleteRole(int RoleID)
        {
            int rowsAffected = 0;
            string query = @"Delete Roles 
                                where RoleID = @RoleID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoleID", RoleID);
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
        public static bool IsRoleExist(int RoleID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Roles WHERE RoleID = @RoleID";
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
        public static bool IsRoleExistByRoleID(int RoleID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Roles WHERE RoleID = @RoleID";
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
        public static bool IsRoleExistByName(string Name)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Roles WHERE Name = @Name";
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
        public static bool IsRoleExistByPermission(int Permission)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Roles WHERE Permission = @Permission";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Permission", Permission);
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
        public static DataTable GetAllRoles()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Roles";
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

        public static string GetRoleNameByID(int RoleID)
        {
            string RoleName = "";

            string query = "SELECT Name FROM Roles where RoleID = @RoleID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@RoleID", RoleID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                                RoleName = (string)reader["Name"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "";
            }
            finally
            {

            }

            return RoleName;
        }
    }
}
