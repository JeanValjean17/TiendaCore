using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using TiendaCore;
using System.Web.Http;
using System.Web.Http.Description;

namespace LocalWebService.Controllers
{
    [System.Web.Http.RoutePrefix("api/clientes")]
    public class ClientesController : ApiController
    {
        // GET api/values
        [HttpGet]
        [ResponseType(typeof(Cliente))]
        [Route("obtenercliente/{identificacion}")]
        public IHttpActionResult ObtenerCliente(int identificacion)
        {
            Cliente oCliente = MasterLogica.ObtenerCliente(identificacion);

            return Ok(oCliente);
        }
    }
}
