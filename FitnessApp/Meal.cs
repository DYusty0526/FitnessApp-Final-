using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    public class Meal
    {
        public int MealId { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public int Calories { get; set; }
        public int ProteinPercentage { get; set; }
        public int CarbsPercentage { get; set; }
        public int FatPercentage { get; set; }
        public DateTime MealDate { get; set; }
    }

}
