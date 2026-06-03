using System.Data.Entity;

namespace NorthwindMVCApp.Models
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}