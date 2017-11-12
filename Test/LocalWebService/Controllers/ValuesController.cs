using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LocalWebService.Controllers
{
    [System.Web.Http.RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        // GET api/values
        [System.Web.Http.HttpGet]
        public IHttpActionResult Get()
        {
            return Ok("Ok");
        }

        // GET api/values/5
        [HttpGet]
        [System.Web.Http.Route("leer/{cara}")]
        public int leer(int cara)
        {
            return cara;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
