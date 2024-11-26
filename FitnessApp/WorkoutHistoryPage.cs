using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FitnessApp
{
    public partial class WorkoutHistoryPage : Form
    {
        private int[] attendanceData = { 10, 12, 8, 15, 11, 14 }; 
        private string[] months = { "June", "July", "Aug", "Sep", "Oct", "Nov" };

        public WorkoutHistoryPage()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawBarGraph(e.Graphics);
        }

        private void DrawBarGraph(Graphics g)
        {
            int graphWidth = 400;
            int graphHeight = 200;
            int xStart = 50;
            int yStart = 100;

            g.FillRectangle(Brushes.White, xStart, yStart, graphWidth, graphHeight);
            g.DrawRectangle(Pens.Black, xStart, yStart, graphWidth, graphHeight);

            int barWidth = graphWidth / attendanceData.Length;
            int maxAttendance = 20; 
            float scale = (float)graphHeight / maxAttendance;

            for (int i = 0; i < attendanceData.Length; i++)
            {
                int barHeight = (int)(attendanceData[i] * scale);
                int x = xStart + i * barWidth;
                int y = yStart + graphHeight - barHeight;

                g.FillRectangle(Brushes.Blue, x, y, barWidth - 10, barHeight);
                g.DrawRectangle(Pens.Black, x, y, barWidth - 10, barHeight);

                g.DrawString(months[i], new Font("Arial", 10), Brushes.Black, x + 5, yStart + graphHeight + 5);
                g.DrawString(attendanceData[i].ToString(), new Font("Arial", 10), Brushes.Black, x + 5, y - 20);
            }

            g.DrawLine(Pens.Black, xStart, yStart + graphHeight, xStart + graphWidth, yStart + graphHeight); // X-axis
            g.DrawLine(Pens.Black, xStart, yStart, xStart, yStart + graphHeight); // Y-axis
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            LogWorkoutPage logWorkoutPage = new LogWorkoutPage();
            logWorkoutPage.Show();
            this.Hide();
        }

        //private void btn_MyGoals_Click(object sender, EventArgs e)
        //{
        //    MyGoalsPage goalsPage = new MyGoalsPage();
        //    goalsPage.Show();
        //    this.Hide();
        //}
    }
}
