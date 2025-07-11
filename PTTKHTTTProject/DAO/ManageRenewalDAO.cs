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

        public static DataTable getCreatedRenewal(string filterText)
        {
            if (string.IsNullOrEmpty(filterText))
            {
                return DataProvider.Instance.ExecuteQuerySP("usp_GetCreatedRenewals");
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
                return DataProvider.Instance.ExecuteQuerySP("usp_GetCreatedRenewals", filter);
            }
        }

        //Them thong tin phieu giahan vao bang PHIEUTHANHTOAN
        public void insertIntoCreatedRenewalsTableDAO(string receiptId, string reason, decimal fee)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maphieudk", SqlDbType.VarChar, 10) { Value = receiptId },
                new SqlParameter("@lydo", SqlDbType.NVarChar, 100) { Value = reason },
                new SqlParameter("@sotienthanhtoan", SqlDbType.Int) { Value = fee},
                new SqlParameter("@hinhthuc", SqlDbType.NVarChar, 20) { Value = "Tiền mặt" },
            };
            DataProvider.Instance.ExecuteNonQuerySP("usp_InsertIntoCreatedRenewalsTable", parameters);
        }


        //Cap nhat thong tin phieu thu dung phuong thuc chuyen khoan
        public void updateCreatedRenewalMethodDAO(string renewalId, string currentValue)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maphieugh", SqlDbType.VarChar, 10) { Value = renewalId },
                new SqlParameter("@hinhthuc", SqlDbType.NVarChar, 50) { Value = currentValue },
            };
            string query = "UPDATE PHIEUGIAHAN SET PGH_HinhThucThanhToan = @hinhthuc WHERE PGH_MaPhieu = @maphieugh";
            DataProvider.Instance.ExecuteQuery(query, parameters);
        }


        // Cap nhat thong tin phieu thu da thanh toan
        public void updateCreatedRenewalPaidDAO(string renewalId, string currentValue)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maphieugh", SqlDbType.VarChar, 10) { Value = renewalId },
                new SqlParameter("@trangthai", SqlDbType.NVarChar,20) { Value = currentValue },
            };
            string query = "UPDATE PHIEUGIAHAN SET PHG_TrangThai = @trangthai WHERE PGH_MaPhieu = @maphieugh";
            DataProvider.Instance.ExecuteQuery(query, parameters);

            string pdk_trangthai;
            if (currentValue == "Đã thanh toán")
            {
                pdk_trangthai = "Đã thanh toán";
            }
            else
            {
                pdk_trangthai = "Thanh toán gia hạn";
            }

            query = "SELECT PGH_MaPhieuDK FROM PHIEUGIAHAN WHERE PGH_MaPhieu = @maphieugh";
            var receiptId = DataProvider.Instance.ExecuteScalar(query, new SqlParameter("@maphieugh", renewalId));

            SqlParameter[] parameters2 = new SqlParameter[]
            {
                new SqlParameter("@maphieudk", SqlDbType.VarChar, 10) { Value = receiptId },
                new SqlParameter("@trangthai", SqlDbType.NVarChar,20) { Value = pdk_trangthai },
            };
            query = "UPDATE PHIEUDANGKYDUTHI SET PDKDT_TrangThaiThanhToan = @trangthai WHERE PDKDT_MaPhieu = @maphieudk";
            DataProvider.Instance.ExecuteQuery(query, parameters2);
        }
    }
}
