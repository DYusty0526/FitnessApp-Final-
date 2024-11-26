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
        private int[] calorieIntakeData = { 1800, 2000, 1900, 2200, 2100, 1850, 2000 }; // Example calorie intake data for the past 7 days
        private string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" }; // Days of the week

        public YourNutritionPage()
        {
            InitializeComponent();
            LoadNutritionData();
            this.DoubleBuffered = true;
        }

        // Load sample data for daily nutrition log (placeholders for now)
        private void LoadNutritionData()
        {
            // Example daily nutrition log data
            dgv_NutritionLog.DataSource = new[]
            {
                new { Meal = "Breakfast", Calories = "400", Date = "25/11/2024" },
                new { Meal = "Lunch", Calories = "600", Date = "25/11/2024" },
                new { Meal = "Dinner", Calories = "700", Date = "25/11/2024" },
                new { Meal = "Snack", Calories = "200", Date = "25/11/2024" }
            };

            int totalCalories = 0;
            foreach (var intake in calorieIntakeData)
            {
                totalCalories += intake;
            }
            lbl_TotalCalories.Text = $"Total Calories Consumed: {totalCalories}";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawCalorieGraph(e.Graphics);
        }

        private void DrawCalorieGraph(Graphics g)
        {
            int graphWidth = 400;
            int graphHeight = 200;
            int xStart = 20;
            int yStart = 50;

            g.FillRectangle(Brushes.White, xStart, yStart, graphWidth, graphHeight);
            g.DrawRectangle(Pens.Black, xStart, yStart, graphWidth, graphHeight);

            int barWidth = graphWidth / calorieIntakeData.Length;
            int maxCalories = 2500; // Assuming the maximum calories in a day is 2500
            float scale = (float)graphHeight / maxCalories;

            for (int i = 0; i < calorieIntakeData.Length; i++)
            {
                int barHeight = (int)(calorieIntakeData[i] * scale);
                int x = xStart + i * barWidth;
                int y = yStart + graphHeight - barHeight;

                g.FillRectangle(Brushes.Green, x, y, barWidth - 10, barHeight);
                g.DrawRectangle(Pens.Black, x, y, barWidth - 10, barHeight);

                g.DrawString(days[i], new Font("Arial", 10), Brushes.Black, x + 5, yStart + graphHeight + 5);
                g.DrawString(calorieIntakeData[i].ToString(), new Font("Arial", 10), Brushes.Black, x + 5, y - 20);
            }

            g.DrawLine(Pens.Black, xStart, yStart + graphHeight, xStart + graphWidth, yStart + graphHeight); // X-axis
            g.DrawLine(Pens.Black, xStart, yStart, xStart, yStart + graphHeight); // Y-axis
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            LogMealsPage logMealsPage = new LogMealsPage();
            logMealsPage.Show();
            this.Hide();
        }
        private void btn_MyGoals_Click(object sender, EventArgs e)
        {
            MyGoalsPage goalsPage = new MyGoalsPage();
            goalsPage.Show();
            this.Hide();
        }
    }
}
