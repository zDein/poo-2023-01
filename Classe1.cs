using System;

namespace Espaco{
    class Classe1{
        public int NumeroConta { get; set; }
        public double Saldo { get; private set; }
        public string Telefone { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Classe1(){
            Saldo = 0;
        }

        public Classe1(string nome, int numeroConta) : this()
        {
            this.Nome = nome;
            this.NumeroConta = numeroConta;
        }

        public void adicionarSaldo(double valor){
            Saldo += valor;
        }

        public void saqueSaldo(double valor){
            if(Saldo>-1000&&(Saldo-valor)>=-1000){
                Saldo -= valor;
            }else{
                Console.WriteLine("\nSaldo insuficiente!\n");
            }
        }

        public override string ToString(){
            return "\n---------------------------------------------------\n" 
            + "Dados do usuário\n" 
            + "---------------------------------------------------\n" 
            + "Nome: " + Nome + "\nCPF: " + Cpf + "\nNumero da conta: " + NumeroConta + "\nTelefone para contato: " + Telefone + "\nSaldo diponível: R$" + Saldo
            + "\n---------------------------------------------------\n" ;
        }
    }
}