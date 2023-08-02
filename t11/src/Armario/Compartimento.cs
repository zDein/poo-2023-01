using System;
using System.Collections.Generic;

namespace CSharp.Entities
{
    public class Compartimento
    {
        public Livro[] Livro { get; set; }
        public List<CD> Cd { get; set; }
    }
}