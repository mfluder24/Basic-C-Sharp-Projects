using System;
using System.Collections.Generic;

namespace ArraySubmission
{
    class Program
    {
        static void Main()
        {
            // Creates a string array and supplies it values
            string[] guessArray = { "Fruit", "Clouds", "Fish", "Raven", "Key", "Bee", "Owl King", "Sunflower" };

            Console.WriteLine("Please select a number 0-7 for a random word:"); // Prompts user for appropriate input
            int guess = Convert.ToInt32(Console.ReadLine()); // Saves user input as a string and converts it to and int variable
            bool isGuessed = false; // Sets bool as 'false' until variable 'guess' has appropriate value

            do // 'Do' portion of 'do/while' loop that ensures switch will run
            {
                switch (guess) // Switch statement with expression value of 'guess'
                {
                    case 0: // Will execute when 'guess' == 0
                        Console.WriteLine("You said " + guess + "! That index = " + guessArray[guess]); // Displays value of 'guess' and index 'guess' in guessArray
                        isGuessed = true; // Changes bool to true, which completes the while loop
                        break; // Keyword that stops the execution of code in the block
                    case 1: 
                        Console.WriteLine("You said " + guess + "! That index = " + guessArray[guess]);
                        isGuessed = true;
                        break;
                    case 2: 
                        Console.WriteLine("You said " + guess + "! That index = " + guessArray[guess]);
                        isGuessed = true;
                        break;
                    case 3: 
                        Console.WriteLine("You said " + guess + "! That index = " + guessArray[guess]);
                        isGuessed = true;
                        break;
                    case 4:
                        Console.WriteLine("You said " + guess + "! That index = " + guessArray[guess]);
                        isGuessed = true;
                        break;
                    case 5:
                        Console.WriteLine("You said " + guess + "! That index = " + guessArray[guess]);
                        isGuessed = true;
                        break;
                    case 6:
                        Console.WriteLine("You said " + guess + "! That index = " + guessArray[guess]);
                        isGuessed = true;
                        break;
                    case 7:
                        Console.WriteLine("You said " + guess + "! That index = " + guessArray[guess]);
                        isGuessed = true;
                        break;
                    default: // Will display if a value > 7 is entered
                        Console.WriteLine("That is not a valid number.");
                        Console.WriteLine("Please select a number 0-7 for a random word:");
                        guess = Convert.ToInt32(Console.ReadLine()); // Restarts the loop until an appropriate value is entered
                        break;
                }
            }
            while (!isGuessed); // 'While' portion of 'do/while' loop, will repeat above code until bool == true

            int[] numArray = { 24, 42, 72, 48, 67, 919 }; // Creates a new int array and provides it values
            Console.WriteLine("Please select a number 0-5 for a random number:");
            int numGuess = Convert.ToInt32(Console.ReadLine()); // Saves user input as a string then converts it to an int variable
            bool isCorrect = false; // Sets bool as 'false' until variable 'numGuess' has appropriate value

            do // 'Do' portion of 'do/while' loop that ensures switch will run
            {
                switch (numGuess) // Switch statement with expression value of 'numGuess'
                {
                    case 0: // Will execute when 'numGuess' == 0
                        Console.WriteLine("You said " + numGuess + "! That index = " + numArray[numGuess]); // Displays value of 'numGuess' and index 'numGuess' in numArray
                        isCorrect = true; // Changes bool to true, which completes the while loop
                        break; // Keyword that stops the execution of code in the block
                    case 1: 
                        Console.WriteLine("You said " + numGuess + "! That index = " + numArray[numGuess]);
                        isCorrect = true;
                        break;
                    case 2:
                        Console.WriteLine("You said " + numGuess + "! That index = " + numArray[numGuess]);
                        isCorrect = true;
                        break;
                    case 3:
                        Console.WriteLine("You said " + numGuess + "! That index = " + numArray[numGuess]);
                        isCorrect = true;
                        break;
                    case 4:
                        Console.WriteLine("You said " + numGuess + "! That index = " + numArray[numGuess]);
                        isCorrect = true;
                        break;
                    case 5:
                        Console.WriteLine("You said " + numGuess + "! That index = " + numArray[numGuess]);
                        isCorrect = true;
                        break;
                    default:
                        Console.WriteLine("That is not a valid number."); // Will display if a value > 5 is entered
                        Console.WriteLine("Please select a number 0-5 for a random number:");
                        numGuess = Convert.ToInt32(Console.ReadLine()); // Restarts the loop until an appropriate value is entered
                        break;
                }
            }
            while (!isCorrect); // 'While' portion of 'do/while' loop, will repeat above code until bool == true

            // Creates a new string list
            List<string> strList = new List<string>();
            strList.Add("The Dark Tower"); // Adds an element to the list
            strList.Add("Hannibal");
            strList.Add("The Starless Sea");
            strList.Add("A Liar's Autobiography");
            strList.Add("Phantom");
            strList.Add("The Bazaar of Bad Dreams");
            strList.Add("Sphere");
            strList.Add("The Secret Life of Church Ladies");

            Console.WriteLine("Please select a number 0-7 for a book title:");
            int choice = Convert.ToInt32(Console.ReadLine()); // Saves user input as a string, then converts it to a int variable
            bool gotIt = false; // Sets bool as 'false' until variable 'choice' has appropriate value

            do // 'Do' portion of 'do/while' loop that ensure switch will run
            {
                switch (choice) // Switch statement with expression value of 'choice'
                {
                    case 0: // Will execute when 'choice' == 0
                        Console.WriteLine("You said " + choice + "! That index = " + strList[choice]); // Displays value of 'choice' and index 'choice' in strList
                        gotIt = true; // Changes bool to true, which completes the while loop
                        break; // Keyword that stops the execution of code in the block
                    case 1:
                        Console.WriteLine("You said " + choice + "! That index = " + strList[choice]);
                        gotIt = true;
                        break;
                    case 2:
                        Console.WriteLine("You said " + choice + "! That index = " + strList[choice]);
                        gotIt = true;
                        break;
                    case 3:
                        Console.WriteLine("You said " + choice + "! That index = " + strList[choice]);
                        gotIt = true;
                        break;
                    case 4:
                        Console.WriteLine("You said " + choice + "! That index = " + strList[choice]);
                        gotIt = true;
                        break;
                    case 5:
                        Console.WriteLine("You said " + choice + "! That index = " + strList[choice]);
                        gotIt = true;
                        break;
                    case 6:
                        Console.WriteLine("You said " + choice + "! That index = " + strList[choice]);
                        gotIt = true;
                        break;
                    case 7:
                        Console.WriteLine("You said " + choice + "! That index = " + strList[choice]);
                        gotIt = true;
                        break;
                    default: // Will display if a value > 7 is entered
                        Console.WriteLine("That is not a valid number.");
                        Console.WriteLine("Please select a number 0-7 for a book title:");
                        choice = Convert.ToInt32(Console.ReadLine()); // Restarts the loop until an appropriate value is entered
                        break;
                }
            }
            while (!gotIt); // 'While' portion of 'do/while' loop, will repeat above code until bool == true

            Console.WriteLine("Thank you for playing!"); // Displays thank you message to user
            Console.ReadLine(); // Prevents program from terminating immediately
        }


    }
}
