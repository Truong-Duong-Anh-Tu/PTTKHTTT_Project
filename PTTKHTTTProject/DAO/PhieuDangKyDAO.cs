using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.DAO
{
    internal class PhieuDangKyDAO
    {
        public static DataTable LayDSPhieuDangKy3Tuan()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuerySP("usp_LayPhieuDangKyThiTrong3TuanSau");
            return dt;
        }
    }
}
