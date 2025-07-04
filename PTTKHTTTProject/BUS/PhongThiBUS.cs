using System;
using System.Data;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.BUS
{
    public class PhongThiBUS
    {
        public static DataTable GetAllPhongThi()
        {
            return PhongThiDAO.GetAllPhongThi();
        }

        // PHƯƠNG THỨC MỚI
        public static bool AddPhongThi(string hinhThuc, string slToiDa, string slToiThieu, string slNhanVien)
        {
            // Kiểm tra các giá trị đầu vào
            if (string.IsNullOrWhiteSpace(hinhThuc) ||
                !int.TryParse(slToiDa, out int slToiDaInt) ||
                !int.TryParse(slToiThieu, out int slToiThieuInt) ||
                !int.TryParse(slNhanVien, out int slNhanVienInt))
            {
                return false;
            }

            // Tự động tạo mã phòng thi mới
            string lastId = PhongThiDAO.GetLastPhongThiId();
            int newIdNumber = 1;
            if (!string.IsNullOrEmpty(lastId) && lastId.StartsWith("P") && int.TryParse(lastId.AsSpan(1), out int lastIdNumber))
            {
                newIdNumber = lastIdNumber + 1;
            }
            string newMaPhong = "P" + newIdNumber.ToString("D3"); // Định dạng P001, P002,...

            return PhongThiDAO.AddPhongThi(newMaPhong, hinhThuc, slToiDaInt, slToiThieuInt, slNhanVienInt);
        }
    }
}