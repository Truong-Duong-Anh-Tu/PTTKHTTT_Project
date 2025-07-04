using System.Data;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.BUS
{
    public class KyThiBUS
    {
        public static bool UpdateKyThi(string maKyThi, string tenKyThi, string lePhi)
        {
            if (string.IsNullOrWhiteSpace(maKyThi) || string.IsNullOrWhiteSpace(tenKyThi) || string.IsNullOrWhiteSpace(lePhi))
            {
                return false;
            }
            if (decimal.TryParse(lePhi, out decimal lePhiDecimal))
            {
                return KyThiDAO.UpdateKyThi(maKyThi, tenKyThi, lePhiDecimal);
            }
            return false;
        }

        public static bool AddKyThi(string tenKyThi, string lePhi)
        {
            if (string.IsNullOrWhiteSpace(tenKyThi) || string.IsNullOrWhiteSpace(lePhi))
            {
                return false;
            }

            string lastId = KyThiDAO.GetLastKyThiId();
            int newIdNumber = 1;
            if (!string.IsNullOrEmpty(lastId) && lastId.StartsWith("KT") && int.TryParse(lastId.AsSpan(2), out int lastIdNumber))
            {
                newIdNumber = lastIdNumber + 1;
            }
            string newMaKyThi = "KT" + newIdNumber.ToString("D2");

            if (decimal.TryParse(lePhi, out decimal lePhiDecimal))
            {
                return KyThiDAO.AddKyThi(newMaKyThi, tenKyThi, lePhiDecimal);
            }
            return false;
        }

        public static bool DeleteKyThi(string maKyThi)
        {
            if (string.IsNullOrWhiteSpace(maKyThi))
            {
                return false;
            }
            return KyThiDAO.DeleteKyThi(maKyThi);
        }
    }
}