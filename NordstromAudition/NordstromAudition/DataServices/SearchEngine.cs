using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Reflection;
using System.IO;

namespace NordstromAudition.DataServices
{
    public class SearchEngine
    {
        public SearchResult[] Search()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var stream = new StreamReader(assembly.GetManifestResourceStream("NordstromAudition.App_Data.Database.json"));
            var products = stream.ReadToEnd();
            var results = JsonConvert.DeserializeObject<SearchResult[]>(products);
            return results;
        }

        public SearchResult Find(string style_id)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var stream = new StreamReader(assembly.GetManifestResourceStream("NordstromAudition.App_Data.Database.json"));
            var products = stream.ReadToEnd();
            var results = JsonConvert.DeserializeObject<SearchResult[]>(products);
            var result = results.Where(r => r.Style_Id.Equals(style_id));
            return result.First();
        }
    }
}