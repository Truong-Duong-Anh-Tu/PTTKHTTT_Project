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

        public static DataProvider Instance => _instance.Value;

        private readonly string _connectionString;

        private DataProvider()
        {
            _connectionString = "Data Source=localhost;Initial Catalog=DB_TRUNGTAMTHI;User Id=sa;Password=123;TrustServerCertificate=True;";
        }

        // Giúp thêm tham số đã cấu hình đầy đủ (Input/Output, SqlDbType, Size, Value)
        private void AddParameters(SqlCommand cmd, params SqlParameter[] parameters)
        {
            if (parameters == null) return;
            foreach (var p in parameters)
                cmd.Parameters.Add(p);
        }

        public DataTable ExecuteQuery(string sql, params SqlParameter[] parameters)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand(sql, conn) { CommandType = CommandType.Text };
            AddParameters(cmd, parameters);
            using var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable ExecuteQuerySP(string sql, params SqlParameter[] parameters)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand(sql, conn) { CommandType = CommandType.StoredProcedure };
            AddParameters(cmd, parameters);
            using var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand(sql, conn) { CommandType = CommandType.Text };
            AddParameters(cmd, parameters);
            conn.Open();
            return cmd.ExecuteScalar();
        }

        public int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand(sql, conn) { CommandType = CommandType.Text };
            AddParameters(cmd, parameters);
            conn.Open();
            return cmd.ExecuteNonQuery();
        }

        public void ExecuteNonQuerySP(string spName, params SqlParameter[] parameters)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand(spName, conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            AddParameters(cmd, parameters);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public T? ExecuteScalarSP<T>(string spName, params SqlParameter[] parameters)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand(spName, conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            AddParameters(cmd, parameters);
            conn.Open();
            var result = cmd.ExecuteScalar();
            return result == null || result == DBNull.Value
                ? default
                : (T)Convert.ChangeType(result, typeof(T));
        }
    }
}
