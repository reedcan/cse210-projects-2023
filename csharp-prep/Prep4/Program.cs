using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> Numbers = new List<int>();
        bool KeepAsking = true;
        string NumberInputString;
        int NumberInput;
        int sum = 0;
        int average;
        int LargestNumber = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (KeepAsking)
        {
            Console.WriteLine("Enter a number: ");
            NumberInputString = Console.ReadLine();
            NumberInput = int.Parse(NumberInputString);

            if (NumberInput == 0)
            {
                for (int i = 0; i < Numbers.Count; i++)
                {
                    sum = Numbers[i] + sum;
                    
                    if (Numbers[i] > LargestNumber)
                    {
                        LargestNumber = Numbers[i];
                    }
                }
                
                average = sum / Numbers.Count;

                Console.WriteLine($"The sum is: {sum}");
                Console.WriteLine($"The average is: {average}");
                Console.WriteLine($"The largest number is: {LargestNumber}");

                KeepAsking = false;
            }

            Numbers.Add(NumberInput);


        }


    }
}