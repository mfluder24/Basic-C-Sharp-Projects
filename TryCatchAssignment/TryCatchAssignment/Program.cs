using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool legitAge = false; // Bool created for while loop to cycle
            while (!legitAge) // While loop will run until legitAge == true
            {
                try // Try block for main body of code
                {
                    Console.WriteLine("Please enter your age:"); // Displays message to user and requests input
                    int age = Convert.ToInt32(Console.ReadLine()); // Saves user input as string variable, then converts to int
                    if (age == 0) // If statement that will execute if age has a value of zero
                    {
                        throw new AgeZeroException(); // Throws AgeZeroException to catch block
                    }
                    else if (age < 0) // Else if statement that will execute if age is less than zero
                    {
                        throw new AgeNegativeException(); // Throws AgenegativeException to catch block
                    }
                    else // Else statement 
                    {
                        int yob = 2022 - age; // Int variable 'yob' that saves result of 2022 - age
                        Console.WriteLine("You were born in: " + yob); // Displays year of birth to user
                        legitAge = true; // Changes bool to true to stop while loop
                        Console.ReadLine(); // Prevents program from terminating immediately
                    }
                }
                catch (AgeZeroException) // Catch block for AgeZeroException
                {
                    Console.WriteLine("You're awfully young to be using a computer!"); // Displays messages to user and returns to while loop
                    Console.WriteLine("Please enter a number greater than zero.");
                    Console.ReadLine();
                }
                catch (AgeNegativeException) // Catch block for AgeNegativeException
                {
                    Console.WriteLine("Can you tell me what the future is like?"); // Displays messages to user and returns to while loop
                    Console.WriteLine("Please don't enter a negative number.");
                    Console.ReadLine();
                }
                catch (Exception) // Catch block for all other exceptions
                {
                    Console.WriteLine("Something went wrong! Please contact your system administrator."); // Displays message to user
                    Console.ReadLine();
                    return; // Terminates program
                }
            }
       
        }
    }
}
