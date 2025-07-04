namespace PTTKHTTTProject.UControl
{
    partial class adminQLPhongThi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelDSPhongThi = new Label();
            labelQLPhongThi = new Label();
            panel1 = new Panel();
            buttonXemLichThi = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            buttonLuuThongTin = new Button();
            buttonXoa = new Button();
            buttonChinhSua = new Button();
            buttonThem = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxSLNVCT = new TextBox();
            textBoxMinThiSinh = new TextBox();
            textBoxMaxThiSinh = new TextBox();
            labelSoLuongNVCT = new Label();
            labelMinThiSinh = new Label();
            labelHinhThuc = new Label();
            labelMaPhongThi = new Label();
            labelMaxThiSinh = new Label();
            textBoxMaPhongThi = new TextBox();
            comboBoxHinhThuc = new ComboBox();
            labelChiTietPhongThi = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelDSPhongThi
            // 
            labelDSPhongThi.AutoSize = true;
            labelDSPhongThi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelDSPhongThi.Location = new Point(169, 15);
            labelDSPhongThi.Name = "labelDSPhongThi";
            labelDSPhongThi.Size = new Size(208, 28);
            labelDSPhongThi.TabIndex = 0;
            labelDSPhongThi.Text = "Danh sách phòng thi";
            // 
            // labelQLPhongThi
            // 
            labelQLPhongThi.AutoSize = true;
            labelQLPhongThi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            labelQLPhongThi.Location = new Point(380, 10);
            labelQLPhongThi.Name = "labelQLPhongThi";
            labelQLPhongThi.Size = new Size(246, 31);
            labelQLPhongThi.TabIndex = 4;
            labelQLPhongThi.Text = "QUẢN LÝ PHÒNG THI";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(buttonXemLichThi);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(labelDSPhongThi);
            panel1.Location = new Point(15, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 479);
            panel1.TabIndex = 5;
            // 
            // buttonXemLichThi
            // 
            buttonXemLichThi.BackColor = Color.SkyBlue;
            buttonXemLichThi.Location = new Point(241, 421);
            buttonXemLichThi.Name = "buttonXemLichThi";
            buttonXemLichThi.Size = new Size(300, 41);
            buttonXemLichThi.TabIndex = 2;
            buttonXemLichThi.Text = "Xem danh sách lịch thi của phòng thi";
            buttonXemLichThi.UseVisualStyleBackColor = false;
            buttonXemLichThi.Click += buttonXemLichThi_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(521, 338);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(buttonLuuThongTin);
            panel2.Controls.Add(buttonXoa);
            panel2.Controls.Add(buttonChinhSua);
            panel2.Controls.Add(buttonThem);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(labelChiTietPhongThi);
            panel2.Location = new Point(598, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(406, 479);
            panel2.TabIndex = 6;
            // 
            // buttonLuuThongTin
            // 
            buttonLuuThongTin.BackColor = Color.SkyBlue;
            buttonLuuThongTin.Location = new Point(179, 421);
            buttonLuuThongTin.Name = "buttonLuuThongTin";
            buttonLuuThongTin.Size = new Size(207, 36);
            buttonLuuThongTin.TabIndex = 6;
            buttonLuuThongTin.Text = "Lưu thông tin";
            buttonLuuThongTin.UseVisualStyleBackColor = false;
            buttonLuuThongTin.Click += buttonLuuThongTin_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = Color.SkyBlue;
            buttonXoa.Location = new Point(282, 362);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(104, 36);
            buttonXoa.TabIndex = 5;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonChinhSua
            // 
            buttonChinhSua.BackColor = Color.SkyBlue;
            buttonChinhSua.Location = new Point(136, 362);
            buttonChinhSua.Name = "buttonChinhSua";
            buttonChinhSua.Size = new Size(119, 36);
            buttonChinhSua.TabIndex = 4;
            buttonChinhSua.Text = "Chỉnh sửa";
            buttonChinhSua.UseVisualStyleBackColor = false;
            buttonChinhSua.Click += buttonChinhSua_Click;
            // 
            // buttonThem
            // 
            buttonThem.BackColor = Color.SkyBlue;
            buttonThem.Location = new Point(16, 362);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(104, 36);
            buttonThem.TabIndex = 3;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = false;
            buttonThem.Click += buttonThem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.6590252F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.34097F));
            tableLayoutPanel1.Controls.Add(textBoxSLNVCT, 1, 4);
            tableLayoutPanel1.Controls.Add(textBoxMinThiSinh, 1, 3);
            tableLayoutPanel1.Controls.Add(textBoxMaxThiSinh, 1, 2);
            tableLayoutPanel1.Controls.Add(labelSoLuongNVCT, 0, 4);
            tableLayoutPanel1.Controls.Add(labelMinThiSinh, 0, 3);
            tableLayoutPanel1.Controls.Add(labelHinhThuc, 0, 1);
            tableLayoutPanel1.Controls.Add(labelMaPhongThi, 0, 0);
            tableLayoutPanel1.Controls.Add(labelMaxThiSinh, 0, 2);
            tableLayoutPanel1.Controls.Add(textBoxMaPhongThi, 1, 0);
            tableLayoutPanel1.Controls.Add(comboBoxHinhThuc, 1, 1);
            tableLayoutPanel1.Location = new Point(19, 60);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.Size = new Size(367, 267);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // textBoxSLNVCT
            // 
            textBoxSLNVCT.Anchor = AnchorStyles.None;
            textBoxSLNVCT.BorderStyle = BorderStyle.FixedSingle;
            textBoxSLNVCT.Location = new Point(144, 220);
            textBoxSLNVCT.Name = "textBoxSLNVCT";
            textBoxSLNVCT.Size = new Size(191, 27);
            textBoxSLNVCT.TabIndex = 13;
            // 
            // textBoxMinThiSinh
            // 
            textBoxMinThiSinh.Anchor = AnchorStyles.None;
            textBoxMinThiSinh.BorderStyle = BorderStyle.FixedSingle;
            textBoxMinThiSinh.Location = new Point(144, 161);
            textBoxMinThiSinh.Name = "textBoxMinThiSinh";
            textBoxMinThiSinh.Size = new Size(191, 27);
            textBoxMinThiSinh.TabIndex = 12;
            // 
            // textBoxMaxThiSinh
            // 
            textBoxMaxThiSinh.Anchor = AnchorStyles.None;
            textBoxMaxThiSinh.BorderStyle = BorderStyle.FixedSingle;
            textBoxMaxThiSinh.Location = new Point(144, 112);
            textBoxMaxThiSinh.Name = "textBoxMaxThiSinh";
            textBoxMaxThiSinh.Size = new Size(191, 27);
            textBoxMaxThiSinh.TabIndex = 11;
            // 
            // labelSoLuongNVCT
            // 
            labelSoLuongNVCT.Anchor = AnchorStyles.None;
            labelSoLuongNVCT.AutoSize = true;
            labelSoLuongNVCT.Location = new Point(3, 213);
            labelSoLuongNVCT.Name = "labelSoLuongNVCT";
            labelSoLuongNVCT.Size = new Size(105, 40);
            labelSoLuongNVCT.TabIndex = 8;
            labelSoLuongNVCT.Text = "Số lượng nhân viên coi thi";
            labelSoLuongNVCT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMinThiSinh
            // 
            labelMinThiSinh.Anchor = AnchorStyles.None;
            labelMinThiSinh.AutoSize = true;
            labelMinThiSinh.Location = new Point(9, 155);
            labelMinThiSinh.Name = "labelMinThiSinh";
            labelMinThiSinh.Size = new Size(94, 40);
            labelMinThiSinh.TabIndex = 6;
            labelMinThiSinh.Text = "Số lượng thí sinh tối thiểu";
            labelMinThiSinh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelHinhThuc
            // 
            labelHinhThuc.Anchor = AnchorStyles.None;
            labelHinhThuc.AutoSize = true;
            labelHinhThuc.Location = new Point(19, 66);
            labelHinhThuc.Name = "labelHinhThuc";
            labelHinhThuc.Size = new Size(73, 20);
            labelHinhThuc.TabIndex = 2;
            labelHinhThuc.Text = "Hình thức";
            // 
            // labelMaPhongThi
            // 
            labelMaPhongThi.Anchor = AnchorStyles.None;
            labelMaPhongThi.AutoSize = true;
            labelMaPhongThi.Location = new Point(7, 15);
            labelMaPhongThi.Name = "labelMaPhongThi";
            labelMaPhongThi.Size = new Size(98, 20);
            labelMaPhongThi.TabIndex = 0;
            labelMaPhongThi.Text = "Mã phòng thi";
            // 
            // labelMaxThiSinh
            // 
            labelMaxThiSinh.Anchor = AnchorStyles.None;
            labelMaxThiSinh.AutoSize = true;
            labelMaxThiSinh.Location = new Point(11, 106);
            labelMaxThiSinh.Name = "labelMaxThiSinh";
            labelMaxThiSinh.Size = new Size(90, 40);
            labelMaxThiSinh.TabIndex = 4;
            labelMaxThiSinh.Text = "Số lượng thí sinh tối đa";
            labelMaxThiSinh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxMaPhongThi
            // 
            textBoxMaPhongThi.Anchor = AnchorStyles.None;
            textBoxMaPhongThi.BorderStyle = BorderStyle.FixedSingle;
            textBoxMaPhongThi.Location = new Point(144, 11);
            textBoxMaPhongThi.Name = "textBoxMaPhongThi";
            textBoxMaPhongThi.Size = new Size(191, 27);
            textBoxMaPhongThi.TabIndex = 9;
            // 
            // comboBoxHinhThuc
            // 
            comboBoxHinhThuc.Anchor = AnchorStyles.None;
            comboBoxHinhThuc.FormattingEnabled = true;
            comboBoxHinhThuc.Location = new Point(147, 62);
            comboBoxHinhThuc.Name = "comboBoxHinhThuc";
            comboBoxHinhThuc.Size = new Size(185, 28);
            comboBoxHinhThuc.TabIndex = 14;
            // 
            // labelChiTietPhongThi
            // 
            labelChiTietPhongThi.AutoSize = true;
            labelChiTietPhongThi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelChiTietPhongThi.Location = new Point(106, 15);
            labelChiTietPhongThi.Name = "labelChiTietPhongThi";
            labelChiTietPhongThi.Size = new Size(179, 28);
            labelChiTietPhongThi.TabIndex = 0;
            labelChiTietPhongThi.Text = "Chi tiết phòng thi";
            // 
            // adminQLPhongThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(labelQLPhongThi);
            Controls.Add(panel1);
            Name = "adminQLPhongThi";
            Size = new Size(1021, 573);
            Load += adminQLPhongThi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelDSPhongThi;
        private Label labelQLPhongThi;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button buttonXemLichThi;
        private Panel panel2;
        private Label labelChiTietPhongThi;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelMaxThiSinh;
        private Label labelHinhThuc;
        private Label labelMaPhongThi;
        private Label labelMinThiSinh;
        private Button buttonThem;
        private Label labelSoLuongNVCT;
        private Button buttonLuuThongTin;
        private Button buttonXoa;
        private Button buttonChinhSua;
        private TextBox textBoxSLNVCT;
        private TextBox textBoxMinThiSinh;
        private TextBox textBoxMaxThiSinh;
        private TextBox textBoxMaPhongThi;
        private ComboBox comboBoxHinhThuc;
    }
}
