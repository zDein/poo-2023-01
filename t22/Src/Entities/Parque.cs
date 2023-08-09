using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src.Entities
{
    public class Parque
    {
        public string NomeParque { get; private set; }
        public HashSet<Pessoa> Pessoas{ get; private set; }
        public Pessoa Direcao { get; private set; }

        /// <summary>
        /// Inicia uma nova instância da classe <see cref="Parque"/>.
        /// </summary>
        /// <param name="nomeParque"></param>
        /// <param name="direcao"></param>
        public Parque(string nomeParque, Pessoa direcao)
        {
            this.Pessoas = new HashSet<Pessoa>();
            this.NomeParque = nomeParque;
            this.Direcao = direcao;
        }

        public void AddPessoas(Pessoa pessoa) => this.Pessoas.Add(pessoa);
    }
}
