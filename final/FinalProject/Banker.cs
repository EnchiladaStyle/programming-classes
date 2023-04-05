public class Banker : Account
    {
        

        public void ReadReviews(List<string> reviews)
        {
            Console.Clear();
            
            foreach (string review in reviews)
            {
                Console.WriteLine(review);
                Console.WriteLine();
            }
            Console.WriteLine("\npress enter to continue");
            Console.ReadLine();
            
        }
    }