using System.ComponentModel.DataAnnotations.Schema;

[NotMapped]
public class Tracks
{
    public Datum[] data { get; set; }
}
