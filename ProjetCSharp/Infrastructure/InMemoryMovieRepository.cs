using ProjetCSharp.Core;
using ProjetCSharp.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace ProjetCSharp.Infrastructure
{
    public class InMemoryMovieRepository : IMovieRepository
    {
        private List<Movies> films = new List<Movies>
        {
            new Movies{ id = new Guid("85fa8e07-8fa2-44ed-a0f4-27477b3b7622"),name = "Star Wars", description = "Pew-Pew",status = Status.Enabled}
        };
        public Movies GetMoviesById(Guid id)
        {
            return films.Where(f => f.id == id).FirstOrDefault();
        }

        public List<Movies> ListMovies()
        {
            return films;
        }

    }
}