using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PTTKHTTTProject.DAO
{
    public class KyThiDAO
    {
        public static bool UpdateKyThi(string maKyThi, string tenKyThi, decimal lePhi)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaKyThi", maKyThi),
                    new SqlParameter("@TenKyThi", tenKyThi),
                    new SqlParameter("@LePhi", lePhi)
                };
                DataProvider.Instance.ExecuteNonQuerySP("usp_UpdateKyThi", parameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool AddKyThi(string maKyThi, string tenKyThi, decimal lePhi)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaKyThi", maKyThi),
                    new SqlParameter("@TenKyThi", tenKyThi),
                    new SqlParameter("@LePhi", lePhi)
                };
                DataProvider.Instance.ExecuteNonQuerySP("usp_AddKyThi", parameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool DeleteKyThi(string maKyThi)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaKyThi", maKyThi)
                };
                DataProvider.Instance.ExecuteNonQuerySP("usp_DeleteKyThi", parameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string GetLastKyThiId()
        {
            try
            {
                return DataProvider.Instance.ExecuteScalarSP<string>("usp_GetLastKyThiId");
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}