using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class BMRCalculator
    {
        //All this fields are using new sintax
        //public string Var { get; set; } = ""; is like
        //private string var = "";
        //public string GetVar() => return var;
        //public void SetVar(string newVar) => var=newVar;
        public string Name { get; set; } = "Undefined";
        public double Height { get; set; } = 0;
        public double Weight { get; set; } = 0;
        public Genders Gender { get; set; } = Genders.Male;
        public UnitTypes Unit { get; set; } = UnitTypes.Metric;
        public ActivityLevels ActivityLevel { get; set; } = ActivityLevels.Lightly;
        public int Age { get; set; } = 0;
        /// <summary>
        /// Calculate and returns BMR based on unit type meter, rounded to the second decimal.
        /// </summary>
        public double GetBMRM() => Math.Round(10 * Weight + 6.25 * Height - 5 * Age, 2);
        /// <summary>
        /// Calculate and returns BMR based on unit type imperial, rounded to the second decimal.
        /// </summary>
        public double GetBMRI() => Math.Round(4.536 * Weight + 15.88 * Height - 5 * Age, 2);
        /// <summary>
        /// Calculate and returns BMR, it calls two methods based on unit type and different behavior based on gender.
        /// </summary>
        public double GetBMR() => Unit == UnitTypes.Metric ? (Gender == Genders.Male ? GetBMRM() + 5 : GetBMRM() - 161) : (Gender == Genders.Male ? GetBMRI() + 5: GetBMRI() - 161);
        /// <summary>
        /// Calculate and returns maintaining BMR, rounded to the second decimal.
        /// </summary>
        public double MaintainWeightBMRs() => Math.Round(GetBMR() * GetActivityLevelFactor(),2);
        /// <summary>
        /// Calculate and returns calories to lose or gain kg, rounded to the second decimal (kg can be negative!).
        /// </summary>
        public double LoseOrGainWeight(double kg) => MaintainWeightBMRs() + kg * 1000;
        /// <summary>
        /// Returns constant based on activitylevels enum.
        /// </summary>
        public double GetActivityLevelFactor()
        {
            return ActivityLevel switch
            {
                ActivityLevels.Sedentary => 1.2,
                ActivityLevels.Lightly => 1.375,
                ActivityLevels.Moderately => 1.55,
                ActivityLevels.Very => 1.725,
                ActivityLevels.Extra => 1.9,
                _ => 1.375,
            };
        }
    }
}
