using PTTKHTTTProject.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PTTKHTTTProject.BUS.TiepNhan;
using PTTKHTTTProject.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PTTKHTTTProject
{
    public partial class fTiepNhan : Form
    {
        private string _username;
        private string _PDKUpdate;
        private string _MaLichThiAdd;
        public fTiepNhan(string username)
        {
            InitializeComponent();
            _username = username;
        }
        private void fTiepNhan_Load_1(object sender, EventArgs e)
        {
            string? tenNhanVien = TiepNhan.LayTenNhanVien(_username);

            if (!string.IsNullOrEmpty(tenNhanVien))
            {
                TiepNhan_TenNV.Text = $"Xin chào, {tenNhanVien}!";
            }
            else
            {
                TiepNhan_TenNV.Text = "...";
            }
        }

        private void HideAllPanels()
        {
            panelPDK.Visible = false;
            panelXLCC.Visible = false;
            panelGiaHan.Visible = false;
            panelPDKAdd.Visible = false;
            panelPDKUpdate.Visible = false;
            panelKHDonVi.Visible = false;
            panelKHTuDo.Visible = false;
            panelTSDVEdit.Visible = false;
            panelTSTDEdit.Visible = false;
            panelTSTDAdd.Visible = false;
            panelTSDVAdd.Visible = false;
        }

        private void btnQLPDK_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelPDK.Visible = true;
            panelPDK.BringToFront();
        }

        private void btnXLCC_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelXLCC.Visible = true;
            panelXLCC.BringToFront();
        }

        private void btnCapNhatGiaHan_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelGiaHan.Visible = true;
            panelGiaHan.BringToFront();
        }

        // Giao diện thêm phiếu đăng ký
        private void btnAddPDK_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelPDKAdd.Visible = true;
            panelPDKAdd.BringToFront();

            string? tenNhanVien = TiepNhan.LayTenNhanVien(_username);

            if (!string.IsNullOrEmpty(tenNhanVien))
            {
                PDKAdd_TenNV.Text = $"{tenNhanVien}";
            }
            else
            {
                PDKAdd_TenNV.Text = "...";
            }
            PDKAdd_NgayLapPhieu.Text = DateTime.Now.ToString("dd/MM/yyyy");
            PDKAdd_TenKyThi.DataSource = TiepNhan.GetDanhSachKyThi();
            PDKAdd_TenKyThi.DisplayMember = "KT_TenKyThi"; // Cột để hiển thị
            PDKAdd_TenKyThi.ValueMember = "KT_MaKyThi";

            PDKAdd_NgayThi.DataSource = null;
            PDKAdd_GioThi.DataSource = null;
            PDKAdd_NgayThi.Enabled = false;
            PDKAdd_GioThi.Enabled = false;
        }

        private void PDKAdd_TenKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PDKAdd_TenKyThi.SelectedValue != null)
            {
                string maKyThi = PDKAdd_TenKyThi.SelectedValue.ToString();
                DataTable dtNgayThi = TiepNhan.GetNgayThi(maKyThi); // SELECT DISTINCT LT_NgayThi

                PDKAdd_NgayThi.DisplayMember = "LT_NgayThi";
                PDKAdd_NgayThi.ValueMember = "LT_NgayThi";
                PDKAdd_NgayThi.DataSource = dtNgayThi;

                PDKAdd_NgayThi.Enabled = true;
                PDKAdd_GioThi.Enabled = false;
                PDKAdd_GioThi.DataSource = null;
            }
        }

        private void PDKAdd_NgayThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PDKAdd_TenKyThi.SelectedValue != null && PDKAdd_NgayThi.SelectedValue != null)
            {
                string maKyThi = PDKAdd_TenKyThi.SelectedValue.ToString();
                DateTime ngayThi = Convert.ToDateTime(PDKAdd_NgayThi.SelectedValue);

                DataTable dtGioThi = TiepNhan.GetThoiGianThi(maKyThi, ngayThi); // trả về LT_MaLichThi + ThoiGianThi

                PDKAdd_GioThi.DisplayMember = "ThoiGianThi"; // ví dụ: 08:00 - 09:30
                PDKAdd_GioThi.ValueMember = "LT_MaLichThi";  // chính là mã lịch thi cần tìm
                PDKAdd_GioThi.DataSource = dtGioThi;

                PDKAdd_GioThi.Enabled = true;
            }
        }

        private void PDKAdd_btnDonVi_CheckedChanged(object sender, EventArgs e)
        {
            panelTSTDAdd.Visible = false;
            panelTSDVAdd.Visible = true;
            panelTSDVAdd.BringToFront();
        }

        private void PDKAdd_btnTuDo_CheckedChanged(object sender, EventArgs e)
        {
            panelTSTDAdd.Visible = true;
            panelTSDVAdd.Visible = false;
            panelTSTDAdd.BringToFront();

            PDKAdd_GioiTinhTD.DataSource = new List<string> { "Nam", "Nữ" };
        }

        private void PDKAdd_XacNhan_Click(object sender, EventArgs e)
        {
            DateTime ngayLap = DateTime.Now.Date; // Lấy ngày hiện tại (bỏ thời gian)
            string diaChi = PDKAdd_DiaChi.Text.Trim();
            string maLichThi = PDKAdd_GioThi.SelectedValue.ToString();
            string maNV = _username; // lấy từ người đăng nhập

            string loaiKH = PDKAdd_btnTuDo.Checked ? "Tự do" : "Đơn vị";
            string emailKH = PDKAdd_Email.Text.Trim();
            string sdtKH = PDKAdd_SDT.Text.Trim();
            string tenKH = PDKAdd_TenKH.Text.Trim();

            // Chuẩn bị DataTable không có cột SoBaoDanh (vì đã tạo tự động ở procedure)
            DataTable danhSachThiSinh = new DataTable();
            danhSachThiSinh.Columns.Add("HoTen", typeof(string));
            danhSachThiSinh.Columns.Add("NgaySinh", typeof(DateTime));
            danhSachThiSinh.Columns.Add("GioiTinh", typeof(string));
            danhSachThiSinh.Columns.Add("Email", typeof(string));
            danhSachThiSinh.Columns.Add("SDT", typeof(string));
            danhSachThiSinh.Columns.Add("CCCD", typeof(string));

            if (loaiKH == "Tự do")
            {
                // Thêm 1 thí sinh tự do từ textbox
                danhSachThiSinh.Rows.Add(
                    PDKAdd_TenTSTD.Text.Trim(),
                    PDKAdd_DOB_TD.Value.Date,
                    PDKAdd_GioiTinhTD.Text,
                    PDKAdd_Email_TD.Text.Trim(),
                    PDKAdd_SDT_TD.Text.Trim(),
                    PDKAdd_CCCD_TD.Text.Trim()
                );
            }
            else
            {
                // Thêm các thí sinh đơn vị từ DataGridView
                foreach (DataGridViewRow row in PDKAdd_dgvTSDV.Rows)
                {
                    if (row.IsNewRow) continue;
                    danhSachThiSinh.Rows.Add(
                        row.Cells["HoTen"].Value?.ToString(),
                        Convert.ToDateTime(row.Cells["NgaySinh"].Value),
                        row.Cells["GioiTinh"].Value?.ToString(),
                        row.Cells["Email"].Value?.ToString(),
                        row.Cells["SDT"].Value?.ToString(),
                        row.Cells["CCCD"].Value?.ToString()
                    );
                }
            }

            // Gọi hàm BUS để thêm phiếu đăng ký
            try
            {
                string maPhieuMoi = TiepNhan.ThemPhieuDangKy(
                    ngayLap, diaChi, maLichThi, maNV,
                    loaiKH, emailKH, sdtKH, tenKH, danhSachThiSinh
                );

                MessageBox.Show($"Thêm phiếu đăng ký thành công!\nMã phiếu: {maPhieuMoi}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFormTiepNhan(); // ← reset lại form

                panelPDKAdd.Visible = false;
                panelPDK.Visible = true;
                panelPDK.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phiếu đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm reset panel Thêm phiếu đăng ký
        void ResetFormTiepNhan()
        {
            // Reset textbox
            PDKAdd_DiaChi.Clear();
            PDKAdd_Email.Clear();
            PDKAdd_SDT.Clear();
            PDKAdd_TenKH.Clear();
            PDKAdd_Email_TD.Clear();
            PDKAdd_SDT_TD.Clear();
            PDKAdd_TenTSTD.Clear();
            PDKAdd_CCCD_TD.Clear();

            // Reset datetime
            PDKAdd_DOB_TD.Value = DateTime.Today;

            // Reset combobox
            PDKAdd_TenKyThi.SelectedIndex = -1;
            PDKAdd_NgayThi.SelectedIndex = -1;
            PDKAdd_GioThi.DataSource = null;
            PDKAdd_GioThi.Enabled = false;

            // Reset radio
            PDKAdd_btnTuDo.Checked = false;
            PDKAdd_btnDonVi.Checked = false;

            // Reset panel visibility
            panelTSTDAdd.Visible = false;
            panelTSDVAdd.Visible = false;

            // Reset DataGridView
            if (PDKAdd_dgvTSDV.DataSource != null)
                ((DataTable)PDKAdd_dgvTSDV.DataSource).Clear();
        }


        private void PDKAdd_ThemTSDV_Click(object sender, EventArgs e)
        {
            fThemThiSinhDonVi formThem = new fThemThiSinhDonVi();

            if (formThem.ShowDialog() == DialogResult.OK && formThem.ThiSinhMoi != null)
            {
                ThiSinhDonViDTO ts = formThem.ThiSinhMoi;

                // Nếu DataGridView chưa có nguồn, tạo DataTable trước
                if (PDKAdd_dgvTSDV.DataSource == null)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("HoTen", typeof(string));
                    table.Columns.Add("NgaySinh", typeof(DateTime));
                    table.Columns.Add("GioiTinh", typeof(string));
                    table.Columns.Add("Email", typeof(string));
                    table.Columns.Add("SDT", typeof(string));
                    table.Columns.Add("CCCD", typeof(string));
                    PDKAdd_dgvTSDV.DataSource = table;
                }

                // Thêm dòng mới
                DataTable dt = (DataTable)PDKAdd_dgvTSDV.DataSource;
                dt.Rows.Add(ts.HoTen, ts.NgaySinh.Date, ts.GioiTinh, ts.Email, ts.SDT, ts.CCCD);
            }
        }

        // Giao diện chỉnh sửa phiếu đăng ký
        private void btnUpdatePDK_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelPDKUpdate.Visible = true;
            panelPDKUpdate.BringToFront();

            GioiTinh_TSTD.DataSource = new List<string> { "Nam", "Nữ" };

            DataTable dt = TiepNhan.TraCuuPhieuDangKy(_PDKUpdate);
            DataTable dt_ts = TiepNhan.TraCuuThiSinh(_PDKUpdate);

            PDKU_AD.Text = Convert.ToDateTime(dt.Rows[0]["PDKDT_ThoiGianLap"]).ToString("dd/MM/yyyy");
            PDKU_DiaChi.Text = dt.Rows[0]["PDKDT_DiaChiChuyenPhat"].ToString();
            PDKU_ED.Text = Convert.ToDateTime(dt.Rows[0]["LT_NgayThi"]).ToString("dd/MM/yyyy");
            PDKU_Email.Text = dt.Rows[0]["KH_Email"].ToString();
            PDKU_LoaiKH.Text = dt.Rows[0]["KH_LoaiKhachHang"].ToString();
            PDKU_SDT.Text = dt.Rows[0]["KH_SDT"].ToString();
            PDKU_TenKH.Text = dt.Rows[0]["TenKhachHang"].ToString();
            PDKU_TenKT.Text = dt.Rows[0]["KT_TenKyThi"].ToString();
            PDKU_TenNV.Text = dt.Rows[0]["NhanVienTaoPhieu"].ToString();

            if (PDKU_LoaiKH.Text == "Tự do")
            {
                panelTSDVEdit.Visible = false;
                panelTSTDEdit.Visible = true;
                panelTSTDEdit.BringToFront();

                PDKU_SBD_TD.Text = dt_ts.Rows[0]["TS_SoBaoDanh"].ToString();
                PDKU_SDT_TD.Text = dt_ts.Rows[0]["TS_SDT"].ToString();
                GioiTinh_TSTD.SelectedItem = dt_ts.Rows[0]["TS_GioiTinh"].ToString();
                PDKU_Email_TD.Text = dt_ts.Rows[0]["TS_Email"].ToString();
                PDKU_TenTS_TD.Text = dt_ts.Rows[0]["TS_HoTen"].ToString();
                PDKU_DOB_TD.Value = Convert.ToDateTime(dt_ts.Rows[0]["TS_NgaySinh"]);
                PDKU_CCCD_TD.Text = dt_ts.Rows[0]["TS_CCCD"].ToString();
            }
            else if (PDKU_LoaiKH.Text == "Đơn vị")
            {
                panelTSDVEdit.Visible = true;
                panelTSTDEdit.Visible = false;
                panelTSTDEdit.BringToFront();
                PDKU_dgvDV.DataSource = dt_ts;

                if (!PDKU_dgvDV.Columns.Contains("btnChiTiet"))
                {
                    DataGridViewButtonColumn btnChiTiet = new DataGridViewButtonColumn();
                    btnChiTiet.Name = "btnChiTiet";
                    btnChiTiet.HeaderText = "Chi tiết";
                    btnChiTiet.Text = "Chi tiết";
                    btnChiTiet.UseColumnTextForButtonValue = true;
                    PDKU_dgvDV.Columns.Add(btnChiTiet);
                    PDKU_dgvDV.CellClick -= dgvThiSinh_CellClick;
                    PDKU_dgvDV.CellClick += dgvThiSinh_CellClick;
                }
            }
        }

        private void dgvThiSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == PDKU_dgvDV.Columns["btnChiTiet"].Index)
            {
                // Lấy mã số báo danh của thí sinh ở dòng đang chọn
                string soBaoDanh = PDKU_dgvDV.Rows[e.RowIndex].Cells["TS_SoBaoDanh"].Value.ToString();

                // Mở form chỉnh sửa, truyền mã số báo danh sang
                fSuaThiSinhDonVi formChiTiet = new fSuaThiSinhDonVi(soBaoDanh);

                if (formChiTiet.ShowDialog() == DialogResult.OK)
                {
                    // Nếu người dùng đã lưu => reload lại danh sách
                    DataTable dt = TiepNhan.TraCuuThiSinh(_PDKUpdate);

                    PDKU_dgvDV.DataSource = dt;

                    if (!PDKU_dgvDV.Columns.Contains("btnChiTiet"))
                    {
                        DataGridViewButtonColumn btnChiTiet = new DataGridViewButtonColumn();
                        btnChiTiet.Name = "btnChiTiet";
                        btnChiTiet.HeaderText = "Chi tiết";
                        btnChiTiet.Text = "Chi tiết";
                        btnChiTiet.UseColumnTextForButtonValue = true;
                        PDKU_dgvDV.Columns.Add(btnChiTiet);
                        PDKU_dgvDV.CellClick -= dgvThiSinh_CellClick;
                        PDKU_dgvDV.CellClick += dgvThiSinh_CellClick;
                    }
                }
            }
        }

        private void btnSave_TTTD_Click(object sender, EventArgs e)
        {
            string SBD = PDKU_SBD_TD.Text.Trim();
            string hoTen = PDKU_TenTS_TD.Text.Trim();
            DateTime ngaySinh = PDKU_DOB_TD.Value.Date;
            string gioiTinh = GioiTinh_TSTD.SelectedItem.ToString();
            string email = PDKU_Email_TD.Text.Trim();
            string sdt = PDKU_SDT_TD.Text.Trim();
            string cccd = PDKU_CCCD_TD.Text.Trim();

            TiepNhan.CapNhatThiSinhTuDo(SBD, hoTen, ngaySinh, gioiTinh, email, sdt, cccd);

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSavePDK_Click(object sender, EventArgs e)
        {
            string MaPhieu = _PDKUpdate;

            string TenKH = PDKU_TenKH.Text;
            string LoaiKH = PDKU_LoaiKH.Text;
            string SDT = PDKU_SDT.Text;
            string Email = PDKU_Email.Text;
            string DiaChi = PDKU_DiaChi.Text;

            TiepNhan.CapNhatPhieuDangKy(MaPhieu, TenKH, LoaiKH, SDT, Email, DiaChi);

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelPDK_Click(object sender, EventArgs e)
        {
            string MaPhieu = _PDKUpdate;

            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ thông tin liên quan đến phiếu này?",
                                          "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                bool success = TiepNhan.XoaPhieuDangKy(MaPhieu);
                if (success)
                {
                    MessageBox.Show("Đã xóa thành công!");
                    HideAllPanels();
                    panelPDK.Visible = true;
                    panelPDK.BringToFront();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu hoặc lỗi khi xóa.");
                }
            }
        }

        // Giao diện xem phiếu đăng ký
        private void PDKView_Search_Click(object sender, EventArgs e)
        {
            string MaPhieu = PDKView_SearchBox.Text.Trim();
            _PDKUpdate = MaPhieu;

            if (string.IsNullOrWhiteSpace(MaPhieu))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu.");
                return;
            }

            try
            {
                DataTable dt = TiepNhan.TraCuuPhieuDangKy(MaPhieu);
                DataTable dt_ts = TiepNhan.TraCuuThiSinh(MaPhieu);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin.");
                    PDKView_AD.Text = "";
                    PDKView_DiaChi.Text = "";
                    PDKView_ED.Text = "";
                    PDKView_EmailKH.Text = "";
                    PDKView_LoaiKH.Text = "";
                    PDKView_KH.Text = "";
                    PDKView_KyThi.Text = "";
                    PDKView_NV.Text = "";
                    PDKView_SDTKH.Text = "";
                    PDKView_TTTT.Text = "";
                    return;
                }

                PDKView_AD.Text = Convert.ToDateTime(dt.Rows[0]["PDKDT_ThoiGianLap"]).ToString("dd/MM/yyyy");
                PDKView_DiaChi.Text = dt.Rows[0]["PDKDT_DiaChiChuyenPhat"].ToString();
                PDKView_ED.Text = Convert.ToDateTime(dt.Rows[0]["LT_NgayThi"]).ToString("dd/MM/yyyy");
                PDKView_EmailKH.Text = dt.Rows[0]["KH_Email"].ToString();
                PDKView_KH.Text = dt.Rows[0]["TenKhachHang"].ToString();
                PDKView_KyThi.Text = dt.Rows[0]["KT_TenKyThi"].ToString();
                PDKView_NV.Text = dt.Rows[0]["NhanVienTaoPhieu"].ToString();
                PDKView_SDTKH.Text = dt.Rows[0]["KH_SDT"].ToString();
                PDKView_TTTT.Text = dt.Rows[0]["PDKDT_TrangThaiThanhToan"].ToString();
                PDKView_LoaiKH.Text = dt.Rows[0]["KH_LoaiKhachHang"].ToString();
                label8.BringToFront();

                if (PDKView_LoaiKH.Text == "Tự do")
                {
                    panelKHDonVi.Visible = false;
                    panelKHTuDo.Visible = true;
                    panelKHTuDo.BringToFront();
                    PDKView_SDBTD.Text = dt_ts.Rows[0]["TS_SoBaoDanh"].ToString();
                    PDKView_SDTTD.Text = dt_ts.Rows[0]["TS_SDT"].ToString();
                    PDKView_GioiTinhTD.Text = dt_ts.Rows[0]["TS_GioiTinh"].ToString();
                    PDKView_EmailTD.Text = dt_ts.Rows[0]["TS_Email"].ToString();
                    PDKView_NameTD.Text = dt_ts.Rows[0]["TS_HoTen"].ToString();
                    PDKView_DOBTD.Text = Convert.ToDateTime(dt_ts.Rows[0]["TS_NgaySinh"]).ToString("dd/MM/yyyy");
                    PDKView_CCCDTD.Text = dt_ts.Rows[0]["TS_CCCD"].ToString();
                }
                else if (PDKView_LoaiKH.Text == "Đơn vị")
                {
                    panelKHDonVi.Visible = true;
                    panelKHTuDo.Visible = false;
                    panelKHDonVi.BringToFront();
                    PDKView_dgvDV.DataSource = dt_ts;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void PDKView_btnSearchDV_Click(object sender, EventArgs e)
        {
            string tuKhoa = PDKView_SearchBoxDV.Text.Trim();
            string maPhieu = PDKView_SearchBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập họ và tên thí sinh.");
                return;
            }

            try
            {
                DataTable dt = TiepNhan.TimThiSinh(tuKhoa, maPhieu);
                PDKView_dgvDV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void PDKU_btnSearchDV_Click(object sender, EventArgs e)
        {
            string tuKhoa = PDKU_SearchBoxDV.Text.Trim();
            string maPhieu = _PDKUpdate;
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập họ và tên thí sinh.");
                return;
            }

            try
            {
                DataTable dt = TiepNhan.TimThiSinh(tuKhoa, maPhieu);
                PDKU_dgvDV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

       
    }
}
