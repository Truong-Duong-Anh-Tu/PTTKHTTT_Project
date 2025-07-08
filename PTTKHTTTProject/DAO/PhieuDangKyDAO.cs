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
        public static DataTable LayDSPhieuDangKy2Tuan()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuerySP("usp_LayPhieuDangKyThiTrong2TuanSau");
            return dt;
        }
        public static DataTable LayDSPhieuDangKyConLai()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuerySP("usp_LayPhieuDangKyThiConLai");
            return dt;
        }
    }
}
