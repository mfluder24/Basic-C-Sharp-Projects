using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do some math!"); // Displays message to user and prompts for input
            Console.WriteLine("Please provide a whole number to do math with:"); 
            int num = Convert.ToInt32(Console.ReadLine()); // Saves user input in a string variable and converts it to an int variable

            Maths.Maths1(num); // Calls Maths1 method and uses user input 'num' as argument

            Maths.Maths2(num); // Calls Maths2 method and uses user input 'num' as argument

            Maths.Maths3(num); // Calls Maths3 method and uses user input 'num' as argument

            Console.WriteLine("Thanks for doing some math with us!"); // Displays thank you message to user
            Console.ReadLine(); // Prevents the program from terminating immediately
        } 

    }
}
