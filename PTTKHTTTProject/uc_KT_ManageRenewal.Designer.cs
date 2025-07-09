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
            lblSearchReceipt = new Label();
            txbInput = new TextBox();
            dtgvResult = new DataGridView();
            pnlManageResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvResult).BeginInit();
            SuspendLayout();
            // 
            // pnlManageResult
            // 
            pnlManageResult.Controls.Add(rbxCreatedRenewal);
            pnlManageResult.Controls.Add(rbxPendingRenewal);
            pnlManageResult.Controls.Add(lblCount);
            pnlManageResult.Controls.Add(txbCount);
            pnlManageResult.Controls.Add(btnSearchRenewal);
            pnlManageResult.Controls.Add(lblSearchReceipt);
            pnlManageResult.Controls.Add(txbInput);
            pnlManageResult.Controls.Add(dtgvResult);
            pnlManageResult.Location = new Point(0, 0);
            pnlManageResult.Name = "pnlManageResult";
            pnlManageResult.Size = new Size(1015, 567);
            pnlManageResult.TabIndex = 1;
            // 
            // rbxCreatedRenewal
            // 
            rbxCreatedRenewal.AutoSize = true;
            rbxCreatedRenewal.Location = new Point(747, 39);
            rbxCreatedRenewal.Margin = new Padding(3, 4, 3, 4);
            rbxCreatedRenewal.Name = "rbxCreatedRenewal";
            rbxCreatedRenewal.Size = new Size(169, 24);
            rbxCreatedRenewal.TabIndex = 34;
            rbxCreatedRenewal.Text = "Đã tạo phiếu gia hạn";
            rbxCreatedRenewal.UseVisualStyleBackColor = true;
            // 
            // rbxPendingRenewal
            // 
            rbxPendingRenewal.AutoSize = true;
            rbxPendingRenewal.Checked = true;
            rbxPendingRenewal.Location = new Point(619, 39);
            rbxPendingRenewal.Margin = new Padding(3, 4, 3, 4);
            rbxPendingRenewal.Name = "rbxPendingRenewal";
            rbxPendingRenewal.Size = new Size(133, 24);
            rbxPendingRenewal.TabIndex = 33;
            rbxPendingRenewal.TabStop = true;
            rbxPendingRenewal.Text = "Yêu cầu gia hạn";
            rbxPendingRenewal.UseVisualStyleBackColor = true;
            rbxPendingRenewal.CheckedChanged += rbxPendingRenewal_CheckedChanged;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(22, 44);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(152, 20);
            lblCount.TabIndex = 32;
            lblCount.Text = "Số yêu cầu chờ duyệt:";
            // 
            // txbCount
            // 
            txbCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txbCount.BorderStyle = BorderStyle.None;
            txbCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbCount.Location = new Point(180, 39);
            txbCount.Name = "txbCount";
            txbCount.ReadOnly = true;
            txbCount.Size = new Size(161, 25);
            txbCount.TabIndex = 28;
            txbCount.Text = "NODATA";
            // 
            // btnSearchRenewal
            // 
            btnSearchRenewal.Location = new Point(907, 76);
            btnSearchRenewal.Margin = new Padding(3, 4, 3, 4);
            btnSearchRenewal.Name = "btnSearchRenewal";
            btnSearchRenewal.Size = new Size(86, 35);
            btnSearchRenewal.TabIndex = 5;
            btnSearchRenewal.Text = "Tìm";
            btnSearchRenewal.UseVisualStyleBackColor = true;
            btnSearchRenewal.Click += btnSearchRenewal_Click;
            // 
            // lblSearchReceipt
            // 
            lblSearchReceipt.AutoSize = true;
            lblSearchReceipt.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchReceipt.Location = new Point(3, 3);
            lblSearchReceipt.Name = "lblSearchReceipt";
            lblSearchReceipt.Size = new Size(263, 23);
            lblSearchReceipt.TabIndex = 4;
            lblSearchReceipt.Text = "Danh sách chờ tạo phiếu gia hạn";
            // 
            // txbInput
            // 
            txbInput.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbInput.Location = new Point(22, 76);
            txbInput.Name = "txbInput";
            txbInput.PlaceholderText = "Nhập Tên hoặc Mã thí sinh";
            txbInput.Size = new Size(878, 30);
            txbInput.TabIndex = 3;
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
            dtgvResult.Size = new Size(971, 411);
            dtgvResult.TabIndex = 0;
            // 
            // uc_KT_ManageRenewal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlManageResult);
            Margin = new Padding(3, 4, 3, 4);
            Name = "uc_KT_ManageRenewal";
            Size = new Size(1021, 573);
            Load += uc_KT_ManageRenewal_Load;
            pnlManageResult.ResumeLayout(false);
            pnlManageResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlManageResult;
        private Label lblSearchReceipt;
        private TextBox txbInput;
        private DataGridView dtgvResult;
        private Button btnSearchRenewal;
        private TextBox txbCount;
        private Label lblCount;
        private RadioButton rbxPendingRenewal;
        private RadioButton rbxCreatedRenewal;
    }
}
