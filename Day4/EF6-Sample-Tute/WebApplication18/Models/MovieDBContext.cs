using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication18.Models
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext() : base("MovieDbContext")
        {
            //
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
    }
}