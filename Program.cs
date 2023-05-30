using System;
using System.Globalization;

namespace Espaco{
    class Classe{
        static void Main(){

            Classe1 p = new Classe1("Não informado", 0000);

            int op, numeroConta;
            double valor;

            do{
                menu();
                op = Convert.ToInt16(Console.ReadLine());
                switch(op){
                    case 1:
                        Console.WriteLine(p);
                        break;
                    case 2:
                        Console.Write("Informe o nome: ");
                        string nome = Console.ReadLine();
                        p.Nome = nome;
                        break;
                    case 3:
                        Console.Write("Informe o numero da conta: ");
                        do{
                            numeroConta = Convert.ToInt16(Console.ReadLine());
                            if(numeroConta<1000&&numeroConta>9999){
                                Console.WriteLine("Numero da conta inválido, tente outro!!!");
                            }
                        }while(numeroConta<1000&&numeroConta>9999);
                        p.NumeroConta = numeroConta;
                        break;
                    case 4:
                        Console.Write("Informe o valor que deseja adicionar ao saldo: ");
                        valor = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                        p.adicionarSaldo(valor);
                        break;
                    case 5:
                        Console.Write("Informe o valor que deseja fazer saque: ");
                        valor = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                        p.saqueSaldo(valor);
                        break;
                }


            }while(op!=6);
        }

        static void menu(){
            Console.WriteLine("1- Mostrar dados;");
            Console.WriteLine("2- Inserir nome de usuario;");
            Console.WriteLine("3- Inserir numero da conta;");
            Console.WriteLine("4- Depositar dinheiro;");
            Console.WriteLine("5- Sacar dinheiro");
            Console.WriteLine("6- Sair;");
        }
    }


}