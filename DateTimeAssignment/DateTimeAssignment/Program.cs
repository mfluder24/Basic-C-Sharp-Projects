using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now; // Creates new DateTime object 'now' with value of DateTime.Now

            Console.WriteLine("The current date and time is: " + now); // Displays message and current DateTime
            Console.WriteLine("Please enter a whole number: "); // Prompts user for appropriate input
            int hours = Convert.ToInt32(Console.ReadLine()); // Saves user input as a string variable, then converts it to an int variable

            DateTime later = now.AddHours(hours); // New DateTime object 'later' with value of previous DateTime plus 'hours' amount of hours

            Console.WriteLine("In " + hours + " hours it will be: " + later); // Displays exact time in 'hours' amount of hours to user
            Console.ReadLine(); // Prevents program from terminating immediately
        }
    }
}
