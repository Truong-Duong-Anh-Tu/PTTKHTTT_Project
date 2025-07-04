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
            SetTextBoxesReadOnly(true);
            buttonLuuThongTin.Enabled = false;
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetTextBoxesReadOnly(bool readOnly)
        {
            // Mã phòng thi luôn ở chế độ chỉ đọc
            textBoxMaPhongThi.ReadOnly = true;
            textBoxMaPhongThi.BackColor = SystemColors.Control;

            // Bật/tắt các control khác
            comboBoxHinhThuc.Enabled = !readOnly;
            textBoxMaxThiSinh.ReadOnly = readOnly;
            textBoxMinThiSinh.ReadOnly = readOnly;
            textBoxSLNVCT.ReadOnly = readOnly;

            // Đổi màu nền để người dùng dễ nhận biết
            textBoxMaxThiSinh.BackColor = readOnly ? SystemColors.Control : SystemColors.Window;
            textBoxMinThiSinh.BackColor = readOnly ? SystemColors.Control : SystemColors.Window;
            textBoxSLNVCT.BackColor = readOnly ? SystemColors.Control : SystemColors.Window;
        }

        private void ClearTextBoxes()
        {
            textBoxMaPhongThi.Text = "(Tự động)"; // Hiển thị thông báo
            comboBoxHinhThuc.SelectedIndex = -1;
            textBoxMaxThiSinh.Text = "";
            textBoxMinThiSinh.Text = "";
            textBoxSLNVCT.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SetTextBoxesReadOnly(true);
                buttonLuuThongTin.Enabled = false;
                buttonChinhSua.Enabled = true;
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
            ClearTextBoxes();
            SetTextBoxesReadOnly(false);
            buttonLuuThongTin.Enabled = true;
            buttonChinhSua.Enabled = false;
        }

        private void buttonLuuThongTin_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                // Gọi phương thức AddPhongThi mới không cần mã phòng
                if (PhongThiBUS.AddPhongThi(comboBoxHinhThuc.Text, textBoxMaxThiSinh.Text, textBoxMinThiSinh.Text, textBoxSLNVCT.Text))
                {
                    MessageBox.Show("Thêm phòng thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPhongThiData();
                    ClearTextBoxes();
                    SetTextBoxesReadOnly(true);
                    buttonLuuThongTin.Enabled = false;
                    buttonChinhSua.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Thêm phòng thi thất bại. Vui lòng kiểm tra lại dữ liệu đầu vào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}