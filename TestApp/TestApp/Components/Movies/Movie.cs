using System.ComponentModel.DataAnnotations;

namespace AuthReviews.Components.Movies
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }
        public float? Rate { get; set; }
        public int? RatesNumber { get; set; }
        public string? Image { get; set; }
    }
}
