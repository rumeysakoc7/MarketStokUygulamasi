using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace MarketStokUygulamsı_
{
   public class DatabaseHelper
    {
        private readonly string _connectionString = @"Data Source=.\SQLEXPRESS03;Initial Catalog=Market_Stok;Integrated Security=True;TrustServerCertificate=True";

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
             try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Hata oluştu: {ex.Message}");
                throw;  
            }
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Hata oluştu: {ex.Message}");
                throw;  
            }
        }

        internal int ExecuteScalar(string sqlKontrol, SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
