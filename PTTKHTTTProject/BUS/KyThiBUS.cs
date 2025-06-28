using System;
using System.Collections.Generic;
using System.Data;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.BUS
{
    public class KyThiBUS
    {
        public static int GetTotalExamCount()
        {
            return KyThiDAO.GetTotalExamCount();
        }
        
        public static DataTable GetAllExams()
        {
            return KyThiDAO.GetAllExams();
        }

        public static int GetRemainingScheduleCount()
        {
            return KyThiDAO.GetRemainingScheduleCount();
        }
    }
}