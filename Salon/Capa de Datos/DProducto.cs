using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_Entidad;

namespace Capa_de_Datos
{
    public class DProducto
    {
        //Metodo para listar los productos

        public static DataTable ListarProducto()
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                //Obteniendo la cadena de conexion
                Sqlcon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Productos_Listar", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                if (Sqlcon.State == ConnectionState.Open)
                {
                    Sqlcon.Close();
                }
            }

        }

        //Metodo para insertar productos

        public static string InsertarProductos(EProducto producto)
        {
            string Resultado = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("[Productos_insertar_sin_fotos]", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;

                //Parametros de entrada
                comando.Parameters.Add("@NombreProducto", SqlDbType.NVarChar).Value = producto.NombreProducto;
                comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = producto.Precio;
                comando.Parameters.Add("@Proveedor", SqlDbType.NVarChar).Value = producto.Proveedor;

                //Parametro de salida

                //El 2 indica que el campo NVARCHAR tendrá un máximo de 2 caracteres (puede ser "Si" o "No" en este caso).
                SqlParameter paramEncontrado = new SqlParameter("@Encontrado", SqlDbType.NVarChar, 2);
                paramEncontrado.Direction = ParameterDirection.Output;
                comando.Parameters.Add(paramEncontrado);
                
                sqlcon.Open();
                //Ejecutamos el procedimiento almacenado
                comando.ExecuteNonQuery();

                //Obtenemos el resultado del parametro de salida
                string Encontrado= paramEncontrado.Value.ToString();

                if (Encontrado == "Si")
                    Resultado = "Existe";
                else
                    Resultado = "Ok";

            }
            catch (Exception ex)
            {
                Resultado = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return Resultado;
        }










    }
}
