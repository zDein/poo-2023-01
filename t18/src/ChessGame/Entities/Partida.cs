using System;
using System.Collections.Generic;

namespace ChessGame.Entities
{
    public class Partida
    {
        public int i;
        public List<Lance> Lances { get; set; }

        public Partida()
        {
            i = 0;
            Lances = new List<Lance>();
        }

        public void addLances(Lance lance)
        {
            Lances.Add(lance);
        }

        public void mostraLances()
        {
            Console.Clear();
            foreach (var lance in Lances)
            {

                Console.WriteLine($"Jogador: {lance.Jogador.Name}");
                Console.WriteLine($"Lance: {++i}");
                Console.WriteLine($"Peça: {lance.Peca.Name}");
                Console.WriteLine($"Origem: {lance.Posicao.X}");
                Console.WriteLine($"Destino: {lance.Posicao.Y}");
                Console.WriteLine("==============================");
            }
        }
    }
}