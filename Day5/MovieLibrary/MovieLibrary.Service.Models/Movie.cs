using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieLibrary.Service.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        public DateTime ReleasedDate { get; set; }
        public bool Status { get; set; }
    }
}