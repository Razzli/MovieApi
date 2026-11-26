namespace MovieApi.Models
{
    public class Movie
    {
        private int _id;
        private string _title = string.Empty;
        private int _year;
        private int _duration;

        public Movie(string title, int year, int duration)
        {
            Title = title;
            Year = year;
            Duration = duration;
        }

        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public int Year { get => _year; set => _year = value; }
        public int Duration { get => _duration; set => _duration = value; }

        public MovieDetails MovieDetails { get; set; }
        public ICollection<Review> Reviews { get; } = new List<Review>();
        public ICollection<Genre> Genres = new List<Genre>();
        public ICollection<Actor> Actors { get; } = new List<Actor>();
    }
}
