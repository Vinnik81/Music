using System.ComponentModel.DataAnnotations;

namespace Music.Models
{
    public class Track
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Title { get; set; }
        public string Preview { get; set; }
        public string? Cover_medium { get; set; }
        public int ArtistDbId { get; set; }
        public ArtistDb ArtistDb { get; set; }
        public int AlbumDbId { get; set; }
        public AlbumDb AlbumDb { get; set; }
    }
}
