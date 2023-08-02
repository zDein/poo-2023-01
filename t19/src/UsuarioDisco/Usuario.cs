// <copyright file="Usuario.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Src.UsuarioDisco
{
    public class Usuario
    {
        public bool Permissao { get; set; }

        private bool Leitura() {
            return true;
        }
        private bool Escrita() {
            return true;
        }
        private bool Execucao() {
            return true;
        }

    }
}
