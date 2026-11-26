using System.ComponentModel.DataAnnotations;

namespace MovieApi.DTOs
{
    public class MovieCreateDTO
    {   
        [Required(ErrorMessage = "Titel är ett krav")]
        public string Title { get; set; }
        [Required(ErrorMessage = "År är ett krav"), Range(0, int.MaxValue, ErrorMessage = "År får inte vara negativ")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Längd är ett krav"), Range(0, int.MaxValue, ErrorMessage = "Längd får inte vara negativ")]
        public int Duration { get; set; }
        [Required(ErrorMessage = "Synopsis är ett krav")]
        public string Synopsis {  get; set; }
        [Required(ErrorMessage = "Språk är ett krav")]
        string Language { get; set; }
        [Required(ErrorMessage = "Budget är ett krav"), Range(0, int.MaxValue, ErrorMessage = "Budget får inte vara negativ")]
        int Budget { get; set; }
    }
}
