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
    public partial class MyProgressPage : Form
    {
        private readonly FitnessAppContext _context;

        public MyProgressPage(FitnessAppContext context)
        {
            InitializeComponent();
            _context = context;

            LoadNutritionProgress();
            LoadExerciseProgress();
        }

        private void LoadNutritionProgress()
        {
            var goal = _context.NutritionGoals.FirstOrDefault();

            if (goal != null)
            {
                lbl_NutritionProgress.Text = $"Nutrition Goal: {goal.GoalType}";

                // Calculate progress for meals
                var totalMeals = _context.Meals.Count();
                progressBar_Meals.Value = CalculateProgress(goal.Meals, totalMeals);

                // Calculate progress for calories
                var totalCalories = _context.Meals.Sum(m => m.Calories);
                progressBar_Calories.Value = CalculateProgress(goal.MaxCalories, totalCalories);

                // Display average macros
                lbl_MacrosAverage.Text = CalculateMacrosAverage();
            }
            else
            {
                lbl_NutritionProgress.Text = "No nutrition goals set.";
                progressBar_Meals.Value = 0;
                progressBar_Calories.Value = 0;
            }
        }

        private void LoadExerciseProgress()
        {
            var goal = _context.ExerciseGoals.FirstOrDefault();

            if (goal != null)
            {
                lbl_FitnessProgress.Text = $"Exercise Goal: {goal.GoalType}";

                // Calculate progress for days exercised
                var daysExercised = _context.Workouts
                    .Select(w => w.Date.Date)
                    .Distinct()
                    .Count();
                progressBar_DaysExercised.Value = CalculateProgress(goal.DaysToExercise, daysExercised);

                // Calculate progress for total exercises
                var totalExercises = _context.Workouts.Count();
                progressBar_ExercisesDone.Value = CalculateProgress(goal.TotalExercises, totalExercises);

                // Display average exercise time
                var totalTime = _context.Workouts.Sum(w => w.Duration);
                lbl_AverageExerciseTime.Text = $"Average Exercise Time: {totalTime / Math.Max(1, daysExercised)} mins";
            }
            else
            {
                lbl_FitnessProgress.Text = "No exercise goals set.";
                progressBar_DaysExercised.Value = 0;
                progressBar_ExercisesDone.Value = 0;
                lbl_AverageExerciseTime.Text = "Average Exercise Time: 0 mins";
            }
        }

        private int CalculateProgress(int goal, int current)
        {
            if (goal == 0) return 0;
            return Math.Min((current * 100) / goal, 100); // Cap progress at 100%
        }

        private string CalculateMacrosAverage()
        {
            var totalMeals = _context.Meals.Count();
            if (totalMeals == 0) return "Macros Average: P: 0% C: 0% F: 0%";

            var totalProtein = _context.Meals.Sum(m => m.ProteinPercentage);
            var totalCarbs = _context.Meals.Sum(m => m.CarbsPercentage);
            var totalFat = _context.Meals.Sum(m => m.FatPercentage);

            return $"Macros Average: P: {totalProtein / totalMeals}% C: {totalCarbs / totalMeals}% F: {totalFat / totalMeals}%";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            var previousPage = new MyGoalsPage(_context); // Navigate to the MyGoalsPage
            previousPage.Show();
            this.Close();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm(_context); // Pass the context
            loginForm.Show();
            this.Close();
        }

    }
}
