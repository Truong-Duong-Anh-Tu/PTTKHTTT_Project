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
            comboBoxPhongBan = new ComboBox();
            pictureBoxThoat = new PictureBox();
            comboBoxChucVu = new ComboBox();
            label1 = new Label();
            textBoxDiaChi = new TextBox();
            textBoxCCCD = new TextBox();
            textBoxSDT = new TextBox();
            textBoxEmail = new TextBox();
            textBoxGioiTinh = new TextBox();
            textBoxHoTen = new TextBox();
            tableLayoutPanelThongTinLichPhanCong = new TableLayoutPanel();
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxThoat).BeginInit();
            tableLayoutPanelThongTinLichPhanCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLuong).BeginInit();
            SuspendLayout();
            // 
            // comboBoxPhongBan
            // 
            comboBoxPhongBan.FormattingEnabled = true;
            comboBoxPhongBan.Location = new Point(91, 181);
            comboBoxPhongBan.Margin = new Padding(5, 5, 5, 5);
            comboBoxPhongBan.Name = "comboBoxPhongBan";
            comboBoxPhongBan.Size = new Size(414, 40);
            comboBoxPhongBan.TabIndex = 18;
            comboBoxPhongBan.Text = "Chọn phòng ban";
            comboBoxPhongBan.SelectedIndexChanged += comboBoxLichThi_SelectedIndexChanged;
            // 
            // pictureBoxThoat
            // 
            pictureBoxThoat.Image = Properties.Resources.exit;
            pictureBoxThoat.Location = new Point(91, 51);
            pictureBoxThoat.Margin = new Padding(5, 5, 5, 5);
            pictureBoxThoat.Name = "pictureBoxThoat";
            pictureBoxThoat.Size = new Size(96, 50);
            pictureBoxThoat.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxThoat.TabIndex = 17;
            pictureBoxThoat.TabStop = false;
            pictureBoxThoat.Click += pictureBoxThoat_Click;
            // 
            // comboBoxChucVu
            // 
            comboBoxChucVu.FormattingEnabled = true;
            comboBoxChucVu.Location = new Point(91, 280);
            comboBoxChucVu.Margin = new Padding(5, 5, 5, 5);
            comboBoxChucVu.Name = "comboBoxChucVu";
            comboBoxChucVu.Size = new Size(414, 40);
            comboBoxChucVu.TabIndex = 16;
            comboBoxChucVu.Text = "Chọn chức vụ";
            comboBoxChucVu.SelectedIndexChanged += comboBoxKyThi_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(684, 51);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(345, 50);
            label1.TabIndex = 14;
            label1.Text = "THÊM NHÂN VIÊN";
            label1.Click += label1_Click;
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.Anchor = AnchorStyles.None;
            textBoxDiaChi.BackColor = SystemColors.Control;
            textBoxDiaChi.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiaChi.Location = new Point(407, 505);
            textBoxDiaChi.Margin = new Padding(5, 5, 5, 5);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.Size = new Size(467, 39);
            textBoxDiaChi.TabIndex = 20;
            // 
            // textBoxCCCD
            // 
            textBoxCCCD.Anchor = AnchorStyles.None;
            textBoxCCCD.BackColor = SystemColors.Control;
            textBoxCCCD.BorderStyle = BorderStyle.FixedSingle;
            textBoxCCCD.Location = new Point(413, 419);
            textBoxCCCD.Margin = new Padding(5, 5, 5, 5);
            textBoxCCCD.Name = "textBoxCCCD";
            textBoxCCCD.Size = new Size(455, 39);
            textBoxCCCD.TabIndex = 19;
            // 
            // textBoxSDT
            // 
            textBoxSDT.Anchor = AnchorStyles.None;
            textBoxSDT.BackColor = SystemColors.Control;
            textBoxSDT.BorderStyle = BorderStyle.FixedSingle;
            textBoxSDT.Location = new Point(413, 340);
            textBoxSDT.Margin = new Padding(5, 5, 5, 5);
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.Size = new Size(454, 39);
            textBoxSDT.TabIndex = 18;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.None;
            textBoxEmail.BackColor = SystemColors.Control;
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Location = new Point(416, 260);
            textBoxEmail.Margin = new Padding(5, 5, 5, 5);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(449, 39);
            textBoxEmail.TabIndex = 17;
            // 
            // textBoxGioiTinh
            // 
            textBoxGioiTinh.Anchor = AnchorStyles.None;
            textBoxGioiTinh.BackColor = SystemColors.Control;
            textBoxGioiTinh.BorderStyle = BorderStyle.FixedSingle;
            textBoxGioiTinh.Location = new Point(417, 180);
            textBoxGioiTinh.Margin = new Padding(5, 5, 5, 5);
            textBoxGioiTinh.Name = "textBoxGioiTinh";
            textBoxGioiTinh.Size = new Size(447, 39);
            textBoxGioiTinh.TabIndex = 16;
            // 
            // textBoxHoTen
            // 
            textBoxHoTen.Anchor = AnchorStyles.None;
            textBoxHoTen.BackColor = SystemColors.Control;
            textBoxHoTen.BorderStyle = BorderStyle.FixedSingle;
            textBoxHoTen.Location = new Point(421, 20);
            textBoxHoTen.Margin = new Padding(5, 5, 5, 5);
            textBoxHoTen.Name = "textBoxHoTen";
            textBoxHoTen.Size = new Size(439, 39);
            textBoxHoTen.TabIndex = 14;
            // 
            // tableLayoutPanelThongTinLichPhanCong
            // 
            tableLayoutPanelThongTinLichPhanCong.ColumnCount = 2;
            tableLayoutPanelThongTinLichPhanCong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.290844F));
            tableLayoutPanelThongTinLichPhanCong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.70916F));
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(numericUpDownLuong, 1, 7);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelLuong, 0, 7);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(dateTimePickerNgaySinh, 1, 1);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxDiaChi, 1, 6);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxCCCD, 1, 5);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxSDT, 1, 4);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxEmail, 1, 3);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxGioiTinh, 1, 2);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelDiaChi, 0, 6);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelCCCD, 0, 5);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelEmail, 0, 3);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelHoTen, 0, 0);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelNgaySinh, 0, 1);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelGioiTinh, 0, 2);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelSDT, 0, 4);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxHoTen, 1, 0);
            tableLayoutPanelThongTinLichPhanCong.Location = new Point(598, 122);
            tableLayoutPanelThongTinLichPhanCong.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanelThongTinLichPhanCong.Name = "tableLayoutPanelThongTinLichPhanCong";
            tableLayoutPanelThongTinLichPhanCong.RowCount = 8;
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanelThongTinLichPhanCong.Size = new Size(954, 654);
            tableLayoutPanelThongTinLichPhanCong.TabIndex = 15;
            // 
            // numericUpDownLuong
            // 
            numericUpDownLuong.Anchor = AnchorStyles.None;
            numericUpDownLuong.Location = new Point(405, 593);
            numericUpDownLuong.Margin = new Padding(5, 5, 5, 5);
            numericUpDownLuong.Maximum = new decimal(new int[] { 500000000, 0, 0, 0 });
            numericUpDownLuong.Minimum = new decimal(new int[] { 5000000, 0, 0, 0 });
            numericUpDownLuong.Name = "numericUpDownLuong";
            numericUpDownLuong.Size = new Size(470, 39);
            numericUpDownLuong.TabIndex = 20;
            numericUpDownLuong.Value = new decimal(new int[] { 5000000, 0, 0, 0 });
            // 
            // labelLuong
            // 
            labelLuong.Anchor = AnchorStyles.None;
            labelLuong.AutoSize = true;
            labelLuong.Font = new Font("Segoe UI", 10F);
            labelLuong.Location = new Point(114, 594);
            labelLuong.Margin = new Padding(5, 0, 5, 0);
            labelLuong.Name = "labelLuong";
            labelLuong.Size = new Size(99, 37);
            labelLuong.TabIndex = 21;
            labelLuong.Text = "Lương:";
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Anchor = AnchorStyles.None;
            dateTimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgaySinh.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgaySinh.Location = new Point(423, 100);
            dateTimePickerNgaySinh.Margin = new Padding(5, 5, 5, 5);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(435, 39);
            dateTimePickerNgaySinh.TabIndex = 20;
            dateTimePickerNgaySinh.ValueChanged += dateTimePickerNgaySinh_ValueChanged;
            // 
            // labelDiaChi
            // 
            labelDiaChi.Anchor = AnchorStyles.None;
            labelDiaChi.AutoSize = true;
            labelDiaChi.Font = new Font("Segoe UI", 10F);
            labelDiaChi.Location = new Point(111, 506);
            labelDiaChi.Margin = new Padding(5, 0, 5, 0);
            labelDiaChi.Name = "labelDiaChi";
            labelDiaChi.Size = new Size(104, 37);
            labelDiaChi.TabIndex = 12;
            labelDiaChi.Text = "Địa chỉ:";
            labelDiaChi.Click += label2_Click;
            // 
            // labelCCCD
            // 
            labelCCCD.Anchor = AnchorStyles.None;
            labelCCCD.AutoSize = true;
            labelCCCD.Font = new Font("Segoe UI", 10F);
            labelCCCD.Location = new Point(118, 420);
            labelCCCD.Margin = new Padding(5, 0, 5, 0);
            labelCCCD.Name = "labelCCCD";
            labelCCCD.Size = new Size(91, 37);
            labelCCCD.TabIndex = 10;
            labelCCCD.Text = "CCCD:";
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.None;
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10F);
            labelEmail.Location = new Point(119, 261);
            labelEmail.Margin = new Padding(5, 0, 5, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(88, 37);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email:";
            // 
            // labelHoTen
            // 
            labelHoTen.Anchor = AnchorStyles.None;
            labelHoTen.AutoSize = true;
            labelHoTen.Font = new Font("Segoe UI", 10F);
            labelHoTen.Location = new Point(112, 21);
            labelHoTen.Margin = new Padding(5, 0, 5, 0);
            labelHoTen.Name = "labelHoTen";
            labelHoTen.Size = new Size(103, 37);
            labelHoTen.TabIndex = 0;
            labelHoTen.Text = "Họ tên:";
            // 
            // labelNgaySinh
            // 
            labelNgaySinh.Anchor = AnchorStyles.None;
            labelNgaySinh.AutoSize = true;
            labelNgaySinh.Font = new Font("Segoe UI", 10F);
            labelNgaySinh.Location = new Point(93, 101);
            labelNgaySinh.Margin = new Padding(5, 0, 5, 0);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new Size(141, 37);
            labelNgaySinh.TabIndex = 2;
            labelNgaySinh.Text = "Ngày sinh:";
            // 
            // labelGioiTinh
            // 
            labelGioiTinh.Anchor = AnchorStyles.None;
            labelGioiTinh.AutoSize = true;
            labelGioiTinh.Font = new Font("Segoe UI", 10F);
            labelGioiTinh.Location = new Point(101, 181);
            labelGioiTinh.Margin = new Padding(5, 0, 5, 0);
            labelGioiTinh.Name = "labelGioiTinh";
            labelGioiTinh.Size = new Size(125, 37);
            labelGioiTinh.TabIndex = 3;
            labelGioiTinh.Text = "Giới tính:";
            // 
            // labelSDT
            // 
            labelSDT.Anchor = AnchorStyles.None;
            labelSDT.AutoSize = true;
            labelSDT.Font = new Font("Segoe UI", 10F);
            labelSDT.Location = new Point(73, 341);
            labelSDT.Margin = new Padding(5, 0, 5, 0);
            labelSDT.Name = "labelSDT";
            labelSDT.Size = new Size(180, 37);
            labelSDT.TabIndex = 7;
            labelSDT.Text = "Số điện thoại:";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Location = new Point(1357, 800);
            button1.Name = "button1";
            button1.Size = new Size(254, 59);
            button1.TabIndex = 19;
            button1.Text = "Lưu thông tin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // fAdminThemNV
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1677, 893);
            Controls.Add(button1);
            Controls.Add(comboBoxPhongBan);
            Controls.Add(pictureBoxThoat);
            Controls.Add(comboBoxChucVu);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanelThongTinLichPhanCong);
            Margin = new Padding(5, 5, 5, 5);
            Name = "fAdminThemNV";
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
        private ComboBox comboBoxPhongBan;
        private PictureBox pictureBoxThoat;
        private ComboBox comboBoxChucVu;
        private Label label1;
        private TextBox textBoxDiaChi;
        private TextBox textBoxCCCD;
        private TextBox textBoxSDT;
        private TextBox textBoxEmail;
        private TextBox textBoxGioiTinh;
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
    }
}