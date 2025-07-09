namespace PTTKHTTTProject.UControl
{
    partial class adminQlyLichThi
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
            components = new System.ComponentModel.Container();
            timerRefresh = new System.Windows.Forms.Timer(components);
            labelDSLichThi = new Label();
            panelChuaDSLichThi = new Panel();
            dataGridViewDSLichThi = new DataGridView();
            btnThem = new Button();
            txtTimKiem = new TextBox();
            panelChuaDSLichThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSLichThi).BeginInit();
            SuspendLayout();
            // 
            // timerRefresh
            // 
            timerRefresh.Tick += timerRefresh_Tick;
            // 
            // labelDSLichThi
            // 
            labelDSLichThi.AutoSize = true;
            labelDSLichThi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            labelDSLichThi.Location = new Point(23, 23);
            labelDSLichThi.Name = "labelDSLichThi";
            labelDSLichThi.Size = new Size(251, 31);
            labelDSLichThi.TabIndex = 2;
            labelDSLichThi.Text = "DANH SÁCH LỊCH THI";
            // 
            // panelChuaDSLichThi
            // 
            panelChuaDSLichThi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelChuaDSLichThi.BackColor = SystemColors.Control;
            panelChuaDSLichThi.Controls.Add(dataGridViewDSLichThi);
            panelChuaDSLichThi.Location = new Point(14, 89);
            panelChuaDSLichThi.Name = "panelChuaDSLichThi";
            panelChuaDSLichThi.Size = new Size(988, 471);
            panelChuaDSLichThi.TabIndex = 1;
            // 
            // dataGridViewDSLichThi
            // 
            dataGridViewDSLichThi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDSLichThi.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewDSLichThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDSLichThi.Location = new Point(37, 23);
            dataGridViewDSLichThi.Name = "dataGridViewDSLichThi";
            dataGridViewDSLichThi.RowHeadersWidth = 51;
            dataGridViewDSLichThi.Size = new Size(938, 436);
            dataGridViewDSLichThi.TabIndex = 0;
            dataGridViewDSLichThi.CellContentClick += dataGridViewDSLichThi_CellContentClick;
            dataGridViewDSLichThi.CellPainting += dataGridViewDSLichThi_CellPainting;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.BackColor = Color.SkyBlue;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThem.Location = new Point(902, 42);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 30);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiem.Location = new Point(523, 45);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm mã lịch thi / tên lịch thi";
            txtTimKiem.Size = new Size(374, 27);
            txtTimKiem.TabIndex = 4;
            // 
            // adminQlyLichThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panelChuaDSLichThi);
            Controls.Add(labelDSLichThi);
            Controls.Add(btnThem);
            Controls.Add(txtTimKiem);
            Name = "adminQlyLichThi";
            Size = new Size(1021, 573);
            Load += adminQlyLichThi_Load;
            panelChuaDSLichThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSLichThi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelDSLichThi;
        private System.Windows.Forms.Panel panelChuaDSLichThi;
        private System.Windows.Forms.DataGridView dataGridViewDSLichThi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Timer timerRefresh;
    }
}