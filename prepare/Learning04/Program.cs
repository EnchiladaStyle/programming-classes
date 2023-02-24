using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment datmath = new MathAssignment("Chris", "log", "college algebra", "x + 1 = 5");

        Console.WriteLine(datmath.getHomeworkList());
        Console.WriteLine();
        Console.WriteLine(datmath.getSummary());

        Writing write = new Writing("Micah", "english", "english 101");
        Console.WriteLine();
        Console.WriteLine(write.getWritingInfo());
        Console.WriteLine();
        Console.WriteLine(write.getSummary());
    }

   
}