using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetAdoption.Helpers
{
    public static class ImageHelper
    {

        public static MvcHtmlString ExibeImagem(this HtmlHelper hp)
        {
            string str = "<div style=\"width:100%; text-align:center; padding:10px\">" +
                          "<div style=\"width:300px; height:225px; margin:5px; display:inline-block\">" +
                          "<img src=\"Resources/Cachorro.jpg\" style=\"width:300px;\"/></div>" +
                          "</div>";

            return new MvcHtmlString(str);
        }

    }
}