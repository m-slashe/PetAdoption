using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetAdoption.Helpers
{
    public static class TitleHelper
    {
        public static MvcHtmlString ExibeTitle(this HtmlHelper hp)
        {
            string str = "<h1>Pet Adoption</h1>";

            return new MvcHtmlString(str);
        }

    }
}