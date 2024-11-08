using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_232410101042_utspbo.Core
{
    internal class DatabaseWrapper
    {
        private static readonly string DB_HOST = "localhost";
        private static readonly string DB_DATABASE = "A_232410101042_utspbo";
        private static readonly string DB_USERNAME = "postgres";
        private static readonly string DB_PASSWORD = "051004";
        private static readonly string DB_PORT = "5432";

        private static NpgsqlConnection connection;
        private static NpgsqlCommand command;

        // Membuka koneksi ke PostgreSQL
        public static void OpenConnection()
        {
            try
            {
                string connString = $"Host={DB_HOST};Port={DB_PORT};Username={DB_USERNAME};Password={DB_PASSWORD};Database={DB_DATABASE}";
                connection = new NpgsqlConnection(connString);
                connection.Open();

                command = new NpgsqlCommand
                {
                    Connection = connection
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to open connection: " + ex.Message);
            }
        }

        // Menutup koneksi dan membersihkan parameter
        public static void CloseConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            command?.Parameters.Clear();
        }

        // Menjalankan query SELECT dan mengembalikan hasil dalam DataTable
        public static DataTable QueryExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                command.CommandText = query;

                // Menambahkan parameter jika ada
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                DataTable dataTable = new DataTable();
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("Query execution failed: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        // Menjalankan query INSERT, UPDATE, DELETE
        public static void CommandExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                command.CommandText = query;

                // Menambahkan parameter jika ada
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Command execution failed: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
