using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "Jello salad "; // Creates a string variable
            string two = "is one of the "; // Creates a string variable
            string three = "worst inventions of mankind."; // Creates a string variable

            Console.WriteLine(one + two + three); // Concatenates three string variables and displays them to the user

            string four = one.ToUpper(); // Converts string one to all uppercase letters and saves it in a string variable

            Console.WriteLine(four); // Displays string variable four

            StringBuilder sb = new StringBuilder(); // Creates a stringbuilder object
            sb.Append("Jello salad is an American salad made with flavoured gelatin, fruit, and sometimes grated carrots or other vegetables."); // Adds a line to sb object
            sb.Append(" Other ingredients may include cottage cheese, cream cheese, marshmallows, nuts, or pretzels."); // Adds a line to sb object
            sb.Append(" Jello salads were popular in the 1960s and are now considered retro."); // Adds a line to sb object
            Console.WriteLine(sb); // Displays stringbuilder object

            Console.ReadLine(); // Prevents program from immediately terminating upon completion
        }
    }
}
