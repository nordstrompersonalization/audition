using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NordstromAudition.DataServices;
using NordstromAudition.Models;

namespace NordstromAudition.Controllers
{
    public class SearchController : Controller
    {
        public ActionResult Results()
        {
            SearchEngine searchengine = new SearchEngine();
            var model = new SearchResults();
            var results = searchengine.Search();
            model.SetSearchResults(results.ToList<SearchResult>());
            return View(model);
        }
    }
}
