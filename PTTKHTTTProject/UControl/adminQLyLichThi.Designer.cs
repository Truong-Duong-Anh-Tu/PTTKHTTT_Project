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
            labelDSLichThi.Location = new Point(37, 37);
            labelDSLichThi.Margin = new Padding(5, 0, 5, 0);
            labelDSLichThi.Name = "labelDSLichThi";
            labelDSLichThi.Size = new Size(403, 50);
            labelDSLichThi.TabIndex = 2;
            labelDSLichThi.Text = "DANH SÁCH LỊCH THI";
            // 
            // panelChuaDSLichThi
            // 
            panelChuaDSLichThi.BackColor = SystemColors.Control;
            panelChuaDSLichThi.Controls.Add(dataGridViewDSLichThi);
            panelChuaDSLichThi.Location = new Point(23, 142);
            panelChuaDSLichThi.Margin = new Padding(5);
            panelChuaDSLichThi.Name = "panelChuaDSLichThi";
            panelChuaDSLichThi.Size = new Size(1606, 754);
            panelChuaDSLichThi.TabIndex = 1;
            // 
            // dataGridViewDSLichThi
            // 
            dataGridViewDSLichThi.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewDSLichThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDSLichThi.Location = new Point(36, 29);
            dataGridViewDSLichThi.Margin = new Padding(5);
            dataGridViewDSLichThi.Name = "dataGridViewDSLichThi";
            dataGridViewDSLichThi.RowHeadersWidth = 51;
            dataGridViewDSLichThi.Size = new Size(1524, 698);
            dataGridViewDSLichThi.TabIndex = 0;
            dataGridViewDSLichThi.CellContentClick += dataGridViewDSLichThi_CellContentClick;
            dataGridViewDSLichThi.CellPainting += dataGridViewDSLichThi_CellPainting;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SkyBlue;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThem.Location = new Point(1466, 67);
            btnThem.Margin = new Padding(5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(162, 48);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(850, 72);
            txtTimKiem.Margin = new Padding(5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm mã lịch thi / tên lịch thi";
            txtTimKiem.Size = new Size(606, 39);
            txtTimKiem.TabIndex = 4;
            // 
            // adminQlyLichThi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panelChuaDSLichThi);
            Controls.Add(labelDSLichThi);
            Controls.Add(btnThem);
            Controls.Add(txtTimKiem);
            Margin = new Padding(5);
            Name = "adminQlyLichThi";
            Size = new Size(1659, 917);
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