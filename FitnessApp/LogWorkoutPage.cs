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
    public partial class LogWorkoutPage : Form
    {
        public LogWorkoutPage()
        {
            InitializeComponent();
        }
        private void btn_AddWorkout_Click(object sender, EventArgs e)
        {
            string workoutType = txt_WorkoutType.Text;
            string exercise = txt_Exercise.Text;
            string duration = txt_Duration.Text;
            string repetitions = txt_Repetitions.Text;
            string date = dtp_Date.Value.ToString("dd/MM/yyyy");

            MessageBox.Show(
                $"Workout Added:\nType: {workoutType}\nExercise: {exercise}\nDuration: {duration}\nRepetitions: {repetitions}\nDate: {date}",
                "Workout Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }
        private void btn_ViewHistory_Click(object sender, EventArgs e)
        {
            WorkoutHistoryPage historyPage = new WorkoutHistoryPage();
            historyPage.Show();
            this.Hide();
        }
    }
}
