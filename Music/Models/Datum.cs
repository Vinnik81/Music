using System.ComponentModel.DataAnnotations.Schema;
[NotMapped]
public class Datum
{
    public long id { get; set; }
    [NotMapped]
    public bool? readable { get; set; }
    public string title { get; set; }
    [NotMapped]
    public string? title_short { get; set; }
    [NotMapped]
    public string? title_version { get; set; }
    [NotMapped]
    public string? link { get; set; }
    [NotMapped]
    public int? duration { get; set; }
    [NotMapped]
    public int? rank { get; set; }
    [NotMapped]
    public bool? explicit_lyrics { get; set; }
    [NotMapped]
    public int? explicit_content_lyrics { get; set; }
    [NotMapped]
    public int? explicit_content_cover { get; set; }
    public string preview { get; set; }
    [NotMapped]
    public string? md5_image { get; set; }
    public int ArtistId { get; set; }
    public Artist artist { get; set; }
    public int AlbumId { get; set; }
    public Album album { get; set; }
    [NotMapped]
    public string? type { get; set; }
}
