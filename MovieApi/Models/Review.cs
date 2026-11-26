namespace MovieApi.Models
{
    public class Review
    {
        private int _id;
        private string _reviewerName = string.Empty;
        private string _comment = string.Empty;
        private int _rating;

        public Review(string reviewerName, string comment, int rating)
        {
            ReviewerName = reviewerName;
            Comment = comment;
            Rating = rating;
        }

        public int Id { get => _id; set => _id = value; }
        public string ReviewerName { get => _reviewerName; set => _reviewerName = value; }
        public string Comment { get => _comment; set => _comment = value; }
        public int Rating { get => _rating; set => _rating = value; }
        public int MovieID { get; set; }
        public Movie Movie { get; set; }
    }
}
