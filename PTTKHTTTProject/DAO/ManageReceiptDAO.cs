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
                return DataProvider.Instance.ExecuteQuerySP("usp_GetReceiptTable", filter);
            }
        }


        //Lay thong tin phieu thu da tao
        public static DataTable getPaycheck(string filterText)
        {
            if (string.IsNullOrEmpty(filterText))
            {
                // If filterText is null or empty, we can return all paychecks
                return DataProvider.Instance.ExecuteQuerySP("usp_GetPaycheckTable");
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
                return DataProvider.Instance.ExecuteQuerySP("usp_GetPaycheckTable", filter);
            }
        }


        //Them thong tin phieu thu vao bang PHIEUTHANHTOAN
        public void insertIntoPaycheckTableDAO(string receiptId, string employeeId, decimal fee, string notes)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maphieudk", SqlDbType.VarChar, 10) { Value = receiptId },
                new SqlParameter("@nvlap", SqlDbType.VarChar, 10) { Value = employeeId },
                new SqlParameter("@sotienbandau", SqlDbType.Int) { Value = fee},
                new SqlParameter("@phtramgiam", SqlDbType.Float) { Value = 0 },
                new SqlParameter("@hinhthuc", SqlDbType.NVarChar, 50) { Value = "Tiền mặt" },
                new SqlParameter("@ghichu", SqlDbType.NVarChar, 200) { Value = notes },
            };
            DataProvider.Instance.ExecuteNonQuerySP("usp_InsertIntoPaycheckTable", parameters);
        }


        //Cap nhat thong tin phieu thu dung phuong thuc chuyen khoan
        public void updatePaycheckMethodDAO(string receiptId, string currentValue)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maphieudk", SqlDbType.VarChar, 10) { Value = receiptId },
                new SqlParameter("@hinhthuc", SqlDbType.NVarChar, 50) { Value = currentValue },
            };
            string query = "UPDATE PHIEUTHANHTOAN SET PTT_HinhThucThanhToan = @hinhthuc WHERE PTT_MaPhieuDK = @maphieudk";
            DataProvider.Instance.ExecuteQuery(query, parameters);
        }


        // Cap nhat thong tin phieu thu da thanh toan
        public void updatePaycheckPaidDAO(string receiptId, string currentValue)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maphieudk", SqlDbType.VarChar, 10) { Value = receiptId },
                new SqlParameter("@trangthai", SqlDbType.NVarChar,20) { Value = currentValue },
            };
            string query = "UPDATE PHIEUDANGKYDUTHI SET PDKDT_TrangThaiThanhToan = @trangthai WHERE PDKDT_MaPhieu = @maphieudk";
            DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public static int getCountOfCandidatesPerReceiptID(string receiptId) {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maphieudk", SqlDbType.VarChar, 10) { Value = receiptId },
            };
            string query = "SELECT COUNT(*) FROM PHIEUDANGKYDUTHI JOIN THISINH ON PDKDT_MaPhieu = TS_MaPhieuDangKy WHERE PDKDT_MaPhieu = @maphieudk";
            var result = DataProvider.Instance.ExecuteScalar(query,parameters);
            //Chuyển sang dạng int

            return Convert.ToInt32(result);
        }
    }
}
