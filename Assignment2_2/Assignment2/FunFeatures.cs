using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class FunFeatures
    {
        private string name = String.Empty; //Init empty string
        private string email = String.Empty;  //Init empty string
        public void Start()
        {
            bool done;
            do
            {
                Introduce();
                PredictTheDay();
                CalculateStringLength();
                done = !RunAgain(); //runAgain() ? yes or no -> true of false
            } while (!done);
        }
        private void Introduce() //output introduction infos
        {
            Console.WriteLine("\n[Introduction]");
            Console.WriteLine("My name is: Francesco and I am a university student");
            Console.WriteLine("Let me know about yourself");
            ReadName();
        }
        private void ReadName() //ask for user infos
        {
            bool flag = false;
            string? firstname, lastname, mail, correctQuestion;
            do
            {
                Console.Write("What is your first name? ");
                firstname = Console.ReadLine();
                Console.Write("What is your last name? ");
                lastname = Console.ReadLine();
                Console.WriteLine("Nice to meet you " + (string.IsNullOrEmpty(firstname) ? "undefined" : firstname));
                Console.Write("What is your email? ");
                mail = Console.ReadLine();
                name = (string.IsNullOrEmpty(lastname) ? "undefined" : lastname.ToUpper()) + ", " + (string.IsNullOrEmpty(firstname) ? "undefined" : firstname);
                email = string.IsNullOrEmpty(mail) ? "undefined" : mail;
                Console.WriteLine("Your full name is " + name + " and your e-mail is " + email + "\nCorrect(y/n)?");
                correctQuestion = Console.ReadLine();
                if (!string.IsNullOrEmpty(correctQuestion))
                {
                    flag = correctQuestion.Trim().Equals("n") || correctQuestion.Trim().Equals("no");
                }
            } while (flag);
        }
        private bool RunAgain() // ask to run again the program
        {
            Console.WriteLine("Do you want to run this program again?(y/n)?");
            string? v = Console.ReadLine();
            if (!string.IsNullOrEmpty(v))
            {
                return (v.Trim().Equals("y") || v.Trim().Equals("yes"));
            }
            return false;
        }
        private void PredictTheDay() // number between 1 and 7 to predict day
        {
            Console.WriteLine("\n[Predict the day]");
            bool flag = false;
            string? day;
            int value;
            do
            {
                Console.WriteLine("Select a number between 1 and 7: ");
                day = Console.ReadLine();
                if (!string.IsNullOrEmpty(day))
                {
                    if (!int.TryParse(day, out value))
                    {
                        value = 8;
                    }
                    switch (value)
                    {
                        case 1:
                            flag = false; //Reassign in case it runs more than once!
                            Console.WriteLine("Monday: Keep calm my friend! You can fall apart!");
                            break;
                        case 2:
                            flag = false;
                            Console.WriteLine("Tuesday and Wednesday break your heart!");
                            break;
                        case 3:
                            flag = false;
                            Console.WriteLine("Tuesday and Wednesday break your heart!");
                            break;
                        case 4:
                            flag = false;
                            Console.WriteLine("Thursday, OMG, still one day to Friday!");
                            break;
                        case 5:
                            flag = false;
                            Console.WriteLine("It's Friday! You are in love!");
                            break;
                        case 6:
                            flag = false;
                            Console.WriteLine("Saturday, do nothing and do plenty of it!");
                            break;
                        case 7:
                            flag = false;
                            Console.WriteLine("And Sunday always comes too soon!");
                            break;
                        default:
                            flag = true;
                            Console.WriteLine("Value not accepted");
                            break;
                    }
                }
                else  //empty input if
                {
                    flag = true;
                    Console.WriteLine("String null or empty");
                }
            } while (flag);
        }
        private void CalculateStringLength()
        {
            Console.WriteLine("\n[Calculate String Length]");
            bool flag;
            string? userInput;
            do
            {
                Console.WriteLine("Write something here: ");
                userInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(userInput))
                {
                    flag = false;
                    Console.WriteLine("String contains " + userInput.Length + " characters");
                }
                else
                {
                    flag = true;
                    Console.WriteLine("Empty or null string");
                }
            } while (flag);
        }
    }
}
