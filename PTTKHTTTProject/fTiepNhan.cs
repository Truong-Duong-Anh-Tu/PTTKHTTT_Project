using Microsoft.Data.SqlClient;
using PTTKHTTTProject.BUS;
using PTTKHTTTProject.DTO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace PTTKHTTTProject
{
    public partial class fTiepNhan : Form
    {
        private string _username;
        private string _PDKUpdate;
        private List<Button> Sidebar_Buttons;
        public fTiepNhan(string username)
        {
            InitializeComponent();
            _username = username;

        }
        private void fTiepNhan_Load_1(object sender, EventArgs e)
        {
            LoadInfo();

            Sidebar_Buttons = new List<Button> { btnQLPDK, btnTTCN, btnThongBao, btnXLCC, btnCapNhatGiaHan };

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

        private void HighlightSelectedButton(Button selectedBtn)
        {
            Color activeColor = Color.LightBlue;   // Màu khi được chọn
            Color normalColor = Color.WhiteSmoke;       // Màu bình thường

            foreach (Button btn in Sidebar_Buttons)
            {
                btn.BackColor = (btn == selectedBtn) ? activeColor : normalColor;
                btn.ForeColor = (btn == selectedBtn) ? Color.Black : Color.Black; // tùy chỉnh thêm nếu cần
            }
        }


        private void LoadInfo()
        {
            HideAllPanels();
            panelInfo.Visible = true;
            panelInfo.BringToFront();

            // Tạo user control
            ucInfo uc = new ucInfo(_username);
            uc.Dock = DockStyle.Fill;

            panelInfo.Controls.Clear();
            panelInfo.Controls.Add(uc);
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
            panelNotifi.Visible = false;
            panelInfo.Visible = false;
        }

        // Giao diện cập nhật chứng chỉ
        private void btnXLCC_Click(object sender, EventArgs e)
        {
            HighlightSelectedButton(btnXLCC);
            HideAllPanels();
            panelXLCC.Visible = true;
            panelXLCC.BringToFront();

            CC_cbKyThi.DataSource = TiepNhan.GetDanhSachKyThi();
            CC_cbKyThi.DisplayMember = "KT_TenKyThi";
            CC_cbKyThi.ValueMember = "KT_MaKyThi";

            CC_btnDonVi.Checked = false;
            CC_btnTuDo.Checked = false;
        }

        private void LoadChungChi()
        {
            string maKyThi = CC_cbKyThi.SelectedValue?.ToString();
            string tuKhoa = CC_SearchBox.Text.Trim();
            string loaiKH = null;

            if (CC_btnTuDo.Checked) loaiKH = "Tự do";
            else if (CC_btnDonVi.Checked) loaiKH = "Đơn vị";

            var dt = TiepNhan.TimChungChi(maKyThi, tuKhoa, loaiKH);
            CC_dgv.AllowUserToAddRows = false;
            CC_dgv.DataSource = dt;

            // Nếu chưa thêm cột checkbox thì thêm vào
            if (!CC_dgv.Columns.Contains("Check"))
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.Name = "Check";
                chk.HeaderText = "Chọn";
                CC_dgv.Columns.Insert(0, chk);
            }
        }

        private void CC_btnSearch_Click(object sender, EventArgs e)
        {
            LoadChungChi();
        }

        private void CC_XacNhan_Click(object sender, EventArgs e)
        {
            List<string> danhSachDuocChon = new List<string>();

            foreach (DataGridViewRow row in CC_dgv.Rows)
            {
                // Kiểm tra ô checkbox được chọn
                bool isChecked = Convert.ToBoolean(row.Cells["Check"].Value ?? false);

                if (isChecked)
                {
                    string maBaiThi = row.Cells["colMaBaiThi"].Value?.ToString()?.Trim();
                    if (!string.IsNullOrEmpty(maBaiThi))
                        danhSachDuocChon.Add(maBaiThi);
                }
            }

            if (danhSachDuocChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 chứng chỉ để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                TiepNhan.CapNhatDanhSachTrangThaiDaNhan(danhSachDuocChon);
                MessageBox.Show("Cập nhật trạng thái thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChungChi(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Giao diện xử lý gia hạn
        private void btnCapNhatGiaHan_Click(object sender, EventArgs e)
        {
            HighlightSelectedButton(btnCapNhatGiaHan);
            HideAllPanels();
            panelGiaHan.Visible = true;
            panelGiaHan.BringToFront();

            GiaHan_ChonKyThi.DataSource = TiepNhan.GetDanhSachKyThi();
            GiaHan_ChonKyThi.DisplayMember = "KT_TenKyThi"; // Cột để hiển thị
            GiaHan_ChonKyThi.ValueMember = "KT_MaKyThi";
        }

        private void GiaHan_ChonKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GiaHan_ChonKyThi.SelectedValue != null)
            {
                string maKyThi = GiaHan_ChonKyThi.SelectedValue.ToString();
                DataTable dtNgayThi = TiepNhan.GetNgayThi(maKyThi); // SELECT DISTINCT LT_NgayThi

                GiaHan_ChonNgayThi.DisplayMember = "LT_NgayThi";
                GiaHan_ChonNgayThi.ValueMember = "LT_NgayThi";
                GiaHan_ChonNgayThi.DataSource = dtNgayThi;

                GiaHan_ChonNgayThi.Enabled = true;
                GiaHan_ChonGioThi.Enabled = false;
                GiaHan_ChonGioThi.DataSource = null;
            }
        }

        private void GiaHan_ChonNgayThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GiaHan_ChonKyThi.SelectedValue != null && GiaHan_ChonNgayThi.SelectedValue != null)
            {
                string maKyThi = GiaHan_ChonKyThi.SelectedValue.ToString();
                DateTime ngayThi = Convert.ToDateTime(GiaHan_ChonNgayThi.SelectedValue);

                DataTable dtGioThi = TiepNhan.GetThoiGianThi(maKyThi, ngayThi); // trả về LT_MaLichThi + ThoiGianThi

                GiaHan_ChonGioThi.DisplayMember = "ThoiGianThi"; // ví dụ: 08:00 - 09:30
                GiaHan_ChonGioThi.ValueMember = "LT_MaLichThi";  // chính là mã lịch thi cần tìm
                GiaHan_ChonGioThi.DataSource = dtGioThi;

                GiaHan_ChonGioThi.Enabled = true;
            }
        }

        private void LoadThongTinPhieuDangKyGiaHan(string maPhieu)
        {
            try
            {
                DataTable dt = TiepNhan.LayThongTinPhieu(maPhieu);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    GiaHan_MaHK.Text = row["KH_MaKhachHang"].ToString();
                    GiaHan_TenKH.Text = row["TenKhachHang"].ToString();
                    GiaHan_LoaiKH.Text = row["KH_LoaiKhachHang"].ToString();
                    GiaHan_SDT.Text = row["KH_SDT"].ToString();
                    GiaHan_Email.Text = row["KH_Email"].ToString();

                    GiaHan_MaPhieu.Text = row["PDKDT_MaPhieu"].ToString();
                    GiaHan__NgayLapPhieu.Text = Convert.ToDateTime(row["PDKDT_ThoiGianLap"]).ToString("dd/MM/yyyy");
                    GiaHan_SLThiSinh.Text = row["SoLuongThiSinh"].ToString();
                    GiaHan_TenNV.Text = row["NhanVienLap"].ToString();
                    GiaHan_DiaChi.Text = row["PDKDT_DiaChiChuyenPhat"].ToString();
                    GiaHan_TrangThaiTT.Text = row["PDKDT_TrangThaiThanhToan"].ToString();

                    GiaHan_TenKT.Text = row["LT_TenKyThi"].ToString();
                    GiaHan_NgayThi.Text = Convert.ToDateTime(row["LT_NgayThi"]).ToString("dd/MM/yyyy");
                    GiaHan_GioThi.Text = row["GioThi"].ToString();
                    GiaHan_SoTS_LichThi.Text = row["SoLuongDangKyLichThi"].ToString();
                    GiaHan_MaPThi.Text = row["LT_MaPhongThi"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tra cứu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GiaHan_btnPDKSearch_Click(object sender, EventArgs e)
        {
            string maPhieu = GiaHan_MaPhieuSearch.Text.Trim();

            LoadThongTinPhieuDangKyGiaHan(maPhieu);
        }

        private void GiaHan_btnGiaHan_Click(object sender, EventArgs e)
        {
            string maPhieu = GiaHan_MaPhieuSearch.Text.Trim();
            string maLichThiMoi = GiaHan_ChonGioThi.SelectedValue.ToString();

            try
            {
                TiepNhan.GiaHanPhieuDangKy(maPhieu, maLichThiMoi);

                MessageBox.Show("Gia hạn phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Gọi lại hàm load thông tin
                LoadThongTinPhieuDangKyGiaHan(maPhieu);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi từ SQL Server:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Chọn tính năng quản lý phiếu đăng ký
        private void btnQLPDK_Click(object sender, EventArgs e)
        {
            HighlightSelectedButton(btnQLPDK);
            HideAllPanels();
            panelPDK.Visible = true;
            panelPDK.BringToFront();
        }

        // Hàm thêm thí sinh đơn vị vào thông tin tạo phiếu
        private DataTable TaoDanhSachThiSinhTuInput(bool laTuDo)
        {
            DataTable danhSach = new DataTable();
            danhSach.Columns.Add("HoTen", typeof(string));
            danhSach.Columns.Add("NgaySinh", typeof(DateTime));
            danhSach.Columns.Add("GioiTinh", typeof(string));
            danhSach.Columns.Add("Email", typeof(string));
            danhSach.Columns.Add("SDT", typeof(string));
            danhSach.Columns.Add("CCCD", typeof(string));

            if (laTuDo)
            {
                danhSach.Rows.Add(
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
                foreach (DataGridViewRow row in PDKAdd_dgvTSDV.Rows)
                {
                    if (row.IsNewRow) continue;

                    danhSach.Rows.Add(
                        row.Cells["HoTen"].Value?.ToString()?.Trim(),
                        Convert.ToDateTime(row.Cells["NgaySinh"].Value),
                        row.Cells["GioiTinh"].Value?.ToString()?.Trim(),
                        row.Cells["Email"].Value?.ToString()?.Trim(),
                        row.Cells["SDT"].Value?.ToString()?.Trim(),
                        row.Cells["CCCD"].Value?.ToString()?.Trim()
                    );
                }
            }

            return danhSach;
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
            string loaiKH = PDKAdd_btnTuDo.Checked ? "Tự do" : "Đơn vị";

            try
            {
                string maPhieuMoi = TiepNhan.ThemPhieuDangKy(
                    DateTime.Now.Date,
                    PDKAdd_DiaChi.Text.Trim(),
                    PDKAdd_GioThi.SelectedValue.ToString(),
                    _username,
                    loaiKH,
                    PDKAdd_Email.Text.Trim(),
                    PDKAdd_SDT.Text.Trim(),
                    PDKAdd_TenKH.Text.Trim(),
                    TaoDanhSachThiSinhTuInput(loaiKH == "Tự do")
                );

                MessageBox.Show($"Thêm phiếu đăng ký thành công!\nMã phiếu: {maPhieuMoi}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetPDKAdd();

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
        void ResetPDKAdd()
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

        // Hàm hiển thị thông tin cơ bản cho giao diện chỉnh sửa phiếu đăng ký
        private void HienThiThongTinPhieuDKU(DataRow dr)
        {
            PDKU_AD.Text = Convert.ToDateTime(dr["PDKDT_ThoiGianLap"]).ToString("dd/MM/yyyy");
            PDKU_DiaChi.Text = dr["PDKDT_DiaChiChuyenPhat"].ToString();
            PDKU_ED.Text = Convert.ToDateTime(dr["LT_NgayThi"]).ToString("dd/MM/yyyy");
            PDKU_Email.Text = dr["KH_Email"].ToString();
            PDKU_LoaiKH.Text = dr["KH_LoaiKhachHang"].ToString();
            PDKU_SDT.Text = dr["KH_SDT"].ToString();
            PDKU_TenKH.Text = dr["TenKhachHang"].ToString();
            PDKU_TenKT.Text = dr["KT_TenKyThi"].ToString();
            PDKU_TenNV.Text = dr["NhanVienTaoPhieu"].ToString();
        }

        // Hiển thị thí sinh tự do cho giao diện chỉnh sửa phiếu đăng ký
        private void HienThiThiSinhTuDoPDKU(DataRow ts)
        {
            panelTSDVEdit.Visible = false;
            panelTSTDEdit.Visible = true;
            panelTSTDEdit.BringToFront();

            PDKU_SBD_TD.Text = ts["TS_SoBaoDanh"].ToString();
            PDKU_SDT_TD.Text = ts["TS_SDT"].ToString();
            GioiTinh_TSTD.SelectedItem = ts["TS_GioiTinh"].ToString();
            PDKU_Email_TD.Text = ts["TS_Email"].ToString();
            PDKU_TenTS_TD.Text = ts["TS_HoTen"].ToString();
            PDKU_DOB_TD.Value = Convert.ToDateTime(ts["TS_NgaySinh"]);
            PDKU_CCCD_TD.Text = ts["TS_CCCD"].ToString();
        }

        // Hiển thị thí sinh đơn vị cho giao diện chỉnh sửa phiếu đăng ký
        private void HienThiThiSinhDonViPDKU(DataTable dtThiSinh)
        {
            panelTSDVEdit.Visible = true;
            panelTSTDEdit.Visible = false;
            panelTSTDEdit.BringToFront();

            PDKU_dgvDV.DataSource = dtThiSinh;
            ThemNutChiTietVaoDGVPDKU();
        }

        private void ThemNutChiTietVaoDGVPDKU()
        {
            if (!PDKU_dgvDV.Columns.Contains("btnChiTiet"))
            {
                var btn = new DataGridViewButtonColumn
                {
                    Name = "btnChiTiet",
                    HeaderText = "Chi tiết",
                    Text = "Chi tiết",
                    UseColumnTextForButtonValue = true
                };

                PDKU_dgvDV.Columns.Add(btn);
                PDKU_dgvDV.CellClick -= dgvThiSinh_CellClick;
                PDKU_dgvDV.CellClick += dgvThiSinh_CellClick;
            }
        }

        // Giao diện chỉnh sửa phiếu đăng ký
        private void btnUpdatePDK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_PDKUpdate))
            {
                MessageBox.Show("Phải chọn mã phiếu để chỉnh sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dt = TiepNhan.TraCuuPhieuDangKy(_PDKUpdate);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phiếu đăng ký.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HideAllPanels();
            panelPDKUpdate.Visible = true;
            panelPDKUpdate.BringToFront();

            GioiTinh_TSTD.DataSource = new List<string> { "Nam", "Nữ" };

            var dt_ts = TiepNhan.TraCuuThiSinh(_PDKUpdate);

            // Hiển thị thông tin phiếu
            HienThiThongTinPhieuDKU(dt.Rows[0]);

            string loaiKH = dt.Rows[0]["KH_LoaiKhachHang"].ToString();

            // Hiển thị thí sinh theo loại khách hàng
            if (loaiKH == "Tự do")
            {
                if (dt_ts.Rows.Count > 0)
                    HienThiThiSinhTuDoPDKU(dt_ts.Rows[0]);
                else
                    MessageBox.Show("Không tìm thấy thí sinh tự do cho phiếu này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dt_ts.Rows.Count > 0)
                    HienThiThiSinhDonViPDKU(dt_ts);
                else
                    MessageBox.Show("Không có thí sinh nào thuộc đơn vị cho phiếu này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvThiSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == PDKU_dgvDV.Columns["btnChiTiet"].Index)
            {
                string soBaoDanh = PDKU_dgvDV.Rows[e.RowIndex].Cells["TS_SoBaoDanh"].Value.ToString();
                fSuaThiSinhDonVi form = new fSuaThiSinhDonVi(soBaoDanh);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    var dt = TiepNhan.TraCuuThiSinh(_PDKUpdate);
                    HienThiThiSinhDonViPDKU(dt);
                }
            }
        }

        private void btnSave_TTTD_Click(object sender, EventArgs e)
        {
            TiepNhan.CapNhatThiSinhTuDo(
                PDKU_SBD_TD.Text.Trim(),
                PDKU_TenTS_TD.Text.Trim(),
                PDKU_DOB_TD.Value.Date,
                GioiTinh_TSTD.SelectedItem.ToString(),
                PDKU_Email_TD.Text.Trim(),
                PDKU_SDT_TD.Text.Trim(),
                PDKU_CCCD_TD.Text.Trim()
            );

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnSavePDK_Click(object sender, EventArgs e)
        {
            TiepNhan.CapNhatPhieuDangKy(
                _PDKUpdate,
                PDKU_TenKH.Text,
                PDKU_LoaiKH.Text,
                PDKU_SDT.Text,
                PDKU_Email.Text,
                PDKU_DiaChi.Text
            );

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelPDK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ thông tin liên quan đến phiếu này?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (TiepNhan.XoaPhieuDangKy(_PDKUpdate))
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

        // Hàm hiển thị thông tin cơ bản giao diện xem phiếu đăng ký
        private void HienThiThongTinPhieuDKView(DataRow row)
        {
            PDKView_AD.Text = Convert.ToDateTime(row["PDKDT_ThoiGianLap"]).ToString("dd/MM/yyyy");
            PDKView_DiaChi.Text = row["PDKDT_DiaChiChuyenPhat"].ToString();
            PDKView_ED.Text = Convert.ToDateTime(row["LT_NgayThi"]).ToString("dd/MM/yyyy");
            PDKView_EmailKH.Text = row["KH_Email"].ToString();
            PDKView_KH.Text = row["TenKhachHang"].ToString();
            PDKView_KyThi.Text = row["KT_TenKyThi"].ToString();
            PDKView_NV.Text = row["NhanVienTaoPhieu"].ToString();
            PDKView_SDTKH.Text = row["KH_SDT"].ToString();
            PDKView_TTTT.Text = row["PDKDT_TrangThaiThanhToan"].ToString();
            PDKView_LoaiKH.Text = row["KH_LoaiKhachHang"].ToString();
        }

        // Hiển thị thí sinh tự do cho giao diện xem phiếu đăng ký
        private void HienThiThiSinhTuDoPDKView(DataRow ts)
        {
            panelKHDonVi.Visible = false;
            panelKHTuDo.Visible = true;
            panelKHTuDo.BringToFront();

            PDKView_SDBTD.Text = ts["TS_SoBaoDanh"].ToString();
            PDKView_SDTTD.Text = ts["TS_SDT"].ToString();
            PDKView_GioiTinhTD.Text = ts["TS_GioiTinh"].ToString();
            PDKView_EmailTD.Text = ts["TS_Email"].ToString();
            PDKView_NameTD.Text = ts["TS_HoTen"].ToString();
            PDKView_DOBTD.Text = Convert.ToDateTime(ts["TS_NgaySinh"]).ToString("dd/MM/yyyy");
            PDKView_CCCDTD.Text = ts["TS_CCCD"].ToString();
        }

        // Hiển thị thí sinh đơn vị cho giao diện xem phiếu đăng ký
        private void HienThiThiSinhDonViPDKView(DataTable dtThiSinh)
        {
            panelKHTuDo.Visible = false;
            panelKHDonVi.Visible = true;
            panelKHDonVi.BringToFront();

            PDKView_dgvDV.DataSource = dtThiSinh;
        }

        // Reset giao diện xem phiếu dăng ký
        private void ResetThongTinPhieuDKView()
        {
            PDKView_AD.Text = "...";
            PDKView_DiaChi.Text = "...";
            PDKView_ED.Text = "...";
            PDKView_EmailKH.Text = "...";
            PDKView_LoaiKH.Text = "...";
            PDKView_KH.Text = "...";
            PDKView_KyThi.Text = "...";
            PDKView_NV.Text = "...";
            PDKView_SDTKH.Text = "...";
            PDKView_TTTT.Text = "...";
        }

        // Giao diện xem phiếu đăng ký
        private void PDKView_Search_Click(object sender, EventArgs e)
        {
            string maPhieu = PDKView_SearchBox.Text.Trim();
            _PDKUpdate = maPhieu;

            if (string.IsNullOrWhiteSpace(maPhieu))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu.");
                return;
            }

            try
            {
                DataTable dt = TiepNhan.TraCuuPhieuDangKy(maPhieu);
                DataTable dt_ts = TiepNhan.TraCuuThiSinh(maPhieu);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin.");
                    ResetThongTinPhieuDKView();
                    return;
                }

                DataRow row = dt.Rows[0];
                HienThiThongTinPhieuDKView(row);
                label8.BringToFront();

                if (row["KH_LoaiKhachHang"].ToString() == "Tự do")
                    HienThiThiSinhTuDoPDKView(dt_ts.Rows[0]);
                else
                    HienThiThiSinhDonViPDKView(dt_ts);
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

        // Hàm quay lại giao diện xem phiếu
        private void PDKView_Return_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelPDK.Visible = true;
            panelPDK.BringToFront();
            ResetThongTinPhieuDKView();
            _PDKUpdate = "";
        }

        private void btnTTCN_Click(object sender, EventArgs e)
        {
            HighlightSelectedButton(btnTTCN);
            LoadInfo();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            HighlightSelectedButton(btnThongBao);
            HideAllPanels();
            panelNotifi.Visible = true;
            panelNotifi.BringToFront();

            ucNotification noti = new ucNotification(_username);
            noti.Dock = DockStyle.Fill;

            panelNotifi.Controls.Clear();
            panelNotifi.Controls.Add(noti);
        }

        private void btn_signOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Cancel Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }


    }
}
