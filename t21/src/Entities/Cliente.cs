// -----------------------------------------------------------------------
// <copyright file="Cliente.cs" company="RestauranteDoCarlão">
// Copyright (c) RestauranteDoCarlão. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src.Entities
{
    public class Cliente
    {
        public HashSet<Pessoa> Pessoas { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public Mesa Mesa { get; set; }

        public Cliente(HashSet<Pessoa> pessoas, DateTime entrada, DateTime saida)
        {
            this. Pessoas = pessoas;
            this.Entrada = entrada;
            this.Saida = saida;
        }

        public mes OcuparMesa(Mesa mesa)
        {
            Mesa = mesa;
        }

        public Mesa DesocuparMesa()
        {

        }
    }
}
