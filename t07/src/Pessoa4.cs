using System;

namespace CSharp.Entities{
    abstract class Pessoa2{
        private string _endereco;
        public string Nome { get; set;}
    } 

    class PessoaFisica : Pessoa2{
        private string _cpf;
        public string CorPele { get; set;}
    }

    class PessoaJuridica : Pessoa2 {
        private string _cnpj;
        public string NomeFantasia { get; set; }
    }
}