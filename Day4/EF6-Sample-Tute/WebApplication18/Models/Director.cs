using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication18.Models
{
    public class Director
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}