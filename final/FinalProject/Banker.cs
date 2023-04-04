public class Banker : Account
    {
        

        public void readReviews(List<string> reviews)
        {
            Console.WriteLine();
            foreach (string review in reviews)
            {
                Console.WriteLine(review);
                Console.WriteLine();
            }
            
        }
    }