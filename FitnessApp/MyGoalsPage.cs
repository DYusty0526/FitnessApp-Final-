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
    public partial class MyGoalsPage : Form
    {
        private readonly FitnessAppContext _context;
        private GoalType _selectedGoalType;

        public MyGoalsPage(FitnessAppContext context)
        {
            InitializeComponent();
            _context = context;
            _selectedGoalType = GoalType.Weekly; // Default to weekly
            RefreshUI();
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
            RefreshUI();
        }

        private void btn_SetExerciseGoal_Click(object sender, EventArgs e)
        {
            try
            {
                var exerciseGoal = new ExerciseGoal
                {
                    GoalType = _selectedGoalType,
                    DaysToExercise = int.Parse(txt_ExerciseDays.Text),
                    TotalExercises = int.Parse(txt_Exercises.Text),
                    DurationMinutes = int.Parse(txt_ExerciseDuration.Text)
                };

                // Replace existing goal of the same type
                var existingGoal = _context.ExerciseGoals.FirstOrDefault(g => g.GoalType == _selectedGoalType);
                if (existingGoal != null)
                {
                    _context.ExerciseGoals.Remove(existingGoal);
                }

                _context.ExerciseGoals.Add(exerciseGoal);
                _context.SaveChanges();

                MessageBox.Show("Exercise goal set successfully!", "Success");
                RefreshUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private void btn_SetNutritionGoal_Click(object sender, EventArgs e)
        {
            try
            {
                var nutritionGoal = new NutritionGoal
                {
                    GoalType = _selectedGoalType,
                    Meals = int.Parse(txt_Meals.Text),
                    MaxCalories = int.Parse(txt_MaxCalories.Text),
                    MaxMacros = txt_MaxMacros.Text // Assign directly as a string
                };

                // Replace existing goal of the same type
                var existingGoal = _context.NutritionGoals.FirstOrDefault(g => g.GoalType == _selectedGoalType);
                if (existingGoal != null)
                {
                    _context.NutritionGoals.Remove(existingGoal);
                }

                _context.NutritionGoals.Add(nutritionGoal);
                _context.SaveChanges();

                MessageBox.Show("Nutrition goal set successfully!", "Success");
                RefreshUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }


        private void btn_Back_Click(object sender, EventArgs e)
        {
            var mainPage = new MainPage(_context);
            mainPage.Show();
            this.Close();
        }

        private void btn_MyProgress_Click(object sender, EventArgs e)
        {
            var myProgressPage = new MyProgressPage(_context);
            myProgressPage.Show();
            this.Close();
        }

        private void RefreshUI()
        {
            // Load existing goals of the selected type
            var exerciseGoal = _context.ExerciseGoals.FirstOrDefault(g => g.GoalType == _selectedGoalType);
            if (exerciseGoal != null)
            {
                txt_ExerciseDays.Text = exerciseGoal.DaysToExercise.ToString();
                txt_Exercises.Text = exerciseGoal.TotalExercises.ToString();
                txt_ExerciseDuration.Text = exerciseGoal.DurationMinutes.ToString();
            }
            else
            {
                txt_ExerciseDays.Text = string.Empty;
                txt_Exercises.Text = string.Empty;
                txt_ExerciseDuration.Text = string.Empty;
            }

            var nutritionGoal = _context.NutritionGoals.FirstOrDefault(g => g.GoalType == _selectedGoalType);
            if (nutritionGoal != null)
            {
                txt_Meals.Text = nutritionGoal.Meals.ToString();
                txt_MaxCalories.Text = nutritionGoal.MaxCalories.ToString();

                // Handle MaxMacros correctly
                txt_MaxMacros.Text = nutritionGoal.MaxMacros ?? string.Empty; // Ensure null safety
            }
            else
            {
                txt_Meals.Text = string.Empty;
                txt_MaxCalories.Text = string.Empty;
                txt_MaxMacros.Text = string.Empty;
            }
        }
    }
}
