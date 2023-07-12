using System;

namespace ChessGame.Entities
{
    public class Jogador
    {
        public string Name { get; set; }

        public Jogador(string name) => this.Name = name;
    }
}