using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    public class Workout
    {
        public int WorkoutId { get; set; }
        public string WorkoutType { get; set; }
        public string ExerciseName { get; set; }
        public int Duration { get; set; } // in minutes
        public int Repetitions { get; set; }
        public DateTime WorkoutDate { get; set; }
    }

}
