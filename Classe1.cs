using System;

namespace Espaco{
    class Classe1{
        public string Nome { get; set; }
        public int NumeroConta { get; set; }
        public double Saldo { get; private set; }

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
                Console.WriteLine("Saldo insuficiente!");
            }
        }

        public override string ToString(){
            return "\n---------------------------------------------------\n" 
            + "Dados do usuário\n" 
            + "---------------------------------------------------\n" 
            + "Nome: " + Nome + "\nNumero da conta: " + NumeroConta + "\nSaldo diponível: " + Saldo
            + "\n---------------------------------------------------\n" ;
        }
    }
}