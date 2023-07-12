using System;
using System.Collections.Generic;

namespace src.Entities.Lanchonete
{
    public class Item
    {
        private Bebida? _bebida;
        private Sanduiche? _sanduiche;

        private List<Detalhe> Detalhes { get; set; }
    }
}