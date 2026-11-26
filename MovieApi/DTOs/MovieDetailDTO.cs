namespace MovieApi.DTOs
{
    public class MovieDetailDTO
    {
        int Id { get; set; }
        string Title { get; set; }
        int Year { get; set; }
        int Duration { get; set; }
        string Synopsis {  get; set; }
        string Language {  get; set; }
        int Budget {  get; set; }
        List<ReviewDTO> Reviews { get; set; }
        List<ActorDTO> Actors { get; set; }
    }
}
