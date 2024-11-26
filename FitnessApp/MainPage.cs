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
        public MainPage()
        {
            InitializeComponent();
        }
        private void btn_LogWorkout_Click(object sender, EventArgs e)
        {
            LogWorkoutPage logWorkoutPage = new LogWorkoutPage();
            logWorkoutPage.Show();
            this.Hide();
        }
        private void btn_LogMeals_Click(object sender, EventArgs e)
        {
            LogMealsPage logMealsPage = new LogMealsPage();
            logMealsPage.Show();
            this.Hide();
        }
        private void btn_MyProgress_Click(object sender, EventArgs e)
        {
            MyProgressPage progressPage = new MyProgressPage();
            progressPage.Show();
            this.Hide();
        }
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
