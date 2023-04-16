using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FilmSitesi.Models;

namespace FilmSitesi.Controllers
{
    public class UsersController : Controller
    {
        private filmSitesiEntities db = new filmSitesiEntities();

        // GET: Users
        [HttpGet]
        public ActionResult Index()
        {
            var films = db.films.Include(f => f.image);

            return View(films.ToList());

        }
    }
}