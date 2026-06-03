using System.Collections.Generic;
using NorthwindMVCApp.Models;

namespace NorthwindMVCApp.Repositories
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
        void Create(Movie m);
        void Edit(Movie m);
        void Delete(int id);
    }
}
