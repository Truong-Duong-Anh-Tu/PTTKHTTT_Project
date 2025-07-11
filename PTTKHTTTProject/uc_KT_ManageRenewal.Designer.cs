namespace PTTKHTTTProject
{
    partial class uc_KT_ManageRenewal
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
            rbxCreatedRenewal = new RadioButton();
            rbxPendingRenewal = new RadioButton();
            lblCount = new Label();
            txbCount = new TextBox();
            btnSearchRenewal = new Button();
            lblSearchRenewal = new Label();
            txbInput = new TextBox();
            dtgvResult = new DataGridView();
            pnlManageResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvResult).BeginInit();
            SuspendLayout();
            // 
            // pnlManageResult
            // 
            pnlManageResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlManageResult.Controls.Add(rbxCreatedRenewal);
            pnlManageResult.Controls.Add(rbxPendingRenewal);
            pnlManageResult.Controls.Add(lblCount);
            pnlManageResult.Controls.Add(txbCount);
            pnlManageResult.Controls.Add(btnSearchRenewal);
            pnlManageResult.Controls.Add(lblSearchRenewal);
            pnlManageResult.Controls.Add(txbInput);
            pnlManageResult.Controls.Add(dtgvResult);
            pnlManageResult.Location = new Point(0, 0);
            pnlManageResult.Margin = new Padding(3, 2, 3, 2);
            pnlManageResult.Name = "pnlManageResult";
            pnlManageResult.Size = new Size(888, 425);
            pnlManageResult.TabIndex = 1;
            // 
            // rbxCreatedRenewal
            // 
            rbxCreatedRenewal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rbxCreatedRenewal.AutoSize = true;
            rbxCreatedRenewal.Location = new Point(677, 29);
            rbxCreatedRenewal.Name = "rbxCreatedRenewal";
            rbxCreatedRenewal.Size = new Size(134, 19);
            rbxCreatedRenewal.TabIndex = 34;
            rbxCreatedRenewal.Text = "Đã tạo phiếu gia hạn";
            rbxCreatedRenewal.UseVisualStyleBackColor = true;
            // 
            // rbxPendingRenewal
            // 
            rbxPendingRenewal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rbxPendingRenewal.AutoSize = true;
            rbxPendingRenewal.Checked = true;
            rbxPendingRenewal.Location = new Point(550, 29);
            rbxPendingRenewal.Name = "rbxPendingRenewal";
            rbxPendingRenewal.Size = new Size(108, 19);
            rbxPendingRenewal.TabIndex = 33;
            rbxPendingRenewal.TabStop = true;
            rbxPendingRenewal.Text = "Yêu cầu gia hạn";
            rbxPendingRenewal.UseVisualStyleBackColor = true;
            rbxPendingRenewal.CheckedChanged += rbxPendingRenewal_CheckedChanged;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(19, 33);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(123, 15);
            lblCount.TabIndex = 32;
            lblCount.Text = "Số yêu cầu chờ duyệt:";
            // 
            // txbCount
            // 
            txbCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txbCount.BorderStyle = BorderStyle.None;
            txbCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbCount.Location = new Point(158, 29);
            txbCount.Margin = new Padding(3, 2, 3, 2);
            txbCount.Name = "txbCount";
            txbCount.ReadOnly = true;
            txbCount.Size = new Size(141, 20);
            txbCount.TabIndex = 28;
            txbCount.Text = "NODATA";
            // 
            // btnSearchRenewal
            // 
            btnSearchRenewal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchRenewal.Location = new Point(794, 57);
            btnSearchRenewal.Name = "btnSearchRenewal";
            btnSearchRenewal.Size = new Size(75, 26);
            btnSearchRenewal.TabIndex = 5;
            btnSearchRenewal.Text = "Tìm";
            btnSearchRenewal.UseVisualStyleBackColor = true;
            btnSearchRenewal.Click += btnSearchRenewal_Click;
            // 
            // lblSearchRenewal
            // 
            lblSearchRenewal.AutoSize = true;
            lblSearchRenewal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchRenewal.Location = new Point(3, 2);
            lblSearchRenewal.Name = "lblSearchRenewal";
            lblSearchRenewal.Size = new Size(215, 19);
            lblSearchRenewal.TabIndex = 4;
            lblSearchRenewal.Text = "Danh sách chờ tạo phiếu gia hạn";
            // 
            // txbInput
            // 
            txbInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbInput.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbInput.Location = new Point(19, 57);
            txbInput.Margin = new Padding(3, 2, 3, 2);
            txbInput.Name = "txbInput";
            txbInput.PlaceholderText = "Nhập Tên hoặc Mã thí sinh";
            txbInput.Size = new Size(769, 26);
            txbInput.TabIndex = 3;
            // 
            // dtgvResult
            // 
            dtgvResult.AllowUserToAddRows = false;
            dtgvResult.AllowUserToDeleteRows = false;
            dtgvResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvResult.BackgroundColor = SystemColors.ControlLightLight;
            dtgvResult.BorderStyle = BorderStyle.None;
            dtgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvResult.Location = new Point(19, 102);
            dtgvResult.Margin = new Padding(3, 2, 3, 2);
            dtgvResult.MultiSelect = false;
            dtgvResult.Name = "dtgvResult";
            dtgvResult.RowHeadersWidth = 51;
            dtgvResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvResult.Size = new Size(850, 308);
            dtgvResult.TabIndex = 0;
            // 
            // uc_KT_ManageRenewal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlManageResult);
            Name = "uc_KT_ManageRenewal";
            Size = new Size(893, 430);
            Load += uc_KT_ManageRenewal_Load;
            pnlManageResult.ResumeLayout(false);
            pnlManageResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlManageResult;
        private Label lblSearchRenewal;
        private TextBox txbInput;
        private DataGridView dtgvResult;
        private Button btnSearchRenewal;
        private TextBox txbCount;
        private Label lblCount;
        private RadioButton rbxPendingRenewal;
        private RadioButton rbxCreatedRenewal;
    }
}
