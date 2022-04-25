using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 17; // Creates an int variable called 'num' with a value of 17
            decimal number = 1408; // Creates a decimal variable called 'number' with a value of 1408
            string integer = "42"; // Creates a string variable called 'integer' with a value of "42"

            Console.WriteLine("Let's do some math!"); // Displays a message to the user

            Maths.Maths1(num); // Calls 'Maths1' method and provides int argument

            Maths.Maths1(number); // Calls 'Maths1' method and provides decimal argument 

            Maths.Maths1(integer); // Calls 'Maths1' method and provides string argument

            Console.ReadLine(); // Prevent program from terminating immediately
        }
    }
}
