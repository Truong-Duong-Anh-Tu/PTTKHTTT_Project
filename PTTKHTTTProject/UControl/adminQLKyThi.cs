using System;
using System.Data;
using System.Windows.Forms;
using PTTKHTTTProject.BUS;

namespace PTTKHTTTProject.UControl
{
    public partial class adminQLKyThi : UserControl
    {
        private DataTable originalDataTable;
        private bool isAdding = false;

        public adminQLKyThi()
        {
            InitializeComponent();
            LoadData();
            SetTextBoxesReadOnly(true);
            buttonLuu.Enabled = false;
        }

        private void LoadData()
        {
            try
            {
                originalDataTable = ExamTypeBUS.GetAllExams();
                dataGridViewDSKythi.DataSource = originalDataTable;
                SetupDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu kỳ thi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            dataGridViewDSKythi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridViewDSKythi.Columns.Contains("LePhi"))
            {
                dataGridViewDSKythi.Columns["LePhi"].DefaultCellStyle.Format = "N0";
            }

            if (dataGridViewDSKythi.Columns["KT_MaKyThi"] != null)
                dataGridViewDSKythi.Columns["KT_MaKyThi"].HeaderText = "Mã Kỳ Thi";

            if (dataGridViewDSKythi.Columns["KT_TenKyThi"] != null)
                dataGridViewDSKythi.Columns["KT_TenKyThi"].HeaderText = "Tên Kỳ Thi";

            if (dataGridViewDSKythi.Columns["LePhi"] != null)
                dataGridViewDSKythi.Columns["LePhi"].HeaderText = "Lệ Phí";
        }

        private void SetTextBoxesReadOnly(bool readOnly)
        {
            // Mã kỳ thi luôn ở chế độ chỉ đọc
            textBoxMaKyThi.ReadOnly = true;
            textBoxTenKyThi.ReadOnly = readOnly;
            numericUpDownHienThiLePhi.ReadOnly = readOnly;
        }

        private void ClearTextBoxes()
        {
            textBoxMaKyThi.Text = "";
            textBoxTenKyThi.Text = "";
            numericUpDownHienThiLePhi.Text = "";
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (originalDataTable == null) return;
            string keyword = textBoxTimKiem.Text.Trim().Replace("'", "''");
            originalDataTable.DefaultView.RowFilter = string.IsNullOrEmpty(keyword)
                ? string.Empty
                : $"[KT_MaKyThi] LIKE '%{keyword}%' OR [KT_TenKyThi] LIKE '%{keyword}%'";
        }

        private void dataGridViewDSKythi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewDSKythi.Rows[e.RowIndex];
                textBoxMaKyThi.Text = row.Cells["KT_MaKyThi"].Value.ToString();
                textBoxTenKyThi.Text = row.Cells["KT_TenKyThi"].Value.ToString();
                if (decimal.TryParse(row.Cells["LePhi"].Value?.ToString(), out decimal lePhi))
                    numericUpDownHienThiLePhi.Value = lePhi;
                else
                    numericUpDownHienThiLePhi.Value = numericUpDownHienThiLePhi.Minimum;

                SetTextBoxesReadOnly(true);
                buttonLuu.Enabled = false;
                buttonChinhSua.Enabled = true;
                buttonThemKyThi.Enabled = true;
                buttonXoa.Enabled = true;
                isAdding = false;
            }
        }

        private void buttonThemKyThi_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ClearTextBoxes();
            textBoxMaKyThi.Text = "Tự động"; // Hiển thị chữ "Tự động"
            numericUpDownHienThiLePhi.Value = numericUpDownHienThiLePhi.Minimum;
            SetTextBoxesReadOnly(false);
            buttonLuu.Enabled = true;
            buttonChinhSua.Enabled = false;
            buttonXoa.Enabled = false;
        }

        private void buttonChinhSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxMaKyThi.Text))
            {
                isAdding = false;
                SetTextBoxesReadOnly(false);
                buttonLuu.Enabled = true;
                buttonThemKyThi.Enabled = false;
                buttonXoa.Enabled = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một kỳ thi để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                if (ExamTypeBUS.AddKyThi(textBoxTenKyThi.Text, numericUpDownHienThiLePhi.Text))
                {
                    MessageBox.Show("Thêm kỳ thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm kỳ thi thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (ExamTypeBUS.UpdateKyThi(textBoxMaKyThi.Text, textBoxTenKyThi.Text, numericUpDownHienThiLePhi.Text))
                {
                    MessageBox.Show("Cập nhật kỳ thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật kỳ thi thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadData();
            ClearTextBoxes();
            SetTextBoxesReadOnly(true);
            buttonLuu.Enabled = false;
            buttonChinhSua.Enabled = true;
            buttonThemKyThi.Enabled = true;
            buttonXoa.Enabled = true;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxMaKyThi.Text))
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa kỳ thi này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (ExamTypeBUS.DeleteKyThi(textBoxMaKyThi.Text))
                    {
                        MessageBox.Show("Xóa kỳ thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Xóa kỳ thi thất bại do đã có lịch thi được tạo cho kỳ thi này.", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một kỳ thi để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void adminQLKyThi_Load(object sender, EventArgs e)
        {
            // Để trống nếu không sử dụng
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}