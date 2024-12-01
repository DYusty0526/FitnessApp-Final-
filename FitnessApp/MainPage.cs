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

            RefreshWorkouts();
            RefreshMeals();
        }

        private void RefreshWorkouts()
        {
            var today = DateTime.Today;
            var workouts = _context.Workouts
                .Where(w => w.Date == today)
                .Take(3) // Show up to 3 workouts
                .ToList();

            lst_Workouts.Items.Clear(); // Clear the ListBox before adding new items

            if (workouts.Any())
            {
                foreach (var workout in workouts)
                {
                    lst_Workouts.Items.Add($"{workout.Type}: {workout.Repetitions} sets, {workout.Duration} mins");
                }
            }
            else
            {
                lst_Workouts.Items.Add("No workouts logged today.");
            }
        }

        private void RefreshMeals()
        {
            var today = DateTime.Today;
            var meals = _context.Meals
                .Where(m => m.MealDate == today)
                .Take(3) // Show up to 3 meals
                .ToList();

            lst_Meals.Items.Clear(); // Clear the ListBox before adding new items

            if (meals.Any())
            {
                foreach (var meal in meals)
                {
                    lst_Meals.Items.Add($"{meal.MealName}: {meal.Calories} calories");
                }
            }
            else
            {
                lst_Meals.Items.Add("No meals logged today.");
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

        private void btn_ViewGoals_Click(object sender, EventArgs e)
        {
            var myGoalsPage = new MyGoalsPage(_context);
            myGoalsPage.Show();
            this.Hide();
        }

        private void btn_ViewProgress_Click(object sender, EventArgs e)
        {
            var myProgressPage = new MyProgressPage(_context);
            myProgressPage.Show();
            this.Hide();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm(_context);
            loginForm.Show();
            this.Close();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            RefreshWorkouts();
            RefreshMeals();
        }
    }
}
