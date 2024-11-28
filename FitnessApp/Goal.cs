using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    public class Goal
    {
        public int GoalId { get; set; }
        public bool IsWeekly { get; set; } // true for weekly goals, false for monthly
        public int ExerciseDays { get; set; }
        public int ExercisesCount { get; set; }
        public int ExerciseDuration { get; set; } // in minutes
        public int MealsCount { get; set; }
        public int MaxCalories { get; set; }
        public int MaxProtein { get; set; }
        public int MaxCarbs { get; set; }
        public int MaxFat { get; set; }
    }

}
