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
    public partial class LogMealsPage : Form
    {
        public LogMealsPage()
        {
            InitializeComponent();
        }
        private void btn_AddMeal_Click(object sender, EventArgs e)
        {
            // Placeholder logic for saving a meal
            string mealName = txt_MealName.Text;
            string description = txt_Description.Text;
            string calories = txt_Calories.Text;
            string protein = txt_Protein.Text;
            string carbs = txt_Carbs.Text;
            string fat = txt_Fat.Text;
            string date = dtp_Date.Value.ToString("dd/MM/yyyy");

            // For now, just display a message box with the entered details
            MessageBox.Show(
                $"Meal Added:\nName: {mealName}\nDescription: {description}\nCalories: {calories}\nProtein: {protein}\nCarbs: {carbs}\nFat: {fat}\nDate: {date}",
                "Meal Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Later, this logic will connect to the database to save the data
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void btn_ViewHistory_Click(object sender, EventArgs e)
        {
            // Navigate to the Nutrition History Page (e.g., YourNutritionPage)
            YourNutritionPage nutritionHistoryPage = new YourNutritionPage();
            nutritionHistoryPage.Show();
            this.Hide();
        }
    }
}
