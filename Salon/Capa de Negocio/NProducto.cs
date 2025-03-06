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
    public class NProducto
    {   

        //Metodo de listar productos
        public static DataTable ListarProducto()
        {
            
            return DProducto.ListarProducto();
        }

        //Metodo para insertar productos

        public static string AgregarProducto(EProducto producto)
        {
            return DProducto.InsertarProductos(producto);
        }




    }
}
