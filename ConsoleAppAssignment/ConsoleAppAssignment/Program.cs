using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates new string array called 'strArray'
            string[] strArray = new string[] { "John: Here! I got you this ", "Ralph: Thank you, but I already have a ", "John: Oh...I guess I'll keep this " };

            Console.WriteLine("Welcome!"); // Displays welcome message and asks user to input a noun
            Console.WriteLine("Please supply a noun (person, place, or thing):");
            string noun = Console.ReadLine() +"."; // Stores user input in a string variable and adds a period on the end to make it look tidy

            for (int i = 0; i < strArray.Length; i++) // For loop that iterates through each element in strArray
            {
                strArray[i] = strArray[i] + noun; // Concatenates variable 'noun' to the end of each element in strArray
            }

            Console.WriteLine("Thank you! Here's how we used your noun!"); // Displays message to user

            for (int n = 0; n < strArray.Length; n++) // For loop that iterates through each element in strArray
            {
                Console.WriteLine(strArray[n] + "\n"); // Displays each array element to user on a new line
            }

            // ---

            int looper = 2; // Creates an int variable called 'looper'

            while (looper < 5) // While loop will execute until looper is equal to 5
            {
                Console.WriteLine("Nicolas Cage is awesome!"); // Displays message to user
                looper++; // Increases value of 'looper' variable by one
            }

            // ---

            int lessOr = 0; // Creates an int variable called 'lessOr'

            Console.WriteLine("\nLet's have fun!"); // Displays a message to the user on a new line

            while (lessOr <= 7) // While loop will execute until lessOr is greater than 7
            {
                Console.WriteLine("We're having lots of fun!"); // Displays message to user
                lessOr++; // Increases value of 'lessOr' by one
            }

            // ---

            // Creates a new string list called 'films' and provides values for it
            List<string> films = new List<string> { "mandy", "the wicker man", "vampire's kiss", "con air", "national treasure", "face off", "guarding tess", "raising arizona", "next", "ghost rider"};

            Console.WriteLine("\nEnter a Nicolas Cage movie to search for a match!"); // Prompts users to enter a film title
            string answer = Console.ReadLine(); // Saves user input to a string variable
            string target = answer.ToLower(); // Converts user answer to lower case letters to match list items
            int index = 99; // Sets 'index' to 99 for loop statement below
            bool correct = false; // Creates a bool for while loop to run and terminate properly

            do // Do portion of do/while loop that ensures code will run if first guess is correct
            {
                foreach (string film in films) // Foreach loop to parse through each 'film' in 'films'
                {
                   if (film == target) // This code will run if user input 'target' matches an item in the list
                    {
                        index = films.FindIndex(f => f.Contains(target)); // Changes the value of 'index' to the index of the correct item in list 'films'
                    }
                   
                }
                
                if (index != 99) // This code runs if the value of 'index' is changed from 99
                {
                    Console.WriteLine("You got it! " + answer + " is at index " + index + "!"); // Displays message to user including index of item guessed
                    correct = true; // Changes bool to 'true' and terminates the do/while loop
                }
                else // Runs no items on list match user input
                {
                    Console.WriteLine("That film isn't on the list. Try again!");
                    Console.WriteLine("Enter a Nicolas Cage movie to search for a match!"); // Prompts user to try again
                    answer = Console.ReadLine(); // Updates 'answer' with new user input
                    target = answer.ToLower(); // Converts new 'answer' to lower case and restarts loop
                }
            }
            while (!correct); // While portion of do/while loop, will run above code until 'correct' = true

            //---

            // Creates a string list called 'characters'
            List<string> characters = new List<string> { "Red", "Castor Troy", "Cameron Poe", "Benjamin Franklin Gates", "Edward Malus", "Red", "Castor Troy", "Cameron Poe", "Benjamin Franklin Gates", "Edward Malus" };
            List<int> indices = new List<int>(characters.Count); // Creates an empty int list to collect incdices of items in loop

            Console.WriteLine("\nChoose one of these awesome Nicolas Cage characters!"); // Displays message to user and asks for them to input appropriate content
            Console.WriteLine("Red, Castor Troy, Cameron Poe, Benjamin Franklin Gates, Edward Malus");
            string choice = Console.ReadLine();  // Saves user input as string variable
            int idx = 99; // Int variable for use in loop
            bool complete = false; // Bool variable for while loop

            do // Do portion of do/while loop that ensures code will run
            {
                for (int c = 0; c < characters.Count; c++) // For loop to pass through each 'c' in 'characters' list
                {
                    if (characters[c] == choice) // This code will run if user input 'choice' matches an item in the list
                    {
                        indices.Add(c); // Adds index of item to list 'indices'
                        idx++; // Adds one to idx variable to progress the loop
                    }

                }

                if (idx != 99) // This code runs if the value of 'idx' is changed from 99
                {   
                    // Displays message to user, including indices of 'choice' saved in 'indices' list
                    Console.WriteLine(choice + " occupies indices " + indices[0] + " & " + indices[1] + ".");
                    Console.WriteLine("Good job!");
                    complete = true; // Changes bool to 'true' and terminates the do/while loop
                }
                else // Runs if no items on list match user input
                {
                    Console.WriteLine("That character is not on the list. Try again!");
                    Console.WriteLine("Choose one of these awesome Nicolas Cage characters!"); // Prompts user to try again
                    Console.WriteLine("Red, Castor Troy, Cameron Poe, Benjamin Franklin Gates, Edward Malus");
                    choice = Console.ReadLine(); // Restarts loop
                }
            }
            while (!complete); // While portion of do/while loop, will run above code until 'complete' = true

            // ---

            // Creates a string list called 'fruits'
            List<string> fruits = new List<string> { "Apples", "Peaches", "Oranges", "Bananas", "Peaches", "Apricots", "Oranges" };
            List<string> checks = new List<string>(); // Creates an empty list called 'checks' to hold values from the foreach loop

            Console.WriteLine("\nHere's a list of fruits. Let's see if any of them repeat...");

            foreach (string fruit in fruits) // Foreach loop that goes through each element in the list
            {
                // Displays message to user, and checks if 'fruit' is already present in 'checks' list
                Console.WriteLine("Fruit: " + fruit + " \nAlready in list? " + checks.Contains(fruit) + "\n");
                checks.Add(fruit); // Adds 'fruit' to 'checks' list
            }

            Console.ReadLine(); // Prevents program from terminating immediately upon completeion
        }
    }
}
