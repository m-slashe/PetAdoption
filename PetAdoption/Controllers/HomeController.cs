using PetAdoption.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetAdoption.Controllers
{
    public class HomeController : Controller
    {

        DatabaseContext db = new DatabaseContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Title = "Autenticação";
            return View();
        }

        public ActionResult Usuario()
        {
            ViewBag.Title = "Usuario";
            var usuarios = db.Usuario.ToList();
            return View(usuarios);
        }
    }
}