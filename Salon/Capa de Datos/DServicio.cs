using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_Datos
{
    public class DServicio
    {

        //Metodo para listar los servicios
        public DataTable ListarServicios()
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                //Obteniendo la cadena de conexion
                Sqlcon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Servicios_Listar", Sqlcon);
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
    }
}
