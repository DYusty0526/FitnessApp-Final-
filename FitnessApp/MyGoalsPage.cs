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
        public MyGoalsPage()
        {
            InitializeComponent();
        }
        private void btn_SetExerciseGoal_Click(object sender, EventArgs e)
        {
            // Placeholder logic to set exercise goals
            string daysOfExercise = txt_ExerciseDays.Text;
            string numberOfExercises = txt_Exercises.Text;
            string exerciseDuration = txt_ExerciseDuration.Text;

            // For now, display a message box to confirm the exercise goals
            MessageBox.Show(
                $"Exercise Goal Set:\nDays of Exercise: {daysOfExercise}\nNumber of Exercises: {numberOfExercises}\nExercise Duration: {exerciseDuration} mins",
                "Exercise Goal Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Later, we will connect this data to the database to save the goal
        }

        // Set Nutrition Goal Button Click Event
        private void btn_SetNutritionGoal_Click(object sender, EventArgs e)
        {
            // Placeholder logic to set nutrition goals
            string numberOfMeals = txt_Meals.Text;
            string maxCalories = txt_MaxCalories.Text;
            string maxMacros = txt_MaxMacros.Text;

            // For now, display a message box to confirm the nutrition goals
            MessageBox.Show(
                $"Nutrition Goal Set:\nNumber of Meals: {numberOfMeals}\nMax Calorie Intake: {maxCalories}\nMax Macros Intake: {maxMacros}",
                "Nutrition Goal Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Later, we will connect this data to the database to save the goal
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            YourNutritionPage nutritionPage = new YourNutritionPage();
            nutritionPage.Show();
            this.Hide();
        }
        private void btn_MyProgress_Click(object sender, EventArgs e)
        {
            MyProgressPage progressPage = new MyProgressPage();
            progressPage.Show();
            this.Hide();
        }
    }
}
