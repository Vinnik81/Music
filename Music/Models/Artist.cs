using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[NotMapped]
public class Artist
{
    public int id { get; set; }
    [MaxLength(50000)]
    public string name { get; set; }
    [NotMapped]
    public string? link { get; set; }
    [NotMapped]
    public string? picture { get; set; }
    [NotMapped]
    public string? picture_small { get; set; }
    [NotMapped]
    public string? picture_medium { get; set; }
    [NotMapped]
    public string? picture_big { get; set; }
    [NotMapped]
    public string? picture_xl { get; set; }
    [NotMapped]
    public string? tracklist { get; set; }
    [NotMapped]
    public string? type { get; set; }
    
}
