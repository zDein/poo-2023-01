// <copyright file="Revisao.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Src.Revisao
{
    public class Revisao : Versao
    {
        public Versao Anterior { get; set; }
        public Versao Proximo { get; set; }
    }
}
