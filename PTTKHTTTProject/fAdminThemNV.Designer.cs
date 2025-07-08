namespace PTTKHTTTProject
{
    partial class fAdminThemNV
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
            pictureBoxThoat = new PictureBox();
            comboBoxChucVu = new ComboBox();
            label1 = new Label();
            textBoxDiaChi = new TextBox();
            textBoxCCCD = new TextBox();
            textBoxSDT = new TextBox();
            textBoxEmail = new TextBox();
            textBoxHoTen = new TextBox();
            tableLayoutPanelThongTinLichPhanCong = new TableLayoutPanel();
            comboBoxGioiTinh = new ComboBox();
            numericUpDownLuong = new NumericUpDown();
            labelLuong = new Label();
            dateTimePickerNgaySinh = new DateTimePicker();
            labelDiaChi = new Label();
            labelCCCD = new Label();
            labelEmail = new Label();
            labelHoTen = new Label();
            labelNgaySinh = new Label();
            labelGioiTinh = new Label();
            labelSDT = new Label();
            button1 = new Button();
            textBoxPhongBan = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThoat).BeginInit();
            tableLayoutPanelThongTinLichPhanCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLuong).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxThoat
            // 
            pictureBoxThoat.Image = Properties.Resources.exit;
            pictureBoxThoat.Location = new Point(56, 32);
            pictureBoxThoat.Name = "pictureBoxThoat";
            pictureBoxThoat.Size = new Size(59, 31);
            pictureBoxThoat.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxThoat.TabIndex = 17;
            pictureBoxThoat.TabStop = false;
            pictureBoxThoat.Click += pictureBoxThoat_Click;
            // 
            // comboBoxChucVu
            // 
            comboBoxChucVu.FormattingEnabled = true;
            comboBoxChucVu.Location = new Point(56, 109);
            comboBoxChucVu.Name = "comboBoxChucVu";
            comboBoxChucVu.Size = new Size(256, 28);
            comboBoxChucVu.TabIndex = 16;
            comboBoxChucVu.Text = "Chọn chức vụ";
            comboBoxChucVu.SelectedIndexChanged += comboBoxChucVu_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(421, 32);
            label1.Name = "label1";
            label1.Size = new Size(213, 31);
            label1.TabIndex = 14;
            label1.Text = "THÊM NHÂN VIÊN";
            label1.Click += label1_Click;
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.Anchor = AnchorStyles.None;
            textBoxDiaChi.BackColor = SystemColors.Control;
            textBoxDiaChi.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiaChi.Location = new Point(250, 314);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.Size = new Size(288, 27);
            textBoxDiaChi.TabIndex = 20;
            // 
            // textBoxCCCD
            // 
            textBoxCCCD.Anchor = AnchorStyles.None;
            textBoxCCCD.BackColor = SystemColors.Control;
            textBoxCCCD.BorderStyle = BorderStyle.FixedSingle;
            textBoxCCCD.Location = new Point(253, 261);
            textBoxCCCD.Name = "textBoxCCCD";
            textBoxCCCD.Size = new Size(281, 27);
            textBoxCCCD.TabIndex = 19;
            // 
            // textBoxSDT
            // 
            textBoxSDT.Anchor = AnchorStyles.None;
            textBoxSDT.BackColor = SystemColors.Control;
            textBoxSDT.BorderStyle = BorderStyle.FixedSingle;
            textBoxSDT.Location = new Point(254, 211);
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.Size = new Size(280, 27);
            textBoxSDT.TabIndex = 18;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.None;
            textBoxEmail.BackColor = SystemColors.Control;
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Location = new Point(255, 161);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(277, 27);
            textBoxEmail.TabIndex = 17;
            // 
            // textBoxHoTen
            // 
            textBoxHoTen.Anchor = AnchorStyles.None;
            textBoxHoTen.BackColor = SystemColors.Control;
            textBoxHoTen.BorderStyle = BorderStyle.FixedSingle;
            textBoxHoTen.Location = new Point(258, 11);
            textBoxHoTen.Name = "textBoxHoTen";
            textBoxHoTen.Size = new Size(271, 27);
            textBoxHoTen.TabIndex = 14;
            // 
            // tableLayoutPanelThongTinLichPhanCong
            // 
            tableLayoutPanelThongTinLichPhanCong.ColumnCount = 2;
            tableLayoutPanelThongTinLichPhanCong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.290844F));
            tableLayoutPanelThongTinLichPhanCong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.70916F));
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(comboBoxGioiTinh, 1, 2);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(numericUpDownLuong, 1, 7);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelLuong, 0, 7);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(dateTimePickerNgaySinh, 1, 1);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxDiaChi, 1, 6);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxCCCD, 1, 5);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxSDT, 1, 4);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxEmail, 1, 3);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelDiaChi, 0, 6);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelCCCD, 0, 5);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelEmail, 0, 3);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelHoTen, 0, 0);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelNgaySinh, 0, 1);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelGioiTinh, 0, 2);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelSDT, 0, 4);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxHoTen, 1, 0);
            tableLayoutPanelThongTinLichPhanCong.Location = new Point(368, 76);
            tableLayoutPanelThongTinLichPhanCong.Name = "tableLayoutPanelThongTinLichPhanCong";
            tableLayoutPanelThongTinLichPhanCong.RowCount = 8;
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanelThongTinLichPhanCong.Size = new Size(587, 409);
            tableLayoutPanelThongTinLichPhanCong.TabIndex = 15;
            // 
            // comboBoxGioiTinh
            // 
            comboBoxGioiTinh.Anchor = AnchorStyles.None;
            comboBoxGioiTinh.FormattingEnabled = true;
            comboBoxGioiTinh.Location = new Point(259, 111);
            comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            comboBoxGioiTinh.Size = new Size(269, 28);
            comboBoxGioiTinh.TabIndex = 21;
            // 
            // numericUpDownLuong
            // 
            numericUpDownLuong.Anchor = AnchorStyles.None;
            numericUpDownLuong.Increment = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownLuong.Location = new Point(249, 369);
            numericUpDownLuong.Maximum = new decimal(new int[] { 500000000, 0, 0, 0 });
            numericUpDownLuong.Minimum = new decimal(new int[] { 5000000, 0, 0, 0 });
            numericUpDownLuong.Name = "numericUpDownLuong";
            numericUpDownLuong.Size = new Size(289, 27);
            numericUpDownLuong.TabIndex = 20;
            numericUpDownLuong.Value = new decimal(new int[] { 5000000, 0, 0, 0 });
            // 
            // labelLuong
            // 
            labelLuong.Anchor = AnchorStyles.None;
            labelLuong.AutoSize = true;
            labelLuong.Font = new Font("Segoe UI", 10F);
            labelLuong.Location = new Point(69, 371);
            labelLuong.Name = "labelLuong";
            labelLuong.Size = new Size(62, 23);
            labelLuong.TabIndex = 21;
            labelLuong.Text = "Lương:";
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Anchor = AnchorStyles.None;
            dateTimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgaySinh.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgaySinh.Location = new Point(259, 61);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(269, 27);
            dateTimePickerNgaySinh.TabIndex = 20;
            dateTimePickerNgaySinh.Value = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dateTimePickerNgaySinh.ValueChanged += dateTimePickerNgaySinh_ValueChanged;
            // 
            // labelDiaChi
            // 
            labelDiaChi.Anchor = AnchorStyles.None;
            labelDiaChi.AutoSize = true;
            labelDiaChi.Font = new Font("Segoe UI", 10F);
            labelDiaChi.Location = new Point(67, 316);
            labelDiaChi.Name = "labelDiaChi";
            labelDiaChi.Size = new Size(66, 23);
            labelDiaChi.TabIndex = 12;
            labelDiaChi.Text = "Địa chỉ:";
            labelDiaChi.Click += label2_Click;
            // 
            // labelCCCD
            // 
            labelCCCD.Anchor = AnchorStyles.None;
            labelCCCD.AutoSize = true;
            labelCCCD.Font = new Font("Segoe UI", 10F);
            labelCCCD.Location = new Point(71, 263);
            labelCCCD.Name = "labelCCCD";
            labelCCCD.Size = new Size(59, 23);
            labelCCCD.TabIndex = 10;
            labelCCCD.Text = "CCCD:";
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.None;
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10F);
            labelEmail.Location = new Point(73, 163);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(55, 23);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email:";
            // 
            // labelHoTen
            // 
            labelHoTen.Anchor = AnchorStyles.None;
            labelHoTen.AutoSize = true;
            labelHoTen.Font = new Font("Segoe UI", 10F);
            labelHoTen.Location = new Point(67, 13);
            labelHoTen.Name = "labelHoTen";
            labelHoTen.Size = new Size(66, 23);
            labelHoTen.TabIndex = 0;
            labelHoTen.Text = "Họ tên:";
            // 
            // labelNgaySinh
            // 
            labelNgaySinh.Anchor = AnchorStyles.None;
            labelNgaySinh.AutoSize = true;
            labelNgaySinh.Font = new Font("Segoe UI", 10F);
            labelNgaySinh.Location = new Point(55, 63);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new Size(90, 23);
            labelNgaySinh.TabIndex = 2;
            labelNgaySinh.Text = "Ngày sinh:";
            // 
            // labelGioiTinh
            // 
            labelGioiTinh.Anchor = AnchorStyles.None;
            labelGioiTinh.AutoSize = true;
            labelGioiTinh.Font = new Font("Segoe UI", 10F);
            labelGioiTinh.Location = new Point(61, 113);
            labelGioiTinh.Name = "labelGioiTinh";
            labelGioiTinh.Size = new Size(79, 23);
            labelGioiTinh.TabIndex = 3;
            labelGioiTinh.Text = "Giới tính:";
            // 
            // labelSDT
            // 
            labelSDT.Anchor = AnchorStyles.None;
            labelSDT.AutoSize = true;
            labelSDT.Font = new Font("Segoe UI", 10F);
            labelSDT.Location = new Point(43, 213);
            labelSDT.Name = "labelSDT";
            labelSDT.Size = new Size(115, 23);
            labelSDT.TabIndex = 7;
            labelSDT.Text = "Số điện thoại:";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Location = new Point(835, 500);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(156, 37);
            button1.TabIndex = 19;
            button1.Text = "Lưu thông tin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxPhongBan
            // 
            textBoxPhongBan.BackColor = SystemColors.MenuBar;
            textBoxPhongBan.BorderStyle = BorderStyle.FixedSingle;
            textBoxPhongBan.Location = new Point(56, 185);
            textBoxPhongBan.Name = "textBoxPhongBan";
            textBoxPhongBan.PlaceholderText = "Tên phòng ban";
            textBoxPhongBan.ReadOnly = true;
            textBoxPhongBan.Size = new Size(257, 27);
            textBoxPhongBan.TabIndex = 20;
            // 
            // fAdminThemNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1032, 558);
            Controls.Add(textBoxPhongBan);
            Controls.Add(button1);
            Controls.Add(pictureBoxThoat);
            Controls.Add(comboBoxChucVu);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanelThongTinLichPhanCong);
            Name = "fAdminThemNV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAdminThemNV";
            Load += fAdminThemNV_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxThoat).EndInit();
            tableLayoutPanelThongTinLichPhanCong.ResumeLayout(false);
            tableLayoutPanelThongTinLichPhanCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxThoat;
        private ComboBox comboBoxChucVu;
        private Label label1;
        private TextBox textBoxDiaChi;
        private TextBox textBoxCCCD;
        private TextBox textBoxSDT;
        private TextBox textBoxEmail;
        private TextBox textBoxHoTen;
        private TableLayoutPanel tableLayoutPanelThongTinLichPhanCong;
        private Label labelDiaChi;
        private Label labelCCCD;
        private Label labelEmail;
        private Label labelHoTen;
        private Label labelNgaySinh;
        private Label labelGioiTinh;
        private Label labelSDT;
        private Button button1;
        private DateTimePicker dateTimePickerNgaySinh;
        private NumericUpDown numericUpDownLuong;
        private Label labelLuong;
        private TextBox textBoxPhongBan;
        private ComboBox comboBoxGioiTinh;
    }
}