using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NordstromAudition.DataServices;

namespace NordstromAudition.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Detail(string id)
        {
            SearchEngine searchengine = new SearchEngine();
            var result = searchengine.Find(id);
            return View(result);
        }
    }
}
