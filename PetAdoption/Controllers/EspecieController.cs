using PetAdoption.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetAdoption.Controllers
{
    public class EspecieController : Controller
    {
        PetAdoptionContextEntities1 db = new PetAdoptionContextEntities1();

        public ActionResult Index()
        {
            return View(db.Usuario.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Especie especie)
        {
            if (ModelState.IsValid)
            {
                db.Especie.Add(especie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(especie);
        }

        public ActionResult Edit(int? id)
        {
            Especie especie = db.Especie.Find(id);
            if (especie == null)
            {
                return HttpNotFound();
            }
            return View(especie);
        }

        [HttpPost]
        public ActionResult Edit(Especie especie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(especie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(especie);
        }

        public ActionResult Delete(int? id)
        {
            Especie especie = db.Especie.Find(id);
            if (especie == null)
            {
                return HttpNotFound();
            }
            return View(especie);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Especie especie = db.Especie.Find(id);
            db.Especie.Remove(especie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            var especie = db.Especie.Find(id);
            if (especie == null)
            {
                return HttpNotFound();
            }
            return View(especie);
        }
    }
}