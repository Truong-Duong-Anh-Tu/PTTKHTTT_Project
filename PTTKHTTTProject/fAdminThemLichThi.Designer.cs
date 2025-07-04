namespace PTTKHTTTProject
{
    partial class fAdminThemLichThi
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
            labelTGBatDau = new Label();
            labelPhongThi = new Label();
            labelTenKyThi = new Label();
            labelSLDangKy = new Label();
            buttonLuuThongTin = new Button();
            pictureBoxThoat = new PictureBox();
            labelThemLichThi = new Label();
            tableLayoutPanelThongTinLichPhanCong = new TableLayoutPanel();
            dateTimePickerTGKetThuc = new DateTimePicker();
            textBoxTenKyThi = new TextBox();
            dateTimePickerNgayThi = new DateTimePicker();
            textBoxTrangThai = new TextBox();
            textBoxSLDangKy = new TextBox();
            textBoxHienThiPhongThi = new TextBox();
            dateTimePickerTGBatDau = new DateTimePicker();
            labelTGKetThuc = new Label();
            labelNgayThi = new Label();
            labelTrangThai = new Label();
            dataGridViewKyThi = new DataGridView();
            labelDSKyThi = new Label();
            labelDSPhongTrong = new Label();
            dataGridViewPhongTrong = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThoat).BeginInit();
            tableLayoutPanelThongTinLichPhanCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKyThi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPhongTrong).BeginInit();
            SuspendLayout();
            // 
            // labelTGBatDau
            // 
            labelTGBatDau.Anchor = AnchorStyles.None;
            labelTGBatDau.AutoSize = true;
            labelTGBatDau.Font = new Font("Segoe UI", 10F);
            labelTGBatDau.Location = new Point(20, 298);
            labelTGBatDau.Name = "labelTGBatDau";
            labelTGBatDau.Size = new Size(149, 23);
            labelTGBatDau.TabIndex = 12;
            labelTGBatDau.Text = "Thời gian bắt đầu:";
            // 
            // labelPhongThi
            // 
            labelPhongThi.Anchor = AnchorStyles.None;
            labelPhongThi.AutoSize = true;
            labelPhongThi.Font = new Font("Segoe UI", 10F);
            labelPhongThi.Location = new Point(50, 236);
            labelPhongThi.Name = "labelPhongThi";
            labelPhongThi.Size = new Size(89, 23);
            labelPhongThi.TabIndex = 10;
            labelPhongThi.Text = "Phòng thi:";
            // 
            // labelTenKyThi
            // 
            labelTenKyThi.Anchor = AnchorStyles.None;
            labelTenKyThi.AutoSize = true;
            labelTenKyThi.Font = new Font("Segoe UI", 10F);
            labelTenKyThi.Location = new Point(52, 13);
            labelTenKyThi.Name = "labelTenKyThi";
            labelTenKyThi.Size = new Size(86, 23);
            labelTenKyThi.TabIndex = 2;
            labelTenKyThi.Text = "Tên kỳ thi:";
            // 
            // labelSLDangKy
            // 
            labelSLDangKy.Anchor = AnchorStyles.None;
            labelSLDangKy.AutoSize = true;
            labelSLDangKy.Font = new Font("Segoe UI", 10F);
            labelSLDangKy.Location = new Point(9, 176);
            labelSLDangKy.Name = "labelSLDangKy";
            labelSLDangKy.Size = new Size(171, 23);
            labelSLDangKy.TabIndex = 7;
            labelSLDangKy.Text = "Số lượng đã đăng ký:";
            // 
            // buttonLuuThongTin
            // 
            buttonLuuThongTin.BackColor = Color.PaleTurquoise;
            buttonLuuThongTin.Location = new Point(805, 528);
            buttonLuuThongTin.Margin = new Padding(2);
            buttonLuuThongTin.Name = "buttonLuuThongTin";
            buttonLuuThongTin.Size = new Size(156, 37);
            buttonLuuThongTin.TabIndex = 25;
            buttonLuuThongTin.Text = "Lưu thông tin";
            buttonLuuThongTin.UseVisualStyleBackColor = false;
            // 
            // pictureBoxThoat
            // 
            pictureBoxThoat.Image = Properties.Resources.exit;
            pictureBoxThoat.Location = new Point(28, 18);
            pictureBoxThoat.Name = "pictureBoxThoat";
            pictureBoxThoat.Size = new Size(59, 31);
            pictureBoxThoat.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxThoat.TabIndex = 23;
            pictureBoxThoat.TabStop = false;
            pictureBoxThoat.Click += pictureBoxThoat_Click;
            // 
            // labelThemLichThi
            // 
            labelThemLichThi.AutoSize = true;
            labelThemLichThi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelThemLichThi.Location = new Point(394, 18);
            labelThemLichThi.Name = "labelThemLichThi";
            labelThemLichThi.Size = new Size(180, 31);
            labelThemLichThi.TabIndex = 20;
            labelThemLichThi.Text = "THÊM LỊCH THI";
            // 
            // tableLayoutPanelThongTinLichPhanCong
            // 
            tableLayoutPanelThongTinLichPhanCong.ColumnCount = 2;
            tableLayoutPanelThongTinLichPhanCong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.290844F));
            tableLayoutPanelThongTinLichPhanCong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.70916F));
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(dateTimePickerTGKetThuc, 1, 6);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelTenKyThi, 0, 0);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxTenKyThi, 1, 0);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(dateTimePickerNgayThi, 1, 1);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxTrangThai, 1, 2);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelSLDangKy, 0, 3);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxSLDangKy, 1, 3);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelPhongThi, 0, 4);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxHienThiPhongThi, 1, 4);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelTGBatDau, 0, 5);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(dateTimePickerTGBatDau, 1, 5);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelTGKetThuc, 0, 6);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelNgayThi, 0, 1);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelTrangThai, 0, 2);
            tableLayoutPanelThongTinLichPhanCong.Location = new Point(405, 111);
            tableLayoutPanelThongTinLichPhanCong.Name = "tableLayoutPanelThongTinLichPhanCong";
            tableLayoutPanelThongTinLichPhanCong.RowCount = 7;
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanelThongTinLichPhanCong.Size = new Size(556, 409);
            tableLayoutPanelThongTinLichPhanCong.TabIndex = 21;
            tableLayoutPanelThongTinLichPhanCong.Paint += tableLayoutPanelThongTinLichPhanCong_Paint;
            // 
            // dateTimePickerTGKetThuc
            // 
            dateTimePickerTGKetThuc.Anchor = AnchorStyles.None;
            dateTimePickerTGKetThuc.CustomFormat = "HH:mm";
            dateTimePickerTGKetThuc.Format = DateTimePickerFormat.Custom;
            dateTimePickerTGKetThuc.Location = new Point(233, 362);
            dateTimePickerTGKetThuc.Name = "dateTimePickerTGKetThuc";
            dateTimePickerTGKetThuc.ShowUpDown = true;
            dateTimePickerTGKetThuc.Size = new Size(279, 27);
            dateTimePickerTGKetThuc.TabIndex = 31;
            // 
            // textBoxTenKyThi
            // 
            textBoxTenKyThi.Anchor = AnchorStyles.None;
            textBoxTenKyThi.BackColor = SystemColors.Control;
            textBoxTenKyThi.BorderStyle = BorderStyle.FixedSingle;
            textBoxTenKyThi.Location = new Point(236, 11);
            textBoxTenKyThi.Name = "textBoxTenKyThi";
            textBoxTenKyThi.Size = new Size(273, 27);
            textBoxTenKyThi.TabIndex = 16;
            // 
            // dateTimePickerNgayThi
            // 
            dateTimePickerNgayThi.Anchor = AnchorStyles.None;
            dateTimePickerNgayThi.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgayThi.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayThi.Location = new Point(238, 64);
            dateTimePickerNgayThi.Name = "dateTimePickerNgayThi";
            dateTimePickerNgayThi.Size = new Size(269, 27);
            dateTimePickerNgayThi.TabIndex = 20;
            // 
            // textBoxTrangThai
            // 
            textBoxTrangThai.Anchor = AnchorStyles.None;
            textBoxTrangThai.BackColor = SystemColors.Control;
            textBoxTrangThai.BorderStyle = BorderStyle.FixedSingle;
            textBoxTrangThai.Location = new Point(234, 117);
            textBoxTrangThai.Name = "textBoxTrangThai";
            textBoxTrangThai.ReadOnly = true;
            textBoxTrangThai.Size = new Size(277, 27);
            textBoxTrangThai.TabIndex = 17;
            textBoxTrangThai.Text = "Chưa thi";
            // 
            // textBoxSLDangKy
            // 
            textBoxSLDangKy.Anchor = AnchorStyles.None;
            textBoxSLDangKy.BackColor = SystemColors.Control;
            textBoxSLDangKy.BorderStyle = BorderStyle.FixedSingle;
            textBoxSLDangKy.Location = new Point(233, 174);
            textBoxSLDangKy.Name = "textBoxSLDangKy";
            textBoxSLDangKy.ReadOnly = true;
            textBoxSLDangKy.Size = new Size(280, 27);
            textBoxSLDangKy.TabIndex = 18;
            textBoxSLDangKy.Text = "0";
            // 
            // textBoxHienThiPhongThi
            // 
            textBoxHienThiPhongThi.Anchor = AnchorStyles.None;
            textBoxHienThiPhongThi.BackColor = SystemColors.Control;
            textBoxHienThiPhongThi.BorderStyle = BorderStyle.FixedSingle;
            textBoxHienThiPhongThi.Location = new Point(232, 234);
            textBoxHienThiPhongThi.Name = "textBoxHienThiPhongThi";
            textBoxHienThiPhongThi.Size = new Size(281, 27);
            textBoxHienThiPhongThi.TabIndex = 19;
            // 
            // dateTimePickerTGBatDau
            // 
            dateTimePickerTGBatDau.Anchor = AnchorStyles.None;
            dateTimePickerTGBatDau.CustomFormat = "HH:mm";
            dateTimePickerTGBatDau.Format = DateTimePickerFormat.Custom;
            dateTimePickerTGBatDau.Location = new Point(233, 296);
            dateTimePickerTGBatDau.Name = "dateTimePickerTGBatDau";
            dateTimePickerTGBatDau.ShowUpDown = true;
            dateTimePickerTGBatDau.Size = new Size(279, 27);
            dateTimePickerTGBatDau.TabIndex = 30;
            // 
            // labelTGKetThuc
            // 
            labelTGKetThuc.Anchor = AnchorStyles.None;
            labelTGKetThuc.AutoSize = true;
            labelTGKetThuc.Font = new Font("Segoe UI", 10F);
            labelTGKetThuc.Location = new Point(19, 364);
            labelTGKetThuc.Name = "labelTGKetThuc";
            labelTGKetThuc.Size = new Size(152, 23);
            labelTGKetThuc.TabIndex = 21;
            labelTGKetThuc.Text = "Thời gian kết thúc:";
            // 
            // labelNgayThi
            // 
            labelNgayThi.Anchor = AnchorStyles.None;
            labelNgayThi.AutoSize = true;
            labelNgayThi.Font = new Font("Segoe UI", 10F);
            labelNgayThi.Location = new Point(55, 66);
            labelNgayThi.Name = "labelNgayThi";
            labelNgayThi.Size = new Size(79, 23);
            labelNgayThi.TabIndex = 32;
            labelNgayThi.Text = "Ngày thi:";
            // 
            // labelTrangThai
            // 
            labelTrangThai.Anchor = AnchorStyles.None;
            labelTrangThai.AutoSize = true;
            labelTrangThai.Font = new Font("Segoe UI", 10F);
            labelTrangThai.Location = new Point(49, 119);
            labelTrangThai.Name = "labelTrangThai";
            labelTrangThai.Size = new Size(91, 23);
            labelTrangThai.TabIndex = 33;
            labelTrangThai.Text = "Trạng thái:";
            // 
            // dataGridViewKyThi
            // 
            dataGridViewKyThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKyThi.Location = new Point(28, 111);
            dataGridViewKyThi.Name = "dataGridViewKyThi";
            dataGridViewKyThi.RowHeadersWidth = 51;
            dataGridViewKyThi.Size = new Size(356, 173);
            dataGridViewKyThi.TabIndex = 26;
            dataGridViewKyThi.CellContentClick += dataGridViewKyThi_CellContentClick;
            // 
            // labelDSKyThi
            // 
            labelDSKyThi.AutoSize = true;
            labelDSKyThi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelDSKyThi.Location = new Point(28, 70);
            labelDSKyThi.Name = "labelDSKyThi";
            labelDSKyThi.Size = new Size(153, 25);
            labelDSKyThi.TabIndex = 27;
            labelDSKyThi.Text = "Danh sách kỳ thi";
            // 
            // labelDSPhongTrong
            // 
            labelDSPhongTrong.AutoSize = true;
            labelDSPhongTrong.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelDSPhongTrong.Location = new Point(28, 299);
            labelDSPhongTrong.Name = "labelDSPhongTrong";
            labelDSPhongTrong.Size = new Size(240, 25);
            labelDSPhongTrong.TabIndex = 28;
            labelDSPhongTrong.Text = "Danh sách phòng thi trống";
            // 
            // dataGridViewPhongTrong
            // 
            dataGridViewPhongTrong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPhongTrong.Location = new Point(28, 337);
            dataGridViewPhongTrong.Name = "dataGridViewPhongTrong";
            dataGridViewPhongTrong.RowHeadersWidth = 51;
            dataGridViewPhongTrong.Size = new Size(356, 183);
            dataGridViewPhongTrong.TabIndex = 29;
            // 
            // fAdminThemLichThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(981, 593);
            Controls.Add(dataGridViewPhongTrong);
            Controls.Add(labelDSPhongTrong);
            Controls.Add(labelDSKyThi);
            Controls.Add(dataGridViewKyThi);
            Controls.Add(buttonLuuThongTin);
            Controls.Add(pictureBoxThoat);
            Controls.Add(labelThemLichThi);
            Controls.Add(tableLayoutPanelThongTinLichPhanCong);
            Name = "fAdminThemLichThi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAdminThemLichThi";
            Load += fAdminThemLichThi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxThoat).EndInit();
            tableLayoutPanelThongTinLichPhanCong.ResumeLayout(false);
            tableLayoutPanelThongTinLichPhanCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKyThi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPhongTrong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxTenNVCoiThi;
        private TextBox textBoxMaNVCoiThi;
        private TextBox textBoxTGKetThuc;
        private Label label2;
        private Label labelMaNVCoithi;
        private Label labelTGBatDau;
        private Label labelTenKyThi;
        private Label labelPhongThi;
        private Label labelSLDangKy;
        private Button buttonLuuThongTin;
        private PictureBox pictureBoxThoat;
        private Label labelThemLichThi;
        private TableLayoutPanel tableLayoutPanelThongTinLichPhanCong;
        private DataGridView dataGridViewKyThi;
        private Label labelDSKyThi;
        private Label labelDSPhongTrong;
        private DataGridView dataGridViewPhongTrong;
        private DateTimePicker dateTimePickerTGKetThuc;
        private TextBox textBoxTenKyThi;
        private DateTimePicker dateTimePickerNgayThi;
        private TextBox textBoxTrangThai;
        private TextBox textBoxSLDangKy;
        private TextBox textBoxHienThiPhongThi;
        private DateTimePicker dateTimePickerTGBatDau;
        private Label labelTGKetThuc;
        private Label labelNgayThi;
        private Label labelTrangThai;
    }
}