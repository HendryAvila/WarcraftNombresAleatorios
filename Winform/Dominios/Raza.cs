using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominios
{
    public class Raza
    {
        public int id { get; set; }
        public string Nombreraza { get; set; }
        public string UrlImagen { get; set; }
        public override string ToString()
        {
            return Nombreraza;
        }

    }
}
