using System;

namespace CSharp.Entities{
    abstract class Pessoa{
        private string _endereco;
        public string Nome { get; set;}
    } 

    class PessoaFisica : Pessoa{
        private string _cpf;
        public string CorPele { get; set;}
    }

    class PessoaJuridica : Pessoa {
        private string _cnpj;
        public string NomeFantasia { get; set; }
    }
}