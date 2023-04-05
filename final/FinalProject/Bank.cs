public class Bank
    {
        private List<string> _reviews = new List<string>();

        public void AddToReviews(string review)
        {
            _reviews.Add(review);
        }

        public List<string> GetReviews()
        {
            return _reviews;
        }
    }