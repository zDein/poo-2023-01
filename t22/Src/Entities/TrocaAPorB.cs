using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src.Entities
{
    public class TrocaAPorB
    {
        public Guid NovoNumSerie { get; set; }
        private DateTime _date;
        private DateTime _hora;
        private Bilhete _diferença;
    }
}
