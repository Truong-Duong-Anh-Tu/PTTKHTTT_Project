namespace PTTKHTTTProject
{
    partial class fAdminChinhSuaLichThi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
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
            dateTimePickerTGBatDau = new DateTimePicker();
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
            label1.Location = new Point(656, 34);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(392, 50);
            label1.TabIndex = 0;
            label1.Text = "CHỈNH SỬA LỊCH THI";
            // 
            // pictureBoxThoat
            // 
            pictureBoxThoat.Image = Properties.Resources.exit;
            pictureBoxThoat.Location = new Point(86, 34);
            pictureBoxThoat.Margin = new Padding(5, 5, 5, 5);
            pictureBoxThoat.Name = "pictureBoxThoat";
            pictureBoxThoat.Size = new Size(102, 50);
            pictureBoxThoat.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxThoat.TabIndex = 1;
            pictureBoxThoat.TabStop = false;
            pictureBoxThoat.Click += pictureBoxThoat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(1066, 126);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(259, 45);
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
            tableLayoutPanelKyThi.Location = new Point(1066, 195);
            tableLayoutPanelKyThi.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanelKyThi.Name = "tableLayoutPanelKyThi";
            tableLayoutPanelKyThi.RowCount = 2;
            tableLayoutPanelKyThi.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelKyThi.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelKyThi.Size = new Size(497, 181);
            tableLayoutPanelKyThi.TabIndex = 30;
            // 
            // labelHienThiTenKyThi
            // 
            labelHienThiTenKyThi.Anchor = AnchorStyles.None;
            labelHienThiTenKyThi.AutoSize = true;
            labelHienThiTenKyThi.Font = new Font("Segoe UI", 10F);
            labelHienThiTenKyThi.Location = new Point(305, 117);
            labelHienThiTenKyThi.Margin = new Padding(5, 0, 5, 0);
            labelHienThiTenKyThi.Name = "labelHienThiTenKyThi";
            labelHienThiTenKyThi.Size = new Size(90, 37);
            labelHienThiTenKyThi.TabIndex = 4;
            labelHienThiTenKyThi.Text = "label2";
            // 
            // labelTenKyThi
            // 
            labelTenKyThi.Anchor = AnchorStyles.None;
            labelTenKyThi.AutoSize = true;
            labelTenKyThi.Font = new Font("Segoe UI", 10F);
            labelTenKyThi.Location = new Point(34, 117);
            labelTenKyThi.Margin = new Padding(5, 0, 5, 0);
            labelTenKyThi.Name = "labelTenKyThi";
            labelTenKyThi.Size = new Size(134, 37);
            labelTenKyThi.TabIndex = 3;
            labelTenKyThi.Text = "Tên kỳ thi:";
            // 
            // labelMaKyThi
            // 
            labelMaKyThi.Anchor = AnchorStyles.None;
            labelMaKyThi.AutoSize = true;
            labelMaKyThi.Font = new Font("Segoe UI", 10F);
            labelMaKyThi.Location = new Point(35, 26);
            labelMaKyThi.Margin = new Padding(5, 0, 5, 0);
            labelMaKyThi.Name = "labelMaKyThi";
            labelMaKyThi.Size = new Size(132, 37);
            labelMaKyThi.TabIndex = 1;
            labelMaKyThi.Text = "Mã kỳ thi:";
            // 
            // labelHienThiMaKT
            // 
            labelHienThiMaKT.Anchor = AnchorStyles.None;
            labelHienThiMaKT.AutoSize = true;
            labelHienThiMaKT.Font = new Font("Segoe UI", 10F);
            labelHienThiMaKT.Location = new Point(305, 26);
            labelHienThiMaKT.Margin = new Padding(5, 0, 5, 0);
            labelHienThiMaKT.Name = "labelHienThiMaKT";
            labelHienThiMaKT.Size = new Size(90, 37);
            labelHienThiMaKT.TabIndex = 2;
            labelHienThiMaKT.Text = "label2";
            // 
            // labelLichThi
            // 
            labelLichThi.AutoSize = true;
            labelLichThi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelLichThi.Location = new Point(58, 126);
            labelLichThi.Margin = new Padding(5, 0, 5, 0);
            labelLichThi.Name = "labelLichThi";
            labelLichThi.Size = new Size(276, 45);
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
            tableLayoutPanelThongTinNV.Controls.Add(dateTimePickerTGBatDau, 1, 4);
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
            tableLayoutPanelThongTinNV.Location = new Point(58, 195);
            tableLayoutPanelThongTinNV.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanelThongTinNV.Name = "tableLayoutPanelThongTinNV";
            tableLayoutPanelThongTinNV.RowCount = 7;
            tableLayoutPanelThongTinNV.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanelThongTinNV.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanelThongTinNV.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanelThongTinNV.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanelThongTinNV.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanelThongTinNV.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tableLayoutPanelThongTinNV.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tableLayoutPanelThongTinNV.Size = new Size(954, 581);
            tableLayoutPanelThongTinNV.TabIndex = 32;
            // 
            // dateTimePickerTGKetThuc
            // 
            dateTimePickerTGKetThuc.Anchor = AnchorStyles.None;
            dateTimePickerTGKetThuc.CustomFormat = "HH:mm";
            dateTimePickerTGKetThuc.Format = DateTimePickerFormat.Custom;
            dateTimePickerTGKetThuc.Location = new Point(423, 419);
            dateTimePickerTGKetThuc.Margin = new Padding(5, 5, 5, 5);
            dateTimePickerTGKetThuc.Name = "dateTimePickerTGKetThuc";
            dateTimePickerTGKetThuc.ShowUpDown = true;
            dateTimePickerTGKetThuc.Size = new Size(435, 39);
            dateTimePickerTGKetThuc.TabIndex = 30;
            // 
            // labelTGKetThuc
            // 
            labelTGKetThuc.Anchor = AnchorStyles.None;
            labelTGKetThuc.AutoSize = true;
            labelTGKetThuc.Font = new Font("Segoe UI", 10F);
            labelTGKetThuc.Location = new Point(46, 420);
            labelTGKetThuc.Margin = new Padding(5, 0, 5, 0);
            labelTGKetThuc.Name = "labelTGKetThuc";
            labelTGKetThuc.Size = new Size(235, 37);
            labelTGKetThuc.TabIndex = 29;
            labelTGKetThuc.Text = "Thời gian kết thúc:";
            // 
            // dateTimePickerTGBatDau
            // 
            dateTimePickerTGBatDau.Anchor = AnchorStyles.None;
            dateTimePickerTGBatDau.CustomFormat = "HH:mm";
            dateTimePickerTGBatDau.Format = DateTimePickerFormat.Custom;
            dateTimePickerTGBatDau.Location = new Point(423, 340);
            dateTimePickerTGBatDau.Margin = new Padding(5, 5, 5, 5);
            dateTimePickerTGBatDau.Name = "dateTimePickerTGBatDau";
            dateTimePickerTGBatDau.ShowUpDown = true;
            dateTimePickerTGBatDau.Size = new Size(435, 39);
            dateTimePickerTGBatDau.TabIndex = 28;
            // 
            // labelHienThiPhongThi
            // 
            labelHienThiPhongThi.Anchor = AnchorStyles.None;
            labelHienThiPhongThi.AutoSize = true;
            labelHienThiPhongThi.Font = new Font("Segoe UI", 10F);
            labelHienThiPhongThi.Location = new Point(595, 261);
            labelHienThiPhongThi.Margin = new Padding(5, 0, 5, 0);
            labelHienThiPhongThi.Name = "labelHienThiPhongThi";
            labelHienThiPhongThi.Size = new Size(90, 37);
            labelHienThiPhongThi.TabIndex = 24;
            labelHienThiPhongThi.Text = "label2";
            // 
            // dateTimePickerNgayThi
            // 
            dateTimePickerNgayThi.Anchor = AnchorStyles.None;
            dateTimePickerNgayThi.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgayThi.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayThi.Location = new Point(412, 100);
            dateTimePickerNgayThi.Margin = new Padding(5, 5, 5, 5);
            dateTimePickerNgayThi.Name = "dateTimePickerNgayThi";
            dateTimePickerNgayThi.Size = new Size(457, 39);
            dateTimePickerNgayThi.TabIndex = 20;
            // 
            // labelPhongThi
            // 
            labelPhongThi.Anchor = AnchorStyles.None;
            labelPhongThi.AutoSize = true;
            labelPhongThi.Font = new Font("Segoe UI", 10F);
            labelPhongThi.Location = new Point(94, 261);
            labelPhongThi.Margin = new Padding(5, 0, 5, 0);
            labelPhongThi.Name = "labelPhongThi";
            labelPhongThi.Size = new Size(138, 37);
            labelPhongThi.TabIndex = 6;
            labelPhongThi.Text = "Phòng thi:";
            // 
            // labelMaLichThi
            // 
            labelMaLichThi.Anchor = AnchorStyles.None;
            labelMaLichThi.AutoSize = true;
            labelMaLichThi.Font = new Font("Segoe UI", 10F);
            labelMaLichThi.Location = new Point(90, 21);
            labelMaLichThi.Margin = new Padding(5, 0, 5, 0);
            labelMaLichThi.Name = "labelMaLichThi";
            labelMaLichThi.Size = new Size(147, 37);
            labelMaLichThi.TabIndex = 0;
            labelMaLichThi.Text = "Mã lịch thi:";
            // 
            // labelNgayThi
            // 
            labelNgayThi.Anchor = AnchorStyles.None;
            labelNgayThi.AutoSize = true;
            labelNgayThi.Font = new Font("Segoe UI", 10F);
            labelNgayThi.Location = new Point(101, 101);
            labelNgayThi.Margin = new Padding(5, 0, 5, 0);
            labelNgayThi.Name = "labelNgayThi";
            labelNgayThi.Size = new Size(124, 37);
            labelNgayThi.TabIndex = 2;
            labelNgayThi.Text = "Ngày thi:";
            // 
            // labelTrangThai
            // 
            labelTrangThai.Anchor = AnchorStyles.None;
            labelTrangThai.AutoSize = true;
            labelTrangThai.Font = new Font("Segoe UI", 10F);
            labelTrangThai.Location = new Point(93, 181);
            labelTrangThai.Margin = new Padding(5, 0, 5, 0);
            labelTrangThai.Name = "labelTrangThai";
            labelTrangThai.Size = new Size(141, 37);
            labelTrangThai.TabIndex = 3;
            labelTrangThai.Text = "Trạng thái:";
            // 
            // labelSoDT
            // 
            labelSoDT.Anchor = AnchorStyles.None;
            labelSoDT.AutoSize = true;
            labelSoDT.Font = new Font("Segoe UI", 10F);
            labelSoDT.Location = new Point(47, 341);
            labelSoDT.Margin = new Padding(5, 0, 5, 0);
            labelSoDT.Name = "labelSoDT";
            labelSoDT.Size = new Size(232, 37);
            labelSoDT.TabIndex = 7;
            labelSoDT.Text = "Thời gian bắt đầu:";
            // 
            // comboBoxTrangThai
            // 
            comboBoxTrangThai.Anchor = AnchorStyles.None;
            comboBoxTrangThai.BackColor = SystemColors.Window;
            comboBoxTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTrangThai.Enabled = false;
            comboBoxTrangThai.FormattingEnabled = true;
            comboBoxTrangThai.Items.AddRange(new object[] { "Chưa thi", "Đang thi", "Đã thi" });
            comboBoxTrangThai.Location = new Point(416, 180);
            comboBoxTrangThai.Margin = new Padding(5, 5, 5, 5);
            comboBoxTrangThai.Name = "comboBoxTrangThai";
            comboBoxTrangThai.Size = new Size(448, 40);
            comboBoxTrangThai.TabIndex = 22;
            // 
            // labelHienThiMaLT
            // 
            labelHienThiMaLT.Anchor = AnchorStyles.None;
            labelHienThiMaLT.AutoSize = true;
            labelHienThiMaLT.Font = new Font("Segoe UI", 10F);
            labelHienThiMaLT.Location = new Point(595, 21);
            labelHienThiMaLT.Margin = new Padding(5, 0, 5, 0);
            labelHienThiMaLT.Name = "labelHienThiMaLT";
            labelHienThiMaLT.Size = new Size(90, 37);
            labelHienThiMaLT.TabIndex = 23;
            labelHienThiMaLT.Text = "label2";
            // 
            // labelLuong
            // 
            labelLuong.Anchor = AnchorStyles.None;
            labelLuong.AutoSize = true;
            labelLuong.Font = new Font("Segoe UI", 10F);
            labelLuong.Location = new Point(29, 511);
            labelLuong.Margin = new Padding(5, 0, 5, 0);
            labelLuong.Name = "labelLuong";
            labelLuong.Size = new Size(268, 37);
            labelLuong.TabIndex = 21;
            labelLuong.Text = "Số lượng đã đăng ký:";
            // 
            // numericUpDownSLDangKy
            // 
            numericUpDownSLDangKy.Anchor = AnchorStyles.None;
            numericUpDownSLDangKy.Location = new Point(414, 510);
            numericUpDownSLDangKy.Margin = new Padding(5, 5, 5, 5);
            numericUpDownSLDangKy.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownSLDangKy.Name = "numericUpDownSLDangKy";
            numericUpDownSLDangKy.Size = new Size(453, 39);
            numericUpDownSLDangKy.TabIndex = 20;
            // 
            // buttonLuuThongTin
            // 
            buttonLuuThongTin.BackColor = Color.LightBlue;
            buttonLuuThongTin.Location = new Point(1287, 715);
            buttonLuuThongTin.Margin = new Padding(5, 5, 5, 5);
            buttonLuuThongTin.Name = "buttonLuuThongTin";
            buttonLuuThongTin.Size = new Size(276, 61);
            buttonLuuThongTin.TabIndex = 34;
            buttonLuuThongTin.Text = "Lưu thông tin";
            buttonLuuThongTin.UseVisualStyleBackColor = false;
            buttonLuuThongTin.Click += buttonLuuThongTin_Click;
            // 
            // fAdminChinhSuaLichThi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1617, 846);
            Controls.Add(buttonLuuThongTin);
            Controls.Add(tableLayoutPanelThongTinNV);
            Controls.Add(labelLichThi);
            Controls.Add(tableLayoutPanelKyThi);
            Controls.Add(label2);
            Controls.Add(pictureBoxThoat);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "fAdminChinhSuaLichThi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chỉnh Sửa Lịch Thi";
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
        private Label labelHienThiPhongThi;
        private NumericUpDown numericUpDownSLDangKy;
        private Label labelLuong;
        private DateTimePicker dateTimePickerNgayThi;
        private Label labelPhongThi;
        private Label labelMaLichThi;
        private Label labelNgayThi;
        private Label labelTrangThai;
        private Label labelSoDT;
        private ComboBox comboBoxTrangThai;
        private Label labelHienThiMaLT;
        private DateTimePicker dateTimePickerTGKetThuc;
        private Label labelTGKetThuc;
        private DateTimePicker dateTimePickerTGBatDau;
        private Button buttonLuuThongTin;
    }
}