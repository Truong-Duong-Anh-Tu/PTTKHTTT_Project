using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.DAO
{
    internal class SuaThiSinhDonViDAO
    {
        public static DataTable LoadThongTinThiSinh(string sbd)
        {
            string query = @"
                   SELECT TS_SoBaoDanh, TS_HoTen, TS_NgaySinh, TS_GioiTinh, TS_Email, TS_SDT, TS_CCCD
                   FROM THISINH
                   WHERE TS_SoBaoDanh = @sbd";

            return DataProvider.Instance.ExecuteQuery(
                query,
                new SqlParameter("@sbd", SqlDbType.VarChar, 10) { Value = sbd }
            );
        }

        public static void CapNhatThiSinh(string sbd, string hoTen, DateTime ngaySinh, string gioiTinh, string email, string sdt, string cccd)
        {
            string query = @"
                   UPDATE THISINH
                   SET TS_HoTen = @HoTen,
                       TS_NgaySinh = @NgaySinh,
                       TS_GioiTinh = @GioiTinh,
                       TS_Email = @Email,
                       TS_SDT = @SDT,
                       TS_CCCD = @CCCD
                   WHERE TS_SoBaoDanh = @SBD";

            DataProvider.Instance.ExecuteNonQuery(
                query,
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@NgaySinh", ngaySinh),
                new SqlParameter("@GioiTinh", gioiTinh),
                new SqlParameter("@Email", email),
                new SqlParameter("@SDT", sdt),
                new SqlParameter("@CCCD", cccd),
                new SqlParameter("@SBD", sbd)
            );
        }

        public static bool XoaThiSinh(string sbd)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuerySP(
                    "XoaThiSinh",
                    new SqlParameter("@sbd", SqlDbType.VarChar, 10) { Value = sbd }
                );
                return true;
            }
            catch (Exception ex)
            {
                // Có thể log hoặc throw lại nếu cần
                MessageBox.Show("Lỗi khi xóa thí sinh: " + ex.Message);
                return false;
            }
        }
    }
}
