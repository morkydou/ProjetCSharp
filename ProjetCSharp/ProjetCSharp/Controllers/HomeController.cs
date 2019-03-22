using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetCSharp.Models;

namespace ProjetCSharp.Controllers
{
    public class HomeController : Controller
    {
        
        private static List<Movies> movies = new List<Movies>();
        
        public ActionResult Index()
        {
           return View(movies);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Insert([FromForm]Movies model)
        {
         
            movies.Add(new Movies
            {
                id = Guid.NewGuid(),
                name = model.name,
                description = model.description,
                status = model.status
            });
            return RedirectToAction("Index");
        }
  
        public ActionResult Update(Guid id)
        {
            Movies film = new Movies();
            for (int ctr = 0; ctr <= movies.Count - 1; ctr++)
            {
                if(movies[ctr].id == id)
                {
                    film.id = movies[ctr].id;
                    film.name = movies[ctr].name;
                    film.description = movies[ctr].description;
                    film.status = movies[ctr].status;
                }
            }
            return View(film);
        }

        [HttpPost]
        public ActionResult Edit([FromForm] Movies model)
        {
            for(int ctr = 0; ctr <= movies.Count-1; ctr++)
            {
                if(movies[ctr].id == model.id)
                {
                    movies[ctr].name = model.name;
                    movies[ctr].description = model.description;
                    movies[ctr].status = model.status;
                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult Search()
        {
            return View(movies);
        }
        [HttpPost]
        public ActionResult SearchResult(string name)
        {

            if(name is null)
            {
                return View("Search", movies);
            }
            var query = movies.Where(movies => movies.name.Contains(name));
            
            
            return View("Search",query);
        }
                        
        public ActionResult Delete(Guid id)
        {
            for (int ctr = 0; ctr <= movies.Count - 1; ctr++)
            {
                if (movies[ctr].id == id)
                {
                    movies.Remove(movies[ctr]);
                }
            }
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
