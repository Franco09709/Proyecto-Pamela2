using Capa_de_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_Negocio
{
    public class NServicio
    {
        public static DataTable ListarServicio()
        {
            DServicio Datos = new DServicio();
            return Datos.ListarServicios();
        }


    }
}
