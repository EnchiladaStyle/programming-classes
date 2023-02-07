using System;

class Program
{
    static void Main(string[] args)
    {
        fraction thisFrac = new fraction();

        thisFrac.topAndBottom(5, 4);

        

        

        
        Console.WriteLine(thisFrac.finishThat());
        Console.WriteLine(thisFrac.getDecimalValue());
    }
}