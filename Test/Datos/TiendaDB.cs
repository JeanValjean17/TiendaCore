﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class TiendaDB
    {
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
    }
}