using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCore
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public DateTime FechaFacturacion { get; set; }
        public int CodigoFactura { get; set; }
        public string Despachador { get; set; }
        public int IdCliente { get; set; }
        public int IdTienda { get; set; }
    }
}
