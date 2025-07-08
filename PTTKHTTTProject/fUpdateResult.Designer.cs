namespace PTTKHTTTProject
{
    partial class fUpdateResult
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlResultExamInfo = new Panel();
            tbxPoint = new TextBox();
            dtpdoExamTime = new DateTimePicker();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            tbxDVCT = new TextBox();
            tbxSBD = new TextBox();
            tbxName = new TextBox();
            tbxExamDate = new TextBox();
            tbxExamType = new TextBox();
            lblDVCT = new Label();
            lblTime = new Label();
            lblPoint = new Label();
            lblExamDate = new Label();
            lblExamType = new Label();
            lblSBD = new Label();
            lblName = new Label();
            label1 = new Label();
            pnlResultExamInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlResultExamInfo
            // 
            pnlResultExamInfo.Controls.Add(tbxPoint);
            pnlResultExamInfo.Controls.Add(dtpdoExamTime);
            pnlResultExamInfo.Controls.Add(btnExit);
            pnlResultExamInfo.Controls.Add(btnDelete);
            pnlResultExamInfo.Controls.Add(btnUpdate);
            pnlResultExamInfo.Controls.Add(tbxDVCT);
            pnlResultExamInfo.Controls.Add(tbxSBD);
            pnlResultExamInfo.Controls.Add(tbxName);
            pnlResultExamInfo.Controls.Add(tbxExamDate);
            pnlResultExamInfo.Controls.Add(tbxExamType);
            pnlResultExamInfo.Controls.Add(lblDVCT);
            pnlResultExamInfo.Controls.Add(lblTime);
            pnlResultExamInfo.Controls.Add(lblPoint);
            pnlResultExamInfo.Controls.Add(lblExamDate);
            pnlResultExamInfo.Controls.Add(lblExamType);
            pnlResultExamInfo.Controls.Add(lblSBD);
            pnlResultExamInfo.Controls.Add(lblName);
            pnlResultExamInfo.Controls.Add(label1);
            pnlResultExamInfo.Location = new Point(12, 12);
            pnlResultExamInfo.Name = "pnlResultExamInfo";
            pnlResultExamInfo.Size = new Size(605, 371);
            pnlResultExamInfo.TabIndex = 0;
            // 
            // tbxPoint
            // 
            tbxPoint.BackColor = SystemColors.Window;
            tbxPoint.BorderStyle = BorderStyle.FixedSingle;
            tbxPoint.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxPoint.ForeColor = SystemColors.WindowText;
            tbxPoint.Location = new Point(477, 160);
            tbxPoint.Name = "tbxPoint";
            tbxPoint.Size = new Size(78, 38);
            tbxPoint.TabIndex = 18;
            tbxPoint.TextAlign = HorizontalAlignment.Center;
            // 
            // dtpdoExamTime
            // 
            dtpdoExamTime.CustomFormat = "HH:mm:ss";
            dtpdoExamTime.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpdoExamTime.Format = DateTimePickerFormat.Custom;
            dtpdoExamTime.Location = new Point(154, 237);
            dtpdoExamTime.Name = "dtpdoExamTime";
            dtpdoExamTime.ShowUpDown = true;
            dtpdoExamTime.Size = new Size(115, 30);
            dtpdoExamTime.TabIndex = 17;
            dtpdoExamTime.Value = new DateTime(2025, 7, 4, 0, 0, 0, 0);
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkGray;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ControlLightLight;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btnExit.IconColor = Color.White;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnExit.IconSize = 25;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(477, 321);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 35);
            btnExit.TabIndex = 16;
            btnExit.Text = "Thoát";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.OrangeRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnDelete.IconColor = Color.White;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnDelete.IconSize = 20;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(371, 321);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Loại bỏ";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DeepSkyBlue;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnUpdate.IconColor = Color.White;
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnUpdate.IconSize = 20;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(265, 321);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 35);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbxDVCT
            // 
            tbxDVCT.BorderStyle = BorderStyle.FixedSingle;
            tbxDVCT.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxDVCT.Location = new Point(154, 280);
            tbxDVCT.Name = "tbxDVCT";
            tbxDVCT.Size = new Size(265, 30);
            tbxDVCT.TabIndex = 12;
            // 
            // tbxSBD
            // 
            tbxSBD.BackColor = SystemColors.Window;
            tbxSBD.BorderStyle = BorderStyle.None;
            tbxSBD.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSBD.Location = new Point(154, 200);
            tbxSBD.Name = "tbxSBD";
            tbxSBD.ReadOnly = true;
            tbxSBD.Size = new Size(265, 23);
            tbxSBD.TabIndex = 11;
            // 
            // tbxName
            // 
            tbxName.BackColor = SystemColors.Window;
            tbxName.BorderStyle = BorderStyle.None;
            tbxName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxName.Location = new Point(154, 160);
            tbxName.Name = "tbxName";
            tbxName.ReadOnly = true;
            tbxName.Size = new Size(265, 23);
            tbxName.TabIndex = 10;
            // 
            // tbxExamDate
            // 
            tbxExamDate.BackColor = SystemColors.Window;
            tbxExamDate.BorderStyle = BorderStyle.None;
            tbxExamDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxExamDate.Location = new Point(125, 91);
            tbxExamDate.Name = "tbxExamDate";
            tbxExamDate.ReadOnly = true;
            tbxExamDate.Size = new Size(430, 23);
            tbxExamDate.TabIndex = 9;
            // 
            // tbxExamType
            // 
            tbxExamType.BackColor = SystemColors.Window;
            tbxExamType.BorderStyle = BorderStyle.None;
            tbxExamType.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxExamType.Location = new Point(125, 49);
            tbxExamType.Name = "tbxExamType";
            tbxExamType.ReadOnly = true;
            tbxExamType.Size = new Size(430, 23);
            tbxExamType.TabIndex = 8;
            // 
            // lblDVCT
            // 
            lblDVCT.AutoSize = true;
            lblDVCT.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDVCT.Location = new Point(12, 280);
            lblDVCT.Name = "lblDVCT";
            lblDVCT.Size = new Size(136, 23);
            lblDVCT.TabIndex = 7;
            lblDVCT.Text = "Đơn vị chấm thi:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(2, 240);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(146, 23);
            lblTime.TabIndex = 6;
            lblTime.Text = "Thời gian làm bài:";
            // 
            // lblPoint
            // 
            lblPoint.AutoSize = true;
            lblPoint.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPoint.Location = new Point(476, 133);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(79, 23);
            lblPoint.TabIndex = 5;
            lblPoint.Text = "ĐIỂM SỐ";
            // 
            // lblExamDate
            // 
            lblExamDate.AutoSize = true;
            lblExamDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExamDate.Location = new Point(52, 91);
            lblExamDate.Name = "lblExamDate";
            lblExamDate.Size = new Size(67, 23);
            lblExamDate.TabIndex = 4;
            lblExamDate.Text = "Đợt thi:";
            // 
            // lblExamType
            // 
            lblExamType.AutoSize = true;
            lblExamType.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExamType.Location = new Point(62, 49);
            lblExamType.Name = "lblExamType";
            lblExamType.Size = new Size(57, 23);
            lblExamType.TabIndex = 3;
            lblExamType.Text = "Kỳ thi:";
            // 
            // lblSBD
            // 
            lblSBD.AutoSize = true;
            lblSBD.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSBD.Location = new Point(37, 200);
            lblSBD.Name = "lblSBD";
            lblSBD.Size = new Size(111, 23);
            lblSBD.TabIndex = 2;
            lblSBD.Text = "Số báo danh:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(70, 160);
            lblName.Name = "lblName";
            lblName.Size = new Size(78, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Thí sinh: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(217, 11);
            label1.Name = "label1";
            label1.Size = new Size(202, 28);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN BÀI THI";
            // 
            // fUpdateResult
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 395);
            Controls.Add(pnlResultExamInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "fUpdateResult";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chỉnh sửa thông tin bài thi";
            Load += fUpdateResult_Load;
            pnlResultExamInfo.ResumeLayout(false);
            pnlResultExamInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlResultExamInfo;
        private Label label1;
        private Label lblTime;
        private Label lblPoint;
        private Label lblExamDate;
        private Label lblExamType;
        private Label lblSBD;
        private Label lblName;
        private Label lblDVCT;
        private TextBox tbxDVCT;
        private TextBox tbxSBD;
        private TextBox tbxName;
        private TextBox tbxExamDate;
        private TextBox tbxExamType;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnExit;
        private DateTimePicker dtpdoExamTime;
        private TextBox tbxPoint;
    }
}