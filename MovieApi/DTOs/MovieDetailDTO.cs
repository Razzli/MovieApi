namespace MovieApi.DTOs
{
    public class MovieDetailDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }
        public string Synopsis {  get; set; }
        public string Language {  get; set; }
        public int Budget {  get; set; }
        public List<ReviewDTO> Reviews { get; set; }
        public List<ActorDTO> Actors { get; set; }
    }
}
