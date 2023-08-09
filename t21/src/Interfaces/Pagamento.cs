// -----------------------------------------------------------------------
// <copyright file="Pagamento.cs" company="RestauranteDoCarlão">
// Copyright (c) RestauranteDoCarlão. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using Src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src.Interfaces
{
    public interface IPagamento
    {
        public Preco Valor();
    }
}
