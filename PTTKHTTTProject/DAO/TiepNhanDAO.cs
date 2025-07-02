using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.DAO
{
    public class TiepNhanDAO
    {
        public static DataTable TraCuuPhieuDangKy(string MaPhieu)
        {
            return DataProvider.Instance.ExecuteQuerySP(
                "TraCuuPhieuDangKyCoBan",
                new SqlParameter("@MaPhieu", SqlDbType.VarChar, 10) { Value = MaPhieu }
            );
        }

        public static DataTable TraCuuThiSinh(string MaPhieu)
        {
            string query = @"
                   SELECT TS_SoBaoDanh, TS_HoTen, TS_NgaySinh, TS_GioiTinh, TS_Email, TS_SDT, TS_CCCD
                   FROM THISINH
                   WHERE TS_MaPhieuDangKy = @MaPhieu";

            return DataProvider.Instance.ExecuteQuery(
                query,
                new SqlParameter("@MaPhieu", SqlDbType.VarChar, 10) { Value = MaPhieu }
            );
        }

        public static DataTable TimThiSinh(string HoTen)
        {
            string query = @"
                   SELECT TS_SoBaoDanh, TS_HoTen, TS_NgaySinh, TS_GioiTinh, TS_Email, TS_SDT, TS_CCCD
                   FROM THISINH
                   WHERE TS_HoTen = @HoTen";
            return DataProvider.Instance.ExecuteQuery(
                query,
                new SqlParameter("@HoTen", SqlDbType.NVarChar, 50) { Value = HoTen }
            );
        }
    }
}
