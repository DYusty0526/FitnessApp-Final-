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
            RefreshWorkouts(); // Load the initial data
        }

        private void btn_AddWorkout_Click(object sender, EventArgs e)
        {
            var workout = new Workout
            {
                Type = cmb_WorkoutType.Text,
                Repetitions = int.Parse(txt_Repetitions.Text),
                Duration = int.Parse(txt_Duration.Text),
                Date = dtp_WorkoutDate.Value.Date
            };

            _context.Workouts.Add(workout);
            _context.SaveChanges();

            MessageBox.Show("Workout added successfully!", "Success");
            RefreshWorkouts();
        }

        private void btn_DeleteWorkout_Click(object sender, EventArgs e)
        {
            if (dgv_Workouts.CurrentRow != null)
            {
                var selectedWorkout = (Workout)dgv_Workouts.CurrentRow.DataBoundItem;
                _context.Workouts.Remove(selectedWorkout);
                _context.SaveChanges();

                MessageBox.Show("Workout deleted successfully!", "Success");
                RefreshWorkouts();
            }
            else
            {
                MessageBox.Show("Please select a workout to delete.", "Error");
            }
        }

        private void btn_UpdateWorkout_Click(object sender, EventArgs e)
        {
            if (dgv_Workouts.CurrentRow != null)
            {
                var selectedWorkout = (Workout)dgv_Workouts.CurrentRow.DataBoundItem;

                selectedWorkout.Type = cmb_WorkoutType.Text;
                selectedWorkout.Repetitions = int.Parse(txt_Repetitions.Text);
                selectedWorkout.Duration = int.Parse(txt_Duration.Text);
                selectedWorkout.Date = dtp_WorkoutDate.Value.Date;

                _context.SaveChanges();

                MessageBox.Show("Workout updated successfully!", "Success");
                RefreshWorkouts();
            }
            else
            {
                MessageBox.Show("Please select a workout to update.", "Error");
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            RefreshWorkouts();
            MessageBox.Show("Workouts refreshed successfully!", "Info");
        }

        private void btn_WorkoutHistory_Click(object sender, EventArgs e)
        {
            var workoutHistoryPage = new WorkoutHistoryPage(_context);
            workoutHistoryPage.Show();
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            var mainPage = new MainPage(_context);
            mainPage.Show();
            this.Close();
        }

        private void RefreshWorkouts()
        {
            var selectedDate = dtp_WorkoutDate.Value.Date;
            var workouts = _context.Workouts.Where(w => w.Date == selectedDate).ToList();
            dgv_Workouts.DataSource = workouts;

            cmb_WorkoutType.Text = string.Empty;
            txt_Repetitions.Text = string.Empty;
            txt_Duration.Text = string.Empty;
        }
    }
}
