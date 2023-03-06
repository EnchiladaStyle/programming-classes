using System;

// This program meets all the requirements provided in the assignment description. It also exceeds the requirements in several ways.
// It qualifies for extra credit because it incorporates polymorphism. The Activity class defines an abstract welcome function that is used in each child class.
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

    public abstract class Activity
    {
    

        private string _duration;
        List<string> _prompts = new List<string>();

        private List<string> _spinnerList = new List<string>();

        public void CreatePrompt()
        {
            Console.WriteLine("Get Ready...");
            SpinnerAnimation(); 
            _prompts.Add("Think of a time when you accomplished something really difficult...");
            _prompts.Add("Think of a time you did something you are proud of...");
            _prompts.Add("Think of the happiest moment you can remember...");
            _prompts.Add("Think of a time someone else was proud of you...");
            _prompts.Add("Think of a time you made a difficult decision that turned out being good...");

            Random _rand1 = new Random();
            int _randIndex = _rand1.Next(0, _prompts.Count());
            Console.WriteLine(_prompts[_randIndex]);
            Console.WriteLine("Press enter when you have something in mind.");
            Console.ReadLine();
            Console.Clear();
            
        }

        public int SetLength()
        {
            Console.Write("For How many seconds do you want to do this activity?: ");
            _duration = Console.ReadLine();
            Console.Clear();
            
            
            return int.Parse(_duration);

        }

        public void SpinnerAnimation()
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(5);
            _spinnerList.Clear();
            _spinnerList.Add("| ->         |");
            _spinnerList.Add("/   ->       /");
            _spinnerList.Add("-     ->     -");
            _spinnerList.Add("\\      ->    \\");
            _spinnerList.Add("|         -> |");
            _spinnerList.Add("/         <- /");
            _spinnerList.Add("-       <-   -");
            _spinnerList.Add("\\    <-      \\");
            _spinnerList.Add("|   <-       |");
            _spinnerList.Add("/ <-         /");
            
            
            Console.WriteLine();
            while (DateTime.Now < endTime)
            {
            foreach (string icon in _spinnerList)
            {
                
                Console.Write(icon);
                Thread.Sleep(250);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            }
            }
            Console.Clear();
            
        }

        public void WellDone()
        {
            Console.WriteLine($"Well done! You have completed {_duration} seconds of this activity!");
            SpinnerAnimation();
            
        }

        public abstract void Welcome();
    }

    public class Breathing : Activity
    {
        
       
        public override void Welcome()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the breathing activity!\nThis activity will help you relax by guiding your breathing rhythm.");
            Console.WriteLine();
            
        }

        public void Breath(int duration)
        {
            Console.WriteLine("Get Ready...");
            SpinnerAnimation();            
            for (int i=0; i<duration/10; i++)
            {
                Console.WriteLine("Breath in...");
                for (int j=5; j>0; j--)
                {
                    Console.Write(j);
                    Thread.Sleep(1000);
                    Console.Write("\b");
                }
                Console.WriteLine("Breath Out...");
                for (int j=5; j>0; j--)
                {
                    Console.Write(j);
                    Thread.Sleep(1000);
                    Console.Write("\b");
                }
            }
        }
    }

    public class Reflecting : Activity
    {
        List<string> _questions = new List<string>();
        private int _index = 0;

        public override void Welcome()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the reflecting activity! \nThis will help you reflect on moments from your life that give you determination.");
            Console.WriteLine();
        }

        public void AskQuestion(int duration)
        {
            
            _questions.Clear();
            _questions.Add("Why was this experience meaningful to you?");
            _questions.Add("Have you ever done anything like this before?");
            _questions.Add("How did you get started?");
            _questions.Add("How did you feel when it was complete?");
            _questions.Add("What made this time different than other times when you were not as successful?");
            _questions.Add("What is your favorite thing about this experience?");
            _questions.Add("What could you learn from this experience that applies to other situations?");
            _questions.Add("What did you learn about yourself through this experience?");
            _questions.Add("How can you keep this experience in mind in the future?");

            for (int i=0; i<duration/5; i++)
            {
                
                Console.Write(_questions[_index]);
                SpinnerAnimation();
                if (_index < 8)
                {
                    _index++;
                }
                else
                {
                    _index = 0;
                }
            }
            
        }

    }
    
    class Listing : Activity
    {
        public override void Welcome()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the listing activity!\nThis activity will help you think positively by having you list out positive things.");
            Console.WriteLine();
            
        }

        public void PromptAndWrite(int duration)
        {
            DateTime startTimeWrite = DateTime.Now;
            DateTime endTimeWrite = startTimeWrite.AddSeconds(duration);
            Console.WriteLine("Now, list as many responses to the question as you can before the time runs out.");
            while (DateTime.Now < endTimeWrite)
            {
                Console.Write(">");
                Console.ReadLine();
            }
            
        }

    }
}