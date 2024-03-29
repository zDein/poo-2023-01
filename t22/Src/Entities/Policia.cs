﻿// -----------------------------------------------------------------------
// <copyright file="Policia.cs" company="ParqueDeDiversões">
// Copyright (c) ParqueDeDiversões. All rights reserved.
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
    public class Policia : Trabalhador
    {
        /// <summary>
        /// Inicia uma nova instância da classe <see cref="Policia"/>.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="idade"></param>
        public Policia(string nome, int idade)
            : base(nome, idade)
        {
        }
    }
}
