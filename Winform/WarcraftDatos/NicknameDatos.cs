using Dominios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarcraftDatos
{
    public  class NicknameDatos
    {
        public void agregar(Nickname nuevo)//insertamos en la base de datos
        {
            WarcraftBaseDatos datos = new WarcraftBaseDatos();
            try
            {
                datos.SetearConsulta("insert into  Nicks (nicknames, NombreRaza, Genero, NombreTipoPersonaje) values ('" + nuevo.nickname + "','" + nuevo.Nombreraza +"', '" + nuevo.genero +"', '" + nuevo.TipoPersonaje +"' )");
                datos.ejecutarAccion();   
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
        public void modificar(Nickname modificar)
        {

        }
    }
}
