using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class SavingCalculator
    {
        //All this fields are using new sintax
        //public string Var { get; set; } = ""; is like
        //private string var = "";
        //public string GetVar() => return var;
        //public void SetVar(string newVar) => var=newVar;
        public double InterestRate { get; set; } = 10;
        public double MonthlyDeposit { get; set; } = 0;
        public int NumberOfYears { get; set; } = 0;
        public double Fees { get; set; } = 0;
        public double TotalFees { get; set;  } = 0;
        public double Balance { get; set; } = 0;
        public double Paid { get; set; } = 0;
        public double Earned { get; set; } = 0;
        /// <summary>
        /// Returns amount paid, but rounded to the second decimals
        /// </summary>
        public double GetAmountPaid() => Math.Round(Paid,2);
        /// <summary>
        /// Calculate composite interest, updating variables and returns final balance rounded
        /// </summary>
        public double GetBalance()
        {
            TotalFees = 0;
            double tmp = 0;
            for (int i = 1; i <= NumberOfYears * 12; i++)
            {
                Balance += Balance * (InterestRate / (12*100)) + MonthlyDeposit;
                tmp = Balance * (Fees / (12*100));
                Balance -= tmp;
                TotalFees += tmp;
            }
            Paid = MonthlyDeposit * 12 * NumberOfYears;
            Earned = Balance - Paid;
            return Math.Round(Balance, 2);
        }
        /// <summary>
        /// Returns amount earned, but rounded to the second decimals
        /// </summary>
        public double GetEarned() => Math.Round(Earned,2);
    }
}
