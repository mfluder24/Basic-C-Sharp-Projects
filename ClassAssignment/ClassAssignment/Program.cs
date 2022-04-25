using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do some math!"); // Displays message to user and requests appropriate input
            Console.WriteLine("Please provide a whole number:");
            string num = Console.ReadLine(); // Saves user input into a string variable called 'num'
            int num2 = Convert.ToInt32(num); // Converts string 'num' to int variable called 'num2'
            int x; // Declares an int variable called 'x'


            Maths.Maths1(num2); // Calls 'Maths1' method and provides int argument

            Maths.Maths1(num); // Calls 'Maths1' method and provides string argument

            Maths.Maths2(out x); // Calls 'Maths2' method and utilises output argument
            Console.WriteLine("Variable value: {0}", x); // Displays value of output variable 'x'


            Console.ReadLine(); // Prevents program from terminating immediately

        }
    }
}
