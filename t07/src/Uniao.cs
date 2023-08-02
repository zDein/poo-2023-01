using System;
using System.Collections;

namespace CSharp.Entities
{
    class Uniao
    {
        private ArrayList _filhos;
        private PessoaUML[] _parceiros = new PessoaUML[2];

        public void novoFilho(PessoaUML p)
        {
            _filhos.Add(p);
        }

        public Uniao(PessoaUML a, PessoaUML b)
        {
            _parceiros[0] = a;
            _parceiros[1] = b;
        }
    }
}