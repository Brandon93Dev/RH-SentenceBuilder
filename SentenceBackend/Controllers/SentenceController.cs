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
            return DataLayerHandler.GetAllSentences();
        }

        // GET api/sentence/5
        public List<string> Get(int id)
        {
            string name = Enum.GetName(typeof(WordTypes), id);
            List<string> outData = DataLayerHandler.GetWordsByType(name);
            return outData;
        }

        // POST api/sentence
        public void Post([FromBody] PostVals value)
        {
            DataLayerHandler.InsertSentence(value.value);
        }

        // PUT api/sentence/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/sentence/5
        public void Delete(int id)
        {
        }
    }

    public class PostVals
    {
        public string value { get; set; }
    }
}
