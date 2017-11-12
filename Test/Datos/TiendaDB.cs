using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class TiendaDB
    {
        static CapacitacionEntities dbContext = new CapacitacionEntities();


        public static bool RegistrarUnidad(string nombreUnidad)
        {
            using (var context = new CapacitacionEntities())
            {
                try
                {
                    context.registrar_unidad(nombreUnidad);
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static bool RegistrarCliente(string nombre, int cedula, int sexo)
        {
            try
            {
                dbContext.registrar_cliente(nombre, cedula, sexo);
                return true;
            }
            catch(Exception ex)
            {                
                throw ex;
            }
        }

        public static bool RegistrarMedioPago(string nombre)
        {
            try
            {
                dbContext.registrar_medio_pago(nombre);                
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool RegistrarProgramacionPrecio(double precio, DateTime fechaInicio, DateTime fechaFin, string nombreProducto)
        {
            try
            {
                dbContext.registrar_programacion_precio(precio, fechaInicio, fechaFin, nombreProducto);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool RegistrarTienda(string nombreTienda, string direccion, string nit)
        {
            using (var context = new CapacitacionEntities())
            {
                try
                {
                    context.registrar_tienda(nombreTienda, nit, direccion);
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static bool RegistrarProducto(string nombreProducto, string nombreUnidad)
        {
            try
            {
                dbContext.registrar_producto(nombreProducto, nombreUnidad);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool RegistrarFactura(DateTime fechaFacturacion, int codigoFactura, string nombreDespachador, string nombreCliente, string nombreTienda)
        {
            try
            {
                dbContext.registrar_factura(fechaFacturacion, codigoFactura, nombreDespachador, nombreCliente, nombreTienda);
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static cliente ObtenerCliente(int identificacion)
        {
            
            using (var context = new CapacitacionEntities())
            {
                try
                {
                    var oCliente = from c in context.clientes
                               where c.cedula == identificacion
                               select c;
                    return oCliente.FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        
    }
}
