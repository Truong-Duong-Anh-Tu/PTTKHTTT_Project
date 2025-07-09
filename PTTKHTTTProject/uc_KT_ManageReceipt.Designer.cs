namespace PTTKHTTTProject
{
    partial class uc_KT_ManageReceipt
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
            txbCount = new TextBox();
            rbxCreatedPaycheck = new RadioButton();
            rbxNotCreatedPaycheck = new RadioButton();
            lblCount = new Label();
            btnSearchReceipt = new Button();
            lblSearchReceipt = new Label();
            txbInput = new TextBox();
            dtgvResult = new DataGridView();
            pnlManageResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvResult).BeginInit();
            SuspendLayout();
            // 
            // pnlManageResult
            // 
            pnlManageResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlManageResult.Controls.Add(txbCount);
            pnlManageResult.Controls.Add(rbxCreatedPaycheck);
            pnlManageResult.Controls.Add(rbxNotCreatedPaycheck);
            pnlManageResult.Controls.Add(lblCount);
            pnlManageResult.Controls.Add(btnSearchReceipt);
            pnlManageResult.Controls.Add(lblSearchReceipt);
            pnlManageResult.Controls.Add(txbInput);
            pnlManageResult.Controls.Add(dtgvResult);
            pnlManageResult.Location = new Point(0, 0);
            pnlManageResult.Name = "pnlManageResult";
            pnlManageResult.Size = new Size(1015, 567);
            pnlManageResult.TabIndex = 2;
            // 
            // txbCount
            // 
            txbCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txbCount.BorderStyle = BorderStyle.None;
            txbCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbCount.Location = new Point(180, 40);
            txbCount.Name = "txbCount";
            txbCount.ReadOnly = true;
            txbCount.Size = new Size(161, 25);
            txbCount.TabIndex = 34;
            txbCount.Text = "NODATA";
            // 
            // rbxCreatedPaycheck
            // 
            rbxCreatedPaycheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rbxCreatedPaycheck.AutoSize = true;
            rbxCreatedPaycheck.Location = new Point(771, 39);
            rbxCreatedPaycheck.Margin = new Padding(3, 4, 3, 4);
            rbxCreatedPaycheck.Name = "rbxCreatedPaycheck";
            rbxCreatedPaycheck.Size = new Size(141, 24);
            rbxCreatedPaycheck.TabIndex = 33;
            rbxCreatedPaycheck.Text = "Đã tạo phiếu thu";
            rbxCreatedPaycheck.UseVisualStyleBackColor = true;
            // 
            // rbxNotCreatedPaycheck
            // 
            rbxNotCreatedPaycheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rbxNotCreatedPaycheck.AutoSize = true;
            rbxNotCreatedPaycheck.Checked = true;
            rbxNotCreatedPaycheck.Location = new Point(619, 39);
            rbxNotCreatedPaycheck.Margin = new Padding(3, 4, 3, 4);
            rbxNotCreatedPaycheck.Name = "rbxNotCreatedPaycheck";
            rbxNotCreatedPaycheck.Size = new Size(156, 24);
            rbxNotCreatedPaycheck.TabIndex = 32;
            rbxNotCreatedPaycheck.TabStop = true;
            rbxNotCreatedPaycheck.Text = "Chưa tạo phiếu thu";
            rbxNotCreatedPaycheck.UseVisualStyleBackColor = true;
            rbxNotCreatedPaycheck.CheckedChanged += rbxNotCreatedPaycheck_CheckedChanged;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(22, 44);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(152, 20);
            lblCount.TabIndex = 31;
            lblCount.Text = "Số yêu cầu chờ duyệt:";
            // 
            // btnSearchReceipt
            // 
            btnSearchReceipt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchReceipt.Location = new Point(907, 76);
            btnSearchReceipt.Margin = new Padding(3, 4, 3, 4);
            btnSearchReceipt.Name = "btnSearchReceipt";
            btnSearchReceipt.Size = new Size(86, 35);
            btnSearchReceipt.TabIndex = 5;
            btnSearchReceipt.Text = "Tìm";
            btnSearchReceipt.UseVisualStyleBackColor = true;
            btnSearchReceipt.Click += btnSearchReceipt_Click;
            // 
            // lblSearchReceipt
            // 
            lblSearchReceipt.AutoSize = true;
            lblSearchReceipt.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchReceipt.Location = new Point(3, 3);
            lblSearchReceipt.Name = "lblSearchReceipt";
            lblSearchReceipt.Size = new Size(296, 23);
            lblSearchReceipt.TabIndex = 4;
            lblSearchReceipt.Text = "Danh sách các khoản chờ thanh toán";
            // 
            // txbInput
            // 
            txbInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbInput.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbInput.Location = new Point(22, 76);
            txbInput.Name = "txbInput";
            txbInput.PlaceholderText = "Nhập Tên, Mã phiếu đăng ký hoặc Mã khách hàng";
            txbInput.Size = new Size(878, 30);
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
            dtgvResult.Location = new Point(22, 136);
            dtgvResult.MultiSelect = false;
            dtgvResult.Name = "dtgvResult";
            dtgvResult.RowHeadersWidth = 51;
            dtgvResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvResult.Size = new Size(971, 411);
            dtgvResult.TabIndex = 0;
            dtgvResult.CellContentClick += dtgvResult_CellContentClick;
            // 
            // uc_KT_ManageReceipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlManageResult);
            Margin = new Padding(3, 4, 3, 4);
            Name = "uc_KT_ManageReceipt";
            Size = new Size(1021, 573);
            Load += uc_KT_ManageReceipt_Load;
            pnlManageResult.ResumeLayout(false);
            pnlManageResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlManageResult;
        private Button btnSearchReceipt;
        private Label lblSearchReceipt;
        private TextBox txbInput;
        private DataGridView dtgvResult;
        private Label lblCount;
        private RadioButton rbxCreatedPaycheck;
        private RadioButton rbxNotCreatedPaycheck;
        private TextBox txbCount;
    }
}
