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
            comboBoxLichThi = new ComboBox();
            pictureBoxThoat = new PictureBox();
            comboBoxKyThi = new ComboBox();
            label1 = new Label();
            textBoxTenNVCoiThi = new TextBox();
            textBoxMaNVCoiThi = new TextBox();
            textBoxTGKetThuc = new TextBox();
            textBoxTGBatDau = new TextBox();
            textBoxPhongThi = new TextBox();
            textBoxKyThi = new TextBox();
            tableLayoutPanelThongTinLichPhanCong = new TableLayoutPanel();
            numericUpDownLuong = new NumericUpDown();
            label3 = new Label();
            dateTimePickerNgaySinh = new DateTimePicker();
            label2 = new Label();
            labelMaNVCoithi = new Label();
            labelTGBatDau = new Label();
            labelKyThi = new Label();
            labelNgayThi = new Label();
            labelPhongThi = new Label();
            labelTGKetThuc = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThoat).BeginInit();
            tableLayoutPanelThongTinLichPhanCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLuong).BeginInit();
            SuspendLayout();
            // 
            // comboBoxLichThi
            // 
            comboBoxLichThi.FormattingEnabled = true;
            comboBoxLichThi.Location = new Point(56, 113);
            comboBoxLichThi.Name = "comboBoxLichThi";
            comboBoxLichThi.Size = new Size(256, 28);
            comboBoxLichThi.TabIndex = 18;
            comboBoxLichThi.Text = "Chọn phòng ban";
            comboBoxLichThi.SelectedIndexChanged += comboBoxLichThi_SelectedIndexChanged;
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
            // comboBoxKyThi
            // 
            comboBoxKyThi.FormattingEnabled = true;
            comboBoxKyThi.Location = new Point(56, 175);
            comboBoxKyThi.Name = "comboBoxKyThi";
            comboBoxKyThi.Size = new Size(256, 28);
            comboBoxKyThi.TabIndex = 16;
            comboBoxKyThi.Text = "Chọn chức vụ";
            comboBoxKyThi.SelectedIndexChanged += comboBoxKyThi_SelectedIndexChanged;
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
            // textBoxTenNVCoiThi
            // 
            textBoxTenNVCoiThi.Anchor = AnchorStyles.None;
            textBoxTenNVCoiThi.BackColor = SystemColors.Control;
            textBoxTenNVCoiThi.BorderStyle = BorderStyle.FixedSingle;
            textBoxTenNVCoiThi.Location = new Point(250, 314);
            textBoxTenNVCoiThi.Name = "textBoxTenNVCoiThi";
            textBoxTenNVCoiThi.Size = new Size(288, 27);
            textBoxTenNVCoiThi.TabIndex = 20;
            // 
            // textBoxMaNVCoiThi
            // 
            textBoxMaNVCoiThi.Anchor = AnchorStyles.None;
            textBoxMaNVCoiThi.BackColor = SystemColors.Control;
            textBoxMaNVCoiThi.BorderStyle = BorderStyle.FixedSingle;
            textBoxMaNVCoiThi.Location = new Point(253, 261);
            textBoxMaNVCoiThi.Name = "textBoxMaNVCoiThi";
            textBoxMaNVCoiThi.Size = new Size(281, 27);
            textBoxMaNVCoiThi.TabIndex = 19;
            // 
            // textBoxTGKetThuc
            // 
            textBoxTGKetThuc.Anchor = AnchorStyles.None;
            textBoxTGKetThuc.BackColor = SystemColors.Control;
            textBoxTGKetThuc.BorderStyle = BorderStyle.FixedSingle;
            textBoxTGKetThuc.Location = new Point(254, 211);
            textBoxTGKetThuc.Name = "textBoxTGKetThuc";
            textBoxTGKetThuc.Size = new Size(280, 27);
            textBoxTGKetThuc.TabIndex = 18;
            // 
            // textBoxTGBatDau
            // 
            textBoxTGBatDau.Anchor = AnchorStyles.None;
            textBoxTGBatDau.BackColor = SystemColors.Control;
            textBoxTGBatDau.BorderStyle = BorderStyle.FixedSingle;
            textBoxTGBatDau.Location = new Point(255, 161);
            textBoxTGBatDau.Name = "textBoxTGBatDau";
            textBoxTGBatDau.Size = new Size(277, 27);
            textBoxTGBatDau.TabIndex = 17;
            // 
            // textBoxPhongThi
            // 
            textBoxPhongThi.Anchor = AnchorStyles.None;
            textBoxPhongThi.BackColor = SystemColors.Control;
            textBoxPhongThi.BorderStyle = BorderStyle.FixedSingle;
            textBoxPhongThi.Location = new Point(256, 111);
            textBoxPhongThi.Name = "textBoxPhongThi";
            textBoxPhongThi.Size = new Size(276, 27);
            textBoxPhongThi.TabIndex = 16;
            // 
            // textBoxKyThi
            // 
            textBoxKyThi.Anchor = AnchorStyles.None;
            textBoxKyThi.BackColor = SystemColors.Control;
            textBoxKyThi.BorderStyle = BorderStyle.FixedSingle;
            textBoxKyThi.Location = new Point(258, 11);
            textBoxKyThi.Name = "textBoxKyThi";
            textBoxKyThi.Size = new Size(271, 27);
            textBoxKyThi.TabIndex = 14;
            // 
            // tableLayoutPanelThongTinLichPhanCong
            // 
            tableLayoutPanelThongTinLichPhanCong.ColumnCount = 2;
            tableLayoutPanelThongTinLichPhanCong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.290844F));
            tableLayoutPanelThongTinLichPhanCong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.70916F));
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(numericUpDownLuong, 1, 7);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(label3, 0, 7);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(dateTimePickerNgaySinh, 1, 1);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxTenNVCoiThi, 1, 6);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxMaNVCoiThi, 1, 5);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxTGKetThuc, 1, 4);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxTGBatDau, 1, 3);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxPhongThi, 1, 2);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(label2, 0, 6);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelMaNVCoithi, 0, 5);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelTGBatDau, 0, 3);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelKyThi, 0, 0);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelNgayThi, 0, 1);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelPhongThi, 0, 2);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelTGKetThuc, 0, 4);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxKyThi, 1, 0);
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
            // numericUpDownLuong
            // 
            numericUpDownLuong.Anchor = AnchorStyles.None;
            numericUpDownLuong.Location = new Point(249, 369);
            numericUpDownLuong.Maximum = new decimal(new int[] { 500000000, 0, 0, 0 });
            numericUpDownLuong.Minimum = new decimal(new int[] { 5000000, 0, 0, 0 });
            numericUpDownLuong.Name = "numericUpDownLuong";
            numericUpDownLuong.Size = new Size(289, 27);
            numericUpDownLuong.TabIndex = 20;
            numericUpDownLuong.Value = new decimal(new int[] { 5000000, 0, 0, 0 });
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(69, 371);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 21;
            label3.Text = "Lương:";
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
            dateTimePickerNgaySinh.ValueChanged += dateTimePickerNgaySinh_ValueChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(67, 316);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 12;
            label2.Text = "Địa chỉ:";
            label2.Click += label2_Click;
            // 
            // labelMaNVCoithi
            // 
            labelMaNVCoithi.Anchor = AnchorStyles.None;
            labelMaNVCoithi.AutoSize = true;
            labelMaNVCoithi.Font = new Font("Segoe UI", 10F);
            labelMaNVCoithi.Location = new Point(71, 263);
            labelMaNVCoithi.Name = "labelMaNVCoithi";
            labelMaNVCoithi.Size = new Size(59, 23);
            labelMaNVCoithi.TabIndex = 10;
            labelMaNVCoithi.Text = "CCCD:";
            // 
            // labelTGBatDau
            // 
            labelTGBatDau.Anchor = AnchorStyles.None;
            labelTGBatDau.AutoSize = true;
            labelTGBatDau.Font = new Font("Segoe UI", 10F);
            labelTGBatDau.Location = new Point(73, 163);
            labelTGBatDau.Name = "labelTGBatDau";
            labelTGBatDau.Size = new Size(55, 23);
            labelTGBatDau.TabIndex = 6;
            labelTGBatDau.Text = "Email:";
            // 
            // labelKyThi
            // 
            labelKyThi.Anchor = AnchorStyles.None;
            labelKyThi.AutoSize = true;
            labelKyThi.Font = new Font("Segoe UI", 10F);
            labelKyThi.Location = new Point(67, 13);
            labelKyThi.Name = "labelKyThi";
            labelKyThi.Size = new Size(66, 23);
            labelKyThi.TabIndex = 0;
            labelKyThi.Text = "Họ tên:";
            // 
            // labelNgayThi
            // 
            labelNgayThi.Anchor = AnchorStyles.None;
            labelNgayThi.AutoSize = true;
            labelNgayThi.Font = new Font("Segoe UI", 10F);
            labelNgayThi.Location = new Point(55, 63);
            labelNgayThi.Name = "labelNgayThi";
            labelNgayThi.Size = new Size(90, 23);
            labelNgayThi.TabIndex = 2;
            labelNgayThi.Text = "Ngày sinh:";
            // 
            // labelPhongThi
            // 
            labelPhongThi.Anchor = AnchorStyles.None;
            labelPhongThi.AutoSize = true;
            labelPhongThi.Font = new Font("Segoe UI", 10F);
            labelPhongThi.Location = new Point(61, 113);
            labelPhongThi.Name = "labelPhongThi";
            labelPhongThi.Size = new Size(79, 23);
            labelPhongThi.TabIndex = 3;
            labelPhongThi.Text = "Giới tính:";
            // 
            // labelTGKetThuc
            // 
            labelTGKetThuc.Anchor = AnchorStyles.None;
            labelTGKetThuc.AutoSize = true;
            labelTGKetThuc.Font = new Font("Segoe UI", 10F);
            labelTGKetThuc.Location = new Point(43, 213);
            labelTGKetThuc.Name = "labelTGKetThuc";
            labelTGKetThuc.Size = new Size(115, 23);
            labelTGKetThuc.TabIndex = 7;
            labelTGKetThuc.Text = "Số điện thoại:";
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
            // fAdminThemNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1032, 558);
            Controls.Add(button1);
            Controls.Add(comboBoxLichThi);
            Controls.Add(pictureBoxThoat);
            Controls.Add(comboBoxKyThi);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanelThongTinLichPhanCong);
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
        private ComboBox comboBoxLichThi;
        private PictureBox pictureBoxThoat;
        private ComboBox comboBoxKyThi;
        private Label label1;
        private TextBox textBoxTenNVCoiThi;
        private TextBox textBoxMaNVCoiThi;
        private TextBox textBoxTGKetThuc;
        private TextBox textBoxTGBatDau;
        private TextBox textBoxPhongThi;
        private TextBox textBoxKyThi;
        private TableLayoutPanel tableLayoutPanelThongTinLichPhanCong;
        private Label label2;
        private Label labelMaNVCoithi;
        private Label labelTGBatDau;
        private Label labelKyThi;
        private Label labelNgayThi;
        private Label labelPhongThi;
        private Label labelTGKetThuc;
        private Button button1;
        private DateTimePicker dateTimePickerNgaySinh;
        private NumericUpDown numericUpDownLuong;
        private Label label3;
    }
}