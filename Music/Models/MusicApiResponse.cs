﻿using System.ComponentModel.DataAnnotations.Schema;

[NotMapped]
public class MusicApiResponse
{
    public Datum[] data { get; set; }
    public int total { get; set; }
    public string next { get; set; }
}
