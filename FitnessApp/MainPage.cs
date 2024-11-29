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
    public partial class MainPage : Form
    {
        private readonly FitnessAppContext _context;

        public MainPage(FitnessAppContext context)
        {
            InitializeComponent();
            _context = context;

            LoadWorkoutData();
            LoadNutritionData();
        }

        private void LoadWorkoutData()
        {
            var today = DateTime.Today;
            var workouts = _context.Workouts.Where(w => w.Date == today).ToList();

            if (workouts.Any())
            {
                lbl_WorkoutToday.Text = $"Workout: {workouts[0].Type} ({workouts[0].Repetitions} Sets)";
                lbl_WorkoutHours.Text = $"Total Hours: {workouts.Sum(w => w.Duration)}";
            }
            else
            {
                lbl_WorkoutToday.Text = "No workouts logged today.";
                lbl_WorkoutHours.Text = "Total Hours: 0";
            }
        }

        private void LoadNutritionData()
        {
            var today = DateTime.Today;
            var meals = _context.Meals.Where(m => m.MealDate == today).ToList();

            if (meals.Any())
            {
                lbl_NutritionToday.Text = $"Meal: {meals[0].MealName} ({meals[0].Calories} Calories)";
                lbl_TotalCalories.Text = $"Total Calories: {meals.Sum(m => m.Calories)}";
            }
            else
            {
                lbl_NutritionToday.Text = "No meals logged today.";
                lbl_TotalCalories.Text = "Total Calories: 0";
            }
        }

        private void btn_LogWorkout_Click(object sender, EventArgs e)
        {
            var logWorkoutPage = new LogWorkoutPage(_context);
            logWorkoutPage.Show();
            this.Hide();
        }

        private void btn_LogMeals_Click(object sender, EventArgs e)
        {
            var logMealsPage = new LogMealsPage(_context);
            logMealsPage.Show();
            this.Hide();
        }

        private void btn_MyProgress_Click(object sender, EventArgs e)
        {
            var myProgressPage = new MyProgressPage(_context);
            myProgressPage.Show();
            this.Hide();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm(_context); // Pass the context
            loginForm.Show();
            this.Close();
        }
    }

}
