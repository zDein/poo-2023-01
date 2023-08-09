using Src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src.Entities
{
    public class Crianca : Visitante
    {
        public IParticipante Acompanhante { get; private set; }


        /// <summary>
        /// Inicia uma nova instância da classe <see cref="Crianca"/>.
        /// </summary>
        public Crianca()
        {
        }

        public void SetAcompanhante(Parente acompanhante) 
        {
        }
    }
}
