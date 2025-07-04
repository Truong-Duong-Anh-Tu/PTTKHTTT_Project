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
        private string _examcode;
        private decimal _point;
        private string _dtime;
        private string _markunit;

        public ManageResultBUS(string examcode, decimal point, string dtime, string markunit)
        {
            _examcode = examcode;
            _point = point;
            _dtime = dtime;
            _markunit = markunit;
        }

        public static DataTable loadCandidateAndPoint(string examtest)
        {
            string examtype = examtest.Split(' ')[0];

            DataTable dt = ManageResultDAO.getCandidateAndPoint(examtype);

            return dt;
        }

        public void updateInfomationOfResultExam()
        {
            TimeOnly parsetime = TimeOnly.Parse(_dtime);

            ManageResultDAO.updateInfomationIntoBAITHI(_examcode, _point, parsetime, _markunit);
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
