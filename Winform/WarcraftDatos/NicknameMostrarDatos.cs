using Dominios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominios;

namespace WarcraftDatos
{
    public class NicknameMostrarDatos
    {
       public  List<Nickname> MostrarNicks()
        {
            List<Nickname> listaMostrar = new List<Nickname>();
            WarcraftBaseDatos datos = new WarcraftBaseDatos();

            try
            {
                datos.SetearConsulta("select  id, nicknames, NombreRaza, Genero, NombreTipoPersonaje from Nicks");
                datos.Ejecutarlectura();

                while (datos.Lector.Read())

                {
                    Nickname aux = new Nickname();
                    if (!(datos.Lector["id"] is DBNull))
                        aux.id = (int)datos.Lector["id"];
                    if (!(datos.Lector["nicknames"] is DBNull))
                    aux.nicknames = (string)datos.Lector["nicknames"];
                    if (!(datos.Lector["NombreRaza"] is DBNull))
                        aux.nombreraza= (string)datos.Lector["NombreRaza"];
                    if (!(datos.Lector["Genero"] is DBNull))
                        aux.genero = (string)datos.Lector["Genero"];
                    if (!(datos.Lector["NombreTipoPersonaje"] is DBNull))
                        aux.NombreTipoPersonaje = (string)datos.Lector["NombreTipoPersonaje"];

                    listaMostrar.Add(aux);
                }


             
            return listaMostrar;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
