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
            numericUpDownHienThiLePhi = new NumericUpDown();
            textBoxTenKyThi = new TextBox();
            labelLePhi = new Label();
            labelTenKyThi = new Label();
            labelMaKyThi = new Label();
            textBoxMaKyThi = new TextBox();
            buttonChinhSua = new Button();
            dataGridViewDSKythi = new DataGridView();
            buttonTimKiem = new Button();
            textBoxTimKiem = new TextBox();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHienThiLePhi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSKythi).BeginInit();
            SuspendLayout();
            // 
            // labelDSKyThi
            // 
            labelDSKyThi.AutoSize = true;
            labelDSKyThi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            labelDSKyThi.Location = new Point(397, 34);
            labelDSKyThi.Name = "labelDSKyThi";
            labelDSKyThi.Size = new Size(192, 31);
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
            panel2.Location = new Point(25, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(478, 421);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = Color.SkyBlue;
            buttonXoa.Location = new Point(292, 285);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(99, 37);
            buttonXoa.TabIndex = 6;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonThemKyThi
            // 
            buttonThemKyThi.BackColor = Color.SkyBlue;
            buttonThemKyThi.Location = new Point(41, 285);
            buttonThemKyThi.Name = "buttonThemKyThi";
            buttonThemKyThi.Size = new Size(94, 36);
            buttonThemKyThi.TabIndex = 5;
            buttonThemKyThi.Text = "Thêm";
            buttonThemKyThi.UseVisualStyleBackColor = false;
            buttonThemKyThi.Click += buttonThemKyThi_Click;
            // 
            // buttonLuu
            // 
            buttonLuu.BackColor = Color.SkyBlue;
            buttonLuu.Location = new Point(41, 346);
            buttonLuu.Name = "buttonLuu";
            buttonLuu.Size = new Size(350, 37);
            buttonLuu.TabIndex = 3;
            buttonLuu.Text = "Lưu thông tin";
            buttonLuu.UseVisualStyleBackColor = false;
            buttonLuu.Click += buttonLuu_Click;
            // 
            // labelThongTinChiTiet
            // 
            labelThongTinChiTiet.AutoSize = true;
            labelThongTinChiTiet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelThongTinChiTiet.Location = new Point(16, 27);
            labelThongTinChiTiet.Name = "labelThongTinChiTiet";
            labelThongTinChiTiet.Size = new Size(200, 23);
            labelThongTinChiTiet.TabIndex = 2;
            labelThongTinChiTiet.Text = "Thông tin chi tiết kỳ thi";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5827332F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.41727F));
            tableLayoutPanel1.Controls.Add(numericUpDownHienThiLePhi, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxTenKyThi, 1, 1);
            tableLayoutPanel1.Controls.Add(labelLePhi, 0, 2);
            tableLayoutPanel1.Controls.Add(labelTenKyThi, 0, 1);
            tableLayoutPanel1.Controls.Add(labelMaKyThi, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxMaKyThi, 1, 0);
            tableLayoutPanel1.Location = new Point(41, 65);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.Size = new Size(418, 187);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // numericUpDownHienThiLePhi
            // 
            numericUpDownHienThiLePhi.Anchor = AnchorStyles.None;
            numericUpDownHienThiLePhi.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
            numericUpDownHienThiLePhi.Location = new Point(134, 143);
            numericUpDownHienThiLePhi.Maximum = new decimal(new int[] { 50000000, 0, 0, 0 });
            numericUpDownHienThiLePhi.Minimum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownHienThiLePhi.Name = "numericUpDownHienThiLePhi";
            numericUpDownHienThiLePhi.Size = new Size(239, 27);
            numericUpDownHienThiLePhi.TabIndex = 7;
            numericUpDownHienThiLePhi.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // textBoxTenKyThi
            // 
            textBoxTenKyThi.Anchor = AnchorStyles.None;
            textBoxTenKyThi.BackColor = SystemColors.MenuBar;
            textBoxTenKyThi.BorderStyle = BorderStyle.None;
            textBoxTenKyThi.Font = new Font("Segoe UI", 10F);
            textBoxTenKyThi.Location = new Point(135, 83);
            textBoxTenKyThi.Name = "textBoxTenKyThi";
            textBoxTenKyThi.Size = new Size(238, 23);
            textBoxTenKyThi.TabIndex = 6;
            // 
            // labelLePhi
            // 
            labelLePhi.Anchor = AnchorStyles.None;
            labelLePhi.AutoSize = true;
            labelLePhi.Location = new Point(21, 146);
            labelLePhi.Name = "labelLePhi";
            labelLePhi.Size = new Size(49, 20);
            labelLePhi.TabIndex = 4;
            labelLePhi.Text = "Lệ phí";
            // 
            // labelTenKyThi
            // 
            labelTenKyThi.Anchor = AnchorStyles.None;
            labelTenKyThi.AutoSize = true;
            labelTenKyThi.Location = new Point(10, 85);
            labelTenKyThi.Name = "labelTenKyThi";
            labelTenKyThi.Size = new Size(71, 20);
            labelTenKyThi.TabIndex = 2;
            labelTenKyThi.Text = "Tên kỳ thi";
            // 
            // labelMaKyThi
            // 
            labelMaKyThi.Anchor = AnchorStyles.None;
            labelMaKyThi.AutoSize = true;
            labelMaKyThi.Location = new Point(11, 22);
            labelMaKyThi.Name = "labelMaKyThi";
            labelMaKyThi.Size = new Size(69, 20);
            labelMaKyThi.TabIndex = 0;
            labelMaKyThi.Text = "Mã kỳ thi";
            // 
            // textBoxMaKyThi
            // 
            textBoxMaKyThi.Anchor = AnchorStyles.None;
            textBoxMaKyThi.BackColor = SystemColors.MenuBar;
            textBoxMaKyThi.BorderStyle = BorderStyle.None;
            textBoxMaKyThi.Font = new Font("Segoe UI", 10F);
            textBoxMaKyThi.Location = new Point(133, 20);
            textBoxMaKyThi.Name = "textBoxMaKyThi";
            textBoxMaKyThi.Size = new Size(241, 23);
            textBoxMaKyThi.TabIndex = 5;
            // 
            // buttonChinhSua
            // 
            buttonChinhSua.BackColor = Color.SkyBlue;
            buttonChinhSua.Location = new Point(152, 285);
            buttonChinhSua.Name = "buttonChinhSua";
            buttonChinhSua.Size = new Size(121, 37);
            buttonChinhSua.TabIndex = 0;
            buttonChinhSua.Text = "Chỉnh sửa";
            buttonChinhSua.UseVisualStyleBackColor = false;
            buttonChinhSua.Click += buttonChinhSua_Click;
            // 
            // dataGridViewDSKythi
            // 
            dataGridViewDSKythi.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewDSKythi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDSKythi.Location = new Point(519, 146);
            dataGridViewDSKythi.Name = "dataGridViewDSKythi";
            dataGridViewDSKythi.RowHeadersWidth = 51;
            dataGridViewDSKythi.Size = new Size(483, 382);
            dataGridViewDSKythi.TabIndex = 6;
            dataGridViewDSKythi.CellClick += dataGridViewDSKythi_CellClick;
            // 
            // buttonTimKiem
            // 
            buttonTimKiem.BackColor = Color.SkyBlue;
            buttonTimKiem.Location = new Point(908, 101);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(94, 33);
            buttonTimKiem.TabIndex = 5;
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.UseVisualStyleBackColor = false;
            buttonTimKiem.Click += buttonTimKiem_Click;
            // 
            // textBoxTimKiem
            // 
            textBoxTimKiem.Location = new Point(644, 107);
            textBoxTimKiem.Name = "textBoxTimKiem";
            textBoxTimKiem.PlaceholderText = "Tìm mã kỳ thi / tên kỳ thi";
            textBoxTimKiem.Size = new Size(247, 27);
            textBoxTimKiem.TabIndex = 4;
            // 
            // adminQLKyThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panel2);
            Controls.Add(labelDSKyThi);
            Controls.Add(dataGridViewDSKythi);
            Controls.Add(textBoxTimKiem);
            Controls.Add(buttonTimKiem);
            Name = "adminQLKyThi";
            Size = new Size(1021, 573);
            Load += adminQLKyThi_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHienThiLePhi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSKythi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDSKyThi;
        private Button buttonTimKiem;
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
        private TextBox textBoxTenKyThi;
        private TextBox textBoxMaKyThi;
        private NumericUpDown numericUpDownHienThiLePhi;
    }
}
