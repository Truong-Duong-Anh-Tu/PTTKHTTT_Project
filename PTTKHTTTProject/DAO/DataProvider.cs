using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PTTKHTTTProject.DAO
{
    internal class DataProvider
    {
        private static readonly Lazy<DataProvider> _instance =
            new Lazy<DataProvider>(() => new DataProvider());

        private readonly string _connectionString;

        /// <summary>
        /// Singleton instance
        /// </summary>
        public static DataProvider Instance => _instance.Value;

        // Private constructor to prevent external instantiation
        private DataProvider()
        {
            _connectionString = "Data Source=localhost;Initial Catalog=DB_TRUNGTAMTHI;User Id=sa;Password=123;TrustServerCertificate=True;";
        }

        /// <summary>
        /// Executes a SELECT query and returns the result as a DataTable.
        /// </summary>
        public DataTable ExecuteQuery(string query, params object[] parameters)
        {
            var data = new DataTable();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                AddParameters(command, parameters);
                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(data);
                }
            }

            return data;
        }

        /// <summary>
        /// Executes an INSERT, UPDATE, or DELETE query and returns the number of affected rows.
        /// </summary>
        public int ExecuteNonQuery(string query, params object[] parameters)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                AddParameters(command, parameters);
                connection.Open();
                return command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Executes a query and returns the first column of the first row in the result set.
        /// </summary>
        public object ExecuteScalar(string query, params object[] parameters)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                AddParameters(command, parameters);
                connection.Open();
                return command.ExecuteScalar();
            }
        }

        /// <summary>
        /// Helper method to add parameters to a SqlCommand. Parameter placeholders in query must match order.
        /// </summary>
        private void AddParameters(SqlCommand command, object[] parameters)
        {
            if (parameters == null || parameters.Length == 0)
                return;

            for (int i = 0; i < parameters.Length; i++)
            {
                var paramName = "@p" + i;
                // Replace only the first occurrence of '?' with the parameter name
                int index = command.CommandText.IndexOf("?");
                if (index < 0)
                    break;
                command.CommandText = command.CommandText.Substring(0, index)
                                         + paramName
                                         + command.CommandText.Substring(index + 1);
                // Add the parameter with its value
                command.Parameters.AddWithValue(paramName, parameters[i] ?? DBNull.Value);
            }
        }
    }
}
