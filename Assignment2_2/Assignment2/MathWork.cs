using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class MathWork
    {
        // Method called from main
        public void Start()
        {
            bool done;
            do
            {
                SumNumbers();
                WriteMultiplicationTable();
                CalculateSquareRoots();
                ListLeapYears();
                done = !RunAgain(); //runAgain() ? yes or no -> true of false
            } while (!done);
        }

        // Method to calculate sum of numbers fron start to end
        // Created using a for loop from start to end, adding the index
        private int SumNumbers(int start, int end)
        {
            int result = 0;
            for (int i = start; i<=end; i++)
            {
                result += i;
            }
            return result;
        }

        // Method to asks to run again the program
        // if users enter yes or y return true else false
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

        // Method to read input integers from console
        // Method asks integer as input, if accepted and parsed returns it
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

        // Method to sum 2 numbers
        // Method asks 2 integer in input, then call sumNumber(int1,int2) to calculate value
        private void SumNumbers()
        {
            Console.WriteLine("\n[Sum Numbers]");
            int first = ReadIntegerFromConsole("Insert the first number here: "); // read num1
            int second = ReadIntegerFromConsole("Insert the second number here: "); // read num2
            int result = SumNumbers(first < second ? first : second, first >= second ? first : second);  // sum nums
            Console.WriteLine("The result is: " + result);
            WriteAllEvenNumbers(first < second ? first : second, first >= second ? first : second);
        }

        // Method to print all even number from start to end
        // Created using a for loop from start to end
        // if the number is even (x%2==0) prints it
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

        // Method to print the multiplication table of 12*12
        // Created using nested for loops from 1 to 12
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

        // Method to calculate roots values of numbers
        // Method asks integer as input, if accepted return square root
        private void CalculateSquareRoots()
        {
            Console.WriteLine("\n[Calculate Square Roots]");
            //Using Pow for the root, and round to round to 2 number after .
            Console.WriteLine("Here is your squared number: " + Math.Round(Math.Pow(ReadIntegerFromConsole("Insert the first number here: "), 1.0 / 2),2));
        }

        // Method to calculate leap years not using inbuilt library between
        private void ListLeapYears()
        {
            Console.WriteLine("\n[List Leap years]");
            int first = ReadIntegerFromConsole("Insert the first year here: "); // read num1
            int second = ReadIntegerFromConsole("Insert the second year here: "); // read num2
            for (int i = first; i<=second; i++)
            {
                for (int j = 0; j < 4; j++) {
                    if (IsLeapYear(i))
                    {
                        Console.Write(i+" ");
                    }
                    else
                    {
                        j--;
                    }
                    i++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // Method to calculate if a year is a leap year
        private bool IsLeapYear(int year)
        {
            return (year%4==0)&&((year%100!=0)||(year%400==0));
        }
    }
}