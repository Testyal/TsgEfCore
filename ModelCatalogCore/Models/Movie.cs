using System;


namespace ModelCatalogCore.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public int? DirectorId { get; set; }
        public int GenreId { get; set; }
        public int? RatingId { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Title { get; set; }
        
        public virtual Director Director { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Rating Rating { get; set; }
    }
}