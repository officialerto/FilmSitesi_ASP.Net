﻿using System;
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
    public class AdminController : Controller
    {
        private filmSitesiEntities db = new filmSitesiEntities();

        // GET: Admin
        public ActionResult Index()
        {
            var films = db.films.Include(f => f.image);
            return View(films.ToList());
        }

        // GET: Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            film film = db.films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            ViewBag.image_id = new SelectList(db.images, "id", "title");
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,category,length,releaseDate,description,comment,imdbScore,myScore,image_id")] film film)
        {
            if (ModelState.IsValid)
            {
                db.films.Add(film);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.image_id = new SelectList(db.images, "id", "title", film.image_id);
            return View(film);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            film film = db.films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            ViewBag.image_id = new SelectList(db.images, "id", "title", film.image_id);
            return View(film);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,category,length,releaseDate,description,comment,imdbScore,myScore,image_id")] film film)
        {
            if (ModelState.IsValid)
            {
                db.Entry(film).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.image_id = new SelectList(db.images, "id", "title", film.image_id);
            return View(film);
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            film film = db.films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            film film = db.films.Find(id);
            db.films.Remove(film);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
