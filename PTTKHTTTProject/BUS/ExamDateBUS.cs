using PTTKHTTTProject.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
            string examtype = examtest.Split(' ')[0];
            DataTable dt = ExamDateDAO.getExamDate(examtype);

            foreach (DataRow dr in dt.Rows)
            {
                string dateStr = dr.Field<DateTime>("LT_NgayThi").ToString("dd/MM/yyyy");

                var timeSpan = dr.Field<TimeSpan>("LT_TGBatDau");
                string timeStr = timeSpan.ToString(@"hh\:mm");

                string temp = $"{dr["LT_MaLichThi"]} : {dateStr} - {timeStr}";
                examDateList.Add(temp);
            }

            return examDateList;
        }

        public static DataTable GetAllLichThi()
        {
            return ExamDateDAO.GetAllLichThi();
        }
        public static DataTable GetLichThiByPhongThi(string maPhongThi)
        {
            return ExamDateDAO.GetLichThiByPhongThi(maPhongThi);
        }

        public static bool AddLichThi(string maKyThi, string tenKyThi, DateTime ngayThi, string maPhongThi, TimeSpan tgBatDau, TimeSpan tgKetThuc, int slDangKy)
        {
            if (string.IsNullOrWhiteSpace(maKyThi) || string.IsNullOrWhiteSpace(tenKyThi) || string.IsNullOrWhiteSpace(maPhongThi))
            {
                return false;
            }

            try
            {
                string lastId = ExamDateDAO.GetLastLichThiId();
                int newIdNumber = 1;
                if (!string.IsNullOrEmpty(lastId) && lastId.StartsWith("LT") && int.TryParse(lastId.AsSpan(2), out int lastIdNumber))
                {
                    newIdNumber = lastIdNumber + 1;
                }
                string newMaLichThi = "LT" + newIdNumber.ToString("D2");

                // Truyền slDangKy xuống DAO
                ExamDateDAO.AddLichThi(newMaLichThi, maKyThi, slDangKy, "Chưa thi", tenKyThi, ngayThi, maPhongThi, tgBatDau, tgKetThuc);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
