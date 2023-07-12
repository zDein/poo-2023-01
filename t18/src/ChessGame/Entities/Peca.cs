using System;

namespace ChessGame.Entities
{
    public class Peca
    {
        public string Name { get; set; }

        public Peca(string name) => this.Name = name;
    }
}