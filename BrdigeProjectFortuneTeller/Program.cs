using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BrdigeProjectFortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collecting and assigning user input to declared variables

            Console.WriteLine("Hello!  Welcome to the Fortune Teller! " +
                "\nType \"quit\" at any time to end this program.  " +
                "\nType \"restart\" at any time to restart this program" +
                "\nTo begin, please enter your first name:");

            string userInput = Console.ReadLine().ToLower();
            string firstName = userInput;
            if (userInput == "quit" || userInput == "restart")
            {
                Quit(userInput);
            }



            Console.WriteLine("Please enter your last name:");
            userInput = Console.ReadLine().ToLower();
            string lastName = userInput;
            if (userInput == "quit" || userInput == "restart")
            {
                Quit(userInput);
            }


            //calling greet method:
            Greet(firstName, lastName);

            Console.WriteLine("Please enter your age:");
            userInput = Console.ReadLine();
            int age;
            int.TryParse(userInput, out age);
            if (userInput == "quit" || userInput == "restart")
            {
                Quit(userInput);
            }


            Console.WriteLine("Please enter your birthmonth (in the form of a number/integer)");
            userInput = Console.ReadLine();
            int birthMonth;
            int.TryParse(userInput, out birthMonth);
            if (userInput == "quit" || userInput == "restart")
            {
                Quit(userInput);
            }



            Console.WriteLine("Please enter your favorite color from the following: R O Y G B I V.  Type \"help\" to view the color selection menu.");
            string color;
            userInput = Console.ReadLine().ToLower();
            color = userInput;
            if (color == "help")
            {
                Console.WriteLine("color Selection Menu: \nR = Red \nO = Orange \nY = Yellow \nG = Green \nB = Blue \nI = Indigo \nV = Violet \nPlease enter your favorite color:");
                color = Console.ReadLine();
            }
            if (userInput == "quit" || userInput == "restart")
            {
                Quit(userInput);
            }


            Console.WriteLine("Please enter the number of siblings you have:");
            userInput = Console.ReadLine();
            int sibling;
            int.TryParse(userInput, out sibling);
            if (userInput == "quit" || userInput == "restart")
            {
                Quit(userInput);
            }


            //call method to calc retirement age:
            int yearsUntilRetire = RetirementAge(age);

            //call method to determine vacation home:
            string vacationHome = VacationHome(sibling);

            //call method to determine transportation:
            string transportation = Transportation(color);

            //call method to determine $$ in the bank:
            double moneyInBank = BankAccount(birthMonth);

            //Returning the user's fortune
            Console.WriteLine("Here is your fortune:");
            Console.WriteLine(firstName + " " + lastName + " will retire in " + yearsUntilRetire + " years, with $" + moneyInBank + " in the bank, a vacation home in " + vacationHome + ", and a " + transportation + ".");

            //method to judge users fortune
            FortuneJudgement();


        }

        //greet user
        public static void Greet(string first, string last)
        {
            Console.WriteLine("Greetings, {0} {1}. I will tell you your fortune!", first, last);
        }

        //Calculating retirement age
        public static int RetirementAge(int currentAge)
        {
            if (currentAge % 2 == 1)
            {
                return 31;
            }
            else
            {
                return 25;
            }
        }

        //method to determine vacation home:
        public static string VacationHome(int numberSibs)
        {
            if (numberSibs < 0 || numberSibs > 3)
            {
                return "Oscar the Grouch's trashcan";
            }
            else if (numberSibs == 0)
            {
                return "Shangri La";
            }
            else if (numberSibs == 1)
            {
                return "Big Sky, Montana";
            }
            else if (numberSibs == 2)
            {
                return "Telluride, Colorado";
            }
            else if (numberSibs == 3)
            {
                return "Coroico, Bolivia";
            }
            else
            {
                return "Cleveland, Ohio";
            }
        }

        //method to determine transportation:
        public static string Transportation(string color)
        {
            switch (color)
            {
                case "r":
                    return "X wing fighter";
                    break;

                case "o":
                    return "hot air baloon";
                    break;

                case "y":
                    return "camel caravan";
                    break;

                case "g":
                    return "space X rocket";
                    break;

                case "b":
                    return "G6 airplane";
                    break;

                case "i":
                    return "raft";
                    break;

                case "v":
                    return "walking stick";
                    break;

                default:
                    return "squeaky shopping cart";
                    break;
            }
        }
        //money in the bank method:
        public static double BankAccount(int birthMonth)
        {
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                return -1.98;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                return 2.00;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                return 8888888.88;
            }
            else
            {
                return 0.00;
            }

        }

        //method to judge user's fortune:
        public static void FortuneJudgement()
        {
            Console.WriteLine("Wowee what a fortune!  Good things around the corner!");
        }





        //method to quit at anytime user input is requested:
        public static void Quit(string userInput)
        {
            switch (userInput)
            {

                case "quit":
                    Console.WriteLine("You are now leaving the program.");
                    System.Environment.Exit(0);
                    break;

                case "restart":
                    Console.WriteLine("You are now restarting the program in a new window.");
                    var BridgeFortune = Assembly.GetExecutingAssembly().Location;
                    System.Diagnostics.Process.Start(BridgeFortune);
                    Environment.Exit(0);
                    break;

                default:
                    break;
            }
        }
    }
}

