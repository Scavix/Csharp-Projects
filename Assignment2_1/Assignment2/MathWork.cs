using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class MathWork
    {
        public void Start()
        {
            bool done;
            do
            {
                SumNumbers();
                WriteMultiplicationTable();
                done = !RunAgain(); //runAgain() ? yes or no -> true of false
            } while (!done);
        }
        private int SumNumbers(int start, int end)
        {
            int result = 0;
            for (int i = start; i<=end; i++)
            {
                result += i;
            }
            return result;
        }
        private bool RunAgain()
        {
            Console.WriteLine("Do you want to run this program again?(y/n)?");
            string? v = Console.ReadLine();
            if (!string.IsNullOrEmpty(v))
            {
                return (v.Trim().Equals("y") || v.Trim().Equals("yes"));
            }
            return false;
        }
        public static int ReadIntegerFromConsole(string messageToUser)
        {
            int convertedValue = 0;  //local variable must be initiated.
            bool goodNumber = false; //flag to stop the loop
            do // Loop until user input can be converted to integer
            {
                Console.Write(messageToUser); // Display info message on console
                goodNumber = int.TryParse(Console.ReadLine(), out convertedValue); // GoodNumber will be true if conversion is successful           
                if (!goodNumber)  //same as (goodNumber == false)
                { 
                    Console.WriteLine("Input must be an integer. Try again.");
                }
            } while (!goodNumber);  //means: while (done == false)
            return convertedValue; //loop is finished and there is a good number - send it back.
        }
        private void SumNumbers()
        {
            Console.WriteLine("\n[Sum Numbers]");
            int first = ReadIntegerFromConsole("Insert the first number here: "); // read num1
            int second = ReadIntegerFromConsole("Insert the second number here: "); // read num2
            int result = SumNumbers(first < second ? first : second, first >= second ? first : second);  // sum nums
            Console.WriteLine("The result is: " + result);
            WriteAllEvenNumbers(first < second ? first : second, first >= second ? first : second);
        }
        private void WriteAllEvenNumbers(int start, int end)
        {
            Console.WriteLine("Even numbers between " + start + " and "+ end);
            for (int i = start; i <= end; i++) //for every number until the end
            {
                if (i % 2 == 0) // if even print
                {
                    Console.Write("|" + i + "|");
                }
            }
            Console.WriteLine();
        }
        private void WriteMultiplicationTable()
        {
            Console.WriteLine("\n[Multiplication Table]");
            for (int row = 1; row <= 12; row++) //for every row until the 12
            {
                for (int col = 1; col <= 12; col++) //for every column until the 12
                {
                    Console.Write(string.Format("{0,4:d} ", row * col));
                }
                Console.WriteLine();
            }
        }
    }
}