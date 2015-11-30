using SimpleBlog.ViewModels;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {
            return View(new AuthLogin()
            {

            });
        }
        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            if (!ModelState.IsValid)
                return View(form);

            if (form.Username != "rainbow dash")
            {
                ModelState.AddModelError("Usermname", "Usename Incorrect");
                return View(form);
            }

            return Content("the form is valid!");
        }
    }
}