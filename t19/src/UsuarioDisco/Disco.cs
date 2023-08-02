// <copyright file="Disco.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Src.UsuarioDisco
{
    public class Disco
    {
        public IList<Arquivo> Arquivo { get; set; }

        public void AddArquivo(Arquivo arquivo)
        {
            Arquivo.Add(arquivo);
        }
    }
}
