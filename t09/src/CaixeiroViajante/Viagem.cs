using System;
using System.Collections.Generic;

namespace CSharp.Entities.CaixeiroViajante
{
    public class Viagem
    {
        public List<Cidade> Cidades { get; set; }
        public static List<ListaPedidos> ListaPedidos { get; set; }
    }
}