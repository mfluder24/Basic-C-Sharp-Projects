using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputMath
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please provide a number:"); // Prompts the user for input
            string mNum = Console.ReadLine(); // Saves user input as a string variable
            int multNum = Convert.ToInt32(mNum); // Converts string to int
            int product = multNum * 50; // Multiplies int variable by 50
            Console.WriteLine("Your number multiplied by 50 = " + product); // Prints result to the console

            Console.WriteLine("Please provide a new number:");
            string aNum = Console.ReadLine(); 
            int addNum = Convert.ToInt32(aNum); // Converts string to int
            int total = addNum + 25; // Adds 25 to int variable
            Console.WriteLine("Your number plus 25 = " + total);

            Console.WriteLine("Please provide a new number:");
            string dNum = Console.ReadLine();
            float divNum = Convert.ToSingle(dNum); // Converts string to float
            float result = divNum / 12.5f; // Divides float variable by 12.5
            Console.WriteLine("Your number divided by 12.5 = " + result);

            Console.WriteLine("Please provide a new number:");
            string userNum = Console.ReadLine();
            int grNum = Convert.ToInt32(userNum); // Converts string to int
            bool answer = grNum > 50; // Checks to see if int variable is greater than 50
            Console.WriteLine("Is your number greater than 50? " + answer);

            Console.WriteLine("Please provide a new number:");
            string modNum = Console.ReadLine();
            int modulusNum = Convert.ToInt32(modNum); // Converts string to int
            int remainder = modulusNum % 7; // Uses modulus operator on int variable
            Console.WriteLine("Your number divided by 7 has a remainder of: " + remainder);

            Console.ReadLine(); // Prevents program from terminating on completion
        }
    }
}
