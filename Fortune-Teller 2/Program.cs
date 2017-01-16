using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller_2
{
    class Program
    {
        //              Quit environment.quit{0}
        static void quitandrestart(string test)
        {
            if (test == "quit")
            {
                Environment.Exit(0);
            }
            if(test=="restart")
            {
                Main();
            }

        }

        //              Restart
        static void restart()
        {
            {
                Console.WriteLine("Welcome to the most accurate virtual fortune telling system on the web.");
                Console.WriteLine("Let's Begin!\a");

                //              Name Info
                Console.WriteLine("What is your first name? Type answers below.");
                string firstname = (Console.ReadLine()).ToLower();
               

                Console.WriteLine("\nWhat is your last name?");
                string lastname = (Console.ReadLine()).ToLower();
                greetingsname(firstname, lastname);

                //              Age Info
                Console.WriteLine("\nWhat is your age?");
                int age = int.Parse(Console.ReadLine());
                age.ToString();

                //if(((age.ToString()).ToLower)=="quit")
                //{
                //    age = (age.ToString());
                //    quit.
                //}

                int retirement = retirementage(age);

                //              Sibling Info
                Console.WriteLine("\nHow many siblings do you have?");
                int siblings = int.Parse(Console.ReadLine());
                string vacation = vacationhome(siblings);

                //              Favorite Color Info
                Console.WriteLine("\nWhat is your favorite ROYGBIV color?");
                Console.WriteLine("If you would a list of ROYGBIV colors type help.");
                string color = Console.ReadLine();
                color = color.ToLower();
                string transport = transportation(color);



                //              Birth Month Info
                Console.WriteLine("\nWhat is your birth month? Ex: October = 10");
                int birthmonth = int.Parse(Console.ReadLine());

                Console.Write(firstname + " " + lastname + " will retire in " + retirement + " with $" + birthmonth + " in the bank, a vacation home in " + vacation + " and a " + transport + "\n for transportation.\a\n");
            }
        }

        static void Main()
        {
            Console.WriteLine("Welcome to the most accurate virtual fortune telling system on the web.");
            Console.WriteLine("Let's Begin!\a");

            //              Name Info
            Console.WriteLine("What is your first name? Type answers below.");
            string firstname = (Console.ReadLine()).ToLower();
            quitandrestart(firstname);
            
            Console.WriteLine("\nWhat is your last name?");
            string lastname = (Console.ReadLine()).ToLower();
            quitandrestart(lastname);

            greetingsname(firstname, lastname);


            //              Age Info
            Console.WriteLine("\nWhat is your age?");
            string age =Console.ReadLine().ToLower();
            quitandrestart(age);
            int ageconvert = int.Parse(age);
            int retirement=retirementage(ageconvert);

            //              Sibling Info
            Console.WriteLine("\nHow many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());
            string vacation = vacationhome(siblings);
            vacation.ToLower();



            //              Favorite Color Info
            Console.WriteLine("\nWhat is your favorite ROYGBIV color?");
            Console.WriteLine("If you would a list of ROYGBIV colors type help.");
            string color = Console.ReadLine();
            color = color.ToLower();
            string transport=transportation(color);
            


            //              Birth Month Info
            Console.WriteLine("\nWhat is your birth month? Ex: October = 10");
            int birthmonth = int.Parse(Console.ReadLine());

            Console.Write(firstname + " " + lastname + " will retire in " + retirement + " with $" + birthmonth + " in the bank, a vacation home in " + vacation + " and a " + transport + "\n for transportation.\a\n");


        }
        //              Greetings Method
        static void greetingsname(string firstname, string lastname)
        {
            Console.WriteLine("Greetings " + firstname + " " + lastname + "! I will tell you your future./a");
        }

        //              Retirement Method
        static int retirementage(int age)
        {
            int years;
            string ageodd = "800";
            string ageeven = "5";
            if (age % 2 > 0)
            {
                years = int.Parse(ageodd);
            }
            else
            {
                years = int.Parse(ageeven);
            }
            return (years);
        }

        //              Vacation Home Method 
        static string vacationhome(int siblings)
        {
            string oddsib = "The Arctic Circle";
            string vacation = "";
            switch (siblings)
            {
                case 0:
                    string nosib = "Ancient Rome";
                    vacation = nosib;
                    break;
                case 1:
                    string onesib = "the crab nebula";
                    vacation = onesib;
                    break;
                case 2:
                    string twosib = "a Deserted Alley";
                    vacation = twosib;
                    break;
                case 3:
                    string threesib = "the Center of the Earth";
                    vacation = threesib;
                    break;
                default:
                    vacation = oddsib;
                    break;
            }
            return (vacation);
        }

        //               Transportation Method
        static string transportation(string color)
        {
            if (color == "help")
            {
                Console.Write("\nRed\nOrange\nYellow\nGreen\nBlue\nIndigo\nViolet\n");
                Console.WriteLine("\nWhat is your favorite ROYGBIV color?");
                string helpcolor = Console.ReadLine();
                color = helpcolor.ToLower();
                switch (color)
                {
                    case ("red"):
                        string redtransportation = "Maserati";
                        color = redtransportation;
                        break;
                    case ("blue"):
                        string bluetransportation = "The Tardis";
                        color = bluetransportation;
                        break;
                    case ("orange"):
                        string orangetransportation = "Hot air balloon";
                        color = orangetransportation;
                        break;
                    case ("yellow"):
                        string yellowtransportation = "Your Feet";
                        color = yellowtransportation;
                        break;
                    case ("green"):
                        string greentransportation = "Giant Squirrel";
                        color = greentransportation;
                        break;
                    case ("indigo"):
                        string indigotransportation = "Unicorn";
                        color = indigotransportation;
                        break;
                    case ("violet"):
                        string violettransportation = "Solid Rainbow";
                        color = violettransportation;
                        break;
                }

            }
            switch (color)
            {
                case ("red"):
                    string redtransportation = "Maserati";
                    color = redtransportation;
                    break;
                case ("blue"):
                    string bluetransportation = "The Tardis";
                    color = bluetransportation;
                    break;
                case ("orange"):
                    string orangetransportation = "Hot air balloon";
                    color = orangetransportation;
                    break;
                case ("yellow"):
                    string yellowtransportation = "Your Feet";
                    color = yellowtransportation;
                    break;
                case ("green"):
                    string greentransportation = "Giant Squirrel";
                    color = greentransportation;
                    break;
                case ("indigo"):
                    string indigotransportation = "Unicorn";
                    color = indigotransportation;
                    break;
                case ("violet"):
                    string violettransportation = "Solid Rainbow";
                    color = violettransportation;
                    break;
            }
            return (color);
        }

        //              Money in the Bank Method
        static double bankroll(int birthmonth)
        {
            if (birthmonth >= 1 && birthmonth <= 4)
            {
                int janaprilcash = 1000000;
                birthmonth = janaprilcash;
            }
            else if (birthmonth >= 5 && birthmonth <= 8)
            {
                int mayaugustcash = 500000;
                birthmonth = mayaugustcash;
            }
            else if (birthmonth >= 9 && birthmonth <= 12)
            {
                int septdecemcash = 2;
                birthmonth = septdecemcash;
            }
            else
            {
                int nomonth = 0;
                birthmonth = nomonth;
            }
            return (birthmonth);
        }
        
        
        
        

                
    }
}
