using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src.Entities
{
    public class Radio
    {
        private Guid IdentificadorRadio;

        public Radio()
        {
            IdentificadorRadio = Guid.NewGuid();
        }


        public override string ToString()
        {
            return $"Id. radio: {this.IdentificadorRadio}";
        }
    }
}
