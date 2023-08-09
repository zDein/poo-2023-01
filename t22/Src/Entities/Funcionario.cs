using Src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Src.Enums;

namespace Src.Entities
{
    public class Funcionario : Trabalhador
    {
        public Cargos Cargo { get; private set; }
        private double Remuneracao;
        public Guid Identificador { get; set; }
        public double Escala { get; private set; }
        private Radio Radio;

        private IList<Venda> ListaVendas;

        // Iniciando os objetos da subclasse e da classe base (superclasse)
        public Funcionario(string nome, int idade, Cargos cargo) : base(nome, idade)
        {
            Identificador = Guid.NewGuid();
            this.Cargo = cargo;
            if (Cargo == Cargos.Vendedor || Cargo == Cargos.OperadorCaixa || Cargo == Cargos.Assistente || Cargo == Cargos.Ajudante)
            {
                ListaVendas = new List<Venda>();
            }
            Radio = new Radio();
        }

        public void SetRemuneracao(double remuneracao)
        {
            this.Remuneracao = remuneracao;
        }
        public void SetEscala(double escala)
        {
            this.Escala = escala;
        }

        public IList<Venda> GetListaVendas()
        {
            return this.ListaVendas;
        }
    }
}
