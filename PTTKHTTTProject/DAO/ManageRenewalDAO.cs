using Microsoft.Data.SqlClient;
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
        public static DataTable getRenewal(string filterText)
        {
            if (string.IsNullOrEmpty(filterText))
            {
                return DataProvider.Instance.ExecuteQuerySP("usp_GetRenewalRequestTable");
            }
            else
            {
                SqlParameter[] filter = new SqlParameter[]
                {
                    new SqlParameter("@search", SqlDbType.NVarChar, 50)
                    {
                        Value = filterText.Trim()
                    },
                };
                return DataProvider.Instance.ExecuteQuerySP("usp_GetRenewalRequestTable", filter);
            }
        }
    }
}
