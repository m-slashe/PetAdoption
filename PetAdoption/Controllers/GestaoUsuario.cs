using PetAdoption.Models;
using System;
using System.Linq;

namespace PetAdoption.Controllers
{
    internal class GestaoUsuario
    {

        public static bool VerificarUsuarioBD(string login, string senha)
        {
            try
            {
                DatabaseContext db = new DatabaseContext();
                var usuario = db.Usuario.Where(x => x.Login == login && x.Senha == senha).SingleOrDefault();
                if(usuario == null)
                {
                    return false;
                }
                else
                {
                    GestaoCookie.CriarCookie(usuario.Id);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}