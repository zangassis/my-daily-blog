using Microsoft.AspNetCore.Mvc;
using MyDailyBlog.Data;
using MyDailyBlog.Models;
using System.Diagnostics;

namespace MyDailyBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PostManager _manager;

        public HomeController(ILogger<HomeController> logger, PostManager manager)
        {
            _logger = logger;
            _manager = manager;
        }

        public IActionResult Index()
        {
            var blogs = _manager.GetAllPosts();

            ViewBag.Empty = false;
            return View(blogs);
        }

        public IActionResult Privacy()
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
