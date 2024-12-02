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
                lbl_TodayWorkout.Text = "Today's Workouts:\n" +
                    string.Join("\n", workouts.Take(3).Select(w => $"{w.Type}: {w.Repetitions} Sets"));
            }
            else
            {
                lbl_TodayWorkout.Text = "Today's Workouts: None";
            }
        }

        private void LoadNutritionData()
        {
            var today = DateTime.Today;
            var meals = _context.Meals.Where(m => m.MealDate == today).ToList();

            if (meals.Any())
            {
                lbl_TodayMeals.Text = "Today's Meals:\n" +
                    string.Join("\n", meals.Take(3).Select(m => $"{m.MealName}: {m.Calories} Calories"));
            }
            else
            {
                lbl_TodayMeals.Text = "Today's Meals: None";
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
    }
}
