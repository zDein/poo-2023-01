using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src.Entities
{
    public class Posto
    {
        public Policia RepresentantePolicia { get; private set; }
        public Justica RespresentanteJustica { get; private set; }
        public IList<Pessoa> CriancasPerdidas { get; set; }

        public Posto()
        {
            CriancasPerdidas = new List<Pessoa>();
        }

        public void AddCriancaLista(Pessoa crianca)
        {
            CriancasPerdidas.Add(crianca);
        }

        public void GetCriancas()
        {
            if (CriancasPerdidas.Count == 0)
            { 
                Console.WriteLine("Não há crianças perdidas!");
            }
            else
            {
                Console.WriteLine("Lista de crianças perdidas:");
                foreach (var crianca in CriancasPerdidas)
                {
                    Console.WriteLine(crianca);
                }
                Console.WriteLine("Quantidade de crianças perdidas: " + CriancasPerdidas.Count);
            }
        }

        public void SetRepresentantes(Policia representantePolicia, Justica respresentanteJustica)
        {
            this.RepresentantePolicia = representantePolicia;
            this.RespresentanteJustica = respresentanteJustica;
        }
    }
}
