using System;

namespace CSharp.Entities{
    class Prova{
        private byte _numQuestoes;

        public byte getNumQuestoes(){
            return _numQuestoes;
        }

        public void setNumQuestoes(byte n){
            if(n > 0){
                _numQuestoes = n;
            }
        }
    }
}