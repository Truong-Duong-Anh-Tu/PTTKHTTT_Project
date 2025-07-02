using PTTKHTTTProject.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.BUS
{
    internal class GuardExamAssignmentBUS
    {
        public static DataTable loadAssignment()
        {
            DataTable dt = GuardExamAssignmentDAO.getAssignment();

            return dt;
        }
    }
}
