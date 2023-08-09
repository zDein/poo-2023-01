// -----------------------------------------------------------------------
// <copyright file="Participante.cs" company="ParqueDeDiversões">
// Copyright (c) ParqueDeDiversões. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src.Interfaces
{
    public class Participante
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Participante(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
