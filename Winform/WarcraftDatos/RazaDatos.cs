using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominios;

namespace WarcraftDatos
{
    public class RazaDatos
    {
        public List<Raza> ListarRaza()
        {
            List<Raza> lista = new List<Raza>();
            WarcraftBaseDatos datos = new WarcraftBaseDatos();
            try
            {
                datos.SetearConsulta("select NombreRaza, UrlImagen from Raza");
                datos.Ejecutarlectura();

                while (datos.Lector.Read())
                {
                    Raza aux = new Raza();

                    aux.Nombreraza = (string)datos.Lector["NombreRaza"]; // Cambiado el tipo de aux a string
                    aux.UrlImagen = (string)datos.Lector["UrlImagen"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
