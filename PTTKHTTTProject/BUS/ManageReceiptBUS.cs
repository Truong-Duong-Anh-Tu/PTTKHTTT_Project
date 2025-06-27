using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.BUS
{
    internal class ManageReceiptBUS
    {
        public static DataTable loadReceipt()
        {
            //if (string.IsNullOrEmpty(receiptType))
            //{
            //    Debug.WriteLine("Receipt type is null or empty, loading all receipts.");
            //    return ManageReceiptDAO.getReceipt();
            //}
            //string type = receiptType.Split(' ')[0];
            DataTable dt = ManageReceiptDAO.getReceipt();
            return dt;
        }
        //public static List<string> loadReceiptType()
        //{
        //    List<string> receiptList = new List<string>();
        //    DataTable dt = ManageReceiptDAO.getReceiptType();
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        string temp = dr["PDKDT_TinhTrangThanhToan"].ToString();
        //        receiptList.Add(temp);
        //    }
        //    return receiptList;
        //}
    }
}
