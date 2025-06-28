using PTTKHTTTProject.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.BUS
{
    internal class ManageRenewalBUS
    {
        public static DataTable loadRenewal()
        {
            DataTable dt = ManageRenewalDAO.getRenewal();
            return dt;
        }
    }
}
