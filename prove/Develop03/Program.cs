using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scrip = new Scripture();
        MemoryHelper memHelp = new MemoryHelper();
        Test testTrial = new Test();
        List<string> scripText = scrip.GetScripture();
        string scripReference = scrip.GetReference();
        bool quit = false;
        string answer = "0";
        int indexCounter = 0;
        
        Console.WriteLine();
        Console.WriteLine(scripReference);
        Console.WriteLine();
        foreach (string word in scripText)
        {
            Console.Write(word + " ");
        }

        do {
        indexCounter = 0;
        
        Console.WriteLine();
        Console.WriteLine("enter 1 to remove letters");
        Console.WriteLine("enter 2 to test your knowledge.");
        Console.WriteLine("enter 3 to quit");
        Console.Write("Put your response here: ");
        answer = Console.ReadLine();
        
        if (answer == "1")
        {
            memHelp.HandleDisplay(indexCounter, scripText, scripReference);
        }
        if (answer == "2")
        {
            testTrial.RecieveAndGrade();
        }
        if (answer == "3")
        {
            break;
        }
        }while (quit == false);

        Console.WriteLine("the end");
        
    }

        
    

    class Scripture
    {
        
        private string _scripture = "I saw a pillar of light exactly over my head, above the brightness of the sun, which descended gradually until it fell upon me.";
        private string _reference = "Joseph Smith's first vision:";

        public List<string> GetScripture()
        {
            string[] _splitScripture = _scripture.Split(" ");
            List<string> _splitScriptureList = new List<string>(_splitScripture);
            return _splitScriptureList;
        }

        public string GetReference()
        {
            return _reference;
        }

    }

    class MemoryHelper
    {
        private List<int> _IndexList = new List<int>();
        private string _HiddenWord;

        
        private int RemoveWords(List<string> scriptText)
        {
            Random __Rand1 = new Random();
            int __RandIndex = __Rand1.Next(0, scriptText.Count());
            return __RandIndex;
            
        }

        private string ReplaceLetters(string word){
            string _Underscores = "";
            foreach (char letter in word){
                _Underscores += "_";
            }
            return _Underscores;
        }

        public void HandleDisplay(int indexCounter, List<string> scripText, string scripReference)
        {
            _IndexList.Add(RemoveWords(scripText));
            Console.WriteLine();
            Console.WriteLine(scripReference);
            Console.WriteLine();
            foreach (string word in scripText){
            
            if (_IndexList.Contains(indexCounter)){
                _HiddenWord = ReplaceLetters(word);
                Console.Write(_HiddenWord + " ");
            }
            else
            {
            Console.Write(word + " ");
            }
            indexCounter += 1;
            
        }
        }

       

    }

    class Test
    {
        private Scripture _TestScrip = new Scripture();
        
        private string _TestCase;
        private int _Score = 0;

        public void RecieveAndGrade()
        {
            List<string> _TestScripText = _TestScrip.GetScripture();
            foreach (string word in _TestScripText)
            {
                Console.WriteLine("Type the next word here and press enter: ");
                _TestCase = Console.ReadLine();
                if (_TestCase == word)
                {
                    _Score += 1;
                }
            }
            
            Console.WriteLine($"Final Score: {_Score}/{_TestScripText.Count()}");
            
            
        }

    }

}