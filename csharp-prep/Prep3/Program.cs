using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?");
        string userInput = Console.ReadLine();
        int magicNumber = int.Parse(userInput);
        Console.WriteLine("What is your guess?");
        userInput = Console.ReadLine();
        int guess = int.Parse(userInput);
        while (magicNumber != guess)
        {
            if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            Console.WriteLine("What is your guess?");
            userInput = Console.ReadLine();
            guess = int.Parse(userInput);
        }
        Console.WriteLine("Good Job!");
    }
}