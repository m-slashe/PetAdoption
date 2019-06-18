using PetAdoption.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetAdoption.Controllers
{
    public class AbrigoController : Controller
    {
        PetAdoptionContextEntities db = new PetAdoptionContextEntities();

        public ActionResult Index()
        {
            return View(db.Abrigo.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Abrigo abrigo)
        {
            if (ModelState.IsValid)
            {
                db.Abrigo.Add(abrigo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(abrigo);
        }

        public ActionResult Edit(int? id)
        {
            Abrigo abrigo = db.Abrigo.Find(id);
            if (abrigo == null)
            {
                return HttpNotFound();
            }
            return View(abrigo);
        }

        [HttpPost]
        public ActionResult Edit(Abrigo abrigo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(abrigo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(abrigo);
        }

        public ActionResult Delete(int? id)
        {
            Abrigo abrigo = db.Abrigo.Find(id);
            if (abrigo == null)
            {
                return HttpNotFound();
            }
            return View(abrigo);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Abrigo abrigo = db.Abrigo.Find(id);
            db.Abrigo.Remove(abrigo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            var abrigo = db.Abrigo.Find(id);
            if (abrigo == null)
            {
                return HttpNotFound();
            }
            return View(abrigo);
        }
    }
}