using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrdigeProjectFortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collecting and assigning user input to declared variables

            Console.WriteLine("Hello!  Welcome to the Fortune Teller! \nTo begin, please enter your first name:");
            string firstName = Console.ReadLine().ToLower();


            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine().ToLower();

            //calling greet method:
            Greet(firstName, lastName);

            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your birthmonth (in the form of a number/integer)");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your favorite color from the following: R O Y G B I V.  Type \"help\" to view the color selection menu.");
            string color = Console.ReadLine().ToLower();
            if (color == "help")
            {
                Console.WriteLine("color Selection Menu: \nR = Red \nO = Orange \nY = Yellow \nG = Green \nB = Blue \nI = Indigo \nV = Violet \nPlease enter your favorite color:");
                color = Console.ReadLine();
            }

            Console.WriteLine("Please enter the number of siblings you have:");
            int sibling = int.Parse(Console.ReadLine());

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
    }
}

