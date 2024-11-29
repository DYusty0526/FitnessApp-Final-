using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    public class Workout
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; } // Duration in minutes
        public int Repetitions { get; set; }
        public DateTime Date { get; set; } // This property is required
    }


}
