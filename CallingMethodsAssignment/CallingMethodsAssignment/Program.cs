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
            var obj = new Maths(); // Instantiates Maths class 
            Console.WriteLine("Let's do some math!"); // Displays message to user and prompts for input
            Console.WriteLine("Please provide a whole number to do math with:"); 
            int num = Convert.ToInt32(Console.ReadLine()); // Saves user input in a string variable and converts it to an int variable

            int result1 = obj.Maths1(num); // Calls Maths1 method and uses user input 'num' as argument, saves result to int variable
            Console.WriteLine(num + " plus 20 = " + result1 + "\n"); // Displays equation and result to user, ending with new line to keep things tidy

            int result2 = obj.Maths2(num); // Calls Maths2 method and uses user input 'num' as argument, saves result to int variable
            Console.WriteLine(num + " minus 5 = " + result2 + "\n"); // Displays equation and result to user, ending with new line to keep things tidy

            int result3 = obj.Maths3(num); // Calls Maths3 method and uses user input 'num' as argument, saves result to int variable
            Console.WriteLine(num + " multiplied by 17 = " + result3 + "\n"); // Displays equation and result to user, ending with new line to keep things tidy

            Console.WriteLine("Thanks for doing some math with us!"); // Displays thank you message to user
            Console.ReadLine(); // Prevents the program from terminating immediately
        } 

    }
}
