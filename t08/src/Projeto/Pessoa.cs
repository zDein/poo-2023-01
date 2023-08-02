using System;
using System.Collections.Generic;

namespace CSharp.Entites.Projeto
{
    class Pessoa
    {
        // Criando um contrutor para mostrar a que projeto esta pessoa foi alocada
        public Pessoa(Projeto p)
        {
            p.NovaPessoa(this);
        }
    }
}