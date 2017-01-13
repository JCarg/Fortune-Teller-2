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
            string firstname = Console.ReadLine();
            Console.WriteLine("\nWhat is your last name?");
            string lastname = Console.ReadLine();
            greetingsname(firstname, lastname);

            //              Age Info
            Console.WriteLine("\nWhat is your age?");
            int age = int.Parse(Console.ReadLine());


        }
        //              Name Method
        static void greetingsname(string firstname, string lastname)
        {
            Console.WriteLine("Greetings " + firstname + " " + lastname + "! I will tell you your future./a");
        }

        //              Age Method
        static int retirementage(int age)
        {
            string years = " ";
            string ageodd = "800 Years";
            string ageeven = "5 years";
            if (age % 2 > 0)
            {
                years = ageodd;
            }
            else
            {
                years = ageeven;
            }
        }

    }
}
