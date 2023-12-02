using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominios
{
   public class Genero
    {
        public int id { get; set; }
        public string Generos { get; set; }
        public override string ToString()
        {
            return Generos;
        }
        
    }
}
