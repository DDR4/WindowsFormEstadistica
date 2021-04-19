using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DatosTotales_E 
    {
        public decimal sumatotal { get; set; }
        public int cantidatotal { get; set; }    
        public int maximafrecuencia { get; set; }
        public int nummediana { get; set; }
        public List<Mediana_E> ltmediana = new List<Mediana_E>();
    }
}
