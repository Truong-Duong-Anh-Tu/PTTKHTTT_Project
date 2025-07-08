using PTTKHTTTProject.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTKHTTTProject.BUS
{
    internal class EmployeeScheduleBUS
    {
        /// <summary>
        /// Lấy và trả về DataTable chứa lịch phân công đã được định dạng bởi Stored Procedure.
        /// </summary>
        /// <returns>DataTable chứa lịch phân công.</returns>
        public DataTable loadEmployeeSchedule()
        {
            return EmployeeScheduleDAO.getEmployeeSchedule();
        }

        /// <summary>
        /// Cập nhật nhân viên coi thi cho một lịch thi cụ thể.
        /// </summary>
        /// <param name="maLichThi">Mã của lịch thi cần cập nhật.</param>
        /// <param name="maNVCU">Mã của nhân viên cũ.</param>
        /// <param name="maNVMoi">Mã của nhân viên mới.</param>
        /// <returns>True nếu cập nhật thành công, False nếu thất bại.</returns>
        public bool UpdateEmployeeSchedule(string maLichThi, string maNVCU, string maNVMoi)
        {
            // (Tùy chọn) Thêm logic kiểm tra nghiệp vụ ở đây
            return EmployeeScheduleDAO.UpdateEmployeeSchedule(maLichThi, maNVCU, maNVMoi);
        }

        public bool DeleteEmployeeSchedule(string maLichThi, string maNhanVien)
        {
            return EmployeeScheduleDAO.DeleteEmployeeSchedule(maLichThi, maNhanVien);
        }
        public bool AddPhanCong(string maLichThi, string maNhanVien)
        {
            try
            {
                EmployeeScheduleDAO.AddPhanCong(maLichThi, maNhanVien);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void UpdateAllExamStatus()
        {
            EmployeeScheduleDAO.UpdateAllExamStatus();
        }
        public bool KiemTraNhanVienDaDuocPhanCong(string maLichThi, string maNhanVien)
        {
            DataTable dtPhanCong = EmployeeScheduleDAO.getEmployeeSchedule();
            bool daTonTai = dtPhanCong.AsEnumerable()
                                      .Any(row => row.Field<string>("LT_MaLichThi") == maLichThi &&
                                                   row.Field<string>("Mã Nhân Viên") == maNhanVien);

            return daTonTai;
        }

        public bool IsPhanCongLimitReached(string maLichThi)
        {
            if (string.IsNullOrEmpty(maLichThi))
            {
                return true; // Coi như đã đầy nếu không có mã lịch thi
            }
            return EmployeeScheduleDAO.IsPhanCongLimitReached(maLichThi);
        }
    }
}
