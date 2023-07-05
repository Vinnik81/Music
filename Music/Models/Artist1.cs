
using System.ComponentModel.DataAnnotations.Schema;

[NotMapped]
public class Artist1
{
    public int id { get; set; }
    public string name { get; set; }
    public string tracklist { get; set; }
    public string type { get; set; }
}
