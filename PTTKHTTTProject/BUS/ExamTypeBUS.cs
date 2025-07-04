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

        public static bool UpdateKyThi(string maKyThi, string tenKyThi, string lePhi)
        {
            if (string.IsNullOrWhiteSpace(maKyThi) || string.IsNullOrWhiteSpace(tenKyThi) || string.IsNullOrWhiteSpace(lePhi))
            {
                return false;
            }
            if (decimal.TryParse(lePhi, out decimal lePhiDecimal))
            {
                return ExamTypeDAO.UpdateKyThi(maKyThi, tenKyThi, lePhiDecimal);
            }
            return false;
        }

        public static bool AddKyThi(string tenKyThi, string lePhi)
        {
            if (string.IsNullOrWhiteSpace(tenKyThi) || string.IsNullOrWhiteSpace(lePhi))
            {
                return false;
            }

            string lastId = ExamTypeDAO.GetLastKyThiId();
            int newIdNumber = 1;
            if (!string.IsNullOrEmpty(lastId) && lastId.StartsWith("KT") && int.TryParse(lastId.AsSpan(2), out int lastIdNumber))
            {
                newIdNumber = lastIdNumber + 1;
            }
            string newMaKyThi = "KT" + newIdNumber.ToString("D2");

            if (decimal.TryParse(lePhi, out decimal lePhiDecimal))
            {
                return ExamTypeDAO.AddKyThi(newMaKyThi, tenKyThi, lePhiDecimal);
            }
            return false;
        }

        public static bool DeleteKyThi(string maKyThi)
        {
            if (string.IsNullOrWhiteSpace(maKyThi))
            {
                return false;
            }
            return ExamTypeDAO.DeleteKyThi(maKyThi);
        }
    }
}
