using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Maths(); // Instantiates Maths class
            Console.WriteLine("Let's do some math!"); // Displays message to user and prompts for appropriate input
            Console.WriteLine("Please provide a whole number:");
            int num1 = Convert.ToInt32(Console.ReadLine()); // Saves user input as string and converts it to an int variable

            Console.WriteLine("Please provide another whole number (optional, can leave blank):"); // Displays message to user and prompt for optional appropriate input
            string answer = Console.ReadLine(); // Saves user input as string variable
            if (answer != "") // If statement that will execute if user input a number
            {
                int num2 = Convert.ToInt32(answer); // Converts string 'answer' to an int variable
                int result = obj.Maths1(num1, num2); // Calls 'Maths1' method and provides two arguments, saves returned result as int
                Console.WriteLine(num1 + " plus " + num2 + " = " + result); // Displays equation and result to user
            }
            else // Else statement that executes if user left optional number blank
            {
                int result = obj.Maths1(num1); // Calls 'Maths1' method and provides one argument, saves returned result as int
                Console.WriteLine(num1 + " plus  5 " + " = " + result); // Displays equation (with default second integer) and result to user
            }

            Console.ReadLine(); // Prevents program from terminating immediately
        }
    }
}
