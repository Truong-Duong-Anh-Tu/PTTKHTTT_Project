namespace PTTKHTTTProject
{
    partial class ucAssignment
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblLichPhanCong = new Label();
            pnlAssignment = new Panel();
            lblTrangThai = new Label();
            dtgvPhanCong = new DataGridView();
            tbxSearch = new TextBox();
            cbxStatus = new ComboBox();
            pnlAssignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPhanCong).BeginInit();
            SuspendLayout();
            // 
            // lblLichPhanCong
            // 
            lblLichPhanCong.AutoSize = true;
            lblLichPhanCong.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLichPhanCong.Location = new Point(12, 23);
            lblLichPhanCong.Name = "lblLichPhanCong";
            lblLichPhanCong.Size = new Size(244, 25);
            lblLichPhanCong.TabIndex = 0;
            lblLichPhanCong.Text = "LỊCH PHÂN CÔNG GÁC THI";
            // 
            // pnlAssignment
            // 
            pnlAssignment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlAssignment.Controls.Add(lblTrangThai);
            pnlAssignment.Controls.Add(dtgvPhanCong);
            pnlAssignment.Controls.Add(tbxSearch);
            pnlAssignment.Controls.Add(cbxStatus);
            pnlAssignment.Controls.Add(lblLichPhanCong);
            pnlAssignment.Location = new Point(3, 3);
            pnlAssignment.Name = "pnlAssignment";
            pnlAssignment.Size = new Size(1009, 561);
            pnlAssignment.TabIndex = 1;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrangThai.Location = new Point(23, 99);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(92, 23);
            lblTrangThai.TabIndex = 4;
            lblTrangThai.Text = "Trạng thái";
            // 
            // dtgvPhanCong
            // 
            dtgvPhanCong.AllowUserToAddRows = false;
            dtgvPhanCong.AllowUserToDeleteRows = false;
            dtgvPhanCong.AllowUserToOrderColumns = true;
            dtgvPhanCong.AllowUserToResizeColumns = false;
            dtgvPhanCong.AllowUserToResizeRows = false;
            dtgvPhanCong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvPhanCong.BackgroundColor = SystemColors.ControlLightLight;
            dtgvPhanCong.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvPhanCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvPhanCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgvPhanCong.DefaultCellStyle = dataGridViewCellStyle2;
            dtgvPhanCong.Location = new Point(23, 188);
            dtgvPhanCong.MultiSelect = false;
            dtgvPhanCong.Name = "dtgvPhanCong";
            dtgvPhanCong.ReadOnly = true;
            dtgvPhanCong.RowHeadersVisible = false;
            dtgvPhanCong.RowHeadersWidth = 51;
            dtgvPhanCong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvPhanCong.Size = new Size(965, 340);
            dtgvPhanCong.TabIndex = 3;
            // 
            // tbxSearch
            // 
            tbxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSearch.Location = new Point(677, 125);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.PlaceholderText = "Nhập mã nhân viên";
            tbxSearch.Size = new Size(311, 30);
            tbxSearch.TabIndex = 2;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // cbxStatus
            // 
            cbxStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Tất cả", "Chưa diễn ra", "Hoàn thành" });
            cbxStatus.Location = new Point(23, 125);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(262, 31);
            cbxStatus.TabIndex = 1;
            cbxStatus.SelectedIndexChanged += cbxStatus_SelectedIndexChanged;
            // 
            // ucAssignment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlAssignment);
            Name = "ucAssignment";
            Size = new Size(1015, 567);
            Load += ucAssignment_Load;
            pnlAssignment.ResumeLayout(false);
            pnlAssignment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPhanCong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblLichPhanCong;
        private Panel pnlAssignment;
        private TextBox tbxSearch;
        private ComboBox cbxStatus;
        private DataGridView dtgvPhanCong;
        private Label lblTrangThai;
    }
}
