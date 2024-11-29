using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
      public enum GoalType
    {
        Weekly,
        Monthly
    }
    public class ExerciseGoal
    {
        public int Id { get; set; } // Primary key
        public int DaysToExercise { get; set; }
        public int TotalExercises { get; set; }
        public int DurationMinutes { get; set; } // Total duration goal in minutes
        public bool IsWeekly { get; set; } // Toggle between weekly or monthly
        public GoalType GoalType { get; set; }
    }
}
