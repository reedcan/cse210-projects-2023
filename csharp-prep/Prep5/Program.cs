using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();

            return userName;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            string favoriteNumberString = Console.ReadLine();
            int favoriteNumber = int.Parse(favoriteNumberString);

            return favoriteNumber;
        }

        static int SquareNumber(int favoriteNumber)
        {
            int squareOfNumber = favoriteNumber * favoriteNumber;

            return squareOfNumber;
        }

        static void DisplayResult(string userName, int squareOfNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squareOfNumber}");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squareOfNumber = SquareNumber(favoriteNumber);
        DisplayResult(userName, squareOfNumber);
    }
}