namespace MovieApi.Models
{
    public class Movie
    {
        private int _id;
        private string _title = string.Empty;
        private int _year;
        private string _description = string.Empty;

        public Movie(int id, string title, int year, string description)
        {
            Id = id;
            Title = title;
            Year = year;
            Description = description;
        }

        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public int Year { get => _year; set => _year = value; }
        public string Description { get => _description; set => _description = value; }

        public MovieDetails MovieDetails { get; set; }
        public ICollection<Review> Reviews { get; } = new List<Review>();
        public ICollection<Genre> Genres = new List<Genre>();
        public ICollection<Actor> Actors { get; } = new List<Actor>();
    }
}
