using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public static class Maths
    {
        public static void Maths1(int num) // Creates method 'Maths1' with int parameter
        {
            int result = num / 2; // Divides int argument and saves result in int variable
            Console.WriteLine(num + " divided by 2 = " + result + "\n"); // Displays equation and result to user
        }

        public static void Maths1(string num) // Overloads 'Maths1' method with string parameter
        {
            int number = Convert.ToInt32(num); // Converts string argument to int variable
            int result = number * 24; // Multiplies int argument and saves result in int variable
            Console.WriteLine(number + " multiplied by 24 = " + result + "\n"); // Displays equation and result to user
        }

        public static void Maths2(out int i) // Creates 'Maths2' method with output parameter
        {
            i = 10; // Provides value to output varible
            i *= i; // Multiplies variable i by itself and changes value of i
        }
    }
}
