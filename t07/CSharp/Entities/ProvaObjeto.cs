using System;

namespace CSharp.Entities
{
    class Program{
        static void Main(String[] args){
            Prova pf = new Prova();

            pf.setNumQuestoes(50);

            Console.WriteLine(pf.getNumQuestoes());
        }
    }

    class Prova{
        private byte _numQuestoes;

        public byte getNumQuestoes(){
            return _numQuestoes;
        }

        public void setNumQuestoes(byte n){
            if(n>0){
                _numQuestoes = n;
            }
        }
    }
}