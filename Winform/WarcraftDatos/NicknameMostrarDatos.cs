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
        public List<Nickname> MostrarNicks()
        {
            List<Nickname> listaMostrar = new List<Nickname>();
            WarcraftBaseDatos datos = new WarcraftBaseDatos();

            try
            {
                datos.SetearConsulta("select  id, nicknames, NombreRaza, Genero, NombreTipoPersonaje from Nicks where Activo = 1");
                datos.Ejecutarlectura();

                while (datos.Lector.Read())

                {
                    Nickname aux = new Nickname();
                    if (!(datos.Lector["id"] is DBNull))
                        aux.id = (int)datos.Lector["id"];
                    if (!(datos.Lector["nicknames"] is DBNull))
                        aux.nicknames = (string)datos.Lector["nicknames"];
                    if (!(datos.Lector["NombreRaza"] is DBNull))
                        aux.nombreraza = (string)datos.Lector["NombreRaza"];
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
        public List<Nickname> filtrar(string campo, string criterio, string filtro)
        {
            List<Nickname> lista = new List<Nickname>();
            WarcraftBaseDatos datos = new WarcraftBaseDatos();
            try
            {
                string consulta = "select  id, nicknames, NombreRaza, Genero, NombreTipoPersonaje from Nicks where Activo = 1 and ";
                if (campo == "ID")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "Id > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "id < " + filtro;
                            break;
                        default:
                            consulta += "id = " + filtro;
                            break;
                    }
                }
                else if (campo == "Nicknames")

                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Nicknames like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "Nicknames like '" + filtro + "%' ";
                            break;
                        default:
                            consulta += "Nicknames like '" + filtro + "%' ";
                            break;
                    }
                }
                else if (campo == "Raza")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "nombrenombreraza like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "nombreraza like '" + filtro + "%' ";
                            break;
                        default:
                            consulta += "nombreraza like '" + filtro + "%' ";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "NombreTipoPersonaje like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "NombreTipoPersonaje like '" + filtro + "%' ";
                            break;
                        default:
                            consulta += "NombreTipoPersonaje like '" + filtro + "%' ";
                            break;
                    }
                }


                datos.SetearConsulta(consulta);
                datos.Ejecutarlectura();
                while (datos.Lector.Read())

                {
                    Nickname aux = new Nickname();
                    if (!(datos.Lector["id"] is DBNull))
                        aux.id = (int)datos.Lector["id"];
                    if (!(datos.Lector["nicknames"] is DBNull))
                        aux.nicknames = (string)datos.Lector["nicknames"];
                    if (!(datos.Lector["NombreRaza"] is DBNull))
                        aux.nombreraza = (string)datos.Lector["NombreRaza"];
                    if (!(datos.Lector["Genero"] is DBNull))
                        aux.genero = (string)datos.Lector["Genero"];
                    if (!(datos.Lector["NombreTipoPersonaje"] is DBNull))
                        aux.NombreTipoPersonaje = (string)datos.Lector["NombreTipoPersonaje"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
