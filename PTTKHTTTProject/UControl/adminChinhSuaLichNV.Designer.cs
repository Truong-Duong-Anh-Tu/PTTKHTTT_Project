namespace PTTKHTTTProject.UControl
{
    partial class adminChinhSuaLichNV
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

        #region Component Designer generated code
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            buttonLuuThongTin = new Button();
            buttonChinhSuaThongTin = new Button();
            tableLayoutPanelThongTinLichPhanCong = new TableLayoutPanel();
            label2 = new Label();
            labelMaNVCoithi = new Label();
            labelTGBatDau = new Label();
            labelKyThi = new Label();
            labelNgayThi = new Label();
            labelPhongThi = new Label();
            labelTGKetThuc = new Label();
            labelHienThiKyThi = new Label();
            labelHienThiNgayThi = new Label();
            labelHienThiPhongThi = new Label();
            labelHienThiTGBatDau = new Label();
            labelHienThiTGKetThuc = new Label();
            textBoxMaNVCoiThi = new TextBox();
            textBoxTenNVCoiThi = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanelThongTinLichPhanCong.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(330, 23);
            label1.Name = "label1";
            label1.Size = new Size(303, 31);
            label1.TabIndex = 0;
            label1.Text = "CHI TIẾT LỊCH PHÂN CÔNG";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.exit;
            pictureBox1.Location = new Point(46, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(buttonLuuThongTin);
            panel1.Controls.Add(buttonChinhSuaThongTin);
            panel1.Controls.Add(tableLayoutPanelThongTinLichPhanCong);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(18, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 414);
            panel1.TabIndex = 2;
            // 
            // buttonLuuThongTin
            // 
            buttonLuuThongTin.BackColor = Color.SkyBlue;
            buttonLuuThongTin.Location = new Point(692, 349);
            buttonLuuThongTin.Name = "buttonLuuThongTin";
            buttonLuuThongTin.Size = new Size(172, 38);
            buttonLuuThongTin.TabIndex = 6;
            buttonLuuThongTin.Text = "Lưu thông tin";
            buttonLuuThongTin.UseVisualStyleBackColor = false;
            buttonLuuThongTin.Click += buttonLuuThongTin_Click;
            // 
            // buttonChinhSuaThongTin
            // 
            buttonChinhSuaThongTin.BackColor = Color.SkyBlue;
            buttonChinhSuaThongTin.Location = new Point(692, 287);
            buttonChinhSuaThongTin.Name = "buttonChinhSuaThongTin";
            buttonChinhSuaThongTin.Size = new Size(172, 38);
            buttonChinhSuaThongTin.TabIndex = 5;
            buttonChinhSuaThongTin.Text = "Chỉnh sửa thông tin";
            buttonChinhSuaThongTin.UseVisualStyleBackColor = false;
            buttonChinhSuaThongTin.Click += buttonChinhSuaThongTin_Click;
            // 
            // tableLayoutPanelThongTinLichPhanCong
            // 
            tableLayoutPanelThongTinLichPhanCong.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanelThongTinLichPhanCong.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanelThongTinLichPhanCong.ColumnCount = 2;
            tableLayoutPanelThongTinLichPhanCong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.0273056F));
            tableLayoutPanelThongTinLichPhanCong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.9726944F));
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(label2, 0, 6);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelMaNVCoithi, 0, 5);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelTGBatDau, 0, 3);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelKyThi, 0, 0);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelNgayThi, 0, 1);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelPhongThi, 0, 2);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelTGKetThuc, 0, 4);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelHienThiKyThi, 1, 0);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelHienThiNgayThi, 1, 1);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelHienThiPhongThi, 1, 2);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelHienThiTGBatDau, 1, 3);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(labelHienThiTGKetThuc, 1, 4);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxMaNVCoiThi, 1, 5);
            tableLayoutPanelThongTinLichPhanCong.Controls.Add(textBoxTenNVCoiThi, 1, 6);
            tableLayoutPanelThongTinLichPhanCong.Location = new Point(28, 50);
            tableLayoutPanelThongTinLichPhanCong.Name = "tableLayoutPanelThongTinLichPhanCong";
            tableLayoutPanelThongTinLichPhanCong.RowCount = 7;
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelThongTinLichPhanCong.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanelThongTinLichPhanCong.Size = new Size(635, 337);
            tableLayoutPanelThongTinLichPhanCong.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(54, 301);
            label2.Name = "label2";
            label2.Size = new Size(172, 23);
            label2.TabIndex = 0;
            label2.Text = "Tên nhân viên coi thi:";
            // 
            // labelMaNVCoithi
            // 
            labelMaNVCoithi.Anchor = AnchorStyles.None;
            labelMaNVCoithi.AutoSize = true;
            labelMaNVCoithi.Font = new Font("Segoe UI", 10F);
            labelMaNVCoithi.Location = new Point(55, 252);
            labelMaNVCoithi.Name = "labelMaNVCoithi";
            labelMaNVCoithi.Size = new Size(170, 23);
            labelMaNVCoithi.TabIndex = 1;
            labelMaNVCoithi.Text = "Mã nhân viên coi thi:";
            // 
            // labelTGBatDau
            // 
            labelTGBatDau.Anchor = AnchorStyles.None;
            labelTGBatDau.AutoSize = true;
            labelTGBatDau.Font = new Font("Segoe UI", 10F);
            labelTGBatDau.Location = new Point(65, 152);
            labelTGBatDau.Name = "labelTGBatDau";
            labelTGBatDau.Size = new Size(149, 23);
            labelTGBatDau.TabIndex = 2;
            labelTGBatDau.Text = "Thời gian bắt đầu:";
            // 
            // labelKyThi
            // 
            labelKyThi.Anchor = AnchorStyles.None;
            labelKyThi.AutoSize = true;
            labelKyThi.Font = new Font("Segoe UI", 10F);
            labelKyThi.Location = new Point(112, 11);
            labelKyThi.Name = "labelKyThi";
            labelKyThi.Size = new Size(56, 23);
            labelKyThi.TabIndex = 3;
            labelKyThi.Text = "Kỳ thi:";
            // 
            // labelNgayThi
            // 
            labelNgayThi.Anchor = AnchorStyles.None;
            labelNgayThi.AutoSize = true;
            labelNgayThi.Font = new Font("Segoe UI", 10F);
            labelNgayThi.Location = new Point(100, 56);
            labelNgayThi.Name = "labelNgayThi";
            labelNgayThi.Size = new Size(79, 23);
            labelNgayThi.TabIndex = 4;
            labelNgayThi.Text = "Ngày thi:";
            // 
            // labelPhongThi
            // 
            labelPhongThi.Anchor = AnchorStyles.None;
            labelPhongThi.AutoSize = true;
            labelPhongThi.Font = new Font("Segoe UI", 10F);
            labelPhongThi.Location = new Point(95, 103);
            labelPhongThi.Name = "labelPhongThi";
            labelPhongThi.Size = new Size(89, 23);
            labelPhongThi.TabIndex = 5;
            labelPhongThi.Text = "Phòng thi:";
            // 
            // labelTGKetThuc
            // 
            labelTGKetThuc.Anchor = AnchorStyles.None;
            labelTGKetThuc.AutoSize = true;
            labelTGKetThuc.Font = new Font("Segoe UI", 10F);
            labelTGKetThuc.Location = new Point(64, 202);
            labelTGKetThuc.Name = "labelTGKetThuc";
            labelTGKetThuc.Size = new Size(152, 23);
            labelTGKetThuc.TabIndex = 6;
            labelTGKetThuc.Text = "Thời gian kết thúc:";
            // 
            // labelHienThiKyThi
            // 
            labelHienThiKyThi.Anchor = AnchorStyles.None;
            labelHienThiKyThi.AutoSize = true;
            labelHienThiKyThi.Font = new Font("Segoe UI", 10F);
            labelHienThiKyThi.Location = new Point(429, 11);
            labelHienThiKyThi.Name = "labelHienThiKyThi";
            labelHienThiKyThi.Size = new Size(55, 23);
            labelHienThiKyThi.TabIndex = 7;
            labelHienThiKyThi.Text = "label2";
            // 
            // labelHienThiNgayThi
            // 
            labelHienThiNgayThi.Anchor = AnchorStyles.None;
            labelHienThiNgayThi.AutoSize = true;
            labelHienThiNgayThi.Font = new Font("Segoe UI", 10F);
            labelHienThiNgayThi.Location = new Point(429, 56);
            labelHienThiNgayThi.Name = "labelHienThiNgayThi";
            labelHienThiNgayThi.Size = new Size(55, 23);
            labelHienThiNgayThi.TabIndex = 8;
            labelHienThiNgayThi.Text = "label2";
            // 
            // labelHienThiPhongThi
            // 
            labelHienThiPhongThi.Anchor = AnchorStyles.None;
            labelHienThiPhongThi.AutoSize = true;
            labelHienThiPhongThi.Font = new Font("Segoe UI", 10F);
            labelHienThiPhongThi.Location = new Point(429, 103);
            labelHienThiPhongThi.Name = "labelHienThiPhongThi";
            labelHienThiPhongThi.Size = new Size(55, 23);
            labelHienThiPhongThi.TabIndex = 9;
            labelHienThiPhongThi.Text = "label2";
            // 
            // labelHienThiTGBatDau
            // 
            labelHienThiTGBatDau.Anchor = AnchorStyles.None;
            labelHienThiTGBatDau.AutoSize = true;
            labelHienThiTGBatDau.Font = new Font("Segoe UI", 10F);
            labelHienThiTGBatDau.Location = new Point(429, 152);
            labelHienThiTGBatDau.Name = "labelHienThiTGBatDau";
            labelHienThiTGBatDau.Size = new Size(55, 23);
            labelHienThiTGBatDau.TabIndex = 10;
            labelHienThiTGBatDau.Text = "label2";
            // 
            // labelHienThiTGKetThuc
            // 
            labelHienThiTGKetThuc.Anchor = AnchorStyles.None;
            labelHienThiTGKetThuc.AutoSize = true;
            labelHienThiTGKetThuc.Font = new Font("Segoe UI", 10F);
            labelHienThiTGKetThuc.Location = new Point(429, 202);
            labelHienThiTGKetThuc.Name = "labelHienThiTGKetThuc";
            labelHienThiTGKetThuc.Size = new Size(55, 23);
            labelHienThiTGKetThuc.TabIndex = 11;
            labelHienThiTGKetThuc.Text = "label2";
            // 
            // textBoxMaNVCoiThi
            // 
            textBoxMaNVCoiThi.Anchor = AnchorStyles.None;
            textBoxMaNVCoiThi.Font = new Font("Segoe UI", 10F);
            textBoxMaNVCoiThi.Location = new Point(319, 249);
            textBoxMaNVCoiThi.Name = "textBoxMaNVCoiThi";
            textBoxMaNVCoiThi.Size = new Size(275, 30);
            textBoxMaNVCoiThi.TabIndex = 13;
            textBoxMaNVCoiThi.TextChanged += textBoxMaNVCoiThi_TextChanged;
            // 
            // textBoxTenNVCoiThi
            // 
            textBoxTenNVCoiThi.Anchor = AnchorStyles.None;
            textBoxTenNVCoiThi.BackColor = SystemColors.ButtonHighlight;
            textBoxTenNVCoiThi.BorderStyle = BorderStyle.None;
            textBoxTenNVCoiThi.Font = new Font("Segoe UI", 10F);
            textBoxTenNVCoiThi.Location = new Point(283, 301);
            textBoxTenNVCoiThi.Name = "textBoxTenNVCoiThi";
            textBoxTenNVCoiThi.ReadOnly = true;
            textBoxTenNVCoiThi.Size = new Size(348, 23);
            textBoxTenNVCoiThi.TabIndex = 14;
            textBoxTenNVCoiThi.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(9, 12);
            label3.Name = "label3";
            label3.Size = new Size(234, 25);
            label3.TabIndex = 3;
            label3.Text = "Thông tin lịch phân công";
            // 
            // adminChinhSuaLichNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "adminChinhSuaLichNV";
            Size = new Size(927, 519);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanelThongTinLichPhanCong.ResumeLayout(false);
            tableLayoutPanelThongTinLichPhanCong.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLuuThongTin;
        private System.Windows.Forms.Button buttonChinhSuaThongTin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelThongTinLichPhanCong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMaNVCoithi;
        private System.Windows.Forms.Label labelTGBatDau;
        private System.Windows.Forms.Label labelKyThi;
        private System.Windows.Forms.Label labelNgayThi;
        private System.Windows.Forms.Label labelPhongThi;
        private System.Windows.Forms.Label labelTGKetThuc;
        private System.Windows.Forms.Label labelHienThiKyThi;
        private System.Windows.Forms.Label labelHienThiNgayThi;
        private System.Windows.Forms.Label labelHienThiPhongThi;
        private System.Windows.Forms.Label labelHienThiTGBatDau;
        private System.Windows.Forms.Label labelHienThiTGKetThuc;
        private System.Windows.Forms.TextBox textBoxMaNVCoiThi;
        private System.Windows.Forms.TextBox textBoxTenNVCoiThi;
        private System.Windows.Forms.Label label3;
    }
}