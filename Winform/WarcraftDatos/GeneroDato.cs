using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominios;

namespace WarcraftDatos
{
    public class GeneroDato
    {
        public List<Genero> ListarGeneros()
        {
            List<Genero> lista = new List<Genero>();
            WarcraftBaseDatos datos = new WarcraftBaseDatos();// esto es para instanciar la clase datos y manipularlo aqui
            try
            {
                datos.SetearConsulta("select Genero from Genero");
                datos.Ejecutarlectura();
                while (datos.Lector.Read())
                {
                    Genero aux = new Genero();
                    aux.Generos = (string)datos.Lector["Genero"];
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
