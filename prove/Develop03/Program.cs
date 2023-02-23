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
        Console.WriteLine("enter 'quit' to quit");
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
        if (answer == "quit")
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
        private List<int> _indexList = new List<int>();
        private string _hiddenWord;

        
        private int RemoveWords(List<string> scriptText)
        {
            Random __rand1 = new Random();
            int __randIndex = __rand1.Next(0, scriptText.Count());
            return __randIndex;
            
        }

        private string ReplaceLetters(string word){
            string _underscores = "";
            foreach (char letter in word){
                _underscores += "_";
            }
            return _underscores;
        }

        public void HandleDisplay(int indexCounter, List<string> scripText, string scripReference)
        {
            _indexList.Add(RemoveWords(scripText));
            Console.WriteLine();
            Console.WriteLine(scripReference);
            Console.WriteLine();
            foreach (string word in scripText){
            
            if (_indexList.Contains(indexCounter)){
                _hiddenWord = ReplaceLetters(word);
                Console.Write(_hiddenWord + " ");
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
        private Scripture _testScrip = new Scripture();
        
        private string _testCase;
        private int _score = 0;

        public void RecieveAndGrade()
        {
            List<string> _testScripText = _testScrip.GetScripture();
            foreach (string word in _testScripText)
            {
                Console.WriteLine("Type the next word here and press enter: ");
                _testCase = Console.ReadLine();
                if (_testCase == word)
                {
                    _score += 1;
                }
            }
            
            Console.WriteLine($"Final Score: {_score}/{_testScripText.Count()}");
            
            
        }

    }

}