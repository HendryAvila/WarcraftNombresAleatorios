using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominios;

namespace WarcraftDatos
{
    public class TipoPersonajeDato
    {
        public List<TipoPersonaje> ListarClase()
        {
            List<TipoPersonaje> lista = new List<TipoPersonaje>();
            WarcraftBaseDatos datos = new WarcraftBaseDatos();
            try
            {
                datos.SetearConsulta("select NombreTipoPersonaje from TipoDePersonaje");
                datos.Ejecutarlectura();

                while (datos.Lector.Read())
                {
                    TipoPersonaje aux = new TipoPersonaje();
                    aux.nombreTipoPersonaje = (string)datos.Lector["NombreTipoPersonaje"];
                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
