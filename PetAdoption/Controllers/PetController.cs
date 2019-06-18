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
        PetAdoptionContextEntities db = new PetAdoptionContextEntities();

        public ActionResult Index()
        {
            return View(db.Pet.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.IdRaca = new SelectList(db.Raca, "Id", "Nome");
            ViewBag.IdEspecie = new SelectList(db.Especie, "Id", "Nome");
            ViewBag.IdPorte = new SelectList(db.Porte, "Id", "Nome");
            ViewBag.IdAbrigo = new SelectList(db.Abrigo, "Id", "Nome");
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

            ViewBag.IdAbrigo = new SelectList(db.Abrigo, "Id", "Nome", pet.IdAbrigo);
            ViewBag.IdEspecie = new SelectList(db.Especie, "Id", "Nome", pet.IdEspecie);
            ViewBag.IdPorte = new SelectList(db.Porte, "Id", "Nome", pet.IdPorte);
            ViewBag.IdRaca = new SelectList(db.Raca, "Id", "Nome", pet.IdRaca);
            return View(pet);
        }

        public ActionResult Edit(int? id)
        {
            Pet pet = db.Pet.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdAbrigo = new SelectList(db.Abrigo, "Id", "Nome", pet.IdAbrigo);
            ViewBag.IdEspecie = new SelectList(db.Especie, "Id", "Nome", pet.IdEspecie);
            ViewBag.IdPorte = new SelectList(db.Porte, "Id", "Nome", pet.IdPorte);
            ViewBag.IdRaca = new SelectList(db.Raca, "Id", "Nome", pet.IdRaca);
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
            ViewBag.IdAbrigo = new SelectList(db.Abrigo, "Id", "Nome", pet.IdAbrigo);
            ViewBag.IdEspecie = new SelectList(db.Especie, "Id", "Nome", pet.IdEspecie);
            ViewBag.IdPorte = new SelectList(db.Porte, "Id", "Nome", pet.IdPorte);
            ViewBag.IdRaca = new SelectList(db.Raca, "Id", "Nome", pet.IdRaca);
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