using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieLibrary.Service.Models;


namespace MovieLibrary.Service.Logic
{
    public class MovieLogic
    {
        private readonly MoiveDbContext context = new MoiveDbContext();
        public List<Movie> GetMovies()
        {
            var movies = context.Movies.ToList();
            return movies;
        }

        public int PostMovie(Movie movie)
        {

            var newMovie = new Movie();

            if (movie.Id > 0)
            {
                newMovie = context.Movies.Find(movie.Id);
            }

            newMovie.Title = movie.Title;
            newMovie.ReleasedDate = movie.ReleasedDate;
            newMovie.Status = movie.Status;

            if (movie.Id == 0)
            {
                context.Entry(newMovie).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
            else
            {
                context.Entry(newMovie).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }


            return newMovie.Id;
        }
    }
}
