using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy"); // Displays the opening titles for the program
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine(); // Saves the user input into a string variable

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine(); // Saves the user input into a string variable

            Console.WriteLine("What page number?");
            string coursePage = Console.ReadLine(); // Saves the user input into a string variable
            int pageNum = Convert.ToInt32(coursePage); // Converts the string variable into an int variable

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string studentHelp = Console.ReadLine(); // Saves the user input into a string variable
            bool needHelp = Convert.ToBoolean(studentHelp); // Converts the string variable into a bool variable

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExp = Console.ReadLine(); // Saves the user input into a string variable

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string studentFeedback = Console.ReadLine(); // Saves the user input into a string variable

            Console.WriteLine("How many hours did you study today?");
            string studentHours = Console.ReadLine(); // Saves the user input into a string variable
            int studyHours = Convert.ToInt32(studentHours); // Converts the string variable into an int variable

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!"); // Displays the closing statement
            Console.ReadLine(); // Prevents the program from terminating immediately and allows user to read final statement and close program when they are ready to

        }
    }
}
