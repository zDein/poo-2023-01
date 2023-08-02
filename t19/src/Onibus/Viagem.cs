// <copyright file="Viagem.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Src.Onibus
{
    public class Viagem
    {
        public SortedSet<Passageiro> Passageiros { get; set; }
        public Motorista Motorista { get; set; }
        public Cidade Origem { get; set; }
        public Cidade Destino { get; set; }
    }
}
