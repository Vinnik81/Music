namespace Music.Models
{
    public class AlbumDb
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<Track> Tracks { get; set; }
    }
}
