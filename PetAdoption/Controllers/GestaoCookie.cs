using System;
using System.Web;

namespace PetAdoption.Controllers
{
    internal class GestaoCookie
    {
        public static void CriarCookie(int IdUsuario)
        {
            HttpCookie cookieUsuario = new HttpCookie("CookieUsuario");
            cookieUsuario.Values["IdUsuario"] = IdUsuario.ToString();
            cookieUsuario.Expires = DateTime.Now.AddDays(1);
            HttpContext.Current.Response.Cookies.Add(cookieUsuario);
        }
    }
}