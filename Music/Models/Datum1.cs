﻿using System.ComponentModel.DataAnnotations.Schema;

[NotMapped]
public class Datum1
{
    public int id { get; set; }
    public string name { get; set; }
    public string picture { get; set; }
    public string type { get; set; }
}
