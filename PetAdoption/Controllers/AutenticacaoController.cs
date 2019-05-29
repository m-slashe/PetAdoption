using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetAdoption.Controllers
{
    public class AutenticacaoController : Controller
    {
        public JsonResult AutenticarUsuario(string login, string senha)
        {
            if(GestaoUsuario.VerificarUsuarioBD(login, senha))
            {
                return Json(new { OK = true, Mensagem = "Usuário encontrado. Redirecionando..." }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { OK = true, Mensagem = "Usuário não encontrado." }, JsonRequestBehavior.AllowGet);
            }
        }


        // GET: Autenticacao
        public ActionResult Index()
        {
            return View();
        }
    }
}