using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PTTKHTTTProject.DAO
{
    internal class ManageReceiptDAO
    {
        public static DataTable getReceipt(string filterText)
        {
            if (string.IsNullOrEmpty(filterText))
            {
                // If filterText is null or empty, we can return all receipts
                return DataProvider.Instance.ExecuteQuerySP("usp_GetReceiptTable");
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
                // If filterText is provided, we can filter the receipts based on it. you can search @name or @sbd
                //check if name and sbd are right


                return DataProvider.Instance.ExecuteQuerySP("usp_GetReceiptTable", filter);
            }
        }

        public static DataTable getReceiptInfo(string receiptId)
        {
            SqlParameter[] filter = new SqlParameter[]
                {
                    new SqlParameter("@search", SqlDbType.NVarChar, 50)
                    {
                        Value = receiptId.Trim()
                    },
                };
            DataTable dt = DataProvider.Instance.ExecuteQuerySP("usp_GetReceiptInfo", filter);
            return dt;
        }
    }
}
