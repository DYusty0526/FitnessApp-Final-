using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    public class NutritionGoal
    {
        public int Id { get; set; } // Primary key
        public int Meals { get; set; }
        public int MaxCalories { get; set; }
        public string MaxMacros { get; set; } // Example: "P:50% C:30% F:20%"
        public bool IsWeekly { get; set; } // Toggle between weekly or monthly
        public GoalType GoalType { get; set; } // Add this property

    }
}
