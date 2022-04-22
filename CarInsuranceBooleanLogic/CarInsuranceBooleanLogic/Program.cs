using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceBooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Program"); // Displays title of program

            Console.WriteLine("What is your age?"); // Asks for user input
            string uAge = Console.ReadLine(); // Saves user input as a string variable
            int age = Convert.ToInt32(uAge); // Converts string to int

            Console.WriteLine("Have you ever had a DUI? Please write \"true\" or \"false\".");
            string uDui = Console.ReadLine(); // Saves user input as a string variable
            bool dui = Convert.ToBoolean(uDui); // Converts string to bool

            Console.WriteLine("How many speeding tickets do you have? Please enter an integer.");
            string uTickets = Console.ReadLine(); // Saves user input as a string variable
            int tickets = Convert.ToInt32(uTickets); // Converts string to int

            bool eligible = (age > 15 && (dui == false) && (tickets <= 3)); // Uses boolean logic to check if user is eligible according to defined requirments
            Console.WriteLine("Qualified?");
            Console.WriteLine(eligible); // Displays result of boolean logic

            Console.ReadLine(); // Prevents the program from terminating immediately so user can read final line
        }
    }
}
