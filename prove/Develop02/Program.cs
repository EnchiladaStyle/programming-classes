using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {   

        //This program meets the main requirements. It also exceeds expectations by providing an inspirational quote.
        //Lots of people struggle with journaling because It's hard to see the value in it. 
        //The quote from Elder Anderson gives a good reason to journal and will help the user get motivated.

        int Quit = 0;
        List<string> entries = new List<string>();
        do
        {   Console.WriteLine("Please select from one of the following choices.");
            Console.WriteLine("0. View Inspirational Quote");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Which number will you choose?");
            string reply = Console.ReadLine();

            if (reply == "0")
            {
                Display quote = new Display();
                quote.InspirationalQuote();
            }
            
            else if (reply == "1")
            {
                Display newPrompt = new Display();
                string prompt = newPrompt.GetPrompt();
                
                
                Entry newEntry = new Entry();
                entries.Add($"{prompt}\n Entry: {newEntry.TakeInput()}");
            }

            else if (reply == "2")
            {
                Display RecentEntries = new Display();
                RecentEntries.DisplayEntries(entries);

            }

            else if (reply == "3")
            {
                LoadAndSave newSave = new LoadAndSave();
                newSave.Save(entries);
            }

            else if (reply == "4")
            {
                LoadAndSave oldEntries = new LoadAndSave();
                oldEntries.Load();
            }

            else
            {
                Quit += 1;
            }

        
        }while (Quit == 0);

        Console.WriteLine("The program has ended.");
        
    }

    class Entry
    {
        public string TakeInput()
        {
            Console.Write("Write your entry here: ");
            string _newResponse = Console.ReadLine();
            DateTime CurrentDate = DateTime.Now;
            return $"{_newResponse} {CurrentDate}";
        }
    }

    class LoadAndSave
    {
        string _journalFile;
        
        public void Load()
        {
        Console.WriteLine("What is the name of the file?");
        _journalFile = Console.ReadLine();
        
        string[] _lines = System.IO.File.ReadAllLines(_journalFile);
        foreach (string line in _lines)
        {
            Console.WriteLine();
            Console.WriteLine(line);
            Console.WriteLine();
        }
        }

        public void Save(List<string> entries)
        {
           Console.WriteLine("What is the name of the file?");
           _journalFile = Console.ReadLine();
           using (StreamWriter _output = new StreamWriter(_journalFile))
           {
            foreach (string entry in entries)
            {
                _output.WriteLine(entry);
            }
            Console.WriteLine();
            Console.WriteLine("Progress saved.");
            Console.WriteLine();
           }
        }
    }

    class Display
    {
        public void InspirationalQuote()
        {
            Console.WriteLine();
            Console.WriteLine("Embrace your sacred memories. Believe them. Write them down. \nShare them with your family. Trust that they come to you from your Heavenly Father\nand His Beloved Son. Let them bring patience to your doubts and understanding\nto your difficulties. -Neil L. Anderson");
            Console.WriteLine();
        }

        public void DisplayEntries(List<string> entries)
        {
            foreach (string entry in entries)
            {
                Console.WriteLine();
                Console.WriteLine(entry);
                Console.WriteLine();
            }
        }

        public string GetPrompt()
        {
            List<string> _prompts = new List<string>();
            _prompts.Add("Write about something nice a stranger did for you.");
            _prompts.Add("Write about a song and a feeling it invoked in you.");
            _prompts.Add("Describe something you are proud of.");
            _prompts.Add("What are some goals you are working on?");
            _prompts.Add("Do you have any regrets today?");

            Random rand = new Random();
            int _randomIndex = rand.Next(_prompts.Count);
            
            string _prompt = $"Prompt: {_prompts[_randomIndex]}";
            Console.WriteLine(_prompt);
            return _prompt;
        }
    }
}