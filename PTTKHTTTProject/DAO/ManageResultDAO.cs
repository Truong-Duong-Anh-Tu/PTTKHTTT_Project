using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xaml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PTTKHTTTProject.DAO
{
    internal class ManageResultDAO
    {
        public static DataTable getCandidateAndPoint(string examtype)
        {
            var pExamtype = new SqlParameter("@examtest", SqlDbType.VarChar, 10)
            { Value = examtype.Trim() };

            DataTable dt = DataProvider.Instance.ExecuteQuerySP("usp_ThongTinKetQuaThi", pExamtype);

            return dt;
        }

        public static void updateInfomationIntoBAITHI(string examcode, float point, TimeOnly dotime, string markunit)
        {
            var pExamcode = new SqlParameter("@mabaithi", SqlDbType.VarChar, 10)
            { Value = examcode.Trim() };

            var pPoint = new SqlParameter("@diemso", SqlDbType.Float) { Value = point };
            
            var pTime = new SqlParameter("@thoigian", SqlDbType.Time) { Value = dotime };

            var pMarkunit = new SqlParameter("@donvicham", SqlDbType.VarChar, 10)
            { Value = markunit };

            DataProvider.Instance.ExecuteNonQuerySP("usp_CapNhatKetQuaThi", pExamcode, pPoint, pTime, pMarkunit);
        }

        public static void deleteBAITHI(string examcode)
        {
            var pExamcode = new SqlParameter("@mabaithi", SqlDbType.VarChar, 10)
            { Value = examcode.Trim() };

            DataProvider.Instance.ExecuteNonQuerySP("usp_XoaBaiThi", pExamcode);
        }

        public static DataTable getTimePointAndMarkuint(string examcode)
        {
            var pExamcode = new SqlParameter("@mabaithi", SqlDbType.VarChar, 10)
            { Value = examcode.Trim() };

            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT BT_ThoiGianLamBai, BT_DiemSo, BT_DonViCham FROM BAITHI WHERE BT_MaBaiThi = @mabaithi", pExamcode);

            return dt;
        }
    }
}
