using System;

namespace ChessGame.Entities
{
    public class Lance
    {
        public Jogador Jogador { get; set; }
        public Peca Peca { get; set; }
        public Posicao Posicao { get; set; }

        public Lance(Jogador jogador, Peca peca, Posicao posicao)
        {
            this.Jogador = jogador;
            this.Peca = peca;
            this.Posicao = posicao;
        }
    }
}