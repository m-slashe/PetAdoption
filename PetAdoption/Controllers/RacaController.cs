using PetAdoption.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetAdoption.Controllers
{
    public class RacaController : Controller
    {

        PetAdoptionContextEntities db = new PetAdoptionContextEntities();

        public ActionResult Index()
        {
            return View(db.Raca.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Raca raca)
        {
            if (ModelState.IsValid)
            {
                db.Raca.Add(raca);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(raca);
        }

        public ActionResult Edit(int? id)
        {
            Raca raca = db.Raca.Find(id);
            if (raca == null)
            {
                return HttpNotFound();
            }
            return View(raca);
        }

        [HttpPost]
        public ActionResult Edit(Raca raca)
        {
            if (ModelState.IsValid)
            {
                db.Entry(raca).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(raca);
        }

        public ActionResult Delete(int? id)
        {
            Raca raca = db.Raca.Find(id);
            if (raca == null)
            {
                return HttpNotFound();
            }
            return View(raca);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Raca raca = db.Raca.Find(id);
            db.Raca.Remove(raca);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            var raca = db.Raca.Find(id);
            if (raca == null)
            {
                return HttpNotFound();
            }
            return View(raca);
        }

    }
}