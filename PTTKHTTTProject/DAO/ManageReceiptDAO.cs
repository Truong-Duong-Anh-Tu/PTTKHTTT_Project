using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PTTKHTTTProject.DAO
{
    internal class ManageReceiptDAO
    {
        public static DataTable getReceipt(string receiptType)
        {

            var pReceiptType = new SqlParameter("@type", SqlDbType.NVarChar, 20)
            { Value = receiptType.Trim() };

            DataTable dt = DataProvider.Instance.ExecuteQuerySP("usp_GetReceiptInfo", pReceiptType);

            return dt;
        }

        public static DataTable getReceiptType()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT PDKDT_TinhTrangThanhToan FROM PHIEUDANGKYDUTHI");
            return dt;
        }
    }
}
