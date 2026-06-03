using System;
using System.Linq;
using System.Web.Mvc;
using NorthwindMVCApp.Models;
using NorthwindMVCApp.Repositories;

namespace NorthwindMVCApp.Controllers
{
    public class MoviesController : Controller
    {
        IMovieRepository repo = new MovieRepository();

        MovieContext db = new MovieContext();

        public ActionResult Index()
        {
            return View(repo.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie m)
        {
            repo.Create(m);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var m = repo.GetAll().First(x => x.Mid == id);
            return View(m);
        }

        [HttpPost]
        public ActionResult Edit(Movie m)
        {
            repo.Edit(m);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            repo.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Search(string option, string value)
        {
            if (option == "Year")
            {
                int year;
                if (int.TryParse(value, out year))
                {
                    var data = db.Movies
                                 .Where(m => m.DateOfRelease.Year == year)
                                 .ToList();

                    return View("ByYear", data);
                }
            }
            else if (option == "Director")
            {
                var data = db.Movies
                             .Where(m => m.DirectorName == value)
                             .ToList();

                return View("ByDirector", data);
            }

            return RedirectToAction("Index");
        }
    }
}