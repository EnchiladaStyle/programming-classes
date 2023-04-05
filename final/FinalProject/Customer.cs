public class Customer : Account
    {
        private string _feedback;
        public string WriteReview()
        {
            Console.Clear();
            Console.WriteLine("Please write your review here: ");
            _feedback = Console.ReadLine();
            Console.WriteLine("\nThank you for your feedback\npress enter to continue");
            Console.ReadLine();
            Console.Clear();

            return _feedback;
        }
    }