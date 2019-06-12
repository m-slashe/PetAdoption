using PetAdoption.Models;
using System;
using System.Linq;

namespace PetAdoption.Controllers
{
    internal class GestaoUsuario
    {

        public static bool VerificarUsuarioBD(string email, string senha)
        {
            try
            {
                PetAdoptionContextEntities1 db = new PetAdoptionContextEntities1();
                var usuario = db.Usuario.Where(x => x.Email == email && x.Senha == senha).SingleOrDefault();
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