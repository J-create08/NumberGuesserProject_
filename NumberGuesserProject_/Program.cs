using System;

namespace NumberGuesserProject_
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInfo();

            GetGreeting();

            while (true)
            {



                //Number to guess init
                Random r = new Random();
                int rInt = r.Next(1, 10);

                //Init number guessed
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10:");

                while (guess != rInt)
                {
                    string numberGuess = Console.ReadLine();

                    if (!int.TryParse(numberGuess, out guess))
                    {
                        PrintAnswer(ConsoleColor.Red, "Please enter a number.");

                        continue;
                    }

                    guess = Int32.Parse(numberGuess);

                    if (guess != rInt)
                    {
                        PrintAnswer(ConsoleColor.Red, "Wrong number, try again!");
                    }
                }

                //Success message

                PrintAnswer(ConsoleColor.Green, "Awesome!! That was the correct number.");

                //Ask to play again
                Console.WriteLine("Want to play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                } else if (answer == "N")
                {
                    return;
                } else
                {
                    return;
                }
            }

        }

        static void GetInfo()
        {
            //App id vars
            string appName = "NUMBER GUESSER";
            string appVersion = "1.0.0";
            string devName = "Juan Carlos Rojas";
            //Console color
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("{0}", appName);
            Console.WriteLine("Version: {0} by {1}.", appVersion, devName);

            Console.ResetColor();
        }

        static void GetGreeting()
        {
            Console.WriteLine("Hello, friend! What is your name?");

            string nameInput = Console.ReadLine();

            Console.WriteLine("Great, {0}! Let's play a game!", nameInput);
        }

        static void PrintAnswer(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
