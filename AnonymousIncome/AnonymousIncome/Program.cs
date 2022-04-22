using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncome
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program"); // Displays opening title for program

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?");
            string r1 = Console.ReadLine(); // Saves user input to string variable
            float rate1 = Convert.ToSingle(r1); // Converts string to float
            Console.WriteLine("Hours worked per week?");
            string h1 = Console.ReadLine(); // Saves user input to string variable
            float hours1 = Convert.ToSingle(h1); // Converts string to float

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            string r2 = Console.ReadLine(); // Saves user input to string variable
            float rate2 = Convert.ToSingle(r2); // Converts string to float
            Console.WriteLine("Hours worked per week?");
            string h2 = Console.ReadLine(); // Saves user input to string variable
            float hours2 = Convert.ToSingle(h2); // Converts string to float

            float week1 = rate1 * hours1; // Multiplies hourly rate by hours worked
            float salary1 = week1 * 52f; // Multiplies weekly earnings by 52 (number of weeks per year)
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1); // Displays annual salary for Person 1

            float week2 = rate2 * hours2; // Multiplies hourly rate by hours worked
            float salary2 = week2 * 52f; // Multiplies weekly earnings by 52 (number of weeks per year)
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2); // Displays annual salary for Person 2

            bool compare = salary1 > salary2; // Checks if salary1 is greater than salary 2 and saves as a bool
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(compare); // Displays value of bool variable

            Console.ReadLine(); // Prevents program from terminating immediately and allows user to read final statement
        }
    }
}
