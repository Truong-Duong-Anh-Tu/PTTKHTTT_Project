namespace PTTKHTTTProject.UControl
{
    partial class adminQLKyThi
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
            labelDSKyThi = new Label();
            panel2 = new Panel();
            buttonXoa = new Button();
            buttonThemKyThi = new Button();
            buttonLuu = new Button();
            labelThongTinChiTiet = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxLePhi = new TextBox();
            textBoxTenKyThi = new TextBox();
            labelLePhi = new Label();
            labelTenKyThi = new Label();
            labelMaKyThi = new Label();
            textBoxMaKyThi = new TextBox();
            buttonChinhSua = new Button();
            dataGridViewDSKythi = new DataGridView();
            textBoxTimKiem = new TextBox();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSKythi).BeginInit();
            SuspendLayout();
            // 
            // labelDSKyThi
            // 
            labelDSKyThi.AutoSize = true;
            labelDSKyThi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            labelDSKyThi.Location = new Point(644, 48);
            labelDSKyThi.Margin = new Padding(5, 0, 5, 0);
            labelDSKyThi.Name = "labelDSKyThi";
            labelDSKyThi.Size = new Size(309, 50);
            labelDSKyThi.TabIndex = 3;
            labelDSKyThi.Text = "QUẢN LÝ KỲ THI";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(buttonXoa);
            panel2.Controls.Add(buttonThemKyThi);
            panel2.Controls.Add(buttonLuu);
            panel2.Controls.Add(labelThongTinChiTiet);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(buttonChinhSua);
            panel2.Location = new Point(41, 171);
            panel2.Margin = new Padding(5, 5, 5, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(691, 674);
            panel2.TabIndex = 7;
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = Color.SkyBlue;
            buttonXoa.Location = new Point(474, 456);
            buttonXoa.Margin = new Padding(5, 5, 5, 5);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(161, 59);
            buttonXoa.TabIndex = 6;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonThemKyThi
            // 
            buttonThemKyThi.BackColor = Color.SkyBlue;
            buttonThemKyThi.Location = new Point(67, 456);
            buttonThemKyThi.Margin = new Padding(5, 5, 5, 5);
            buttonThemKyThi.Name = "buttonThemKyThi";
            buttonThemKyThi.Size = new Size(153, 58);
            buttonThemKyThi.TabIndex = 5;
            buttonThemKyThi.Text = "Thêm";
            buttonThemKyThi.UseVisualStyleBackColor = false;
            buttonThemKyThi.Click += buttonThemKyThi_Click;
            // 
            // buttonLuu
            // 
            buttonLuu.BackColor = Color.SkyBlue;
            buttonLuu.Location = new Point(67, 554);
            buttonLuu.Margin = new Padding(5, 5, 5, 5);
            buttonLuu.Name = "buttonLuu";
            buttonLuu.Size = new Size(569, 59);
            buttonLuu.TabIndex = 3;
            buttonLuu.Text = "Lưu thông tin";
            buttonLuu.UseVisualStyleBackColor = false;
            buttonLuu.Click += buttonLuu_Click;
            // 
            // labelThongTinChiTiet
            // 
            labelThongTinChiTiet.AutoSize = true;
            labelThongTinChiTiet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelThongTinChiTiet.Location = new Point(26, 43);
            labelThongTinChiTiet.Margin = new Padding(5, 0, 5, 0);
            labelThongTinChiTiet.Name = "labelThongTinChiTiet";
            labelThongTinChiTiet.Size = new Size(327, 38);
            labelThongTinChiTiet.TabIndex = 2;
            labelThongTinChiTiet.Text = "Thông tin chi tiết kỳ thi";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.42857F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.57143F));
            tableLayoutPanel1.Controls.Add(textBoxLePhi, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxTenKyThi, 1, 1);
            tableLayoutPanel1.Controls.Add(labelLePhi, 0, 2);
            tableLayoutPanel1.Controls.Add(labelTenKyThi, 0, 1);
            tableLayoutPanel1.Controls.Add(labelMaKyThi, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxMaKyThi, 1, 0);
            tableLayoutPanel1.Location = new Point(67, 104);
            tableLayoutPanel1.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            tableLayoutPanel1.Size = new Size(569, 299);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // textBoxLePhi
            // 
            textBoxLePhi.Anchor = AnchorStyles.None;
            textBoxLePhi.BackColor = SystemColors.MenuBar;
            textBoxLePhi.BorderStyle = BorderStyle.None;
            textBoxLePhi.Font = new Font("Segoe UI", 10F);
            textBoxLePhi.Location = new Point(233, 232);
            textBoxLePhi.Margin = new Padding(5, 5, 5, 5);
            textBoxLePhi.Name = "textBoxLePhi";
            textBoxLePhi.Size = new Size(292, 36);
            textBoxLePhi.TabIndex = 7;
            // 
            // textBoxTenKyThi
            // 
            textBoxTenKyThi.Anchor = AnchorStyles.None;
            textBoxTenKyThi.BackColor = SystemColors.MenuBar;
            textBoxTenKyThi.BorderStyle = BorderStyle.None;
            textBoxTenKyThi.Font = new Font("Segoe UI", 10F);
            textBoxTenKyThi.Location = new Point(233, 134);
            textBoxTenKyThi.Margin = new Padding(5, 5, 5, 5);
            textBoxTenKyThi.Name = "textBoxTenKyThi";
            textBoxTenKyThi.Size = new Size(292, 36);
            textBoxTenKyThi.TabIndex = 6;
            // 
            // labelLePhi
            // 
            labelLePhi.Anchor = AnchorStyles.None;
            labelLePhi.AutoSize = true;
            labelLePhi.Location = new Point(56, 234);
            labelLePhi.Margin = new Padding(5, 0, 5, 0);
            labelLePhi.Name = "labelLePhi";
            labelLePhi.Size = new Size(79, 32);
            labelLePhi.TabIndex = 4;
            labelLePhi.Text = "Lệ phí";
            // 
            // labelTenKyThi
            // 
            labelTenKyThi.Anchor = AnchorStyles.None;
            labelTenKyThi.AutoSize = true;
            labelTenKyThi.Location = new Point(36, 136);
            labelTenKyThi.Margin = new Padding(5, 0, 5, 0);
            labelTenKyThi.Name = "labelTenKyThi";
            labelTenKyThi.Size = new Size(118, 32);
            labelTenKyThi.TabIndex = 2;
            labelTenKyThi.Text = "Tên kỳ thi";
            // 
            // labelMaKyThi
            // 
            labelMaKyThi.Anchor = AnchorStyles.None;
            labelMaKyThi.AutoSize = true;
            labelMaKyThi.Location = new Point(38, 35);
            labelMaKyThi.Margin = new Padding(5, 0, 5, 0);
            labelMaKyThi.Name = "labelMaKyThi";
            labelMaKyThi.Size = new Size(114, 32);
            labelMaKyThi.TabIndex = 0;
            labelMaKyThi.Text = "Mã kỳ thi";
            // 
            // textBoxMaKyThi
            // 
            textBoxMaKyThi.Anchor = AnchorStyles.None;
            textBoxMaKyThi.BackColor = SystemColors.MenuBar;
            textBoxMaKyThi.BorderStyle = BorderStyle.None;
            textBoxMaKyThi.Font = new Font("Segoe UI", 10F);
            textBoxMaKyThi.Location = new Point(233, 33);
            textBoxMaKyThi.Margin = new Padding(5, 5, 5, 5);
            textBoxMaKyThi.Name = "textBoxMaKyThi";
            textBoxMaKyThi.Size = new Size(292, 36);
            textBoxMaKyThi.TabIndex = 5;
            // 
            // buttonChinhSua
            // 
            buttonChinhSua.BackColor = Color.SkyBlue;
            buttonChinhSua.Location = new Point(247, 456);
            buttonChinhSua.Margin = new Padding(5, 5, 5, 5);
            buttonChinhSua.Name = "buttonChinhSua";
            buttonChinhSua.Size = new Size(197, 59);
            buttonChinhSua.TabIndex = 0;
            buttonChinhSua.Text = "Chỉnh sửa";
            buttonChinhSua.UseVisualStyleBackColor = false;
            buttonChinhSua.Click += buttonChinhSua_Click;
            // 
            // dataGridViewDSKythi
            // 
            dataGridViewDSKythi.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewDSKythi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDSKythi.Location = new Point(795, 234);
            dataGridViewDSKythi.Margin = new Padding(5, 5, 5, 5);
            dataGridViewDSKythi.Name = "dataGridViewDSKythi";
            dataGridViewDSKythi.RowHeadersWidth = 51;
            dataGridViewDSKythi.Size = new Size(785, 611);
            dataGridViewDSKythi.TabIndex = 6;
            dataGridViewDSKythi.CellClick += dataGridViewDSKythi_CellClick;
            // 
            // textBoxTimKiem
            // 
            textBoxTimKiem.Location = new Point(1155, 171);
            textBoxTimKiem.Margin = new Padding(5, 5, 5, 5);
            textBoxTimKiem.Name = "textBoxTimKiem";
            textBoxTimKiem.PlaceholderText = "Tìm mã kỳ thi / tên kỳ thi";
            textBoxTimKiem.Size = new Size(425, 39);
            textBoxTimKiem.TabIndex = 4;
            // 
            // adminQLKyThi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panel2);
            Controls.Add(labelDSKyThi);
            Controls.Add(dataGridViewDSKythi);
            Controls.Add(textBoxTimKiem);
            Margin = new Padding(5, 5, 5, 5);
            Name = "adminQLKyThi";
            Size = new Size(1659, 917);
            Load += adminQLKyThi_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSKythi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDSKyThi;
        private TextBox textBoxTimKiem;
        private DataGridView dataGridViewDSKythi;
        private Button buttonThemKyThi;
        private Panel panel2;
        private Label labelThongTinChiTiet;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonChinhSua;
        private Label labelLePhi;
        private Label labelTenKyThi;
        private Label labelMaKyThi;
        private Button buttonLuu;
        private Button buttonXoa;
        private TextBox textBoxLePhi;
        private TextBox textBoxTenKyThi;
        private TextBox textBoxMaKyThi;
    }
}
