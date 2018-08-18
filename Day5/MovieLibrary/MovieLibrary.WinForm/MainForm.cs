using MovieLibrary.WinForm.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary.WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void MoviesButton_Click(object sender, EventArgs e)
        {
            //
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get,
                "http://localhost:51640/api/Movies/MovieList");

            HttpResponseMessage response = await client.SendAsync(request);

            string output = await response.Content.ReadAsStringAsync();

            var movieList = JsonConvert.DeserializeObject<List<MovieViewModel>>(output);

            foreach (var movie in movieList)
            {
                MoviesList.Items.Add($"{movie.Id} - {movie.Title}");
            }


        }
    }
}
