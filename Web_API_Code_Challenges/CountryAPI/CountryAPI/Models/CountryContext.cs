using System.Collections.Generic;
using System.Data.Entity;

namespace CountryAPI.Models
{
    public class CountryContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
    }
}