using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program");
        Console.Write("Please enter your name");
        string name = Console.ReadLine();

        Console.Write("Please enter your favorite number");
        int num = int.Parse(Console.ReadLine());

        string myFunction(string name, int num)
        {
            return $"{name}, your favorite number squared is {Math.Pow(num, 2)}";
        }

        Console.WriteLine(myFunction(name, num));
    }
}