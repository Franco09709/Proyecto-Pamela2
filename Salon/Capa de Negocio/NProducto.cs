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

        public static string ActualizarProducto(EProducto producto)
        {
            //Si nombre anterior es igual al nombre del producto hacer el update
            if (producto.NombreAnterior == producto.NombreProducto)
            {
                return DProducto.ActualizarProductos(producto);
            }
            //De lo contrario verificar en la base de datos
            else
            {   
                
                string Resultado= DProducto.Producto_ActualizarExiste(producto);
                if (Resultado.Equals("Si"))
                {
                    return "Existe";
                }
                else
                {
                    return DProducto.ActualizarProductos(producto);
                }

            }
            


            
        }


    }
}
