using System;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please supply a whole number:"); // Displays message to user and prompts for input
            int num = Convert.ToInt32(Console.ReadLine()); // Saves user input as string, then converts to int variable

            // Initiates new StreamWriter and directs to .txt file to append to, true = append
            using (StreamWriter sw = new StreamWriter(@"C:\Users\User\Documents\GitHub\Basic-C-Sharp-Projects\InputAssignment\Log_InputAssignment.txt", true))
            {
                sw.WriteLine(num); // StreamWriter adds value of 'num' to the .txt file
            }

            // Initiates new StreamReader and directs to .txt file to read from
            StreamReader sr = new StreamReader(@"C:\Users\User\Documents\GitHub\Basic-C-Sharp-Projects\InputAssignment\Log_InputAssignment.txt");
            string line = sr.ReadLine(); // Creates string variable 'line', which has a value of StreamReader.ReadLine() method 

            Console.WriteLine("Current numbers in file:"); // Displays message to user to keep information tidy
            while (line != null) // While loop that will execute while 'line' is not null
            {
                Console.WriteLine(line); // Prints line from .txt file to the console
                line = sr.ReadLine(); // Resets 'line' to read the following line of text in the .txt file
            }

            sr.Close(); // Closes .txt file
            Console.ReadLine(); // Prevents program from terminating immediately


        }
    }
}
