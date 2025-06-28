using PTTKHTTTProject.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.BUS
{
    internal class ExamDateBUS
    {
        public static List<string> loadExamDate(string examtest)
        {
            List<string> examDateList = new List<string>();
            DataTable dt = ExamDateDAO.getExamDate(examtest);

            foreach (DataRow dr in dt.Rows)
            {
                string temp = $"{dr["LT_MaLichThi"]}: {dr["LT_NgayThi"]} - {dr["LT_TGBatDau"]}";
                examDateList.Add(temp);
            }

            return examDateList;
        }
    }
}
