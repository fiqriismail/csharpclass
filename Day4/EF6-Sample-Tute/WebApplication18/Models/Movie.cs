using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WebApplication18.Models
{
    public class Movie
    {

        public int Id { get; set; }
        [Display(Name = "Enter Movie Title")]
        [Required(ErrorMessage = "You must enter a valid title")]
        [StringLength(200)]
        public string Title { get; set; }
        public int ReleasedYear { get; set; }
        public bool Status { get; set; }

        public int DirectorId { get; set; }
        public Director Director { get; set; }
    }
}