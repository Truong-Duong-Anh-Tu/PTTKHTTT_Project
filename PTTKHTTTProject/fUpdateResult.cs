using PTTKHTTTProject.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTKHTTTProject
{
    public partial class fUpdateResult : Form
    {
        private string ExamType;
        private string ExamDate;
        private string SBD;
        private string NameCandidate;
        private string examcode;
        public fUpdateResult(string codeexam, string examType, string examDate, string sBD, string name)
        {
            InitializeComponent();
            ExamType = examType;
            ExamDate = examDate;
            SBD = sBD;
            NameCandidate = name;
            examcode = codeexam;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void fUpdateResult_Load(object sender, EventArgs e)
        {
            List<string> temp = ManageResultBUS.loadTimePointAndMarkuint(examcode);

            tbxExamType.Text = ExamType;
            tbxExamDate.Text = ExamDate;
            tbxName.Text = NameCandidate;
            tbxSBD.Text = SBD;

            dtpdoExamTime.Value = DateTime.Parse(temp[0]);
            tbxPoint.Text = temp[1];
            tbxDVCT.Text = temp[2];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string point = tbxPoint.Text;
                string dtime = dtpdoExamTime.Text;
                string markunit = tbxDVCT.Text;

                if (decimal.TryParse(point, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal parsepoint))
                {
                    // result đã có giá trị
                }
                else
                {
                    MessageBox.Show("Điểm số nhập không đúng định dạng", "Miss Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                var bus = new ManageResultBUS(examcode, parsepoint, dtime, markunit);
                bus.updateInfomationOfResultExam();

                if (MessageBox.Show("Đã cập nhật thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa bài thi này hay không? (Quá trình này không thể hoàn tác)", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    ManageResultBUS.deleteAExam(examcode);

                    if (MessageBox.Show("Đã loại bỏ thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
