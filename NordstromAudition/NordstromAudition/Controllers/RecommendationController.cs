using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NordstromAudition.DataServices;

namespace NordstromAudition.Controllers
{
    public class RecommendationController : ApiController
    {
        // GET api/recommendation
        public IEnumerable<SearchResult> Get(string styleid)
        {
            var s = new SearchEngine();
            //simiulating a recommendation system
            var recommendations = s.Search()
                .Where(item => !item.Style_Id.Equals(styleid))
                .Take(6);
            return recommendations;
        }
    }
}
