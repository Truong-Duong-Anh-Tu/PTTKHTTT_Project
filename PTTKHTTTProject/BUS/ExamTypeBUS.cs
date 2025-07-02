using PTTKHTTTProject.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.BUS
{
    internal class ExamTypeBUS
    {

        public static List<string> loadExamType()
        {

            List<string> examList = new List<string>();
            DataTable dt = ExamTypeDAO.GetAllExams();

            foreach (DataRow dr in dt.Rows)
            {
                string temp = $"{dr["KT_MaKyThi"]} - {dr["KT_TenKyThi"]}";
                examList.Add(temp);
            }

            return examList;
        }

        public static int GetTotalExamCount()
        {
            return ExamTypeDAO.GetTotalExamCount();
        }

        public static DataTable GetAllExams()
        {
            return ExamTypeDAO.GetAllExams();
        }

        public static int GetRemainingScheduleCount()
        {
            return ExamTypeDAO.GetRemainingScheduleCount();
        }
    }
}
