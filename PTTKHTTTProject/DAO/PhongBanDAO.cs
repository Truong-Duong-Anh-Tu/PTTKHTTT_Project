using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
    }
}
