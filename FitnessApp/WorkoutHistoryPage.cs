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
        private readonly FitnessAppContext _context;
        private System.Collections.Generic.List<AttendanceRecord> _attendanceData;

        public WorkoutHistoryPage(FitnessAppContext context)
        {
            InitializeComponent();
            _context = context;

            // Load data for the chart and workout log
            LoadAttendanceData();
            LoadWorkoutLog();
        }

        private void WorkoutHistoryPage_Paint(object sender, PaintEventArgs e)
        {
            // Draw the chart whenever the form is repainted
            if (_attendanceData != null)
            {
                DrawBarChart(e.Graphics, _attendanceData);
            }
        }

        private void LoadAttendanceData()
        {
            // Retrieve the last 6 months of attendance data
            var today = DateTime.Today;
            var sixMonthsAgo = today.AddMonths(-6);

            _attendanceData = _context.Workouts
                .Where(w => w.Date >= sixMonthsAgo && w.Date <= today)
                .GroupBy(w => new { w.Date.Year, w.Date.Month })
                .Select(g => new AttendanceRecord
                {
                    Month = new DateTime(g.Key.Year, g.Key.Month, 1).ToString("MMM yyyy"),
                    Count = g.Count()
                })
                .ToList();

            // Trigger a repaint to update the chart
            Invalidate();
        }

        private void LoadWorkoutLog()
        {
            // Load today's workouts into the DataGridView
            var today = DateTime.Today;
            var workouts = _context.Workouts
                .Where(w => w.Date == today)
                .Select(w => new { w.Type, w.Duration, w.Repetitions })
                .ToList();

            dgv_WorkoutLog.DataSource = workouts;
        }

        private void DrawBarChart(Graphics g, System.Collections.Generic.List<AttendanceRecord> data)
        {
            // Chart dimensions
            int x = 50;
            int y = 50;
            int barWidth = 40;
            int barSpacing = 20;
            int chartHeight = 200;
            int maxCount = data.Any() ? data.Max(d => d.Count) : 1;

            // Draw the bars
            for (int i = 0; i < data.Count; i++)
            {
                var record = data[i];
                int barHeight = (int)((record.Count / (double)maxCount) * chartHeight);
                g.FillRectangle(Brushes.Blue, x + i * (barWidth + barSpacing), y + (chartHeight - barHeight), barWidth, barHeight);
                g.DrawString(record.Month, Font, Brushes.Black, x + i * (barWidth + barSpacing), y + chartHeight + 5);
                g.DrawString(record.Count.ToString(), Font, Brushes.Black, x + i * (barWidth + barSpacing), y + (chartHeight - barHeight) - 20);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            var logWorkoutPage = new LogWorkoutPage(_context);
            logWorkoutPage.Show();
            this.Close();
        }

        private void btn_MyGoals_Click(object sender, EventArgs e)
        {
            var myGoalsPage = new MyGoalsPage(_context);
            myGoalsPage.Show();
            this.Close();
        }
    }
}