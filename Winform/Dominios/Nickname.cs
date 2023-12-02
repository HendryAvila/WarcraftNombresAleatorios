using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dominios
{
    public class Nickname
    {
        public int id { get; set; }
        [DisplayName("NickName")]
        public string nicknames { get; set; }
        [DisplayName("Raza")]
        public string nombreraza { get; set; }
        [DisplayName("Genero")]
        public string genero { get; set; }
        [DisplayName("Clase")]
        public string NombreTipoPersonaje { get; set; }

    }
}
