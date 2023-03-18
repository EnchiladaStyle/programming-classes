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