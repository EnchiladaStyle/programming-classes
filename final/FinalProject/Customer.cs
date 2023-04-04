public class Customer : Account
    {
        public string writeReview()
        {
            Console.WriteLine("Please write your review here: ");
            return Console.ReadLine();
        }
    }