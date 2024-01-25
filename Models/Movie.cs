using System.ComponentModel.DataAnnotations;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }

        [MaxLength(3)]
        public List<Actor>? Actors {get;set;} 
    }
}