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
            labelGhiChu = new Label();
            labelGhiChu2 = new Label();
            btnPhatHanh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSCho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLichSuPhatHanh).BeginInit();
            SuspendLayout();
            // 
            // labelPhatHanhPhieuDuThi
            // 
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
            labelDSChoTaoPhieu.Location = new Point(70, 46);
            labelDSChoTaoPhieu.Name = "labelDSChoTaoPhieu";
            labelDSChoTaoPhieu.Size = new Size(285, 23);
            labelDSChoTaoPhieu.TabIndex = 19;
            labelDSChoTaoPhieu.Text = "Danh sách chờ tạo phiếu dự thi (*)";
            // 
            // dataGridViewDSCho
            // 
            dataGridViewDSCho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDSCho.Location = new Point(41, 81);
            dataGridViewDSCho.Name = "dataGridViewDSCho";
            dataGridViewDSCho.RowHeadersWidth = 51;
            dataGridViewDSCho.Size = new Size(949, 195);
            dataGridViewDSCho.TabIndex = 20;
            // 
            // labelLichSuPhatHanh
            // 
            labelLichSuPhatHanh.AutoSize = true;
            labelLichSuPhatHanh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelLichSuPhatHanh.Location = new Point(70, 289);
            labelLichSuPhatHanh.Name = "labelLichSuPhatHanh";
            labelLichSuPhatHanh.Size = new Size(184, 23);
            labelLichSuPhatHanh.TabIndex = 22;
            labelLichSuPhatHanh.Text = "Lịch sử phát hành (**)";
            // 
            // dataGridViewLichSuPhatHanh
            // 
            dataGridViewLichSuPhatHanh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLichSuPhatHanh.Location = new Point(41, 315);
            dataGridViewLichSuPhatHanh.Name = "dataGridViewLichSuPhatHanh";
            dataGridViewLichSuPhatHanh.RowHeadersWidth = 51;
            dataGridViewLichSuPhatHanh.Size = new Size(949, 202);
            dataGridViewLichSuPhatHanh.TabIndex = 23;
            // 
            // labelGhiChu
            // 
            labelGhiChu.AutoSize = true;
            labelGhiChu.Location = new Point(609, 540);
            labelGhiChu.Name = "labelGhiChu";
            labelGhiChu.Size = new Size(381, 20);
            labelGhiChu.TabIndex = 24;
            labelGhiChu.Text = "(**) Phiếu dự thi sẽ được tạo tự động 2 tuần trước khi thi";
            // 
            // labelGhiChu2
            // 
            labelGhiChu2.AutoSize = true;
            labelGhiChu2.Location = new Point(559, 520);
            labelGhiChu2.Name = "labelGhiChu2";
            labelGhiChu2.Size = new Size(431, 20);
            labelGhiChu2.TabIndex = 25;
            labelGhiChu2.Text = "(*) Danh sách thí sinh chờ đã thanh toán và chưa có phiếu dự thi";
            // 
            // btnPhatHanh
            // 
            btnPhatHanh.BackColor = Color.SkyBlue;
            btnPhatHanh.Location = new Point(828, 46);
            btnPhatHanh.Name = "btnPhatHanh";
            btnPhatHanh.Size = new Size(162, 29);
            btnPhatHanh.TabIndex = 26;
            btnPhatHanh.Text = "Phát hành";
            btnPhatHanh.UseVisualStyleBackColor = false;
            // 
            // adminPhatHanhPhieuDuThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(btnPhatHanh);
            Controls.Add(labelGhiChu2);
            Controls.Add(labelGhiChu);
            Controls.Add(dataGridViewLichSuPhatHanh);
            Controls.Add(labelLichSuPhatHanh);
            Controls.Add(dataGridViewDSCho);
            Controls.Add(labelDSChoTaoPhieu);
            Controls.Add(labelPhatHanhPhieuDuThi);
            Name = "adminPhatHanhPhieuDuThi";
            Size = new Size(1021, 578);
            Load += adminPhatHanhPhieuDuThi_Load;
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
        private Label labelGhiChu;
        private Label labelGhiChu2;
        private Button btnPhatHanh;
    }
}
