using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public fUpdateResult(string examType, string examDate, string sBD, string name)
        {
            InitializeComponent();
            ExamType = examType;
            ExamDate = examDate;
            SBD = sBD;
            NameCandidate = name;
        }

        private void pnlResultExamInfo_Paint(object sender, PaintEventArgs e)
        {
            tbxExamType.Text = ExamType;
            tbxExamDate.Text = ExamDate;
            tbxName.Text = NameCandidate;
            tbxSBD.Text = SBD;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
