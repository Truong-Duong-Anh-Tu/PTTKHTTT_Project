using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.DAO
{
    internal class ExamTypeDAO
    {
        public static DataTable getExamType()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM KYTHI");

            return dt;
        }
    }
}
