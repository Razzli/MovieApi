namespace MovieApi.Models
{
    public class Actor
    {
        private int _id;
        private string _name = string.Empty;
        private int _birthYear;

        public Actor(int id, string name, int birthYear)
        {
            Id = id;
            Name = name;
            BirthYear = birthYear;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int BirthYear { get => _birthYear; set => _birthYear = value; }
        public ICollection<Movie> Movies = new List<Movie>();
    }
}
