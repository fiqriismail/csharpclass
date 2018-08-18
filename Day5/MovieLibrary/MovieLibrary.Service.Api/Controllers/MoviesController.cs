using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieLibrary.Service.Logic;
using MovieLibrary.Service.Models;

namespace MovieLibrary.Service.Api.Controllers
{
    public class MoviesController : ApiController
    {
        private MovieLogic _movieService = new MovieLogic();

        [HttpGet]
        public IHttpActionResult MovieList()
        {
            var movies = _movieService.GetMovies();
            return Ok(movies);
        }

        [HttpPost]
        public IHttpActionResult PostMovie(Movie movie)
        {
            var lastId = _movieService.PostMovie(movie);
            return Ok(lastId);
                
        }

    }
}
