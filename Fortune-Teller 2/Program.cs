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

            //Name
            Console.WriteLine("What is your first name? Type answers below.");
            string firstname = Console.ReadLine();
            Console.WriteLine("\nWhat is your last name?");
            string lastname = Console.ReadLine();
            name(firstname, lastname);

        }
        static void name(string firstname, string lastname)
        {
            Console.WriteLine("Greetings " + firstname + " " + lastname + ". I will tell you your future./a");
        }
    }
}
