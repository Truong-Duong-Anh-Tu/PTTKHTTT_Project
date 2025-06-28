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

            Debug.WriteLine(dt.Rows.Count);

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
    }
}
