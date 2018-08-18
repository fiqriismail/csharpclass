using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MovieLibrary.Service.Models
{
    public class MoiveDbContext : DbContext
    {
        public MoiveDbContext() : base("MovieDbContext")
        {
            //TODO
        }

        //Tables
        public DbSet<Movie> Movies { get; set; }
    }
}
