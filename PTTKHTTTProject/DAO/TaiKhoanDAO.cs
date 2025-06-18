using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.DAO
{
    internal class TaiKhoanDAO
    {
        public static bool checkLogin(string username, string password)
        {
            object obj = DataProvider.Instance.ExecuteScalar(
                "EXEC usp_CheckTaiKhoan ?, ?",
                username.Trim(), password.Trim());

            if (obj == null || obj == DBNull.Value) return false;
            return (bool)obj;
        }
    }
}
