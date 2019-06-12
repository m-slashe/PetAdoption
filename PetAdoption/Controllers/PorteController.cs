using PetAdoption.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetAdoption.Controllers
{
    public class PorteController : Controller
    {
        PetAdoptionContextEntities1 db = new PetAdoptionContextEntities1();

        public ActionResult Index()
        {
            return View(db.Abrigo.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Porte porte)
        {
            if (ModelState.IsValid)
            {
                db.Porte.Add(porte);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(porte);
        }

        public ActionResult Edit(int? id)
        {
            Porte porte = db.Porte.Find(id);
            if (porte == null)
            {
                return HttpNotFound();
            }
            return View(porte);
        }

        [HttpPost]
        public ActionResult Edit(Porte porte)
        {
            if (ModelState.IsValid)
            {
                db.Entry(porte).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(porte);
        }

        public ActionResult Delete(int? id)
        {
            Porte porte = db.Porte.Find(id);
            if (porte == null)
            {
                return HttpNotFound();
            }
            return View(porte);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Porte porte = db.Porte.Find(id);
            db.Porte.Remove(porte);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            var porte = db.Porte.Find(id);
            if (porte == null)
            {
                return HttpNotFound();
            }
            return View(porte);
        }
    }
}