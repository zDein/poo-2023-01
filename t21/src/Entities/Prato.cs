// -----------------------------------------------------------------------
// <copyright file="Prato.cs" company="RestauranteDoCarlão">
// Copyright (c) RestauranteDoCarlão. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Src.Entities
{
    public class Prato
    {
        private Preco preco;

        private String nome;

        private HashSet<DiaDaSemana> dias;

        public bool servidoEm(DiaDaSemana dia)
        {
            foreach (var item in DiasDaSemana)
            {
                if (servido == dia)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
