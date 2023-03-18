using System;

// This program is being resubmitted an place of the polymorphism project because we are doing that one together in class.
// I made some changes to it, mainly the classes are separated into individual files.
// It Exceeded requirements by ensuring that a question in the reflecting activity won't repeat itself untill all other questions are displayed.
// It also exceded requirements by giving the user the ability to end the program, which was not specified by the instructions. 

class Program
{
    static void Main(string[] args)
    {
        Breathing breathingActivity = new Breathing();
        Reflecting reflectingActivity = new Reflecting();
        Listing listingActivity = new Listing();
        bool end = false;
        do
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Please Select an activity below");
            Console.WriteLine();
            Console.WriteLine("1: Breathing");
            Console.WriteLine("2: Reflecting");
            Console.WriteLine("3: Listing");
            Console.WriteLine("4: End Program");
            Console.Write("enter the number here: ");
            string ActivityChoice = Console.ReadLine();
            Console.Clear();

            if (ActivityChoice == "1")
            {
                breathingActivity.Welcome();
                int duration = breathingActivity.SetLength();
                breathingActivity.Breath(duration);
                breathingActivity.WellDone();
            }
            else if (ActivityChoice == "2")
            {
                reflectingActivity.Welcome();
                int duration = reflectingActivity.SetLength();
                reflectingActivity.CreatePrompt();
                reflectingActivity.AskQuestion(duration);
                reflectingActivity.WellDone();
                
            }
            else if (ActivityChoice == "3")
            {
                listingActivity.Welcome();
                int duration = listingActivity.SetLength();
                listingActivity.CreatePrompt();
                listingActivity.PromptAndWrite(duration);
                listingActivity.WellDone();
                
            }

            else if (ActivityChoice == "4")
            {
                break;
            }
        }while (end == false);

        Console.WriteLine("the end");
    }

    

   

   
    
    
}