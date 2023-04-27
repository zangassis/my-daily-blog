using Microsoft.AspNetCore.Mvc;
using MyDailyBlog.Data;

namespace MyDailyBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly PostManager _manager;

        public BlogController(PostManager manager)
        {
            _manager = manager;
        }

        // GET: BlogController/{idd}
        [Route("blog/{id}")] // Set the ID parameter  
        public ActionResult Index(Guid id)
        {
            var post = _manager.GetPostById(id);
            return View(post);
        }
    }
}
