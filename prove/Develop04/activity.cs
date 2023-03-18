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