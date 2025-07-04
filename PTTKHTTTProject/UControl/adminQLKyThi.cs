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
        }

        private void SetTextBoxesReadOnly(bool readOnly)
        {
            // Mã kỳ thi luôn ở chế độ chỉ đọc, không thay đổi
            textBoxMaKyThi.ReadOnly = true;

            // Cập nhật trạng thái ReadOnly cho các ô khác
            textBoxTenKyThi.ReadOnly = readOnly;
            textBoxLePhi.ReadOnly = readOnly;

            // Thay đổi màu nền dựa trên trạng thái ReadOnly
            // Nếu không phải chỉ đọc (tức là có thể sửa), nền sẽ là màu trắng.
            // Nếu là chỉ đọc, nền sẽ là màu của control mặc định (thường là xám).
            textBoxTenKyThi.BackColor = readOnly ? SystemColors.Control : SystemColors.Window;
            textBoxLePhi.BackColor = readOnly ? SystemColors.Control : SystemColors.Window;
        }

        private void ClearTextBoxes()
        {
            textBoxMaKyThi.Text = "";
            textBoxTenKyThi.Text = "";
            textBoxLePhi.Text = "";
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
                textBoxLePhi.Text = row.Cells["LePhi"].Value.ToString();

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
                if (KyThiBUS.AddKyThi(textBoxTenKyThi.Text, textBoxLePhi.Text))
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
                if (KyThiBUS.UpdateKyThi(textBoxMaKyThi.Text, textBoxTenKyThi.Text, textBoxLePhi.Text))
                {
                    MessageBox.Show("Cập nhật kỳ thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật kỳ thi thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadData();
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
                    if (KyThiBUS.DeleteKyThi(textBoxMaKyThi.Text))
                    {
                        MessageBox.Show("Xóa kỳ thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Xóa kỳ thi thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một kỳ thi để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}