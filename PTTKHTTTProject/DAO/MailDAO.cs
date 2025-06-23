using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.DAO
{
    internal class MailDAO
    {
        public static DataTable LoadReceiveMail(string username)
        {
            var pUser = new SqlParameter("@username", SqlDbType.VarChar, 10)
            { Value = username.Trim() };

            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM THONGBAO where TB_MaDoiTuongNhan = @username", pUser);

            return dt;
        }

        public static DataTable GetRecipients()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT NV_MaNHanVien, NV_TenNhanVien, NV_ChucVu FROM NHANVIEN");

            return dt;
        }

        public static DataTable GetDepartment()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM PHONGBAN");

            return dt;
        }

        public static void sendNotification(string usender, string recipient, string subject, string body)
        {
            var pSender = new SqlParameter("@sender", SqlDbType.VarChar, 10) { Value = usender.Trim() };
            var pRecipient = new SqlParameter("@recipient", SqlDbType.VarChar, 10) { Value = recipient.Trim() };
            var pSubject = new SqlParameter("@subject", SqlDbType.NVarChar, 50) { Value = subject.Trim() };
            var pBody = new SqlParameter("@body", SqlDbType.NVarChar, 100) { Value = body.Trim() };

            DataProvider.Instance.ExecuteNonQuerySP("usp_CreateNotification", pSender, pRecipient, pSubject, pBody);
        }
    }
}
