using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominios;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace WarcraftDatos
{
    public class WarcraftBaseDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get{ return lector; }
        }

        public WarcraftBaseDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS;database=WorldOfWarcraftNombres; integrated security = true");
            comando = new SqlCommand();
        }

        public void SetearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void Ejecutarlectura()
        {
            comando.Connection = conexion;
            try
            {
            conexion.Open();
            lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void CerrarConexion()
        {
            if (lector != null)
            {
                lector.Close();
                conexion.Close();
            }
        }
        public void ejecutarAccion()
        {
                comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void SetearParametros(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

    }
}
