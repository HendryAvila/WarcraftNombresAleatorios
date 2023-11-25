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
       public  List<NicknamesMostrar> MostrarNicks()
        {
            List<NicknamesMostrar> listaMostrar = new List<NicknamesMostrar>();
            WarcraftBaseDatos datos = new WarcraftBaseDatos();

            try
            {
                datos.SetearConsulta("select nicknames, NombreRaza, Genero, NombreTipoPersonaje from Nicks");
                datos.Ejecutarlectura();

                while (datos.Lector.Read())

                {
                    NicknamesMostrar aux = new NicknamesMostrar();
                    if (!(datos.Lector["nicknames"] is DBNull))
                    aux.nicknames = (string)datos.Lector["nicknames"];
                    if (!(datos.Lector["NombreRaza"] is DBNull))
                        aux.raza= (string)datos.Lector["NombreRaza"];
                    if (!(datos.Lector["Genero"] is DBNull))
                        aux.genero = (string)datos.Lector["Genero"];
                    if (!(datos.Lector["NombreTipoPersonaje"] is DBNull))
                        aux.tipopersonaje = (string)datos.Lector["NombreTipoPersonaje"];

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
