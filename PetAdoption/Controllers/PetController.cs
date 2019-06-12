using PetAdoption.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetAdoption.Controllers
{
    public class PetController : Controller
    {
        PetAdoptionContextEntities1 db = new PetAdoptionContextEntities1();

        public ActionResult Index()
        {
            return View(db.Pet.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Pet pet)
        {
            if (ModelState.IsValid)
            {
                db.Pet.Add(pet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pet);
        }

        public ActionResult Edit(int? id)
        {
            Pet pet = db.Pet.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            return View(pet);
        }

        [HttpPost]
        public ActionResult Edit(Pet pet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pet);
        }

        public ActionResult Delete(int? id)
        {
            Pet pet = db.Pet.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            return View(pet);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Pet pet = db.Pet.Find(id);
            db.Pet.Remove(pet);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            var pet = db.Pet.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            return View(pet);
        }
    }
}