using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCore
{
    public static class MasterLogica
    {
        public static Cliente ObtenerCliente(int identificacion)
        {
            Datos.cliente dbCliente = Datos.TiendaDB.ObtenerCliente(identificacion);

            Cliente oCliente = new Cliente();

            oCliente.Cedula = (int)dbCliente.cedula;
            oCliente.IdCliente = dbCliente.id_cliente;
            oCliente.IdSexo = (int)dbCliente.id_sexo;
            oCliente.Nombre = dbCliente.nombre;

            return oCliente;
        }        

        #region Métodos de Registro
        public static bool RegistrarFactura(DateTime fechaFacturacion, int codigoFactura, string nombreDespachador, string nombreCliente, string nombreTienda)
        {
            return Datos.TiendaDB.RegistrarFactura(fechaFacturacion, codigoFactura, nombreDespachador, nombreCliente, nombreTienda);
        }


        public static bool RegistrarProducto(string nombreProducto, string nombreUnidad)
        {
            return Datos.TiendaDB.RegistrarProducto(nombreProducto, nombreUnidad);
        }

        public static bool RegistrarTienda(string nombreTienda, string direccion, string nit)
        {
            return Datos.TiendaDB.RegistrarTienda(nombreTienda, direccion, nit);
        }

        public static bool RegistrarProgramacionPrecio(double precio, DateTime fechaInicio, DateTime fechaFin, string nombreProducto)
        {
            return Datos.TiendaDB.RegistrarProgramacionPrecio(precio, fechaInicio, fechaFin, nombreProducto);
        }

        public static bool RegistrarMedioPago(string nombre)
        {
            return Datos.TiendaDB.RegistrarMedioPago(nombre);
        }

        public static bool RegistrarCliente(string nombre, int cedula, int sexo)
        {
            return Datos.TiendaDB.RegistrarCliente(nombre, cedula, sexo);
        }

        public static bool RegistrarUnidad(string nombreUnidad)
        {
            return Datos.TiendaDB.RegistrarUnidad(nombreUnidad);
        } 
        #endregion

    }
}
