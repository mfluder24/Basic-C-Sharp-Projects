using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        public enum Week // Creating enum Week and giving it values
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week:"); // Displays message to user and prompts for input
            string day = Console.ReadLine(); // Saves user input as string variable

            try // Try statement that will execute if no exceptions are thrown
            {
                // Takes user input 'day' and parses list of Enums for match 
                // (true == 'ignore case'), saves result in variable 'weekDay'
                Week weekDay = (Week)Enum.Parse(typeof(Week), day, true); 

                // Displays message to user to verify program functions properly
                Console.WriteLine("You said " + weekDay + ". That is a valid day of the week!");
            }
            catch // Catch statement that will execute if exceptions are thrown
            {
                Console.WriteLine("Please enter an actual day of the week."); // Displays message to user
            }

            Console.ReadLine(); // Prevents program from terminating immediately
        }
    }
}
