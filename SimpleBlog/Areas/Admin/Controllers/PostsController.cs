using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    public class PostsController : Controller
    {
        // GET: Admin/Posts
        [Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            return Content("Admin Posts!");
        }
    }
}