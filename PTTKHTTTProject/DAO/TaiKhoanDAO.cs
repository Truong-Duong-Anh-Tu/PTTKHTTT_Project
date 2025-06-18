using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using BCrypt.Net;
using Microsoft.Data.SqlClient;

namespace PTTKHTTTProject.DAO
{
    internal class TaiKhoanDAO
    {
        public static string getAccount(string username)
        {
            var pUser = new SqlParameter("@username", SqlDbType.VarChar, 10)
            { Value = username.Trim() };
            var pPass = new SqlParameter("@password", SqlDbType.VarChar, 100)
            { Direction = ParameterDirection.Output };

            DataProvider.Instance.ExecuteNonQuerySP("usp_GetPasswordOfUsername", pUser, pPass);

            string storedHash = pPass.Value as string ?? string.Empty;

            return storedHash;
        }

        public static string getRole(string username)
        {
            var pUser = new SqlParameter("@username", SqlDbType.VarChar, 10)
            { Value = username.Trim() };
            var pRole = new SqlParameter("@role", SqlDbType.NVarChar, 20)
            { Direction = ParameterDirection.Output };

            DataProvider.Instance.ExecuteNonQuerySP("usp_GetRoleOfUser", pUser, pRole);

            string role = pRole.Value as string ?? string.Empty;

            return role;

        }
    }
}
