using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.DAO
{
    internal class MailDAO
    {
        public static DataTable LoadReceiveMail(string username)
        {
            var pUser = new SqlParameter("@username", SqlDbType.VarChar, 10)
            { Value = username.Trim() };

            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM THONGBAO where TB_MaNhanVienNhan = @username", pUser);

            return dt;
        }
    }
}
