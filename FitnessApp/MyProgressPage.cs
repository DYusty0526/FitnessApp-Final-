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
        private GoalType _selectedGoalType;

        public MyProgressPage(FitnessAppContext context)
        {
            InitializeComponent();
            _context = context;
            _selectedGoalType = GoalType.Weekly; // Default to weekly
            RefreshProgress(); // Load initial progress
        }

        private void ToggleGoalType(object sender, EventArgs e)
        {
            if (rbtn_Weekly.Checked)
            {
                _selectedGoalType = GoalType.Weekly;
            }
            else if (rbtn_Monthly.Checked)
            {
                _selectedGoalType = GoalType.Monthly;
            }
            RefreshProgress();
        }

        private void RefreshProgress()
        {
            // Refresh progress bars based on logged data
            var totalCalories = _context.Meals
                .Where(m => m.MealDate >= GetStartDate() && m.MealDate <= DateTime.Today)
                .Sum(m => m.Calories);

            var totalMeals = _context.Meals
                .Count(m => m.MealDate >= GetStartDate() && m.MealDate <= DateTime.Today);

            var avgProtein = _context.Meals
                .Where(m => m.MealDate >= GetStartDate() && m.MealDate <= DateTime.Today)
                .Average(m => (double?)m.ProteinPercentage) ?? 0;

            var avgCarbs = _context.Meals
                .Where(m => m.MealDate >= GetStartDate() && m.MealDate <= DateTime.Today)
                .Average(m => (double?)m.CarbsPercentage) ?? 0;

            var avgFat = _context.Meals
                .Where(m => m.MealDate >= GetStartDate() && m.MealDate <= DateTime.Today)
                .Average(m => (double?)m.FatPercentage) ?? 0;

            progressBar_Calories.Value = Math.Min(progressBar_Calories.Maximum, totalCalories);
            progressBar_Meals.Value = Math.Min(progressBar_Meals.Maximum, totalMeals);
            lbl_MacrosAverage.Text = $"Macros Average: P: {avgProtein:F1}% C: {avgCarbs:F1}% F: {avgFat:F1}%";

            var daysExercised = _context.Workouts
                .Where(w => w.Date >= GetStartDate() && w.Date <= DateTime.Today)
                .Select(w => w.Date)
                .Distinct()
                .Count();

            var totalExercises = _context.Workouts
                .Where(w => w.Date >= GetStartDate() && w.Date <= DateTime.Today)
                .Count();

            var avgDuration = _context.Workouts
                .Where(w => w.Date >= GetStartDate() && w.Date <= DateTime.Today)
                .Average(w => (double?)w.Duration) ?? 0;

            progressBar_DaysExercised.Value = Math.Min(progressBar_DaysExercised.Maximum, daysExercised);
            progressBar_ExercisesDone.Value = Math.Min(progressBar_ExercisesDone.Maximum, totalExercises);
            lbl_AverageExerciseTime.Text = $"Average Exercise Time: {avgDuration:F1} mins";

            // Display goals overview
            var exerciseGoal = _context.ExerciseGoals.FirstOrDefault(g => g.GoalType == _selectedGoalType);
            if (exerciseGoal != null)
            {
                lbl_ExerciseGoals.Text = $"Exercise Goals: Days - {exerciseGoal.DaysToExercise}, " +
                                         $"Exercises - {exerciseGoal.TotalExercises}, " +
                                         $"Duration - {exerciseGoal.DurationMinutes} mins";
            }
            else
            {
                lbl_ExerciseGoals.Text = "Exercise Goals: Not set";
            }

            var nutritionGoal = _context.NutritionGoals.FirstOrDefault(g => g.GoalType == _selectedGoalType);
            if (nutritionGoal != null)
            {
                lbl_NutritionGoals.Text = $"Nutrition Goals: Meals - {nutritionGoal.Meals}, " +
                                          $"Calories - {nutritionGoal.MaxCalories}, " +
                                          $"Macros - {nutritionGoal.MaxMacros}";
            }
            else
            {
                lbl_NutritionGoals.Text = "Nutrition Goals: Not set";
            }
        }

        private DateTime GetStartDate()
        {
            return _selectedGoalType == GoalType.Weekly
                ? DateTime.Today.AddDays(-7)
                : DateTime.Today.AddMonths(-1);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            var mainPage = new MainPage(_context);
            mainPage.Show();
            this.Close();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm(_context);
            loginForm.Show();
            this.Close();
        }
    }
}
