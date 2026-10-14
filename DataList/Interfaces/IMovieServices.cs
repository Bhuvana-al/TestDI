using System;
using System.Collections.Generic;
using DataList.Models;
using DataList.Services;

namespace DataList.Interfaces;

public interface IMovieServices
{
    List<Movie> ListRomantic();
    List<Movie> ListThriller();
}
