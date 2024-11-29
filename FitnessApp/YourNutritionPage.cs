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
            LoadCalorieGraph();
            LoadDailyLog();
        }

        private void LoadCalorieGraph()
        {
            var sevenDaysAgo = DateTime.Today.AddDays(-7);
            var calorieData = _context.Meals
                .Where(m => m.MealDate >= sevenDaysAgo)
                .GroupBy(m => m.MealDate)
                .Select(g => new { Date = g.Key, TotalCalories = g.Sum(m => m.Calories) })
                .OrderBy(d => d.Date)
                .ToList();

            // Redraw chart manually
            chart_Calories.Paint += (sender, e) =>
            {
                var g = e.Graphics;
                var chartWidth = chart_Calories.ClientSize.Width - 40; // Padding
                var chartHeight = chart_Calories.ClientSize.Height - 40; // Padding
                var barWidth = chartWidth / 7; // Assuming 7 days

                // Get max calories for scaling
                int maxCalories = calorieData.Any() ? calorieData.Max(c => c.TotalCalories) : 1;

                for (int i = 0; i < calorieData.Count; i++)
                {
                    var data = calorieData[i];
                    var barHeight = (int)((data.TotalCalories / (double)maxCalories) * chartHeight);

                    // Draw bar
                    var barX = 20 + i * barWidth; // Add margin
                    var barY = chart_Calories.ClientSize.Height - barHeight - 20; // Invert Y-axis

                    g.FillRectangle(Brushes.Blue, barX, barY, barWidth - 5, barHeight);

                    // Draw date label
                    g.DrawString(data.Date.ToShortDateString(), Font, Brushes.Black, barX, chart_Calories.ClientSize.Height - 20);

                    // Draw calorie value
                    g.DrawString(data.TotalCalories.ToString(), Font, Brushes.Black, barX, barY - 15);
                }
            };

            chart_Calories.Refresh(); // Trigger redraw
        }

        private void LoadDailyLog()
        {
            var today = DateTime.Today;
            var meals = _context.Meals
                .Where(m => m.MealDate == today)
                .ToList();

            dgv_DailyMeals.DataSource = meals;
            lbl_TotalCalories.Text = $"Total Calories: {meals.Sum(m => m.Calories)}";
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
