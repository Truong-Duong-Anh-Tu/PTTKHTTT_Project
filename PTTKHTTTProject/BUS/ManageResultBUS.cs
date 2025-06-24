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
    internal class ManageResultBUS
    {
        public static DataTable loadCandidateAndPoint(string examtest)
        {
            string examtype = examtest.Split(' ')[0];

            DataTable dt = ManageResultDAO.getCandidateAndPoint(examtype);

            return dt;
        }

        public static List<string> loadExamType()
        {
            List<string> examList = new List<string>();
            DataTable dt = ManageResultDAO.getExamType();

            foreach (DataRow dr in dt.Rows)
            {
                string temp = $"{dr["KT_MaKyThi"]} - {dr["KT_TenKyThi"]}";
                examList.Add(temp);
            }

            return examList;
        }
    }
}
