using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src.Entities
{
    public class Ocorrencia
    {
        public Guid IdentificadorOcorrencia { get; set; }
        public string LocalOcorrencia { get; private set; }
        public DateTime HoraOcorrencia { get; private set; }
        public string DescricaoOcorrencia { get; private set; }

        public Ocorrencia()
        {
            IdentificadorOcorrencia = Guid.NewGuid();
            HoraOcorrencia = DateTime.Now;
        }

        public void SetLocalOcorrencia(string localOcorrencia)
        {
            this.LocalOcorrencia = localOcorrencia;
        }

        public void SetDescricaoOcorrencia(string descricaoOcorrencia)
        {
            this.DescricaoOcorrencia = descricaoOcorrencia;
        }

    }
}
