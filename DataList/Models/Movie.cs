using System;

namespace DataList.Models;

public class Movie
{
    public required string MovieName { get; set; }
    public int Year { get; set; }
    public required string Language { get; set; }
}
