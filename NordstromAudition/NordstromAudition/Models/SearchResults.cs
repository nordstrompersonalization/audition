using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NordstromAudition.DataServices;

namespace NordstromAudition.Models
{
    public class SearchResults
    {
        public List<SearchResult> _results;
        public void SetSearchResults(List<SearchResult> results)
        {
            _results = results;
        }

        public List<SearchResult> Results
        {
            get { return _results; }
        }
    }
}