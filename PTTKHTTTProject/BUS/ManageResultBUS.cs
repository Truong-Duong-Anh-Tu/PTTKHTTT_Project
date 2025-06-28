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
    }
}
