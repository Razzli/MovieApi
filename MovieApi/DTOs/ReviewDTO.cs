namespace MovieApi.DTOs
{
    public class ReviewDTO
    {
        int Id { get; set; }
        string ReviewerName {  get; set; }
        string Comment {  get; set; }
        int Rating {  get; set; }
    }
}
