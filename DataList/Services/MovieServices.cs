using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using DataList.Interfaces;
using DataList.Models;

namespace DataList.Services;

public class MovieServices : IMovieServices
{
    public List<Movie> ListRomantic()
    {
        return [
            new Movie
                {MovieName="Love today",
                Year=2010,
                Language="Tamil"},
            new Movie
                {MovieName="Hidden Love",
                Year=2024,
                Language="Korean"}
            ];
    }

    public List<Movie> ListThriller()
    {
        return [
            new Movie
                {MovieName="Final Destination",
                Year=2025,
                Language="English"},
            new Movie
                {MovieName="Evil dead",
                Year=2020,
                Language="English"}
            ];
    }
}

