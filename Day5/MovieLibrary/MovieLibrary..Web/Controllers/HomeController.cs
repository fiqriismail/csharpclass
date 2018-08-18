using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using MovieLibrary.Web.Models;
using System.Net.Http.Headers;

namespace MovieLibrary.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public async Task<ActionResult> Index()
        {

            //
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get,
                "http://localhost:51640/api/Movies/MovieList");
           
            HttpResponseMessage response = await client.SendAsync(request);

            string output = await response.Content.ReadAsStringAsync();

            var movieList = JsonConvert.DeserializeObject<List<MovieViewModel>>(output);


            return View(movieList);
        }

        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(MovieViewModel movie)
        {
            if (ModelState.IsValid)
            {

                var uri = new Uri("http://localhost:51640/api/Movies/PostMovie");

                var jsonContent = JsonConvert.SerializeObject(movie);
                var payLoad = new StringContent(jsonContent, 
                    System.Text.Encoding.UTF8, "application/json");


                //
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
               
                var response = await client.PostAsync(uri, payLoad);

                var result = await response.Content.ReadAsStringAsync();

                if (int.Parse(result) > 0)
                {
                    return RedirectToAction("Index");
                }
            }

            return View(movie);
        }
    }
}