using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[NotMapped]
public class Album
{
    public int id { get; set; }
    [MaxLength(100000)]
    public string? title { get; set; }
    [NotMapped]
    public string? cover { get; set; }
    [NotMapped]
    public string? cover_small { get; set; }
    public string? cover_medium { get; set; }
    [NotMapped]
    public string? cover_big { get; set; }
    [NotMapped]
    public string? cover_xl { get; set; }
    [NotMapped]
    public string? md5_image { get; set; }
    [NotMapped]
    public string? tracklist { get; set; }
    [NotMapped]
    public string? type { get; set; }
 
}