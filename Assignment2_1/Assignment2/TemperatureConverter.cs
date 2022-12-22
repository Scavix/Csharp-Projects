using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class TemperatureConverter
    {
        public void Start()
        {
            bool done; //variable for loop
            do
            {
                ShowMenu(); //show choices
                done = !RunAgain(); //runAgain() ? yes or no -> true of false
            } while (!done);
        }
        private bool RunAgain() // ask to run again
        {
            Console.WriteLine("Do you want to run this program again?(y/n)?");
            string? v = Console.ReadLine(); //input if y or yes it runs again
            if (!string.IsNullOrEmpty(v))
            {
                return (v.Trim().Equals("y") || v.Trim().Equals("yes"));
            }
            return false;
        }
        private void ShowMenu() //show choices
        {
            bool done = false;  //Flag to control when to exit the loop
            while (!done)
            {
                int choice = ReadMenuChoice(); //Show the menu text and retrieve the user's choice
                switch (choice) //Show results
                {
                    case 0: // case exit
                        done = true;
                        break;
                    case 1: // case C to F
                        ShowTableCelsiusToFarenheit(); //Show table
                        done = true; //end loop
                        break;
                    case 2: // case F to C
                        ShowTableFarenheitToCelsius(); //Show table
                        done = true; //end loop
                        break; 
                } //switch
                if (!done)
                {
                    Console.WriteLine("\nThank you for trying this program.");
                } //if
            } //while
        }
        private int ReadMenuChoice() //asks for input scenario
        {
            bool done = false;
            int choice = -1;
            do
            {
                WriteMenuText();
                if (int.TryParse(Console.ReadLine(), out choice)) //parse input
                {
                    if ((choice >= 0) && (choice <= 2)) //if valid input go on
                    {
                        done = true;
                    }
                }
                if (!done)
                {
                    Console.WriteLine("Invalid choice, try again!\n");
                }
            } while (!done);
            return choice;
        } //ReadMenutChoiche
        private void WriteMenuText()
        {
            Console.WriteLine("\n ***************** MENU *********************");
            Console.WriteLine(" ***** Celsius to Fahrenheit [1]");
            Console.WriteLine(" ***** Fahrenheit to Celsius [2]");
            Console.WriteLine(" ***** Exit [0]");
            Console.WriteLine(" *********************************************\n");
            Console.Write("What is your choice? ");
        } //WriteMenutText
        private static double CelsiusToFarenheit(double value) => 9 / 5.0 * value + 32;
        private static double FarenheitToCelsius(double value) => 5 / 9.0 * (value - 32);
        private static void ShowTableCelsiusToFarenheit()
        {
            for (int value = 0 ; value<=100; value+=4) //up to 100 with jumps of 4
            {
                for (int i = 0 ; i<2; i++) // 2 columns
                { 
                    Console.Write(string.Format("{0,3}",value) + "°C = " + string.Format("{0,5:0.##}",CelsiusToFarenheit(value)) + "°F   ");
                    value+=4;
                }
                Console.WriteLine();
            }
        }
        private static void ShowTableFarenheitToCelsius()
        {
            for (int value = 0 ; value<=212; value+=4) //up to 100 with jumps of 4
            {
                for (int i = 0 ; i<4; i++) // 4 columns
                { 
                    Console.Write(string.Format("{0,3}",value) + "°C = " + string.Format("{0,6:0.##}",FarenheitToCelsius(value)) + "°F   ");
                    value+=4;
                }
                Console.WriteLine();
            }
        }
    }
}
