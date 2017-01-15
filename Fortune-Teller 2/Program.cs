using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the most accurate virtual fortune telling system on the web.");
            Console.WriteLine("Let's Begin!\a");

            //              Name Info
            Console.WriteLine("What is your first name? Type answers below.");
            string firstname = (Console.ReadLine()).ToLower();        
            quit(firstname);
            Console.WriteLine("\nWhat is your last name?");
            string lastname = (Console.ReadLine()).ToLower();
            quit(lastname);
            
            

            

            greetingsname(firstname, lastname);

            //              Age Info
            Console.WriteLine("\nWhat is your age?");
            int age = int.Parse(Console.ReadLine());

            //              Sibling Info
            Console.WriteLine("\nWhat is your birth month? Ex: October = 10");
            int siblings = int.Parse(Console.ReadLine());

            //



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
       
        //              Quit environment.quit{0}
        static void quit(string exit)
        {
            if (exit=="quit")
            {
                Environment.Exit(0);
            }

        }

                
    }
}
