using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a number between 0-12:"); // Prompts the user for appropriate input
            int number = Convert.ToInt32(Console.ReadLine()); // Saves user input as a string variable and converts it to an int variable

            while (number < 13) // While loop that will execute as long as number is less than 13
            {
                Console.WriteLine(number); // Prints the current value of number to the screen
                number++; // Increases the value of number by 1
            }

            Console.WriteLine("Lucky number 13!"); // Displays at the end of while loop after number is equal to 13

            Console.WriteLine("Time for an important question!");
            Console.WriteLine("What is my favourite primary colour? Please write \"blue\", \"yellow\", \"red\", or \"green\"."); // Prompts the user for appropriate input
            string answer = Console.ReadLine(); // Saves user input as a string variable
            bool correct = answer == "green"; // Sets the bool 'correct' as false until variable 'answer' is equal to 'green'

            do // 'Do' portion of 'do/whlie' loop that ensures switch will run even if correct answer is guessed first
            {
                switch (answer) // Switch statement with expression value of 'answer' string variable
                {
                    case "blue": // Will execute if 'answer' is equal to 'blue'
                        Console.WriteLine("You chose blue. You are incorrect. Try again!"); // Displays message to user and prompts them to guess again
                        Console.WriteLine("What is my favourite primary colour? Please write \"blue\", \"yellow\", \"red\", or \"green\".");
                        answer = Console.ReadLine(); // Changes the value of variable 'answer' to user's new input
                        break; // Keyword that stops the execution of code in the block
                    case "yellow": // Will execute if 'answer' is equal to 'yellow'
                        Console.WriteLine("You chose yellow. You are incorrect. Try again!"); // Displays message to user and prompts them to guess again
                        Console.WriteLine("What is my favourite primary colour? Please write \"blue\", \"yellow\", \"red\", or \"green\".");
                        answer = Console.ReadLine(); // Changes the value of variable 'answer' to user's new input
                        break; // Keyword that stops the execution of code in the block
                    case "red": // Will execute if 'answer' is equal to 'red'
                        Console.WriteLine("You chose red. You are incorrect. Try again!"); // Displays message to user and prompts them to guess again
                        Console.WriteLine("What is my favourite primary colour? Please write \"blue\", \"yellow\", \"red\", or \"green\".");
                        answer = Console.ReadLine(); // Changes the value of variable 'answer' to user's new input
                        break; // Keyword that stops the execution of code in the block
                    case "green": // Will execute if 'answer' is equal to 'green'
                        Console.WriteLine("You chose green. You are correct! Nice job!"); // Displays message to user that they guessed correctly
                        correct = true; // Changes bool to true, which completes the while loop
                        break; // Keyword that stops the execution of code in the block
                    default: // Will execute if 'answer' is equal to anything that is not previously listed
                        Console.WriteLine("Hey, that's not on the list! Try again!"); // Displays message to user and prompts them to guess again
                        Console.WriteLine("What is my favourite primary colour? Please write \"blue\", \"yellow\", \"red\", or \"green\".");
                        answer = Console.ReadLine(); // Changes the value of variable 'answer' to user's new input
                        break; // Keyword that stops the execution of code in the block
                }
            }
            while (!correct); // While portion of 'do/while' loop, will continue to execute above code until bool 'correct' = 'true'

            Console.ReadLine(); // Prevents program from terminating immediately so user can read final statement
        }   

    }
}
