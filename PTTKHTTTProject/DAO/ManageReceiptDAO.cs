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
        public static DataTable getReceipt(/*string receiptType*/)
        {
            //// the @type parameter can be empty or null, which means we want to get all receipts
            //// if receiptType is null or empty, we can pass null to the stored procedure
            //DataTable table = new DataTable();
            //if (string.IsNullOrEmpty(receiptType))
            //{
            //    // If receiptType is null or empty, we can return all receipts
            //    return DataProvider.Instance.ExecuteQuerySP("usp_GetAllReceipts");
            //}

            //var pReceiptType = new SqlParameter("@type", SqlDbType.NVarChar, 20)
            //{ Value = receiptType.Trim() };

            DataTable dt = DataProvider.Instance.ExecuteQuerySP("usp_GetReceiptInfo");

            return dt;
        }

        //public static DataTable getReceiptType()
        //{
        //    DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT PDKDT_TinhTrangThanhToan FROM PHIEUDANGKYDUTHI");
        //    return dt;
        //}
    }
}
