using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.DAO
{
    internal class ExamDateDAO
    {
        public static DataTable getExamDate(string examtype)
        {
            var pExamtype = new SqlParameter("@examtest", SqlDbType.VarChar, 10)
            { Value = examtype.Trim() };

            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT LT_MaLichThi, LT_NgayThi, LT_TGBatDau FROM LICHTHI WHERE LT_MaKyThi = @examtest", pExamtype);

            return dt;
        }

        public static DataTable GetAllLichThi()
        {
            return DataProvider.Instance.ExecuteQuerySP("usp_GetLichThi");
        }

        public static DataTable GetLichThiByPhongThi(string maPhongThi)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhongThi", maPhongThi)
            };
            return DataProvider.Instance.ExecuteQuerySP("usp_GetLichThiByPhongThi", parameters);
        }
    }
}
