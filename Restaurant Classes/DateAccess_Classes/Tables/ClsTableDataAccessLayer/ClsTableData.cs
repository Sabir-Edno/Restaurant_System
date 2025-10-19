using ClsConnectionStringLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsTableDataAccessLayer
{
    public class ClsTableData
    {
        public static bool GetTableByID(int TableID, ref string TableName, ref int Capacity, ref string Status, ref DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM Tables WHERE TableID = @TableID";
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

                                TableName = (string)reader["TableName"];
                                Capacity = (int)reader["Capacity"];
                                Status = (string)reader["Status"];
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
        public static bool GetTableByTableID(int TableID, ref string TableName, ref int Capacity, ref string Status, ref DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM Tables WHERE TableID = @TableID";
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

                                TableName = (string)reader["TableName"];
                                Capacity = (int)reader["Capacity"];
                                Status = (string)reader["Status"];
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
        public static bool GetTableByTableName(ref int TableID, string TableName, ref int Capacity, ref string Status, ref DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM Tables WHERE TableName = @TableName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TableName", TableName);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                TableID = (int)reader["TableID"];
                                Capacity = (int)reader["Capacity"];
                                Status = (string)reader["Status"];
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
        public static bool GetTableByCapacity(ref int TableID, ref string TableName, int Capacity, ref string Status, ref DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM Tables WHERE Capacity = @Capacity";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Capacity", Capacity);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                TableID = (int)reader["TableID"];
                                TableName = (string)reader["TableName"];
                                Status = (string)reader["Status"];
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
        public static bool GetTableByStatus(ref int TableID, ref string TableName, ref int Capacity, string Status, ref DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM Tables WHERE Status = @Status";
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

                                TableID = (int)reader["TableID"];
                                TableName = (string)reader["TableName"];
                                Capacity = (int)reader["Capacity"];
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
        public static bool GetTableByCreatedAt(ref int TableID, ref string TableName, ref int Capacity, ref string Status, DateTime CreatedAt, ref DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM Tables WHERE CreatedAt = @CreatedAt";
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

                                TableID = (int)reader["TableID"];
                                TableName = (string)reader["TableName"];
                                Capacity = (int)reader["Capacity"];
                                Status = (string)reader["Status"];

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
        public static bool GetTableByUpdated(ref int TableID, ref string TableName, ref int Capacity, ref string Status, ref DateTime CreatedAt, DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT * FROM Tables WHERE Updated = @Updated";
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

                                TableID = (int)reader["TableID"];
                                TableName = (string)reader["TableName"];
                                Capacity = (int)reader["Capacity"];
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
        public static int AddNewTable(string TableName, int Capacity, string Status, DateTime CreatedAt, DateTime Updated)
        {
            int TableID = -1;
            string query = @"INSERT INTO Tables (TableName, Capacity, Status, CreatedAt, Updated)
                            VALUES (@TableName, @Capacity, @Status, @CreatedAt, @Updated)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@TableName", TableName);
                        command.Parameters.AddWithValue("@Capacity", Capacity);
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
                            TableID = insertedID;
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

            return TableID;
        }
        public static bool UpdateTable(int TableID, string TableName, int Capacity, string Status, DateTime CreatedAt, DateTime Updated)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Tables  
                                        SET 
                                        TableName = @TableName, 
                            Capacity = @Capacity, 
                            Status = @Status, 
                            CreatedAt = @CreatedAt, 
                            Updated = @Updated
                            WHERE TableID = @TableID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@TableID", TableID);
                        command.Parameters.AddWithValue("@TableName", TableName);
                        command.Parameters.AddWithValue("@Capacity", Capacity);
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
        public static bool DeleteTable(int TableID)
        {
            int rowsAffected = 0;
            string query = @"Delete Tables 
                                where TableID = @TableID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TableID", TableID);
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
        public static bool IsTableExist(int TableID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Tables WHERE TableID = @TableID";
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
        public static bool IsTableExistByTableID(int TableID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Tables WHERE TableID = @TableID";
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
        public static bool IsTableExistByTableName(string TableName)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Tables WHERE TableName = @TableName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TableName", TableName);
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
        public static bool IsTableExistByCapacity(int Capacity)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Tables WHERE Capacity = @Capacity";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Capacity", Capacity);
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
        public static bool IsTableExistByStatus(string Status)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Tables WHERE Status = @Status";
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
        public static bool IsTableExistByCreatedAt(DateTime CreatedAt)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Tables WHERE CreatedAt = @CreatedAt";
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
        public static bool IsTableExistByUpdated(DateTime Updated)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Tables WHERE Updated = @Updated";
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
        public static DataTable GetAllTables()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Tables";
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