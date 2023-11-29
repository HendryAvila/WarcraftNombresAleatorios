using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominios
{
    public class TipoPersonaje
    {
        public int id { get; set; }
        public string nombreTipoPersonaje { get; set; }
        public override string ToString()
        {
            return nombreTipoPersonaje;
        }

    }
}
