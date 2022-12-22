using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class Menu
    {
        public void ShowMenu()
	    {
		    bool done = false;  //Flag to control when to exit the loop
		    while (!done)
		    {
			    int choice = ReadMenuChoice(); //Show the menu text and retrieve the user's choice
			    switch (choice) //Show results
                {
                    case 0: //scenario exit
                        done = true;
                        break;
                    case 1: //scenario all classes
                        Console.WriteLine("\n-----Complete Program Section-----");
                        Console.WriteLine("--Fun Features Section");
                        FunFeatures funFeaturesObj = new();
                        funFeaturesObj.Start();
                        Console.WriteLine("\n--Math Work Section");
                        MathWork mathWorkObj = new();
                        mathWorkObj.Start();
                        Console.WriteLine("\n--Temperature Converter Section");
                        TemperatureConverter temperatureConverterObj = new();
                        temperatureConverterObj.Start();
                        Console.WriteLine("\n--Working Schedule Section");
                        WorkingSchedule workingScheduleObj = new();
                        workingScheduleObj.Start();
                        break;
                    case 2: //scenario just fun feature
                        Console.WriteLine("\n--Fun Features Section");
                        FunFeatures funFeatures = new();
                        funFeatures.Start();
                        break;
                    case 3: //scenario just math work
                        Console.WriteLine("\n-----Math Work Section-----");
                        MathWork mathWork = new();
                        mathWork.Start();
                        break;
                    case 4: //scenario just temperature conversion
                        Console.WriteLine("\n-----Temperature Converter Section-----");
                        TemperatureConverter temperatureConverter = new();
                        temperatureConverter.Start();
                        break;
                    case 5: //scenario just working schedule
                        Console.WriteLine("\n-----Working Schedule Section-----");
                        WorkingSchedule workingSchedule = new();
                        workingSchedule.Start();
                        break;
                } //switch
                if (!done)
                {
                    Console.WriteLine("\nThank you for trying this program.");
                } //if
		    } //while
	    } //showMenu
        private int ReadMenuChoice()
	    {
		    bool done = false;
		    int choice = -1;
		    do
		    {
                WriteMenuText();
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if ((choice >= 0) && (choice <= 5)) // if valid input go on
                    {
                        done = true;
                    }
                }
                if (!done){
                    Console.WriteLine("Invalid choice, try again!\n");
                }
            } while (!done);
		    return choice;
        } //ReadMenutChoiche
        private void WriteMenuText()
        {
            Console.WriteLine("\n ***************** MENU *********************");
            Console.WriteLine(" ***** 1. Complete Program");
            Console.WriteLine(" ***** 2. Fun Features");
            Console.WriteLine(" ***** 3. Math Works");
            Console.WriteLine(" ***** 4. Temperature Converter");
            Console.WriteLine(" ***** 5. Working Schedule");
            Console.WriteLine(" ***** 0. Exit");
            Console.WriteLine(" *********************************************\n");
            Console.Write("What is your choice? ");
        } //WriteMenutText
    } //class
} //namespace
