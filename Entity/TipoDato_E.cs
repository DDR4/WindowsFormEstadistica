using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TipoDato_E
    {
        public int tipodato { get; set; }
        public List<decimal> datadecimal = new List<decimal>(); 
        public List<string> datatexto = new List<string>();
    }
}
