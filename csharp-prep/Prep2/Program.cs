using System;

class Program
{
    static void Main(string[] args)
    {
        string percentageString;
        int percentage;
        int gradeA = 90;
        int gradeB = 80;
        int gradeC = 70;
        int gradeD = 60;

        Console.WriteLine("Please enter grade percentage: ");
        percentageString = Console.ReadLine();
        percentage = int.Parse(percentageString);

        if (percentage >= gradeA)
        {
            Console.WriteLine("You recieved an A.");
        }

        else if (percentage >= gradeB)
        {
            Console.WriteLine("You recieved a B.");
        }

        else if (percentage >= gradeC)
        {
            Console.WriteLine("You recieved a C.");
        }

        else if (percentage >= gradeD)
        {
            Console.WriteLine("You recieved a D.");
        }

        else
        {
            Console.WriteLine("You recieved an F.");
        }
    }
}