using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SentenceBackend.Models;
using SentenceBackend.Service;

namespace SentenceBackend.Controllers
{
    public class SentenceController : ApiController
    {
        // GET api/sentence
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/sentence/5
        public List<string> Get(int id)
        {
           string name = Enum.GetName(typeof(WordTypes), id);
           return DataLayerHandler.GetWordsByType(name);
        }


        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
