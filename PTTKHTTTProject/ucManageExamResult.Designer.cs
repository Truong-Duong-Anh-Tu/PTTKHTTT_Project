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
            pnlManageResult = new Panel();
            lblChonThiSinh = new Label();
            lblChonLich = new Label();
            lblKyThi = new Label();
            dtpExamDate = new DateTimePicker();
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
            pnlManageResult.Controls.Add(lblChonThiSinh);
            pnlManageResult.Controls.Add(lblChonLich);
            pnlManageResult.Controls.Add(lblKyThi);
            pnlManageResult.Controls.Add(dtpExamDate);
            pnlManageResult.Controls.Add(lblSearchExam);
            pnlManageResult.Controls.Add(tbxSearchCandidate);
            pnlManageResult.Controls.Add(cbxExamName);
            pnlManageResult.Controls.Add(dtgvResult);
            pnlManageResult.Location = new Point(3, 3);
            pnlManageResult.Name = "pnlManageResult";
            pnlManageResult.Size = new Size(1015, 567);
            pnlManageResult.TabIndex = 0;
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
            // dtpExamDate
            // 
            dtpExamDate.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpExamDate.CustomFormat = "";
            dtpExamDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpExamDate.Format = DateTimePickerFormat.Custom;
            dtpExamDate.Location = new Point(356, 77);
            dtpExamDate.Name = "dtpExamDate";
            dtpExamDate.Size = new Size(241, 30);
            dtpExamDate.TabIndex = 5;
            dtpExamDate.ValueChanged += dtpExamDate_ValueChanged;
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
            dtgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvResult.BackgroundColor = SystemColors.ControlLightLight;
            dtgvResult.BorderStyle = BorderStyle.None;
            dtgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvResult.Location = new Point(22, 136);
            dtgvResult.MultiSelect = false;
            dtgvResult.Name = "dtgvResult";
            dtgvResult.RowHeadersWidth = 51;
            dtgvResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvResult.Size = new Size(972, 410);
            dtgvResult.TabIndex = 0;
            dtgvResult.CellContentClick += dtgvResult_CellContentClick;
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
        private DateTimePicker dtpExamDate;
        private Label lblChonLich;
        private Label lblChonThiSinh;
    }
}
