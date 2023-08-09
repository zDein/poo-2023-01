using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src.Entities
{
    public class CentroDeVenda
    {
        private Funcionario Funcionario;
        private IList<Venda> ListaVendas;
        private IList<TrocaAPorB> TrocaBilhetes;

        public CentroDeVenda()
        {

            if (Funcionario.Cargo == Enums.Cargos.OperadorCaixa || Funcionario.Cargo == Enums.Cargos.Vendedor || Funcionario.Cargo == Enums.Cargos.Ajudante || Funcionario.Cargo == Enums.Cargos.Assistente)
            {
                ListaVendas = Funcionario.GetListaVendas();
            }
        }

        
    }   
}