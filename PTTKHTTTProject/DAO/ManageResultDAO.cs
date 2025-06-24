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
    internal class ManageResultDAO
    {
        public static DataTable getCandidateAndPoint(string examtype)
        {
            var pExamtype = new SqlParameter("@examtest", SqlDbType.VarChar, 10)
            { Value =examtype.Trim() };

            DataTable dt = DataProvider.Instance.ExecuteQuerySP("usp_ThongTinKetQuaThi", pExamtype);

            return dt;
        }

        public static DataTable getExamType()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELeCT * FROM KYTHI");

            return dt;
        }
    }
}
