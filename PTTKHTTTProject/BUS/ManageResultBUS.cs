using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
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

        public static void updateInfomationOfResultExam(string examcode, string point, string dotime, string markunit)
        {
            Debug.WriteLine($"Ma bai thi: {examcode}");

            if (float.TryParse(point, NumberStyles.Float, CultureInfo.InvariantCulture, out float parsepoint))
            {
                // result đã có giá trị
            }
            else
            {
                MessageBox.Show("Điểm số nhập không đúng định dạng", "Miss Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TimeOnly parsetime = TimeOnly.Parse(dotime);

            ManageResultDAO.updateInfomationIntoBAITHI(examcode, parsepoint, parsetime, markunit);
        }

        public static void deleteAExam(string examcode)
        {
            ManageResultDAO.deleteBAITHI(examcode);
        }

        public static List<string> loadTimePointAndMarkuint(string examcode)
        {
            DataTable temp = ManageResultDAO.getTimePointAndMarkuint(examcode);

            string point = temp.Rows[0]["BT_DiemSo"]?.ToString() ?? string.Empty;
            string dtime = temp.Rows[0]["BT_ThoiGianLamBai"]?.ToString() ?? string.Empty;
            string markunit = temp.Rows[0]["BT_DonViCham"]?.ToString() ?? string.Empty;

            return [dtime, point, markunit];
        }
    }
}
