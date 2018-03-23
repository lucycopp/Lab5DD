using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lab5.Controllers
{
    public class TranslateController : ApiController
    {
        // GET: api/Translate
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("api/Translate/{input}")]
        public string Get(string input)
        {
            return Request.CreateResponse().ToString();
        }
        [HttpGet]
        [Route("api/Translate/GetId")]
        public string GetId([FromUri]int id)
        {
            return "Your id is: " + id;
        }

        // GET: api/Translate/5
        [HttpGet]
        [Route("api/Translate/GetNumber")]
        public string GetNumber([FromUri]int number)
        {
            number += 100;
            return "Your number plus 100 is " + number.ToString();
        }

        // POST: api/Translate
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Translate/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Translate/5
        public void Delete(int id)
        {
        }
    }
}
