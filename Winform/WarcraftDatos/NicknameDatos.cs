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
        private object comando;

        public void agregar(Nickname nuevo)//insertamos en la base de datos
        {
            WarcraftBaseDatos datos = new WarcraftBaseDatos();
            try
            {
                datos.SetearConsulta("insert into  Nicks (nicknames, NombreRaza, Genero, NombreTipoPersonaje) values ('" + nuevo.nicknames + "','" + nuevo.nombreraza +"', '" + nuevo.genero +"', '" + nuevo.NombreTipoPersonaje +"' )");
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
            WarcraftBaseDatos datos = new WarcraftBaseDatos();

            try
            {
                datos.SetearConsulta("update Nicks set nicknames = @nicknames, NombreRaza = @NombreRaza, Genero = @Genero, NombreTipoPersonaje = @NombreTipoPersonaje where id = @id");
            datos.SetearParametros("@nicknames", modificar.nicknames);
            datos.SetearParametros("@nombreraza", modificar.nombreraza);
            datos.SetearParametros("@genero", modificar.genero);
            datos.SetearParametros("@NombreTipoPersonaje", modificar.NombreTipoPersonaje);
            datos.SetearParametros("@id", modificar.id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }finally
            {
                datos.CerrarConexion();
            }       
        }
        public void Eliminar(int id)
        {
            try
            {
                WarcraftBaseDatos datos = new WarcraftBaseDatos();
                datos.SetearConsulta("Delete from Nicks where id = @id");
                datos.SetearParametros("@id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void EliminarLogico(int id)
        {
            WarcraftBaseDatos datos = new WarcraftBaseDatos();
            datos.SetearConsulta("UPDATE Nicks SET Activo = 0 WHERE id = @id");
            datos.SetearParametros("@id", id);
            datos.ejecutarAccion();
        }

    }
}

