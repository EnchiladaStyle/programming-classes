public class Bank
    {
        private List<string> _reviews = new List<string>();

        public void addToReviews(string review)
        {
            _reviews.Add(review);
        }

        public List<string> getReviews()
        {
            return _reviews;
        }
    }