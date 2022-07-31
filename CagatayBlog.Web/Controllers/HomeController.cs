using CagatayBlog.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CagatayBlog.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            var news = new List<NewsViewModel>
            {
                new NewsViewModel{Title="Technology and Entertainment",Content="Technological development led to evolution in our understanding of enjoy."},
                new NewsViewModel{Title="World Domination: Monster Mobile",Content="Mobile industry is one of the biggest sector in the world and still growing."},
                new NewsViewModel{Title="Game, Game, Game!",Content="Movies and TV series were dominated for decades, but a new actor is in scene: Gaming!"}
            };
            ViewBag.News = news;
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}