using FilmSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FilmSitesi.Controllers
{
    public class LoginController : Controller
    {
        private filmSitesiEntities db = new filmSitesiEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(admin p)
        {
            var adminuser = db.admins.FirstOrDefault
                (x=>x.name==p.name && x.password==p.password);

            if (adminuser!=null)
            {
                FormsAuthentication.SetAuthCookie(adminuser.name, false);
                Session["name"] = adminuser.name;
                // Login işleminin gerçekleştiği yer
                Session["isLoggedIn"] = true;
                return RedirectToAction("Index", "Users");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();

            return RedirectToAction("Index", "Users");
        }
    }
}