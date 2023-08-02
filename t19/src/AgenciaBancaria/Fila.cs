// <copyright file="Fila.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Src.AgenciaBancaria
{
    public class Fila
    {
        public SortedSet<Cliente> Clientes { get; set; }

        public void AddClientesFila(Cliente cliente)
        {
            Clientes.Add(cliente);
        }
    }
}
