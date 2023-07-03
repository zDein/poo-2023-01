using System;
using System.Collections.Generic;

namespace CSharp.Entites.Projeto
{
    class Projeto
    {
        // Lista ligad avazia de pessoas para o projeto
        private List<Pessoa> P;

        public void NovaPessoa(Pessoa p)
        {
            P.Add(p);
        }
    }
}