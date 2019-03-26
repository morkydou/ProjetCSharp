using System.Collections.Generic;
using ProjetCSharp.Models;
using System;

namespace ProjetCSharp.Core
{
    public interface IMovieRepository
    {
        List<Movies> ListMovies();

        Movies GetMoviesById(Guid id);
    }
}