using System;
using System.Collections.Generic;

namespace CSharp.Entities.Habitos
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Habitos> Habitos { get; set; }
    }
}