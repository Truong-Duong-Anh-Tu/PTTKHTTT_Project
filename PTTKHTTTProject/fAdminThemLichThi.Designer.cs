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
            labelTGBatDau.Location = new Point(38, 476);
            labelTGBatDau.Margin = new Padding(5, 0, 5, 0);
            labelTGBatDau.Name = "labelTGBatDau";
            labelTGBatDau.Size = new Size(232, 37);
            labelTGBatDau.TabIndex = 12;
            labelTGBatDau.Text = "Thời gian bắt đầu:";
            // 
            // labelPhongThi
            // 
            labelPhongThi.Anchor = AnchorStyles.None;
            labelPhongThi.AutoSize = true;
            labelPhongThi.Font = new Font("Segoe UI", 10F);
            labelPhongThi.Location = new Point(85, 377);
            labelPhongThi.Margin = new Padding(5, 0, 5, 0);
            labelPhongThi.Name = "labelPhongThi";
            labelPhongThi.Size = new Size(138, 37);
            labelPhongThi.TabIndex = 10;
            labelPhongThi.Text = "Phòng thi:";
            // 
            // labelTenKyThi
            // 
            labelTenKyThi.Anchor = AnchorStyles.None;
            labelTenKyThi.AutoSize = true;
            labelTenKyThi.Font = new Font("Segoe UI", 10F);
            labelTenKyThi.Location = new Point(87, 21);
            labelTenKyThi.Margin = new Padding(5, 0, 5, 0);
            labelTenKyThi.Name = "labelTenKyThi";
            labelTenKyThi.Size = new Size(134, 37);
            labelTenKyThi.TabIndex = 2;
            labelTenKyThi.Text = "Tên kỳ thi:";
            // 
            // labelSLDangKy
            // 
            labelSLDangKy.Anchor = AnchorStyles.None;
            labelSLDangKy.AutoSize = true;
            labelSLDangKy.Font = new Font("Segoe UI", 10F);
            labelSLDangKy.Location = new Point(20, 281);
            labelSLDangKy.Margin = new Padding(5, 0, 5, 0);
            labelSLDangKy.Name = "labelSLDangKy";
            labelSLDangKy.Size = new Size(268, 37);
            labelSLDangKy.TabIndex = 7;
            labelSLDangKy.Text = "Số lượng đã đăng ký:";
            // 
            // buttonLuuThongTin
            // 
            buttonLuuThongTin.BackColor = Color.PaleTurquoise;
            buttonLuuThongTin.Location = new Point(1308, 845);
            buttonLuuThongTin.Name = "buttonLuuThongTin";
            buttonLuuThongTin.Size = new Size(254, 59);
            buttonLuuThongTin.TabIndex = 25;
            buttonLuuThongTin.Text = "Lưu thông tin";
            buttonLuuThongTin.UseVisualStyleBackColor = false;
            buttonLuuThongTin.Click += buttonLuuThongTin_Click;
            // 
            // pictureBoxThoat
            // 
            pictureBoxThoat.Image = Properties.Resources.exit;
            pictureBoxThoat.Location = new Point(46, 29);
            pictureBoxThoat.Margin = new Padding(5);
            pictureBoxThoat.Name = "pictureBoxThoat";
            pictureBoxThoat.Size = new Size(96, 50);
            pictureBoxThoat.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxThoat.TabIndex = 23;
            pictureBoxThoat.TabStop = false;
            pictureBoxThoat.Click += pictureBoxThoat_Click;
            // 
            // labelThemLichThi
            // 
            labelThemLichThi.AutoSize = true;
            labelThemLichThi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelThemLichThi.Location = new Point(640, 29);
            labelThemLichThi.Margin = new Padding(5, 0, 5, 0);
            labelThemLichThi.Name = "labelThemLichThi";
            labelThemLichThi.Size = new Size(291, 50);
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
            tableLayoutPanelThongTinLichPhanCong.Location = new Point(658, 178);
            tableLayoutPanelThongTinLichPhanCong.Margin = new Padding(5);
            tableLayoutPanelThongTinLichPhanCong.Name = "tableLayoutPanelThongTinLichPhanCong";
            tableLayoutPanelThongTinLichPhanCong.RowCount = 7;
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanelThongTinLichPhanCong.Size = new Size(904, 654);
            tableLayoutPanelThongTinLichPhanCong.TabIndex = 21;
            // 
            // dateTimePickerTGKetThuc
            // 
            dateTimePickerTGKetThuc.Anchor = AnchorStyles.None;
            dateTimePickerTGKetThuc.CustomFormat = "HH:mm";
            dateTimePickerTGKetThuc.Format = DateTimePickerFormat.Custom;
            dateTimePickerTGKetThuc.Location = new Point(381, 581);
            dateTimePickerTGKetThuc.Margin = new Padding(5);
            dateTimePickerTGKetThuc.Name = "dateTimePickerTGKetThuc";
            dateTimePickerTGKetThuc.ShowUpDown = true;
            dateTimePickerTGKetThuc.Size = new Size(451, 39);
            dateTimePickerTGKetThuc.TabIndex = 31;
            // 
            // textBoxTenKyThi
            // 
            textBoxTenKyThi.Anchor = AnchorStyles.None;
            textBoxTenKyThi.BackColor = SystemColors.ButtonHighlight;
            textBoxTenKyThi.BorderStyle = BorderStyle.FixedSingle;
            textBoxTenKyThi.Location = new Point(385, 20);
            textBoxTenKyThi.Margin = new Padding(5);
            textBoxTenKyThi.Name = "textBoxTenKyThi";
            textBoxTenKyThi.Size = new Size(442, 39);
            textBoxTenKyThi.TabIndex = 16;
            // 
            // dateTimePickerNgayThi
            // 
            dateTimePickerNgayThi.Anchor = AnchorStyles.None;
            dateTimePickerNgayThi.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgayThi.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayThi.Location = new Point(389, 104);
            dateTimePickerNgayThi.Margin = new Padding(5);
            dateTimePickerNgayThi.Name = "dateTimePickerNgayThi";
            dateTimePickerNgayThi.Size = new Size(435, 39);
            dateTimePickerNgayThi.TabIndex = 20;
            // 
            // textBoxTrangThai
            // 
            textBoxTrangThai.Anchor = AnchorStyles.None;
            textBoxTrangThai.BackColor = SystemColors.Control;
            textBoxTrangThai.BorderStyle = BorderStyle.FixedSingle;
            textBoxTrangThai.Enabled = false;
            textBoxTrangThai.Location = new Point(382, 190);
            textBoxTrangThai.Margin = new Padding(5);
            textBoxTrangThai.Name = "textBoxTrangThai";
            textBoxTrangThai.ReadOnly = true;
            textBoxTrangThai.Size = new Size(449, 39);
            textBoxTrangThai.TabIndex = 17;
            textBoxTrangThai.Text = "Chưa thi";
            // 
            // textBoxSLDangKy
            // 
            textBoxSLDangKy.Anchor = AnchorStyles.None;
            textBoxSLDangKy.BackColor = SystemColors.ButtonHighlight;
            textBoxSLDangKy.BorderStyle = BorderStyle.FixedSingle;
            textBoxSLDangKy.Location = new Point(379, 280);
            textBoxSLDangKy.Margin = new Padding(5);
            textBoxSLDangKy.Name = "textBoxSLDangKy";
            textBoxSLDangKy.Size = new Size(454, 39);
            textBoxSLDangKy.TabIndex = 18;
            textBoxSLDangKy.Text = "0";
            // 
            // textBoxHienThiPhongThi
            // 
            textBoxHienThiPhongThi.Anchor = AnchorStyles.None;
            textBoxHienThiPhongThi.BackColor = SystemColors.ButtonHighlight;
            textBoxHienThiPhongThi.BorderStyle = BorderStyle.FixedSingle;
            textBoxHienThiPhongThi.Location = new Point(379, 376);
            textBoxHienThiPhongThi.Margin = new Padding(5);
            textBoxHienThiPhongThi.Name = "textBoxHienThiPhongThi";
            textBoxHienThiPhongThi.Size = new Size(455, 39);
            textBoxHienThiPhongThi.TabIndex = 19;
            // 
            // dateTimePickerTGBatDau
            // 
            dateTimePickerTGBatDau.Anchor = AnchorStyles.None;
            dateTimePickerTGBatDau.CustomFormat = "HH:mm";
            dateTimePickerTGBatDau.Format = DateTimePickerFormat.Custom;
            dateTimePickerTGBatDau.Location = new Point(381, 475);
            dateTimePickerTGBatDau.Margin = new Padding(5);
            dateTimePickerTGBatDau.Name = "dateTimePickerTGBatDau";
            dateTimePickerTGBatDau.ShowUpDown = true;
            dateTimePickerTGBatDau.Size = new Size(451, 39);
            dateTimePickerTGBatDau.TabIndex = 30;
            // 
            // labelTGKetThuc
            // 
            labelTGKetThuc.Anchor = AnchorStyles.None;
            labelTGKetThuc.AutoSize = true;
            labelTGKetThuc.Font = new Font("Segoe UI", 10F);
            labelTGKetThuc.Location = new Point(37, 582);
            labelTGKetThuc.Margin = new Padding(5, 0, 5, 0);
            labelTGKetThuc.Name = "labelTGKetThuc";
            labelTGKetThuc.Size = new Size(235, 37);
            labelTGKetThuc.TabIndex = 21;
            labelTGKetThuc.Text = "Thời gian kết thúc:";
            // 
            // labelNgayThi
            // 
            labelNgayThi.Anchor = AnchorStyles.None;
            labelNgayThi.AutoSize = true;
            labelNgayThi.Font = new Font("Segoe UI", 10F);
            labelNgayThi.Location = new Point(92, 105);
            labelNgayThi.Margin = new Padding(5, 0, 5, 0);
            labelNgayThi.Name = "labelNgayThi";
            labelNgayThi.Size = new Size(124, 37);
            labelNgayThi.TabIndex = 32;
            labelNgayThi.Text = "Ngày thi:";
            // 
            // labelTrangThai
            // 
            labelTrangThai.Anchor = AnchorStyles.None;
            labelTrangThai.AutoSize = true;
            labelTrangThai.Font = new Font("Segoe UI", 10F);
            labelTrangThai.Location = new Point(84, 191);
            labelTrangThai.Margin = new Padding(5, 0, 5, 0);
            labelTrangThai.Name = "labelTrangThai";
            labelTrangThai.Size = new Size(141, 37);
            labelTrangThai.TabIndex = 33;
            labelTrangThai.Text = "Trạng thái:";
            // 
            // dataGridViewKyThi
            // 
            dataGridViewKyThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKyThi.Location = new Point(46, 178);
            dataGridViewKyThi.Margin = new Padding(5);
            dataGridViewKyThi.Name = "dataGridViewKyThi";
            dataGridViewKyThi.RowHeadersWidth = 51;
            dataGridViewKyThi.Size = new Size(578, 277);
            dataGridViewKyThi.TabIndex = 26;
            dataGridViewKyThi.CellClick += dataGridViewKyThi_CellClick;
            // 
            // labelDSKyThi
            // 
            labelDSKyThi.AutoSize = true;
            labelDSKyThi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelDSKyThi.Location = new Point(46, 112);
            labelDSKyThi.Margin = new Padding(5, 0, 5, 0);
            labelDSKyThi.Name = "labelDSKyThi";
            labelDSKyThi.Size = new Size(241, 40);
            labelDSKyThi.TabIndex = 27;
            labelDSKyThi.Text = "Danh sách kỳ thi";
            // 
            // labelDSPhongTrong
            // 
            labelDSPhongTrong.AutoSize = true;
            labelDSPhongTrong.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelDSPhongTrong.Location = new Point(46, 478);
            labelDSPhongTrong.Margin = new Padding(5, 0, 5, 0);
            labelDSPhongTrong.Name = "labelDSPhongTrong";
            labelDSPhongTrong.Size = new Size(383, 40);
            labelDSPhongTrong.TabIndex = 28;
            labelDSPhongTrong.Text = "Danh sách phòng thi trống";
            // 
            // dataGridViewPhongTrong
            // 
            dataGridViewPhongTrong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPhongTrong.Location = new Point(46, 539);
            dataGridViewPhongTrong.Margin = new Padding(5);
            dataGridViewPhongTrong.Name = "dataGridViewPhongTrong";
            dataGridViewPhongTrong.RowHeadersWidth = 51;
            dataGridViewPhongTrong.Size = new Size(578, 293);
            dataGridViewPhongTrong.TabIndex = 29;
            dataGridViewPhongTrong.CellClick += dataGridViewPhongTrong_CellClick;
            // 
            // fAdminThemLichThi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1594, 949);
            Controls.Add(dataGridViewPhongTrong);
            Controls.Add(labelDSPhongTrong);
            Controls.Add(labelDSKyThi);
            Controls.Add(dataGridViewKyThi);
            Controls.Add(buttonLuuThongTin);
            Controls.Add(pictureBoxThoat);
            Controls.Add(labelThemLichThi);
            Controls.Add(tableLayoutPanelThongTinLichPhanCong);
            Margin = new Padding(5);
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