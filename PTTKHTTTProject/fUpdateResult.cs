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
        private ManageResultBUS managebus;

        public fUpdateResult(string codeexam, string examType, string examDate, string sBD, string name)
        {
            InitializeComponent();
            ExamType = examType;
            ExamDate = examDate;
            SBD = sBD;
            NameCandidate = name;
            examcode = codeexam;
            managebus = new ManageResultBUS(examcode);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void fUpdateResult_Load(object sender, EventArgs e)
        {
            tbxExamType.Text = ExamType;
            tbxExamDate.Text = ExamDate;
            tbxName.Text = NameCandidate;
            tbxSBD.Text = SBD;

            decimal point;
            string dtime;
            string markunit;

            managebus.loadTimePointAndMarkuint(out point, out dtime, out markunit);

            dtpdoExamTime.Value = DateTime.Parse(dtime);
            tbxPoint.Text = point < 0 ? string.Empty : point.ToString();
            tbxDVCT.Text = markunit;
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


                managebus.updateInfomationOfResultExam(parsepoint, dtime, markunit);

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
                    managebus.deleteAExam();

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
