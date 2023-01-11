using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percent did you score?");
        string grade = Console.ReadLine();
        int intgrade = int.Parse(grade);

        if (intgrade >= 90)
        {
            Console.WriteLine("you got an A!");
        }
        else if (intgrade >= 80)
        {
            Console.WriteLine("you got a B!");
        }
        else if (intgrade >= 70)
        {
            Console.WriteLine("you got a C.");
        }
        else
        {
            Console.WriteLine("you failure");
        }

    }
}