using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.DAO
{
    internal class PhongBanDAO
    {
        public static DataTable GetAllPhongBan()
        {
            return DataProvider.Instance.ExecuteQuerySP("usp_GetAllPhongBan");
        }
        public static DataTable GetPhongBanByTenPhongBan(string TenPhongBan)
        {
            return DataProvider.Instance.ExecuteQuerySP("usp_GetPhongBanByTenPhongBan", new SqlParameter("@TenPhongBan", TenPhongBan));
        }
    }
}
