namespace PTTKHTTTProject
{
    partial class fAdminChinhSuaLichThi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBoxThoat = new PictureBox();
            label2 = new Label();
            tableLayoutPanelKyThi = new TableLayoutPanel();
            labelHienThiTenKyThi = new Label();
            labelTenKyThi = new Label();
            labelMaKyThi = new Label();
            labelHienThiMaKT = new Label();
            labelLichThi = new Label();
            tableLayoutPanelThongTinNV = new TableLayoutPanel();
            dateTimePickerTGKetThuc = new DateTimePicker();
            labelTGKetThuc = new Label();
            dateTimePicker1 = new DateTimePicker();
            labelHienThiPhongThi = new Label();
            dateTimePickerNgayThi = new DateTimePicker();
            labelPhongThi = new Label();
            labelMaLichThi = new Label();
            labelNgayThi = new Label();
            labelTrangThai = new Label();
            labelSoDT = new Label();
            comboBoxTrangThai = new ComboBox();
            labelHienThiMaLT = new Label();
            labelLuong = new Label();
            numericUpDownSLDangKy = new NumericUpDown();
            buttonChinhSuaThongTin = new Button();
            buttonLuuThongTin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThoat).BeginInit();
            tableLayoutPanelKyThi.SuspendLayout();
            tableLayoutPanelThongTinNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSLDangKy).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(404, 21);
            label1.Name = "label1";
            label1.Size = new Size(243, 31);
            label1.TabIndex = 0;
            label1.Text = "CHỈNH SỬA LỊCH THI";
            // 
            // pictureBoxThoat
            // 
            pictureBoxThoat.Image = Properties.Resources.exit;
            pictureBoxThoat.Location = new Point(53, 21);
            pictureBoxThoat.Name = "pictureBoxThoat";
            pictureBoxThoat.Size = new Size(63, 31);
            pictureBoxThoat.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxThoat.TabIndex = 1;
            pictureBoxThoat.TabStop = false;
            pictureBoxThoat.Click += pictureBoxThoat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(656, 79);
            label2.Name = "label2";
            label2.Size = new Size(164, 28);
            label2.TabIndex = 2;
            label2.Text = "Thông tin kỳ thi";
            // 
            // tableLayoutPanelKyThi
            // 
            tableLayoutPanelKyThi.ColumnCount = 2;
            tableLayoutPanelKyThi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.8496742F));
            tableLayoutPanelKyThi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.1503258F));
            tableLayoutPanelKyThi.Controls.Add(labelHienThiTenKyThi, 1, 1);
            tableLayoutPanelKyThi.Controls.Add(labelTenKyThi, 0, 1);
            tableLayoutPanelKyThi.Controls.Add(labelMaKyThi, 0, 0);
            tableLayoutPanelKyThi.Controls.Add(labelHienThiMaKT, 1, 0);
            tableLayoutPanelKyThi.Location = new Point(656, 122);
            tableLayoutPanelKyThi.Name = "tableLayoutPanelKyThi";
            tableLayoutPanelKyThi.RowCount = 2;
            tableLayoutPanelKyThi.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelKyThi.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelKyThi.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelKyThi.Size = new Size(306, 113);
            tableLayoutPanelKyThi.TabIndex = 30;
            // 
            // labelHienThiTenKyThi
            // 
            labelHienThiTenKyThi.Anchor = AnchorStyles.None;
            labelHienThiTenKyThi.AutoSize = true;
            labelHienThiTenKyThi.Font = new Font("Segoe UI", 10F);
            labelHienThiTenKyThi.Location = new Point(188, 73);
            labelHienThiTenKyThi.Name = "labelHienThiTenKyThi";
            labelHienThiTenKyThi.Size = new Size(55, 23);
            labelHienThiTenKyThi.TabIndex = 4;
            labelHienThiTenKyThi.Text = "label2";
            // 
            // labelTenKyThi
            // 
            labelTenKyThi.Anchor = AnchorStyles.None;
            labelTenKyThi.AutoSize = true;
            labelTenKyThi.Font = new Font("Segoe UI", 10F);
            labelTenKyThi.Location = new Point(19, 73);
            labelTenKyThi.Name = "labelTenKyThi";
            labelTenKyThi.Size = new Size(86, 23);
            labelTenKyThi.TabIndex = 3;
            labelTenKyThi.Text = "Tên kỳ thi:";
            // 
            // labelMaKyThi
            // 
            labelMaKyThi.Anchor = AnchorStyles.None;
            labelMaKyThi.AutoSize = true;
            labelMaKyThi.Font = new Font("Segoe UI", 10F);
            labelMaKyThi.Location = new Point(20, 16);
            labelMaKyThi.Name = "labelMaKyThi";
            labelMaKyThi.Size = new Size(84, 23);
            labelMaKyThi.TabIndex = 1;
            labelMaKyThi.Text = "Mã kỳ thi:";
            // 
            // labelHienThiMaKT
            // 
            labelHienThiMaKT.Anchor = AnchorStyles.None;
            labelHienThiMaKT.AutoSize = true;
            labelHienThiMaKT.Font = new Font("Segoe UI", 10F);
            labelHienThiMaKT.Location = new Point(188, 16);
            labelHienThiMaKT.Name = "labelHienThiMaKT";
            labelHienThiMaKT.Size = new Size(55, 23);
            labelHienThiMaKT.TabIndex = 2;
            labelHienThiMaKT.Text = "label2";
            // 
            // labelLichThi
            // 
            labelLichThi.AutoSize = true;
            labelLichThi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelLichThi.Location = new Point(36, 79);
            labelLichThi.Name = "labelLichThi";
            labelLichThi.Size = new Size(176, 28);
            labelLichThi.TabIndex = 31;
            labelLichThi.Text = "Thông tin lịch thi";
            // 
            // tableLayoutPanelThongTinNV
            // 
            tableLayoutPanelThongTinNV.ColumnCount = 2;
            tableLayoutPanelThongTinNV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.290844F));
            tableLayoutPanelThongTinNV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.70916F));
            tableLayoutPanelThongTinNV.Controls.Add(dateTimePickerTGKetThuc, 1, 5);
            tableLayoutPanelThongTinNV.Controls.Add(labelTGKetThuc, 0, 5);
            tableLayoutPanelThongTinNV.Controls.Add(dateTimePicker1, 1, 4);
            tableLayoutPanelThongTinNV.Controls.Add(labelHienThiPhongThi, 1, 3);
            tableLayoutPanelThongTinNV.Controls.Add(dateTimePickerNgayThi, 1, 1);
            tableLayoutPanelThongTinNV.Controls.Add(labelPhongThi, 0, 3);
            tableLayoutPanelThongTinNV.Controls.Add(labelMaLichThi, 0, 0);
            tableLayoutPanelThongTinNV.Controls.Add(labelNgayThi, 0, 1);
            tableLayoutPanelThongTinNV.Controls.Add(labelTrangThai, 0, 2);
            tableLayoutPanelThongTinNV.Controls.Add(labelSoDT, 0, 4);
            tableLayoutPanelThongTinNV.Controls.Add(comboBoxTrangThai, 1, 2);
            tableLayoutPanelThongTinNV.Controls.Add(labelHienThiMaLT, 1, 0);
            tableLayoutPanelThongTinNV.Controls.Add(labelLuong, 0, 6);
            tableLayoutPanelThongTinNV.Controls.Add(numericUpDownSLDangKy, 1, 6);
            tableLayoutPanelThongTinNV.Location = new Point(36, 122);
            tableLayoutPanelThongTinNV.Name = "tableLayoutPanelThongTinNV";
            tableLayoutPanelThongTinNV.RowCount = 7;
            tableLayoutPanelThongTinNV.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelThongTinNV.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelThongTinNV.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelThongTinNV.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelThongTinNV.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelThongTinNV.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanelThongTinNV.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanelThongTinNV.Size = new Size(587, 363);
            tableLayoutPanelThongTinNV.TabIndex = 32;
            // 
            // dateTimePickerTGKetThuc
            // 
            dateTimePickerTGKetThuc.Anchor = AnchorStyles.None;
            dateTimePickerTGKetThuc.CustomFormat = "HH:mm";
            dateTimePickerTGKetThuc.Format = DateTimePickerFormat.Custom;
            dateTimePickerTGKetThuc.Location = new Point(259, 261);
            dateTimePickerTGKetThuc.Name = "dateTimePickerTGKetThuc";
            dateTimePickerTGKetThuc.ShowUpDown = true;
            dateTimePickerTGKetThuc.Size = new Size(269, 27);
            dateTimePickerTGKetThuc.TabIndex = 30;
            // 
            // labelTGKetThuc
            // 
            labelTGKetThuc.Anchor = AnchorStyles.None;
            labelTGKetThuc.AutoSize = true;
            labelTGKetThuc.Font = new Font("Segoe UI", 10F);
            labelTGKetThuc.Location = new Point(24, 263);
            labelTGKetThuc.Name = "labelTGKetThuc";
            labelTGKetThuc.Size = new Size(152, 23);
            labelTGKetThuc.TabIndex = 29;
            labelTGKetThuc.Text = "Thời gian kết thúc:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.CustomFormat = "HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(259, 211);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(269, 27);
            dateTimePicker1.TabIndex = 28;
            // 
            // labelHienThiPhongThi
            // 
            labelHienThiPhongThi.Anchor = AnchorStyles.None;
            labelHienThiPhongThi.AutoSize = true;
            labelHienThiPhongThi.Font = new Font("Segoe UI", 10F);
            labelHienThiPhongThi.Location = new Point(366, 163);
            labelHienThiPhongThi.Name = "labelHienThiPhongThi";
            labelHienThiPhongThi.Size = new Size(55, 23);
            labelHienThiPhongThi.TabIndex = 24;
            labelHienThiPhongThi.Text = "label2";
            // 
            // dateTimePickerNgayThi
            // 
            dateTimePickerNgayThi.Anchor = AnchorStyles.None;
            dateTimePickerNgayThi.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgayThi.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayThi.Location = new Point(252, 61);
            dateTimePickerNgayThi.Name = "dateTimePickerNgayThi";
            dateTimePickerNgayThi.Size = new Size(283, 27);
            dateTimePickerNgayThi.TabIndex = 20;
            // 
            // labelPhongThi
            // 
            labelPhongThi.Anchor = AnchorStyles.None;
            labelPhongThi.AutoSize = true;
            labelPhongThi.Font = new Font("Segoe UI", 10F);
            labelPhongThi.Location = new Point(56, 163);
            labelPhongThi.Name = "labelPhongThi";
            labelPhongThi.Size = new Size(89, 23);
            labelPhongThi.TabIndex = 6;
            labelPhongThi.Text = "Phòng thi:";
            // 
            // labelMaLichThi
            // 
            labelMaLichThi.Anchor = AnchorStyles.None;
            labelMaLichThi.AutoSize = true;
            labelMaLichThi.Font = new Font("Segoe UI", 10F);
            labelMaLichThi.Location = new Point(53, 13);
            labelMaLichThi.Name = "labelMaLichThi";
            labelMaLichThi.Size = new Size(94, 23);
            labelMaLichThi.TabIndex = 0;
            labelMaLichThi.Text = "Mã lịch thi:";
            // 
            // labelNgayThi
            // 
            labelNgayThi.Anchor = AnchorStyles.None;
            labelNgayThi.AutoSize = true;
            labelNgayThi.Font = new Font("Segoe UI", 10F);
            labelNgayThi.Location = new Point(61, 63);
            labelNgayThi.Name = "labelNgayThi";
            labelNgayThi.Size = new Size(79, 23);
            labelNgayThi.TabIndex = 2;
            labelNgayThi.Text = "Ngày thi:";
            // 
            // labelTrangThai
            // 
            labelTrangThai.Anchor = AnchorStyles.None;
            labelTrangThai.AutoSize = true;
            labelTrangThai.Font = new Font("Segoe UI", 10F);
            labelTrangThai.Location = new Point(55, 113);
            labelTrangThai.Name = "labelTrangThai";
            labelTrangThai.Size = new Size(91, 23);
            labelTrangThai.TabIndex = 3;
            labelTrangThai.Text = "Trạng thái:";
            // 
            // labelSoDT
            // 
            labelSoDT.Anchor = AnchorStyles.None;
            labelSoDT.AutoSize = true;
            labelSoDT.Font = new Font("Segoe UI", 10F);
            labelSoDT.Location = new Point(26, 213);
            labelSoDT.Name = "labelSoDT";
            labelSoDT.Size = new Size(149, 23);
            labelSoDT.TabIndex = 7;
            labelSoDT.Text = "Thời gian bắt đầu:";
            // 
            // comboBoxTrangThai
            // 
            comboBoxTrangThai.Anchor = AnchorStyles.None;
            comboBoxTrangThai.BackColor = SystemColors.Window;
            comboBoxTrangThai.FormattingEnabled = true;
            comboBoxTrangThai.Location = new Point(255, 111);
            comboBoxTrangThai.Name = "comboBoxTrangThai";
            comboBoxTrangThai.Size = new Size(277, 28);
            comboBoxTrangThai.TabIndex = 22;
            comboBoxTrangThai.Text = "Giới tính";
            // 
            // labelHienThiMaLT
            // 
            labelHienThiMaLT.Anchor = AnchorStyles.None;
            labelHienThiMaLT.AutoSize = true;
            labelHienThiMaLT.Font = new Font("Segoe UI", 10F);
            labelHienThiMaLT.Location = new Point(366, 13);
            labelHienThiMaLT.Name = "labelHienThiMaLT";
            labelHienThiMaLT.Size = new Size(55, 23);
            labelHienThiMaLT.TabIndex = 23;
            labelHienThiMaLT.Text = "label2";
            // 
            // labelLuong
            // 
            labelLuong.Anchor = AnchorStyles.None;
            labelLuong.AutoSize = true;
            labelLuong.Font = new Font("Segoe UI", 10F);
            labelLuong.Location = new Point(15, 319);
            labelLuong.Name = "labelLuong";
            labelLuong.Size = new Size(171, 23);
            labelLuong.TabIndex = 21;
            labelLuong.Text = "Số lượng đã đăng ký:";
            // 
            // numericUpDownSLDangKy
            // 
            numericUpDownSLDangKy.Anchor = AnchorStyles.None;
            numericUpDownSLDangKy.Location = new Point(254, 317);
            numericUpDownSLDangKy.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownSLDangKy.Name = "numericUpDownSLDangKy";
            numericUpDownSLDangKy.Size = new Size(279, 27);
            numericUpDownSLDangKy.TabIndex = 20;
            numericUpDownSLDangKy.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // buttonChinhSuaThongTin
            // 
            buttonChinhSuaThongTin.BackColor = Color.LightBlue;
            buttonChinhSuaThongTin.Location = new Point(792, 385);
            buttonChinhSuaThongTin.Name = "buttonChinhSuaThongTin";
            buttonChinhSuaThongTin.Size = new Size(170, 38);
            buttonChinhSuaThongTin.TabIndex = 33;
            buttonChinhSuaThongTin.Text = "Chỉnh sửa thông tin";
            buttonChinhSuaThongTin.UseVisualStyleBackColor = false;
            // 
            // buttonLuuThongTin
            // 
            buttonLuuThongTin.BackColor = Color.LightBlue;
            buttonLuuThongTin.Location = new Point(792, 447);
            buttonLuuThongTin.Name = "buttonLuuThongTin";
            buttonLuuThongTin.Size = new Size(170, 38);
            buttonLuuThongTin.TabIndex = 34;
            buttonLuuThongTin.Text = "Lưu thông tin";
            buttonLuuThongTin.UseVisualStyleBackColor = false;
            // 
            // fAdminChinhSuaLichThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(995, 529);
            Controls.Add(buttonLuuThongTin);
            Controls.Add(buttonChinhSuaThongTin);
            Controls.Add(tableLayoutPanelThongTinNV);
            Controls.Add(labelLichThi);
            Controls.Add(tableLayoutPanelKyThi);
            Controls.Add(label2);
            Controls.Add(pictureBoxThoat);
            Controls.Add(label1);
            Name = "fAdminChinhSuaLichThi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAdminChinhSuaLichThi";
            Load += fAdminChinhSuaLichThi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxThoat).EndInit();
            tableLayoutPanelKyThi.ResumeLayout(false);
            tableLayoutPanelKyThi.PerformLayout();
            tableLayoutPanelThongTinNV.ResumeLayout(false);
            tableLayoutPanelThongTinNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSLDangKy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBoxThoat;
        private Label label2;
        private TableLayoutPanel tableLayoutPanelKyThi;
        private Label labelHienThiTenKyThi;
        private Label labelTenKyThi;
        private Label labelMaKyThi;
        private Label labelHienThiMaKT;
        private Label labelLichThi;
        private TableLayoutPanel tableLayoutPanelThongTinNV;
        private Label labelHienThiDiaChi;
        private Label labelHienThiCCCD;
        private Label labelHienThiSDT;
        private Label labelHienThiPhongThi;
        private NumericUpDown numericUpDownSLDangKy;
        private Label labelLuong;
        private DateTimePicker dateTimePickerNgayThi;
        private Label labelDiaChi;
        private Label labelCCCD;
        private Label labelPhongThi;
        private Label labelMaLichThi;
        private Label labelNgayThi;
        private Label labelTrangThai;
        private Label labelSoDT;
        private ComboBox comboBoxTrangThai;
        private Label labelHienThiMaLT;
        private DateTimePicker dateTimePickerTGKetThuc;
        private Label labelTGKetThuc;
        private DateTimePicker dateTimePicker1;
        private Button buttonChinhSuaThongTin;
        private Button buttonLuuThongTin;
    }
}