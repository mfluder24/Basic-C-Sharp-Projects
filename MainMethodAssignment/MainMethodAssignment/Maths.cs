using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Maths
    {
        public static void Maths1(int num) // Creates method called 'Maths1' with int parameter
        {
            int result = num + 24; // Performs math operation on num argument and saves result as int variable
            Console.WriteLine(num + " plus 24 = " + result); // Displays equation to user and provides result
        }

        public static void Maths1(decimal num) // Creates method called 'Maths1' with decimal parameter
        {
            int result = Convert.ToInt32(num / 2); // Performs equation on decimal argument and converts result to int variable
            Console.WriteLine(num + " divided by 2 = " + result); // Displays equation to user and provides result
        }

        public static void Maths1(string num) // Creates method called 'Maths1' with string parameter
        {
            int number = Convert.ToInt32(num); // Converts string argument to int variable
            int result = number * 3; // Performs equation on int argument and saves result to int variable
            Console.WriteLine(number + " multiplied by 3 = " + result); // Displays equation to user and provides result
        }
    }
}
