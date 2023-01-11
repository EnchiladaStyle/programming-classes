using System;

class Program
{
    static void Main(string[] args)
    {
        int answer = 0;
        List<int> nums = new List<int>();
        do
        {
            Console.Write("What number will you add?");
            answer = int.Parse(Console.ReadLine());
            nums.Add(answer);
        }
        while (answer != 0);
    
    int added = 0;
    foreach (int i in nums)
    {
        added += i;
    }

    int average = added/nums.Count;

    Console.WriteLine(average);

    int largest = 0;

    foreach (int i in nums)
    {
        if (i > largest)
        {
            largest = i;
        }
    }
    
    Console.WriteLine(largest);

    }
}