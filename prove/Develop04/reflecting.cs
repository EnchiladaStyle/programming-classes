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