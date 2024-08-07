using System;
using System.Data;
using System.Data.SqlClient;

namespace ProfileManagement
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Server=BOOTCAMP\\SQL19;Database=UserProfileDB;User Id=sa;Password=123456;";

        public static void ExecuteQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetDataTable(string query, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
    }
}
