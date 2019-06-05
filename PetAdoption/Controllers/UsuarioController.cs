using PetAdoption.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetAdoption.Controllers
{
    public class UsuarioController : Controller
    {

        DatabaseContext db = new DatabaseContext();
        
        public ActionResult Index()
        {
            return View(db.Usuario.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Usuario.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuario);
        }
    }
}