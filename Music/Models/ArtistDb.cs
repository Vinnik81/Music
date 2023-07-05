using System.ComponentModel.DataAnnotations;

namespace Music.Models
{
    public class ArtistDb
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public IEnumerable<Track> Tracks { get; set; }
    }
}
