namespace PTTKHTTTProject
{
    partial class ucManageExamResult
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
            pnlManageResult = new Panel();
            cbxExamDate = new ComboBox();
            lblChonThiSinh = new Label();
            lblChonLich = new Label();
            lblKyThi = new Label();
            lblSearchExam = new Label();
            tbxSearchCandidate = new TextBox();
            cbxExamName = new ComboBox();
            dtgvResult = new DataGridView();
            pnlManageResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvResult).BeginInit();
            SuspendLayout();
            // 
            // pnlManageResult
            // 
            pnlManageResult.Controls.Add(cbxExamDate);
            pnlManageResult.Controls.Add(lblChonThiSinh);
            pnlManageResult.Controls.Add(lblChonLich);
            pnlManageResult.Controls.Add(lblKyThi);
            pnlManageResult.Controls.Add(lblSearchExam);
            pnlManageResult.Controls.Add(tbxSearchCandidate);
            pnlManageResult.Controls.Add(cbxExamName);
            pnlManageResult.Controls.Add(dtgvResult);
            pnlManageResult.Location = new Point(3, 3);
            pnlManageResult.Name = "pnlManageResult";
            pnlManageResult.Size = new Size(1015, 567);
            pnlManageResult.TabIndex = 0;
            // 
            // cbxExamDate
            // 
            cbxExamDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxExamDate.FormattingEnabled = true;
            cbxExamDate.Location = new Point(367, 77);
            cbxExamDate.Name = "cbxExamDate";
            cbxExamDate.Size = new Size(270, 31);
            cbxExamDate.TabIndex = 9;
            cbxExamDate.SelectedIndexChanged += cbxExamDate_SelectedIndexChanged;
            // 
            // lblChonThiSinh
            // 
            lblChonThiSinh.AutoSize = true;
            lblChonThiSinh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChonThiSinh.Location = new Point(853, 51);
            lblChonThiSinh.Name = "lblChonThiSinh";
            lblChonThiSinh.Size = new Size(141, 23);
            lblChonThiSinh.TabIndex = 8;
            lblChonThiSinh.Text = "Tìm kiếm thí sinh";
            // 
            // lblChonLich
            // 
            lblChonLich.AutoSize = true;
            lblChonLich.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChonLich.Location = new Point(356, 51);
            lblChonLich.Name = "lblChonLich";
            lblChonLich.Size = new Size(125, 23);
            lblChonLich.TabIndex = 7;
            lblChonLich.Text = "Chọn Ngày Thi";
            // 
            // lblKyThi
            // 
            lblKyThi.AutoSize = true;
            lblKyThi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKyThi.Location = new Point(22, 51);
            lblKyThi.Name = "lblKyThi";
            lblKyThi.Size = new Size(102, 23);
            lblKyThi.TabIndex = 6;
            lblKyThi.Text = "Chọn Kỳ Thi";
            // 
            // lblSearchExam
            // 
            lblSearchExam.AutoSize = true;
            lblSearchExam.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchExam.Location = new Point(3, 3);
            lblSearchExam.Name = "lblSearchExam";
            lblSearchExam.Size = new Size(136, 23);
            lblSearchExam.TabIndex = 4;
            lblSearchExam.Text = "Tìm kiếm lịch thi";
            // 
            // tbxSearchCandidate
            // 
            tbxSearchCandidate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSearchCandidate.Location = new Point(742, 78);
            tbxSearchCandidate.Name = "tbxSearchCandidate";
            tbxSearchCandidate.PlaceholderText = "Số báo danh thí sinh";
            tbxSearchCandidate.Size = new Size(252, 30);
            tbxSearchCandidate.TabIndex = 3;
            tbxSearchCandidate.TextChanged += tbxSearchCandidate_TextChanged;
            // 
            // cbxExamName
            // 
            cbxExamName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxExamName.FormattingEnabled = true;
            cbxExamName.Location = new Point(22, 77);
            cbxExamName.Name = "cbxExamName";
            cbxExamName.Size = new Size(328, 31);
            cbxExamName.TabIndex = 1;
            cbxExamName.SelectedIndexChanged += cbxExamName_SelectedIndexChanged;
            // 
            // dtgvResult
            // 
            dtgvResult.AllowUserToAddRows = false;
            dtgvResult.AllowUserToDeleteRows = false;
            dtgvResult.AllowUserToOrderColumns = true;
            dtgvResult.AllowUserToResizeColumns = false;
            dtgvResult.AllowUserToResizeRows = false;
            dtgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvResult.BackgroundColor = SystemColors.ControlLightLight;
            dtgvResult.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtgvResult.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgvResult.DefaultCellStyle = dataGridViewCellStyle2;
            dtgvResult.GridColor = SystemColors.Window;
            dtgvResult.Location = new Point(22, 136);
            dtgvResult.MultiSelect = false;
            dtgvResult.Name = "dtgvResult";
            dtgvResult.ReadOnly = true;
            dtgvResult.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgvResult.RowHeadersVisible = false;
            dtgvResult.RowHeadersWidth = 51;
            dtgvResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvResult.Size = new Size(972, 410);
            dtgvResult.TabIndex = 0;
            dtgvResult.CellContentClick += dtgvResult_CellContentClick;
            dtgvResult.CellPainting += dtgvResult_CellPainting;
            // 
            // ucManageExamResult
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlManageResult);
            Name = "ucManageExamResult";
            Size = new Size(1021, 573);
            Load += ucManageExamResult_Load;
            pnlManageResult.ResumeLayout(false);
            pnlManageResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlManageResult;
        private DataGridView dtgvResult;
        private ComboBox cbxExamName;
        private TextBox tbxSearchCandidate;
        private Label lblSearchExam;
        private Label lblKyThi;
        private Label lblChonLich;
        private Label lblChonThiSinh;
        private ComboBox cbxExamDate;
    }
}
