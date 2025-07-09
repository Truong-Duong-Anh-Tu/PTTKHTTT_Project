namespace PTTKHTTTProject.UControl
{
    partial class adminPhatHanhPhieuDuThi
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
            labelPhatHanhPhieuDuThi = new Label();
            labelDSChoTaoPhieu = new Label();
            dataGridViewDSCho = new DataGridView();
            labelLichSuPhatHanh = new Label();
            dataGridViewLichSuPhatHanh = new DataGridView();
            btnPhatHanh = new Button();
            textBoxTimKiem = new TextBox();
            radioButtonDSCho = new RadioButton();
            radioButtonDSCho2Tuan = new RadioButton();
            buttonDSChoMoiPhatHanh = new Button();
            labelGhiChu = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSCho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLichSuPhatHanh).BeginInit();
            SuspendLayout();
            // 
            // labelPhatHanhPhieuDuThi
            // 
            labelPhatHanhPhieuDuThi.Anchor = AnchorStyles.Top;
            labelPhatHanhPhieuDuThi.AutoSize = true;
            labelPhatHanhPhieuDuThi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            labelPhatHanhPhieuDuThi.Location = new Point(357, 12);
            labelPhatHanhPhieuDuThi.Name = "labelPhatHanhPhieuDuThi";
            labelPhatHanhPhieuDuThi.Size = new Size(308, 31);
            labelPhatHanhPhieuDuThi.TabIndex = 17;
            labelPhatHanhPhieuDuThi.Text = "PHÁT HÀNH PHIẾU DỰ THI";
            // 
            // labelDSChoTaoPhieu
            // 
            labelDSChoTaoPhieu.AutoSize = true;
            labelDSChoTaoPhieu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelDSChoTaoPhieu.Location = new Point(28, 52);
            labelDSChoTaoPhieu.Name = "labelDSChoTaoPhieu";
            labelDSChoTaoPhieu.Size = new Size(206, 23);
            labelDSChoTaoPhieu.TabIndex = 19;
            labelDSChoTaoPhieu.Text = "Danh sách chờ tạo phiếu";
            // 
            // dataGridViewDSCho
            // 
            dataGridViewDSCho.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDSCho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDSCho.Location = new Point(28, 82);
            dataGridViewDSCho.Name = "dataGridViewDSCho";
            dataGridViewDSCho.RowHeadersWidth = 51;
            dataGridViewDSCho.Size = new Size(972, 200);
            dataGridViewDSCho.TabIndex = 20;
            // 
            // labelLichSuPhatHanh
            // 
            labelLichSuPhatHanh.Anchor = AnchorStyles.Left;
            labelLichSuPhatHanh.AutoSize = true;
            labelLichSuPhatHanh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelLichSuPhatHanh.Location = new Point(28, 298);
            labelLichSuPhatHanh.Name = "labelLichSuPhatHanh";
            labelLichSuPhatHanh.Size = new Size(151, 23);
            labelLichSuPhatHanh.TabIndex = 22;
            labelLichSuPhatHanh.Text = "Lịch sử phát hành";
            // 
            // dataGridViewLichSuPhatHanh
            // 
            dataGridViewLichSuPhatHanh.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewLichSuPhatHanh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLichSuPhatHanh.Location = new Point(28, 337);
            dataGridViewLichSuPhatHanh.Name = "dataGridViewLichSuPhatHanh";
            dataGridViewLichSuPhatHanh.RowHeadersWidth = 51;
            dataGridViewLichSuPhatHanh.Size = new Size(972, 204);
            dataGridViewLichSuPhatHanh.TabIndex = 23;
            // 
            // btnPhatHanh
            // 
            btnPhatHanh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPhatHanh.BackColor = Color.SkyBlue;
            btnPhatHanh.Location = new Point(848, 47);
            btnPhatHanh.Name = "btnPhatHanh";
            btnPhatHanh.Size = new Size(142, 28);
            btnPhatHanh.TabIndex = 26;
            btnPhatHanh.Text = "Phát hành";
            btnPhatHanh.UseVisualStyleBackColor = false;
            btnPhatHanh.Click += btnPhatHanh_Click;
            // 
            // textBoxTimKiem
            // 
            textBoxTimKiem.Anchor = AnchorStyles.Right;
            textBoxTimKiem.BorderStyle = BorderStyle.FixedSingle;
            textBoxTimKiem.Location = new Point(410, 298);
            textBoxTimKiem.Name = "textBoxTimKiem";
            textBoxTimKiem.PlaceholderText = "Tìm kiếm phiếu dự thi đã phát hành";
            textBoxTimKiem.Size = new Size(290, 27);
            textBoxTimKiem.TabIndex = 27;
            textBoxTimKiem.TextChanged += textBoxTimKiem_TextChanged;
            // 
            // radioButtonDSCho
            // 
            radioButtonDSCho.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButtonDSCho.AutoSize = true;
            radioButtonDSCho.Location = new Point(642, 52);
            radioButtonDSCho.Name = "radioButtonDSCho";
            radioButtonDSCho.Size = new Size(174, 24);
            radioButtonDSCho.TabIndex = 28;
            radioButtonDSCho.TabStop = true;
            radioButtonDSCho.Text = "Danh sách chờ còn lại";
            radioButtonDSCho.UseVisualStyleBackColor = true;
            radioButtonDSCho.CheckedChanged += radioButtonDSCho_CheckedChanged;
            // 
            // radioButtonDSCho2Tuan
            // 
            radioButtonDSCho2Tuan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButtonDSCho2Tuan.AutoSize = true;
            radioButtonDSCho2Tuan.Location = new Point(300, 52);
            radioButtonDSCho2Tuan.Name = "radioButtonDSCho2Tuan";
            radioButtonDSCho2Tuan.Size = new Size(316, 24);
            radioButtonDSCho2Tuan.TabIndex = 30;
            radioButtonDSCho2Tuan.TabStop = true;
            radioButtonDSCho2Tuan.Text = "Danh sách chờ cách hiện tại 2 tuần (sắp thi)";
            radioButtonDSCho2Tuan.UseVisualStyleBackColor = true;
            radioButtonDSCho2Tuan.CheckedChanged += radioButtonDSCho2Tuan_CheckedChanged;
            // 
            // buttonDSChoMoiPhatHanh
            // 
            buttonDSChoMoiPhatHanh.Anchor = AnchorStyles.Right;
            buttonDSChoMoiPhatHanh.BackColor = Color.SkyBlue;
            buttonDSChoMoiPhatHanh.Location = new Point(706, 296);
            buttonDSChoMoiPhatHanh.Name = "buttonDSChoMoiPhatHanh";
            buttonDSChoMoiPhatHanh.Size = new Size(294, 29);
            buttonDSChoMoiPhatHanh.TabIndex = 31;
            buttonDSChoMoiPhatHanh.Text = "Hiển thị danh sách mới phát hành (*)";
            buttonDSChoMoiPhatHanh.UseVisualStyleBackColor = false;
            buttonDSChoMoiPhatHanh.Click += buttonDSChoMoiPhatHanh_Click;
            // 
            // labelGhiChu
            // 
            labelGhiChu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelGhiChu.AutoSize = true;
            labelGhiChu.Location = new Point(475, 544);
            labelGhiChu.Name = "labelGhiChu";
            labelGhiChu.Size = new Size(515, 20);
            labelGhiChu.TabIndex = 32;
            labelGhiChu.Text = "(*) Danh sách chờ mới phát hành, cách thời gian hiện tại khoảng 2 tuần trước";
            // 
            // adminPhatHanhPhieuDuThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(labelGhiChu);
            Controls.Add(buttonDSChoMoiPhatHanh);
            Controls.Add(radioButtonDSCho2Tuan);
            Controls.Add(radioButtonDSCho);
            Controls.Add(textBoxTimKiem);
            Controls.Add(btnPhatHanh);
            Controls.Add(dataGridViewLichSuPhatHanh);
            Controls.Add(labelLichSuPhatHanh);
            Controls.Add(dataGridViewDSCho);
            Controls.Add(labelDSChoTaoPhieu);
            Controls.Add(labelPhatHanhPhieuDuThi);
            Name = "adminPhatHanhPhieuDuThi";
            Size = new Size(1021, 578);
            Load += adminPhatHanhPhieuDuThi_Load;
            Resize += adminPhatHanhPhieuDuThi_Resize;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSCho).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLichSuPhatHanh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPhatHanhPhieuDuThi;
        private PictureBox pictureBox1;
        private Label labelDSChoTaoPhieu;
        private DataGridView dataGridViewDSCho;
        private Label labelLichSuPhatHanh;
        private DataGridView dataGridViewLichSuPhatHanh;
        private Button btnPhatHanh;
        private TextBox textBoxTimKiem;
        private RadioButton radioButtonDSCho;
        private RadioButton radioButtonDSCho2Tuan;
        private Button buttonDSChoMoiPhatHanh;
        private Label labelGhiChu;
    }
}
