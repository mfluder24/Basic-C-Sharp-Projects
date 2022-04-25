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
            var obj = new Maths(); // Instantiates new instance of Maths class
            int num = 17; // Creates an int variable called 'num' with a value of 17
            decimal number = 1408; // Creates a decimal variable called 'number' with a value of 1408
            string integer = "42"; // Creates a string variable called 'integer' with a value of "42"

            Console.WriteLine("Let's do some math!"); // Displays a message to the user

            int result1 = obj.Maths1(num); // Calls 'Maths1' method and provides int argument, saves returned result as int
            Console.WriteLine(num + " plus 24 = " + result1); // Displays equation to user and provides result

            int result2 = obj.Maths1(number); // Calls 'Maths1' method and provides decimal argument, saves returned result as int 
            Console.WriteLine(num + " divided by 2 = " + result2); // Displays equation to user and provides result

            int result3 = obj.Maths1(integer); // Calls 'Maths1' method and provides string argument, saves returned result as int
            Console.WriteLine(number + " multiplied by 3 = " + result3); // Displays equation to user and provides result

            Console.ReadLine(); // Prevents program from terminating immediately
        }
    }
}
