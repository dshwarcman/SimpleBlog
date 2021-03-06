﻿using SimpleBlog.ViewModels;
using System.Web.Mvc;
using System.Web.Security;

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
        public ActionResult Login(AuthLogin form, string returnUrl)
        {
            if (!ModelState.IsValid)
                return View(form);

            FormsAuthentication.SetAuthCookie(form.Username, true);

            if(!string.IsNullOrWhiteSpace(returnUrl))
                return Redirect(returnUrl);

            return RedirectToRoute("home");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("home");
        }
    }
}