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

        public ManageResultBUS(string examcode)
        {
            _examcode = examcode;
            DataTable temp = ManageResultDAO.getTimePointAndMarkuint(_examcode);
            object diemSoObj = temp.Rows[0]["BT_DiemSo"];
            if (diemSoObj != DBNull.Value && decimal.TryParse(diemSoObj.ToString(), out decimal diemSo))
            {
                _point = diemSo;
            }
            else
            {
                _point = -1; // hoặc giá trị mặc định
            }
            _dtime = temp.Rows[0]["BT_ThoiGianLamBai"]?.ToString() ?? string.Empty;
            _markunit = temp.Rows[0]["BT_DonViCham"]?.ToString() ?? string.Empty;
        }

        public static DataTable loadCandidateAndPoint(string examtest)
        {
            string examtype = examtest.Split(' ')[0];

            DataTable dt = ManageResultDAO.getCandidateAndPoint(examtype);

            return dt;
        }

        public void updateInfomationOfResultExam(decimal point, string dtime, string markunit)
        {
            TimeOnly parsetime = TimeOnly.Parse(dtime);

            ManageResultDAO.updateInfomationIntoBAITHI(_examcode, point, parsetime, markunit);
        }

        public void deleteAExam()
        {
            ManageResultDAO.deleteBAITHI(_examcode);
        }

        public void loadTimePointAndMarkuint(out decimal point, out string dtime, out string markunit)
        {
            point = _point;
            dtime = _dtime;
            markunit = _markunit;
        }
    }
}
