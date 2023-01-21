using System;

class Program
{

    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello Learning02 World!");
        
        Job job1 = new Job();
        job1._company = "Alaska Coach Tours";
        job1._jobTitle = "Bus Driver";
        job1._startYear = 2022;
        job1._endYear = 2022;

        job1.Display();

        Job job2 = new Job();
        job2._company = "Cafe Rio";
        job2._jobTitle = "Manager";
        job2._startYear = 2020;
        job2._endYear = 2022;

        job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "Chris Jones";
        resume1._jobs.Add("Bus Driver");
        resume1._jobs.Add("Manager");

        
        resume1.Display();

        
    }
}