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

        public WorkoutHistoryPage(FitnessAppContext context)
        {
            InitializeComponent();
            _context = context;

            // Load the data
            LoadAttendanceChart();
            LoadWorkoutLog();
        }

        private void LoadAttendanceChart()
        {
            // Calculate attendance for the last 6 months
            var today = DateTime.Today;
            var sixMonthsAgo = today.AddMonths(-6);

            // Fetch attendance data grouped by month
            var attendanceData = _context.Workouts
                .Where(w => w.Date >= sixMonthsAgo && w.Date <= today) // Filter workouts in the last 6 months
                .GroupBy(w => new { Year = w.Date.Year, Month = w.Date.Month }) // Group by year and month
                .Select(g => new AttendanceRecord // Map to AttendanceRecord
                {
                    Month = g.Key.Month, // Extract month
                    Count = g.Count()    // Count workouts in that month
                })
                .OrderBy(d => d.Month) // Order by month
                .ToList(); // Convert to a list

            // Redraw the chart on the Panel
            pnl_Chart.Invalidate();
            pnl_Chart.Paint += (s, e) => DrawChart(e.Graphics, attendanceData);
        }

        private void DrawChart(Graphics graphics, List<AttendanceRecord> attendanceData)
        {
            var barWidth = 50; // Width of each bar
            var spacing = 20;  // Spacing between bars
            var maxBarHeight = 150; // Maximum height for the tallest bar
            var maxCount = attendanceData.Any() ? attendanceData.Max(d => d.Count) : 1; // Prevent divide by zero

            // Set drawing area dimensions
            var chartWidth = pnl_Chart.Width;
            var chartHeight = pnl_Chart.Height;
            var xStart = 20; // Starting X position for the first bar
            var yBase = chartHeight - 20; // Base Y position for bars

            // Set up fonts and colors
            using (var barBrush = new SolidBrush(Color.CornflowerBlue))
            using (var labelBrush = new SolidBrush(Color.Black))
            using (var font = new Font("Arial", 10))
            {
                foreach (var data in attendanceData)
                {
                    // Calculate bar height relative to maxCount
                    var barHeight = (int)((data.Count / (float)maxCount) * maxBarHeight);

                    // Draw the bar
                    var barX = xStart;
                    var barY = yBase - barHeight;
                    graphics.FillRectangle(barBrush, barX, barY, barWidth, barHeight);

                    // Draw the month label
                    var monthLabel = $"{data.Month}";
                    var labelX = barX + (barWidth / 2) - (graphics.MeasureString(monthLabel, font).Width / 2);
                    var labelY = yBase + 5; // Slightly below the bars
                    graphics.DrawString(monthLabel, font, labelBrush, labelX, labelY);

                    // Draw the count label above the bar
                    var countLabel = $"{data.Count}";
                    var countLabelX = barX + (barWidth / 2) - (graphics.MeasureString(countLabel, font).Width / 2);
                    var countLabelY = barY - 15; // Slightly above the bars
                    graphics.DrawString(countLabel, font, labelBrush, countLabelX, countLabelY);

                    // Move to the next bar position
                    xStart += barWidth + spacing;
                }
            }
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
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadAttendanceChart();
            LoadWorkoutLog();
            MessageBox.Show("Data refreshed!", "Info");
        }

    }
}
