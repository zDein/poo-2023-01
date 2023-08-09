// -----------------------------------------------------------------------
// <copyright file="Trabalhador.cs" company="ParqueDeDiversões">
// Copyright (c) ParqueDeDiversões. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using Src.Enums;
using Src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src.Entities
{
    public class Trabalhador : Participante
    {
        /// <summary>
        /// Inicia uma nova instância da classe <see cref="Trabalhador"/>.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="idade"></param>
        public Trabalhador(string nome, int idade)
            : base(nome, idade)
        {
        }
    }
}
