using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.DataFormats;

namespace Assignment3
{
    //Class used to make internal calulations regard BMI
    internal class BMICalculator
    {
        //All this fields are using new sintax
        //public string Var { get; set; } = ""; is like
        //private string var = "";
        //public string GetVar() => return var;
        //public void SetVar(string newVar) => var=newVar;
        public string Name { get; set; } = "Undefined";
        public double Height { get; set; } = 0;
        public double Weight { get; set; } = 0;
        public UnitTypes Unit { get; set; } = UnitTypes.Metric;
        private double BMI { get; set; } = 0;
        public double LowerBound{ get; set; } = 18.5;
        public double HigherBound { get; set; } = 24.9;

        /// <summary>
        /// Method that calculate BMI with Metric unit.
        /// </summary>
        public double BMIMetric() => Math.Round(Weight / (Height * Height / 10000),2);
        /// <summary>
        /// Method that calculate BMI with Imperial unit.
        /// </summary>
        public double BMIImperial() => Math.Round(703 * Weight / (Height * Height),2);
        /// <summary>
        /// Method that calculate BMI and returns it.
        /// </summary>
        public double GetBMI()
        {
            BMI = Unit == UnitTypes.Metric ? BMIMetric() : BMIImperial();
            return BMI;
        }
        /// <summary>
        /// Method that calculate category based on BMI and returns it.
        /// </summary>
        public string GetCategory()
        {
            if (BMI<18.5)
            {
                return "Underweight";
            }
            else if(BMI < 25)
            {
                return "Normal weight";
            }
            else if (BMI < 30)
            {
                return "Overweight (Pre-obesity)";
            }
            else if (BMI < 35)
            {
                return "Overweight (Obesity class I)";
            }
            else if (BMI < 40)
            {
                return "Overweight (Obesity class II)";
            }
            else
            {
                return "Overweight (Obesity class III)";
            }
        }
        /// <summary>
        /// Method that create category texts based on unit.
        /// </summary>
        public string GetCategoryInfo()
        {
            string result = "Normal weight should be between ";
            result += Unit == UnitTypes.Metric ? Math.Round(LowerBound * (Height * Height / 10000),2) : Math.Round(LowerBound * (Height * Height / 703),2);
            result += " and ";
            result += Unit == UnitTypes.Metric ? Math.Round(HigherBound * (Height * Height / 10000),2) : Math.Round(HigherBound * (Height * Height / 703),2);
            result += Unit == UnitTypes.Metric ? " kg " : " lbs";
            return result;
        }
        /// <summary>
        /// Method that create BMI texts based on unit
        /// </summary>
        public string GetBMIInfo()
        {
            string result = "Normal BMI is between " + LowerBound.ToString() + " and " + HigherBound.ToString();
            return result;
        }
    }
}
