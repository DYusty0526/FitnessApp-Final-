using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace FitnessApp
{
    public partial class LogMealsPage : Form
    {
        private readonly FitnessAppContext _context;

        public LogMealsPage(FitnessAppContext context)
        {
            InitializeComponent();
            _context = context;
            RefreshMeals(); // Load the initial data
        }

        private void btn_AddMeal_Click(object sender, EventArgs e)
        {
            try
            {
                var meal = new Meal
                {
                    MealName = txt_MealName.Text,
                    Description = txt_Description.Text,
                    Calories = int.Parse(txt_Calories.Text),
                    ProteinPercentage = int.Parse(txt_Protein.Text),
                    CarbsPercentage = int.Parse(txt_Carbs.Text),
                    FatPercentage = int.Parse(txt_Fat.Text),
                    MealDate = dtp_Date.Value.Date
                };

                _context.Meals.Add(meal);
                _context.SaveChanges();

                MessageBox.Show("Meal added successfully!", "Success");
                RefreshMeals();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private void btn_DeleteMeal_Click(object sender, EventArgs e)
        {
            if (dgv_Meals.CurrentRow != null)
            {
                try
                {
                    var selectedMeal = (Meal)dgv_Meals.CurrentRow.DataBoundItem;
                    _context.Meals.Remove(selectedMeal);
                    _context.SaveChanges();

                    MessageBox.Show("Meal deleted successfully!", "Success");
                    RefreshMeals();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please select a meal to delete.", "Error");
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            RefreshMeals();
            MessageBox.Show("Meals refreshed successfully!", "Info");
        }

        private void btn_ViewHistory_Click(object sender, EventArgs e)
        {
            var yourNutritionPage = new YourNutritionPage(_context);
            yourNutritionPage.Show();
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            var mainPage = new MainPage(_context);
            mainPage.Show();
            this.Close();
        }

        private void RefreshMeals()
        {
            var selectedDate = dtp_Date.Value.Date;
            var meals = _context.Meals.Where(m => m.MealDate == selectedDate).ToList();
            dgv_Meals.DataSource = meals;

            txt_MealName.Text = string.Empty;
            txt_Description.Text = string.Empty;
            txt_Calories.Text = string.Empty;
            txt_Protein.Text = string.Empty;
            txt_Carbs.Text = string.Empty;
            txt_Fat.Text = string.Empty;
        }
    }
}
