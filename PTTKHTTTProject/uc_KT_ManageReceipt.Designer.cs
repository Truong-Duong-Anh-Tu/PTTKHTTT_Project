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
            cbxCreatedPaycheck = new RadioButton();
            rbxNotCreatedPaycheck = new RadioButton();
            label1 = new Label();
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
            pnlManageResult.Controls.Add(cbxCreatedPaycheck);
            pnlManageResult.Controls.Add(rbxNotCreatedPaycheck);
            pnlManageResult.Controls.Add(label1);
            pnlManageResult.Controls.Add(btnSearchReceipt);
            pnlManageResult.Controls.Add(lblSearchReceipt);
            pnlManageResult.Controls.Add(txbInput);
            pnlManageResult.Controls.Add(dtgvResult);
            pnlManageResult.Location = new Point(0, 0);
            pnlManageResult.Margin = new Padding(3, 2, 3, 2);
            pnlManageResult.Name = "pnlManageResult";
            pnlManageResult.Size = new Size(888, 425);
            pnlManageResult.TabIndex = 2;
            // 
            // cbxCreatedPaycheck
            // 
            cbxCreatedPaycheck.AutoSize = true;
            cbxCreatedPaycheck.Location = new Point(675, 29);
            cbxCreatedPaycheck.Name = "cbxCreatedPaycheck";
            cbxCreatedPaycheck.Size = new Size(113, 19);
            cbxCreatedPaycheck.TabIndex = 33;
            cbxCreatedPaycheck.Text = "Đã tạo phiếu thu";
            cbxCreatedPaycheck.UseVisualStyleBackColor = true;
            // 
            // rbxNotCreatedPaycheck
            // 
            rbxNotCreatedPaycheck.AutoSize = true;
            rbxNotCreatedPaycheck.Checked = true;
            rbxNotCreatedPaycheck.Location = new Point(542, 29);
            rbxNotCreatedPaycheck.Name = "rbxNotCreatedPaycheck";
            rbxNotCreatedPaycheck.Size = new Size(127, 19);
            rbxNotCreatedPaycheck.TabIndex = 32;
            rbxNotCreatedPaycheck.TabStop = true;
            rbxNotCreatedPaycheck.Text = "Chưa tạo phiếu thu";
            rbxNotCreatedPaycheck.UseVisualStyleBackColor = true;
            rbxNotCreatedPaycheck.CheckedChanged += rbxNotCreatedPaycheck_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 33);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 31;
            label1.Text = "Số yêu cầu chờ duyệt";
            // 
            // btnSearchReceipt
            // 
            btnSearchReceipt.Location = new Point(794, 57);
            btnSearchReceipt.Name = "btnSearchReceipt";
            btnSearchReceipt.Size = new Size(75, 26);
            btnSearchReceipt.TabIndex = 5;
            btnSearchReceipt.Text = "Tìm";
            btnSearchReceipt.UseVisualStyleBackColor = true;
            btnSearchReceipt.Click += btnSearchReceipt_Click;
            // 
            // lblSearchReceipt
            // 
            lblSearchReceipt.AutoSize = true;
            lblSearchReceipt.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchReceipt.Location = new Point(3, 2);
            lblSearchReceipt.Name = "lblSearchReceipt";
            lblSearchReceipt.Size = new Size(241, 19);
            lblSearchReceipt.TabIndex = 4;
            lblSearchReceipt.Text = "Danh sách các khoản chờ thanh toán";
            // 
            // txbInput
            // 
            txbInput.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbInput.Location = new Point(19, 57);
            txbInput.Margin = new Padding(3, 2, 3, 2);
            txbInput.Name = "txbInput";
            txbInput.PlaceholderText = "Nhập Tên hoặc Mã khách hàng";
            txbInput.Size = new Size(769, 26);
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
            dtgvResult.Location = new Point(19, 102);
            dtgvResult.Margin = new Padding(3, 2, 3, 2);
            dtgvResult.MultiSelect = false;
            dtgvResult.Name = "dtgvResult";
            dtgvResult.RowHeadersWidth = 51;
            dtgvResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvResult.Size = new Size(850, 308);
            dtgvResult.TabIndex = 0;
            dtgvResult.CellContentClick += dtgvResult_CellContentClick;
            // 
            // uc_KT_ManageReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlManageResult);
            Name = "uc_KT_ManageReceipt";
            Size = new Size(893, 430);
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
        private Label label1;
        private RadioButton cbxCreatedPaycheck;
        private RadioButton rbxNotCreatedPaycheck;
    }
}
