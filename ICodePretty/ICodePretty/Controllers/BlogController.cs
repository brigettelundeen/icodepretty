using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICodePretty.Controllers
{
    public class BlogController : Controller
    {
        //
        // GET: /Blog/name

        public ActionResult Search(string name)
        {
            ViewBag.message = Server.HtmlEncode(name);

            return View();
        }
    }
}
