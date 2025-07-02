using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTKHTTTProject.BUS;  // Thêm namespace này

namespace PTTKHTTTProject.UControl
{
    public partial class adminTongQuan : UserControl
    {
        public adminTongQuan()
        {
            InitializeComponent();
            LoadKyThiData();  // Gọi phương thức tải dữ liệu kỳ thi
        }

        private void LoadKyThiData()
        {
            try
            {
                // Lấy tổng số kỳ thi từ BUS
                int totalExams = ExamTypeBUS.GetTotalExamCount();

                // Hiển thị tổng số kỳ thi trong control
                labelNumberOfExamination.Text = totalExams.ToString();

                // Lấy và hiển thị tổng số lịch thi còn lại
                int remainingSchedules = ExamTypeBUS.GetRemainingScheduleCount();
                labelNumberOfSchedule.Text = remainingSchedules.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelNumberOfExamination.Text = "0";
                labelNumberOfSchedule.Text = "0";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelNumberOfSchedule_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelNumberOfExamination_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}