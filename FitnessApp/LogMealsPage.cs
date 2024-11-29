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
        }

        // Event handler for Add Meal button
        private void btn_AddMeal_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new Meal object
                var meal = new Meal
                {
                    MealName = txt_MealName.Text,
                    Description = txt_Description.Text,
                    Calories = int.Parse(txt_Calories.Text),
                    ProteinPercentage = int.Parse(txt_Protein.Text),
                    CarbsPercentage = int.Parse(txt_Carbs.Text),
                    FatPercentage = int.Parse(txt_Fat.Text),
                    MealDate = dtp_Date.Value
                };

                // Add the new meal to the database
                _context.Meals.Add(meal);
                _context.SaveChanges();

                MessageBox.Show("Meal added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the fields for a new entry
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding meal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for Back button
        private void btn_Back_Click(object sender, EventArgs e)
        {
            var mainPage = new MainPage(_context);
            mainPage.Show();
            this.Close();
        }

        // Event handler for View History button
        private void btn_ViewHistory_Click(object sender, EventArgs e)
        {
            var nutritionHistoryPage = new YourNutritionPage(_context);
            nutritionHistoryPage.Show();
            this.Close();
        }

        // Helper method to clear the input fields
        private void ClearFields()
        {
            txt_MealName.Text = string.Empty;
            txt_Description.Text = string.Empty;
            txt_Calories.Text = string.Empty;
            txt_Protein.Text = string.Empty;
            txt_Carbs.Text = string.Empty;
            txt_Fat.Text = string.Empty;
            dtp_Date.Value = DateTime.Today;
        }
    }
}
