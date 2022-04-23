using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below."); // Displays welcome statement

            Console.WriteLine("Please enter the package weight:"); // Askes the user to input requested information
            int weight = Convert.ToInt32(Console.ReadLine()); // Stores user input in a string variable, and converts it to an int variable
            if (weight > 50) // Checks if weight is over 50, and executes following code if true
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine(); // Prevents program from terminating immediately so user can read final statement
                Environment.Exit(0); // Terminates program
            }

            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine()); // Stores user input in a string variable, and converts it to an int variable

            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine()); // Stores user input in a string variable, and converts it to an int variable

            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine()); // Stores user input in a string variable, and converts it to an int variable

            if (width + height + length > 50) // Checks if combined variables are greater than 50, and executes following code if true
            {
                Console.WriteLine("Package too big to be shipped via Package Express."); 
                Console.ReadLine(); // Prevents program from terminating immediately so user can read final statement
                Environment.Exit(0); // Terminates program
            }

            int product = width * height * length; // Multiplies three user input variables and saves them as an int variable called product
            int total = product * weight; // Multiplies the int product by the user input int weight and saves result as int variable called total
            int quote = total / 100; // Divides int total by 100 and saves result as an int variable called quote
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ".00"); // Displays message to user and shows int quote as a price
            Console.WriteLine("Thank you!");

            Console.ReadLine(); // Prevents program from terminating immediately so user can read final statement
        }
    }
}
