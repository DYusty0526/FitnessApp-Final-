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
        // Placeholder data for progress tracking (can be linked to a database later)
        private int weeklyCaloriesGoal = 14000;  // Example: 2000 calories per day for a week
        private int weeklyMealsGoal = 21;  // Example: 3 meals per day for a week
        private int weeklyDaysExercisedGoal = 5;  // Example: 5 days per week
        private int weeklyExercisesGoal = 15;  // Example: 15 exercises per week

        private int[] weeklyCaloriesConsumed = { 1800, 2000, 2100, 2200, 1950, 1800, 1850 };  // Calories over 7 days
        private int totalMealsConsumed = 20;  // Placeholder for total meals consumed so far
        private int totalDaysExercised = 4;  // Placeholder for days exercised so far
        private int totalExercisesDone = 12;  // Placeholder for total exercises done so far
        private float averageExerciseTime = 3.5f;  // Average exercise time (hours) for the current week

        public MyProgressPage()
        {
            InitializeComponent();
            UpdateProgress();
        }

        // Update progress bars and labels based on goals and actual data
        private void UpdateProgress()
        {
            // Nutrition Progress
            int totalCaloriesConsumed = 0;
            foreach (var calories in weeklyCaloriesConsumed)
            {
                totalCaloriesConsumed += calories;
            }

            progressBar_Calories.Maximum = weeklyCaloriesGoal;
            progressBar_Calories.Value = Math.Min(totalCaloriesConsumed, weeklyCaloriesGoal);
            progressBar_Meals.Maximum = weeklyMealsGoal;
            progressBar_Meals.Value = Math.Min(totalMealsConsumed, weeklyMealsGoal);

            // Update average macros label (using dummy values here for simplicity)
            lbl_AverageMacros.Text = "Average Macros: P: 30% C: 40% F: 30%";

            // Fitness Progress
            progressBar_DaysExercised.Maximum = weeklyDaysExercisedGoal;
            progressBar_DaysExercised.Value = Math.Min(totalDaysExercised, weeklyDaysExercisedGoal);
            progressBar_ExercisesDone.Maximum = weeklyExercisesGoal;
            progressBar_ExercisesDone.Value = Math.Min(totalExercisesDone, weeklyExercisesGoal);

            lbl_AverageExerciseTime.Text = $"Average Exercise Time: {averageExerciseTime} hrs";
        }

        // Back Button Click Event
        private void btn_Back_Click(object sender, EventArgs e)
        {
            // Navigate back to the previous page (e.g., MyGoalsPage)
            MyGoalsPage goalsPage = new MyGoalsPage();
            goalsPage.Show();
            this.Hide();
        }

        // Logout Button Click Event
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            // Navigate back to the Login Page (or close the application)
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        // Weekly/Monthly RadioButton CheckedChanged Events
        private void rbtn_Weekly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Weekly.Checked)
            {
                // Update progress to reflect weekly goals and data
                UpdateProgress();
            }
        }

        private void rbtn_Monthly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Monthly.Checked)
            {
                // For simplicity, we assume monthly goals are 4 times the weekly goals
                progressBar_Calories.Maximum = weeklyCaloriesGoal * 4;
                progressBar_Calories.Value = Math.Min(weeklyCaloriesConsumed[0] * 4, progressBar_Calories.Maximum);  // Example data for monthly

                progressBar_Meals.Maximum = weeklyMealsGoal * 4;
                progressBar_Meals.Value = Math.Min(totalMealsConsumed * 4, progressBar_Meals.Maximum);

                progressBar_DaysExercised.Maximum = weeklyDaysExercisedGoal * 4;
                progressBar_DaysExercised.Value = Math.Min(totalDaysExercised * 4, progressBar_DaysExercised.Maximum);

                progressBar_ExercisesDone.Maximum = weeklyExercisesGoal * 4;
                progressBar_ExercisesDone.Value = Math.Min(totalExercisesDone * 4, progressBar_ExercisesDone.Maximum);

                lbl_AverageExerciseTime.Text = $"Average Exercise Time: {averageExerciseTime * 4} hrs";

                // Update average macros label for monthly progress (using dummy values)
                lbl_AverageMacros.Text = "Average Macros: P: 28% C: 42% F: 30%";
            }
        }
    }
}
