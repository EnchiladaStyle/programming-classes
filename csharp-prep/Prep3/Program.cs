using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        int magicNumber2 = randomGenerator.Next(1,100);
        int guess2 = 0;


        do
        {
            Console.Write("What is your guess?");
            string guess = Console.ReadLine();
            guess2 = int.Parse(guess);
            if (guess2 < magicNumber2)
            {
                Console.WriteLine("Higher");
            }
            if (guess2 > magicNumber2)
            {
                Console.WriteLine("Lower");
            }
        } while (guess2 != magicNumber2);
        Console.WriteLine("Congrats! you guessed correctly.");
    }
}