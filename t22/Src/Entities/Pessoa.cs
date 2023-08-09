using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src.Entities
{
    public class Pessoa
    {
        public IList<Ocorrencia> Ocorrencias { get; private set; }
        public bool IsVisitante { get; private set; }
        public bool IsFuncionario { get; private set; }
    }
}
