using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Run GetAppInfo method to get info
            GetAppInfo();

            // Ask for users name and greet
            GreetUser();


            // While loop
            while (true)
            {
                // Create a new Random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 5);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 5.");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.DarkRed, "Please enter a valid numeric value!");
                        
                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again!");
                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!! You guessed it!");

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get user answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        // Displays App Info
        static void GetAppInfo()
        {
            // Note //
            // set app vars
            string appName = "Game of Numbers";
            string appVersion = "1.0.0";
            string appAuthor = "Joseph Holmin";

            // change text color
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            // write out app info
            Console.WriteLine("{0}\nVersion: {1}\nAuthor: {2}", appName, appVersion, appAuthor);

            // resets text color to default white
            Console.ResetColor();
        }

        // Ask users name and greet
        static void GreetUser() 
        {
            // change text color
            Console.ForegroundColor = ConsoleColor.Gray;

            // Ask users name
            Console.WriteLine("What is your name?");

            // Get users input
            string inputName = Console.ReadLine();

            // Message to user using input
            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            // resets text color to default white
            Console.ResetColor();
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message) {
            // Change text color
            Console.ForegroundColor = color;

            // Message
            Console.WriteLine(message);

            // Resets text color to default white
            Console.ResetColor();
        }
    }
}
