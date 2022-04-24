using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try // Places main body of code into 'try' block
            {
                List<int> nums = new List<int> { 7, 24, 42, 72 }; // Creates an int list called 'nums'

                Console.WriteLine("Please provide a number:"); // Prompts user for input
                int div = Convert.ToInt32(Console.ReadLine()); // Saves user input as string, and converts it to int variable

                foreach (int num in nums) // Foreach loop that goes through each item in 'nums'
                {
                    int result = num / div; // Divides list item by user input and saves result in an int variable
                    Console.WriteLine(num + " divided by " + div + " = " + result); // Displays equation and result
                }
             
            }
            catch (FormatException ex) // Catch block targets FormatExceptions
            {
                Console.WriteLine(ex.Message); // Displays default error message to user
                Console.WriteLine("Please type a whole number..."); // Displays custom error message
                return; // Terminates execution of method and returns control to calling method
            }
            catch (DivideByZeroException ex) // Catch block targets DivideByZeroExceptions
            {
                Console.WriteLine(ex.Message); // Displays default error message to user
                Console.WriteLine("Please don't divide by zero..."); // Displays custom error message
                return; // Terminates execution of method and returns control to calling method
            }
            catch (Exception ex) // Catch block targets any other Exceptions
            {
                Console.WriteLine(ex.Message); // Displays default error message to user
                return; // Terminates execution of method and returns control to calling method
            }
            finally // Block of statements always executed even if exceptions are thrown
            {
                Console.ReadLine(); // Prevents the program from terminating immediately upon completion
            }

        }
    }
}
