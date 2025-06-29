using PTTKHTTTProject.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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

        private void pnlResultExamInfo_Paint(object sender, PaintEventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void fUpdateResult_Load(object sender, EventArgs e)
        {
            dtpdoExamTime.Value = DateTime.Today;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string point = tbxPoint.Text;
                string dtime = dtpdoExamTime.Text;
                string markunit = tbxDVCT.Text;

                ManageResultBUS.updateInfomationOfResultExam(examcode, point, dtime, markunit);

                if (MessageBox.Show("Đã cập nhật thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            } 
            
        }
    }
}
