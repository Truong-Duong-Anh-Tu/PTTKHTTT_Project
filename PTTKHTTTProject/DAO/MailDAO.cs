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
        public static DataTable LoadReceiveMail(string username, string department)
        {
            var pUser = new SqlParameter("@username", SqlDbType.VarChar, 10)
            { Value = username.Trim() };

            var pDepartment = new SqlParameter("@department", SqlDbType.VarChar, 10)
            { Value = department.Trim() };

            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM THONGBAO where TB_MaDoiTuongNhan = @username or TB_MaDoiTuongNhan = @department", pUser, pDepartment);

            return dt;
        }

        public static DataTable LoadSendMail(string username)
        {
            var pUser = new SqlParameter("@username", SqlDbType.VarChar, 10)
            { Value = username.Trim() };

            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM THONGBAO where TB_MaNhanVienGui = @username", pUser);

            return dt;
        }

        public static DataTable GetRecipients()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT NV_MaNhanVien, NV_TenNhanVien, NV_ChucVu FROM NHANVIEN");

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

        public static string getDepartment(string username)
        {
            var pUser = new SqlParameter("@username", SqlDbType.VarChar, 10)
            { Value = username.Trim() };

            object result = DataProvider.Instance.ExecuteScalar("SELECT NV_MaPhongBan FROM NHANVIEN WHERE NV_MaNhanVien = @username", pUser);

            string? department = result != null && result != DBNull.Value ? result.ToString() : string.Empty;

            return $"{department}";
        }

        public static string getRole(string username)
        {
            var pUser = new SqlParameter("@username", SqlDbType.VarChar, 10)
            { Value = username.Trim() };
            var pRole = new SqlParameter("@role", SqlDbType.NVarChar, 20)
            { Direction = ParameterDirection.Output };

            DataProvider.Instance.ExecuteNonQuerySP("usp_GetRoleOfUser", pUser, pRole);

            string role = pRole.Value as string ?? string.Empty;

            return role;
        }

        public static string getDepartmentName(string department)
        {
            var pDepartment = new SqlParameter("@department", SqlDbType.VarChar, 10)
            { Value = department.Trim() };

            object result = DataProvider.Instance.ExecuteScalar("SELECT PB_TenPhongBan FROM PHONGBAN WHERE PB_MaPhongBan = @department", pDepartment);

            string? departmentName = result != null && result != DBNull.Value ? result.ToString() : string.Empty;

            return $"{departmentName}";
        }
    }
}
