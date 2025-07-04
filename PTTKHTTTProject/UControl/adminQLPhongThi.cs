using System;
using System.Data;
using System.Windows.Forms;
using PTTKHTTTProject.BUS;

namespace PTTKHTTTProject.UControl
{
    public partial class adminQLPhongThi : UserControl
    {
        private bool isAdding = false;

        public adminQLPhongThi()
        {
            InitializeComponent();
            PopulateHinhThucThiComboBox();
            LoadPhongThiData();
            SetUIState(false);
        }

        private void PopulateHinhThucThiComboBox()
        {
            comboBoxHinhThuc.Items.Clear();
            comboBoxHinhThuc.Items.Add("Tự luận");
            comboBoxHinhThuc.Items.Add("Trắc nghiệm");
            comboBoxHinhThuc.Items.Add("Trắc nghiệm-Tự luận");
            comboBoxHinhThuc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadPhongThiData()
        {
            try
            {
                dataGridView1.DataSource = PhongThiBUS.GetAllPhongThi();
                SetupDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu phòng thi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            // Tự động điều chỉnh độ rộng các cột
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Đặt lại tên cho các cột để hiển thị
            if (dataGridView1.Columns["PT_MaPhongThi"] != null)
                dataGridView1.Columns["PT_MaPhongThi"].HeaderText = "Mã Phòng";

            if (dataGridView1.Columns["PT_HinhThuc"] != null)
                dataGridView1.Columns["PT_HinhThuc"].HeaderText = "Hình Thức";

            if (dataGridView1.Columns["PT_SLThiSinhToiDa"] != null)
                dataGridView1.Columns["PT_SLThiSinhToiDa"].HeaderText = "SL Tối Đa";

            if (dataGridView1.Columns["PT_SLThiSinhToiThieu"] != null)
                dataGridView1.Columns["PT_SLThiSinhToiThieu"].HeaderText = "SL Tối Thiểu";

            if (dataGridView1.Columns["PT_SLNhanVienCoiThi"] != null)
                dataGridView1.Columns["PT_SLNhanVienCoiThi"].HeaderText = "SL Nhân Viên";
        }

        private void SetUIState(bool isEditingOrAdding)
        {
            SetTextBoxesReadOnly(!isEditingOrAdding);
            buttonLuuThongTin.Enabled = isEditingOrAdding;
            buttonThem.Enabled = !isEditingOrAdding;
            buttonChinhSua.Enabled = !isEditingOrAdding;
            buttonXoa.Enabled = !isEditingOrAdding;
        }

        private void SetTextBoxesReadOnly(bool readOnly)
        {
            textBoxMaPhongThi.ReadOnly = true;
            textBoxMaPhongThi.BackColor = SystemColors.Control;

            comboBoxHinhThuc.Enabled = !readOnly;
            textBoxMaxThiSinh.ReadOnly = readOnly;
            textBoxMinThiSinh.ReadOnly = readOnly;
            textBoxSLNVCT.ReadOnly = readOnly;

            textBoxMaxThiSinh.BackColor = readOnly ? SystemColors.Control : SystemColors.Window;
            textBoxMinThiSinh.BackColor = readOnly ? SystemColors.Control : SystemColors.Window;
            textBoxSLNVCT.BackColor = readOnly ? SystemColors.Control : SystemColors.Window;
        }

        private void ClearTextBoxes()
        {
            textBoxMaPhongThi.Text = isAdding ? "(Tự động)" : "";
            comboBoxHinhThuc.SelectedIndex = -1;
            textBoxMaxThiSinh.Text = "";
            textBoxMinThiSinh.Text = "";
            textBoxSLNVCT.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SetUIState(false);
                isAdding = false;
                try
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    textBoxMaPhongThi.Text = row.Cells["PT_MaPhongThi"].Value.ToString();
                    comboBoxHinhThuc.SelectedItem = row.Cells["PT_HinhThuc"].Value.ToString();
                    textBoxMaxThiSinh.Text = row.Cells["PT_SLThiSinhToiDa"].Value.ToString();
                    textBoxMinThiSinh.Text = row.Cells["PT_SLThiSinhToiThieu"].Value.ToString();
                    textBoxSLNVCT.Text = row.Cells["PT_SLNhanVienCoiThi"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc dữ liệu từ dòng đã chọn: " + ex.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            SetUIState(true);
            ClearTextBoxes();
        }

        private void buttonChinhSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaPhongThi.Text))
            {
                MessageBox.Show("Vui lòng chọn một phòng thi để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            isAdding = false;
            SetUIState(true);
        }

        private void buttonLuuThongTin_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                if (PhongThiBUS.AddPhongThi(comboBoxHinhThuc.Text, textBoxMaxThiSinh.Text, textBoxMinThiSinh.Text, textBoxSLNVCT.Text))
                {
                    MessageBox.Show("Thêm phòng thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm phòng thi thất bại. Vui lòng kiểm tra lại dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Đang sửa
            {
                if (PhongThiBUS.UpdatePhongThi(textBoxMaPhongThi.Text, comboBoxHinhThuc.Text, textBoxMaxThiSinh.Text, textBoxMinThiSinh.Text, textBoxSLNVCT.Text))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadPhongThiData();
            ClearTextBoxes();
            SetUIState(false);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaPhongThi.Text))
            {
                MessageBox.Show("Vui lòng chọn một phòng thi để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phòng thi này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (PhongThiBUS.DeletePhongThi(textBoxMaPhongThi.Text))
                {
                    MessageBox.Show("Xóa phòng thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPhongThiData();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Có thể phòng thi này đang được sử dụng trong một lịch thi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonXemLichThi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaPhongThi.Text) || textBoxMaPhongThi.Text == "(Tự động)")
            {
                MessageBox.Show("Vui lòng chọn một phòng thi từ danh sách.", "Chưa chọn phòng thi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string selectedMaPhongThi = textBoxMaPhongThi.Text;
            fAdminXemDSLichThi_PhongThi f = new fAdminXemDSLichThi_PhongThi(selectedMaPhongThi);
            f.ShowDialog();
        }

        private void adminQLPhongThi_Load(object sender, EventArgs e)
        {

        }
    }
}