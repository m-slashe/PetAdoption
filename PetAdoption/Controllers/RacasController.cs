using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PetAdoption.Models;

namespace PetAdoption.Controllers
{
    public class RacasController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Racas
        public ActionResult Index()
        {
            return View(db.Raca.ToList());
        }

        // GET: Racas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Raca raca = db.Raca.Find(id);
            if (raca == null)
            {
                return HttpNotFound();
            }
            return View(raca);
        }

        // GET: Racas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Racas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome")] Raca raca)
        {
            if (ModelState.IsValid)
            {
                db.Raca.Add(raca);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(raca);
        }

        // GET: Racas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Raca raca = db.Raca.Find(id);
            if (raca == null)
            {
                return HttpNotFound();
            }
            return View(raca);
        }

        // POST: Racas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome")] Raca raca)
        {
            if (ModelState.IsValid)
            {
                db.Entry(raca).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(raca);
        }

        // GET: Racas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Raca raca = db.Raca.Find(id);
            if (raca == null)
            {
                return HttpNotFound();
            }
            return View(raca);
        }

        // POST: Racas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Raca raca = db.Raca.Find(id);
            db.Raca.Remove(raca);
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
