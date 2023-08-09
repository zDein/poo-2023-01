// -----------------------------------------------------------------------
// <copyright file="Preco.cs" company="RestauranteDoCarlão">
// Copyright (c) RestauranteDoCarlão. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Entities
{
    public class Preco
    {
        private double _valor;
        private Moeda _moeda;

        public Preco(double valor, Moeda moeda)
        {
            if (valor < 0)
            {
                throw new ArgumentException("valor não pode ser negativo");
            }

            Objects.requireNonNull(moeda, "nao pode ser nulo");

            this._valor = valor;
            this._moeda = moeda;
        }

        public double getValor()
        {
            return _valor;
        }

        public Moeda getMoeda()
        {
            return _moeda;
        }

        public static Preco reais(double valor)
        {
            return new Preco(valor, Moeda.REAL);
        }

        public override string ToString()
        {
            return "Preco{" +
                    "valor=" + _valor +
                    ", moeda=" + _moeda +
                    '}';
        }

        public Preco adiciona(Preco valor)
        {
            if (_moeda != valor.getMoeda())
            {
                throw new ArgumentException("não se soma valores de moedas distintas");
            }

            return new Preco(valor.getValor() + getValor(), _moeda);
        }
    }
}
