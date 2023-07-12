using System;

namespace src.Entities.Computador
{
    class CPU
    {
        public CPU(Memoria memoria)
        {
            _memoria = memoria;
        }	

        private Memoria _memoria;
    }
}