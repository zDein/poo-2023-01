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
    public interface IParticipante
    {
        public bool IsVisitante(Object obj);
    }
}