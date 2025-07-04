using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.BUS
{
    internal class DepartmentBUS
    {
        private string _departmentCode;
        private string _departmentName;
        public DepartmentBUS(string departmentCode)
        {
            _departmentCode = departmentCode;
            _departmentName = DepartmentDAO.getDepartmentName(_departmentCode);
        }


    }
}
