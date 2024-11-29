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
        private readonly FitnessAppContext _context;

        public LogWorkoutPage(FitnessAppContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btn_AddWorkout_Click(object sender, EventArgs e)
        {
            try
            {
                var workout = new Workout
                {
                    Type = txt_WorkoutType.Text,
                    Duration = int.Parse(txt_Duration.Text),
                    Repetitions = int.Parse(txt_Repetitions.Text),
                    Date = dtp_WorkoutDate.Value
                };

                _context.Workouts.Add(workout);
                _context.SaveChanges();

                MessageBox.Show("Workout added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding workout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            var mainPage = new MainPage(_context);
            mainPage.Show();
            this.Close();
        }

        private void btn_ViewHistory_Click(object sender, EventArgs e)
        {
            var workoutHistoryPage = new WorkoutHistoryPage(_context);
            workoutHistoryPage.Show();
            this.Close();
        }
    }
}
