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
            dtgvPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvPhanCong.BackgroundColor = SystemColors.ControlLightLight;
            dtgvPhanCong.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtgvPhanCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            tbxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSearch.Location = new Point(677, 125);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.PlaceholderText = "Nhập mã nhân viên";
            tbxSearch.Size = new Size(311, 30);
            tbxSearch.TabIndex = 2;
            // 
            // cbxStatus
            // 
            cbxStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Location = new Point(23, 125);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(262, 31);
            cbxStatus.TabIndex = 1;
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
