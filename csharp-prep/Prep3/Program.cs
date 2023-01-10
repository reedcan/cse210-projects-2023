using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
 
        string GuessNumberInputString;
        int GuessNumber;
        bool KeepPlaying = true;
        string KeepPlayingInput;


        while (KeepPlaying)
        
        {
            int RandomMagicNumber = random.Next(1, 101);
            int NumberOfGuesses = 0;
            bool GuessedCorrectly = false;
            while (GuessedCorrectly == false)

            {
                Console.WriteLine("What is your guess? ");

                GuessNumberInputString = Console.ReadLine();

                GuessNumber = Int32.Parse(GuessNumberInputString);


                if (GuessNumber > RandomMagicNumber)
                {
                    Console.WriteLine("Lower");
                    NumberOfGuesses += 1;
                    Console.WriteLine($"Guesses: {NumberOfGuesses}");
                }

                else if (GuessNumber < RandomMagicNumber)
                {
                    Console.WriteLine("Higher");
                    NumberOfGuesses += 1;
                    Console.WriteLine($"Guesses: {NumberOfGuesses}");
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                    NumberOfGuesses += 1;
                    Console.WriteLine($"Guesses: {NumberOfGuesses}");
                    GuessedCorrectly = true;
                    Console.WriteLine("Would you like to play again? (y/n)");
                    KeepPlayingInput = Console.ReadLine();

                    if (KeepPlayingInput != "y")
                    {
                        KeepPlaying = false;
                    }
                    
                }
            }
        }

    }
}