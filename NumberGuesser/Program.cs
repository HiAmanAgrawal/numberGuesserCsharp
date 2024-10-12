using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Run the GetAppInfo function to display app info
            GetAppInfo();

            // Run the GreetUser function to greet the user
            GreetUser();

            // Start the game
            PlayGame();
        }

        // Function to display app info
        static void GetAppInfo()
        {
            // Set app variables
            string appName = "Number Guesser";
            string version = "1.0.1";
            string author = "Aman Agrawal";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Display the app details
            Console.WriteLine("{0}: Version {1} by {2}", appName, version, author);

            // Reset text color
            Console.ResetColor();
        }

        // Function to greet the user
        static void GreetUser()
        {
            // Ask for the user's name
            Console.WriteLine("What is your name?");

            // Get user input and store it
            string userName = Console.ReadLine();

            // Greet the user
            Console.WriteLine("Welcome {0}, let's play a game...", userName);
        }

        // Function to play the guessing game
        static void PlayGame()
        {
            while (true)
            {
                // Generate a random number between 0 and 10
                Random random = new Random();
                int correctNumber = random.Next(0, 11);

                // Initialize guess variable
                int guessedNumber = 0;

                // Prompt user to guess a number
                Console.WriteLine("Guess a number between 0 and 10:");

                // Loop until the correct number is guessed
                while (guessedNumber != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Validate input
                    if (!int.TryParse(input, out guessedNumber))
                    {
                        // Print an error message if input is invalid
                        PrintColorMessage(ConsoleColor.Red, "Please enter a valid number.");
                        continue; // Continue to the next iteration
                    }

                    // Check if the guess is too low or too high
                    if (guessedNumber < correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Yellow, "Too low! Try again.");
                    }
                    else if (guessedNumber > correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Yellow, "Too high! Try again.");
                    }
                }

                // Output success message
                PrintColorMessage(ConsoleColor.Green, "Congratulations! You guessed the correct number!");

                // Ask if the user wants to play again
                Console.WriteLine("Do you want to play again? (Y/N)");

                // Get the user's response
                string answer = Console.ReadLine().ToUpper();

                // Break the loop if the user does not want to play again
                if (answer != "Y")
                {
                    break;
                }
            }

            // Say goodbye to the user
            Console.WriteLine("Thanks for playing! Goodbye.");
        }

        // Function to print a message in a specific color
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Print the message
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
