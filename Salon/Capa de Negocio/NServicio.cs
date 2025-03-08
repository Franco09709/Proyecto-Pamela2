using Capa_de_Datos;
using Capa_de_Entidad;
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


        //Metodo para insertar productos

        public static string AgregarProducto(EServicio servicio)
        {
            return DServicio.InsertarServicios(servicio);
        }


    }
}
