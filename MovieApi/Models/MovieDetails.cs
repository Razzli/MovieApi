namespace MovieApi.Models
{
    public class MovieDetails
    {
        private int _id;
        private string _synopsis = string.Empty;
        private string _langueage =string.Empty;
        private int _budget;

        public MovieDetails(string synopsis, string langueage, int budget)
        {
            Synopsis = synopsis;
            Langueage = langueage;
            Budget = budget;
        }

        public int Id { get => _id; set => _id = value; }
        public string Synopsis { get => _synopsis; set => _synopsis = value; }
        public string Langueage { get => _langueage; set => _langueage = value; }
        public int Budget { get => _budget; set => _budget = value; }
        public int MovieID { get; set; }
        public Movie Movie { get; set; }
    }
}
