namespace MovieApi.Models
{
    public class Genre
    {
        private int _id;
        private string _name = string.Empty;

        public Genre(string name)
        {
            Name = name;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}
