using System.Collections.Generic;
using System.Linq;
using NorthwindMVCApp.Models;
using System.Data.Entity;

namespace NorthwindMVCApp.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        MovieContext db = new MovieContext();

        public List<Movie> GetAll()
        {
            return db.Movies.ToList();
        }

        public void Create(Movie m)
        {
            db.Movies.Add(m);
            db.SaveChanges();
        }

        public void Edit(Movie m)
        {
            db.Entry(m).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var m = db.Movies.Find(id);
            db.Movies.Remove(m);
            db.SaveChanges();
        }
    }
}