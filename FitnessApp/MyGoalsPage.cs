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

        public MyGoalsPage(FitnessAppContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btn_SetExerciseGoal_Click(object sender, EventArgs e)
        {
            try
            {
                var goal = new ExerciseGoal
                {
                    DaysToExercise = int.Parse(txt_ExerciseDays.Text),
                    TotalExercises = int.Parse(txt_Exercises.Text),
                    DurationMinutes = int.Parse(txt_ExerciseDuration.Text),
                    IsWeekly = rbtn_Weekly.Checked
                };

                // Add to database and save
                _context.ExerciseGoals.Add(goal);
                _context.SaveChanges();

                MessageBox.Show("Exercise goal set successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error setting exercise goal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SetNutritionGoal_Click(object sender, EventArgs e)
        {
            try
            {
                var goal = new NutritionGoal
                {
                    Meals = int.Parse(txt_Meals.Text),
                    MaxCalories = int.Parse(txt_MaxCalories.Text),
                    MaxMacros = txt_MaxMacros.Text,
                    IsWeekly = rbtn_Weekly.Checked
                };

                // Add to database and save
                _context.NutritionGoals.Add(goal);
                _context.SaveChanges();

                MessageBox.Show("Nutrition goal set successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error setting nutrition goal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            var previousPage = new YourNutritionPage(_context); // Navigate back to the YourNutritionPage
            previousPage.Show();
            this.Close();
        }

        private void btn_MyProgress_Click(object sender, EventArgs e)
        {
            var progressPage = new MyProgressPage(_context); // Navigate to MyProgressPage
            progressPage.Show();
            this.Close();
        }
    }
}
