using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocalWebService.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public int Cedula { get; set; }
        public int IdSexo { get; set; }
    }
}