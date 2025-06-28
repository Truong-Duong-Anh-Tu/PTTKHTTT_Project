using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.DAO
{
    internal class ManageRenewalDAO
    {
        public static DataTable getRenewal()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuerySP("usp_GetRenewalRequestTable");
            return dt;
        }
    }
}
