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
    public partial class YourNutritionPage : Form
    {
        private readonly FitnessAppContext _context;

        public YourNutritionPage(FitnessAppContext context)
        {
            InitializeComponent();
            _context = context;

            LoadCalorieChart();
            LoadDailyNutritionLog();
        }

        private void LoadCalorieChart()
        {
            // Fetch data for the last 7 days
            var today = DateTime.Today;
            var oneWeekAgo = today.AddDays(-6);

            var calorieData = _context.Meals
                .Where(m => m.MealDate >= oneWeekAgo && m.MealDate <= today)
                .GroupBy(m => m.MealDate)
                .Select(g => new CalorieRecord // Use CalorieRecord class
                {
                    Date = g.Key,
                    TotalCalories = g.Sum(m => m.Calories)
                })
                .OrderBy(d => d.Date)
                .ToList();

            // Redraw the chart
            pnl_CalorieChart.Invalidate();
            pnl_CalorieChart.Paint += (s, e) => DrawCalorieChart(e.Graphics, calorieData);
        }

        private void DrawCalorieChart(Graphics graphics, List<CalorieRecord> calorieData)
        {
            var barWidth = 50; // Width of each bar
            var spacing = 20;  // Spacing between bars
            var maxBarHeight = 150; // Maximum height for the tallest bar
            var maxCalories = calorieData.Any() ? calorieData.Max(d => d.TotalCalories) : 1; // Prevent divide by zero

            // Set drawing area dimensions
            var chartWidth = pnl_CalorieChart.Width;
            var chartHeight = pnl_CalorieChart.Height;
            var xStart = 20; // Starting X position for the first bar
            var yBase = chartHeight - 20; // Base Y position for bars

            // Set up fonts and colors
            using (var barBrush = new SolidBrush(Color.SeaGreen))
            using (var labelBrush = new SolidBrush(Color.Black))
            using (var font = new Font("Arial", 10))
            {
                foreach (var data in calorieData)
                {
                    // Calculate bar height relative to maxCalories
                    var barHeight = (int)((data.TotalCalories / (float)maxCalories) * maxBarHeight);

                    // Draw the bar
                    var barX = xStart;
                    var barY = yBase - barHeight;
                    graphics.FillRectangle(barBrush, barX, barY, barWidth, barHeight);
                    
                    // Draw the date label below the bar
                    var dateLabel = data.Date.ToString("MM/dd");
                    var labelX = barX + (barWidth / 2) - (graphics.MeasureString(dateLabel, font).Width / 2);
                    var labelY = yBase + 5; // Slightly below the bars
                    graphics.DrawString(dateLabel, font, labelBrush, labelX, labelY);

                    // Draw the calorie label above the bar
                    var calorieLabel = $"{data.TotalCalories}";
                    var calorieLabelX = barX + (barWidth / 2) - (graphics.MeasureString(calorieLabel, font).Width / 2);
                    var calorieLabelY = barY - 15; // Slightly above the bars
                    graphics.DrawString(calorieLabel, font, labelBrush, calorieLabelX, calorieLabelY);

                    // Move to the next bar position
                    xStart += barWidth + spacing;
                }
            }
        }

        private void LoadDailyNutritionLog()
        {
            // Load today's meals into the DataGridView
            var today = DateTime.Today;
            var meals = _context.Meals
                .Where(m => m.MealDate == today)
                .Select(m => new { m.MealName, m.Calories })
                .ToList();

            dgv_NutritionLog.DataSource = meals;

            // Calculate total calories for today
            var totalCalories = meals.Sum(m => m.Calories);
            lbl_TotalCalories.Text = $"Total Calories: {totalCalories}";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            var logMealsPage = new LogMealsPage(_context);
            logMealsPage.Show();
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
