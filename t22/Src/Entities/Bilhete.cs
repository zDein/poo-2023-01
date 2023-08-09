// -----------------------------------------------------------------------
// <copyright file="Bilhete.cs" company="ParqueDeDiversões">
// Copyright (c) ParqueDeDiversões. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using Src.Enums;
using System;

namespace Src.Entities
{
    public class Bilhete
    {
        public string? Nome = string.Empty;
        public double Valor { get; set; }
        public Guid NumSerie { get; set; }
        public DateTime DiaHoraEvento { get; set; }
        public TipoBilhete TipoBilhete { get; private set; }

        /// <summary>
        /// Inicia uma nova instância da classe <see cref="Bilhete"/>.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="valor"></param>
        /// <param name="numSerie"></param>
        /// <param name="diaHoraEvento"></param>
        public Bilhete(string? nome, double valor, Guid numSerie, DateTime diaHoraEvento, TipoBilhete tipoBilhete)
        {
            if (nome == null)
            {
                this.Nome = "Parque de diversões do Carlão";
            }

            this.Nome = nome;
            this.Valor = valor;
            this.NumSerie = numSerie;
            this.DiaHoraEvento = diaHoraEvento;
            this.TipoBilhete = tipoBilhete;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}" +
                $"Valor: {Valor}" +
                $"Data e hora: {DiaHoraEvento}" +
                $"Nº bilhete: {NumSerie}";
        }
    }
}
