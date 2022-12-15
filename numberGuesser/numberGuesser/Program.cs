using System;
namespace numberGuesser;

class program
{
    static void Main(string[] args)
    {
        GetAppInfo();

        GreetUser();

        while (true)
        {
            Random random = new Random();
            int correctNumber = random.Next(1, 10);
            int guessedNumber = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            while (guessedNumber != correctNumber)
            {
                string input = Console.ReadLine();
                if (!int.TryParse(input, out guessedNumber))
                {
                    PrintColorMessage(ConsoleColor.Red, "Please use a number");
                    continue;
                }

                guessedNumber = Int32.Parse(input);
                if (guessedNumber != correctNumber)
                {
                    PrintColorMessage(ConsoleColor.Red, "Wrong number please try again");
                }
            }
            PrintColorMessage(ConsoleColor.DarkGreen, "you are correct");
            Console.WriteLine("Play again? [Y or N]");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "Y")
            {
                continue;
            }
            else
            {
                return;
            }
        }
    }

    static void GetAppInfo()
    {
        string appName = "Number Guesser";
        string appVersion = "1.0.0";
        string appAuthor = "Wanny";

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("{0}: version {1} by {2}", appName, appVersion, appAuthor);
        Console.ResetColor();

    }

    static void GreetUser()
    {
        Console.WriteLine("What should i call you?");
        string nameinput = Console.ReadLine();
        Console.WriteLine("Greetings {0}, let's play a game", nameinput);
    }

    static void PrintColorMessage(ConsoleColor color, string Message)
    {
        Console.ForegroundColor = color;
        Console.WriteLine("Message");
        Console.ResetColor();
    }
}