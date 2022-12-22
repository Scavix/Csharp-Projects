using System;

namespace Assignment2
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            PrepareConsoleLook(ConsoleColor.Cyan, ConsoleColor.Black, "Assignment 2");
            Menu menu = new(); // Declare and create an object of the Menu class
            menu.ShowMenu(); // Call the start method of the Menu class to get started
        }
        static void PrepareConsoleLook(ConsoleColor backgroundColor, ConsoleColor foregroundColor, string title)
        {
            Console.BackgroundColor = backgroundColor;
            Console.Clear();
            Console.ForegroundColor = foregroundColor;
            Console.Title = title;
        }
    }
}