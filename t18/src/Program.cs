using System;
using ChessGame.Entities;

namespace ChessGame
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var jogador1 = new Jogador("Adolf Anderssen");
            var jogador2 = new Jogador("Lionel Kieseritzky");

            var peca = new Peca("0");
            var pos = new Posicao("0", "0");
            var partidaImortal = new Partida();

            var lance1 = new Lance(jogador1, peca = new Peca("Peao"), pos = new Posicao("e2", "e4"));
            var lance2 = new Lance(jogador2, peca = new Peca("Peao"), pos = new Posicao("e7", "e5"));
            var lance3 = new Lance(jogador1, peca = new Peca("Peao"), pos = new Posicao("f2", "f4"));
            var lance4 = new Lance(jogador2, peca = new Peca("Peao"), pos = new Posicao("e5", "f4"));
            var lance5 = new Lance(jogador1, peca = new Peca("Bispo"), pos = new Posicao("f1", "c4"));
            var lance6 = new Lance(jogador2, peca = new Peca("Rainha"), pos = new Posicao("d8", "h4"));
            var lance7 = new Lance(jogador1, peca = new Peca("Rei"), pos = new Posicao("e1", "f1"));
            var lance8 = new Lance(jogador2, peca = new Peca("Peao"), pos = new Posicao("b7", "b5"));
            var lance9 = new Lance(jogador1, peca = new Peca("Bispo"), pos = new Posicao("c4", "b5"));
            var lance10 = new Lance(jogador2, peca = new Peca("Cavalo"), pos = new Posicao("g8", "f6"));
            var lance11 = new Lance(jogador1, peca = new Peca("Cavalo"), pos = new Posicao("g1", "f3"));
            var lance12 = new Lance(jogador2, peca = new Peca("Rainha"), pos = new Posicao("h4", "h6"));
            var lance13 = new Lance(jogador1, peca = new Peca("Peao"), pos = new Posicao("d2", "d3"));
            var lance14 = new Lance(jogador2, peca = new Peca("Cavalo"), pos = new Posicao("f6", "h5"));
            var lance15 = new Lance(jogador1, peca = new Peca("Cavalo"), pos = new Posicao("f3", "h4"));
            var lance16 = new Lance(jogador2, peca = new Peca("Rainha"), pos = new Posicao("h6", "g5"));
            var lance17 = new Lance(jogador1, peca = new Peca("Cavalo"), pos = new Posicao("h4", "f5"));
            var lance18 = new Lance(jogador2, peca = new Peca("Peao"), pos = new Posicao("c7", "c6"));
            var lance19 = new Lance(jogador1, peca = new Peca("Peao"), pos = new Posicao("g2", "g4"));
            var lance20 = new Lance(jogador2, peca = new Peca("Cavalo"), pos = new Posicao("h5", "f2"));
            var lance21 = new Lance(jogador1, peca = new Peca("Torre"), pos = new Posicao("h1", "g1"));
            var lance22 = new Lance(jogador2, peca = new Peca("Peao"), pos = new Posicao("c6", "b5"));
            var lance23 = new Lance(jogador1, peca = new Peca("Peao"), pos = new Posicao("h2", "h4"));
            var lance24 = new Lance(jogador2, peca = new Peca("Rainha"), pos = new Posicao("g5", "g6"));
            var lance25 = new Lance(jogador1, peca = new Peca("Peao"), pos = new Posicao("h4", "h5"));
            var lance26 = new Lance(jogador2, peca = new Peca("Rainha"), pos = new Posicao("g6", "g5"));
            var lance27 = new Lance(jogador1, peca = new Peca("Rainha"), pos = new Posicao("d1", "f3"));
            var lance28 = new Lance(jogador2, peca = new Peca("Cavalo"), pos = new Posicao("f6", "g8"));
            var lance29 = new Lance(jogador1, peca = new Peca("Bispo"), pos = new Posicao("c1", "f4"));
            var lance30 = new Lance(jogador2, peca = new Peca("Rainha"), pos = new Posicao("g5", "f6"));
            var lance31 = new Lance(jogador1, peca = new Peca("Cavalo"), pos = new Posicao("b1", "c3"));
            var lance32 = new Lance(jogador2, peca = new Peca("Bispo"), pos = new Posicao("f8", "c5"));
            var lance33 = new Lance(jogador1, peca = new Peca("Cavalo"), pos = new Posicao("c3", "d5"));
            var lance34 = new Lance(jogador2, peca = new Peca("Rainha"), pos = new Posicao("f6", "b2"));
            var lance35 = new Lance(jogador1, peca = new Peca("Bispo"), pos = new Posicao("f4", "d6"));
            var lance36 = new Lance(jogador2, peca = new Peca("Bispo"), pos = new Posicao("c5", "g1"));
            var lance37 = new Lance(jogador1, peca = new Peca("Peao"), pos = new Posicao("e4", "e5"));
            var lance38 = new Lance(jogador2, peca = new Peca("Rainha"), pos = new Posicao("b2", "a1"));
            var lance39 = new Lance(jogador1, peca = new Peca("Rei"), pos = new Posicao("f1", "e2"));
            var lance40 = new Lance(jogador2, peca = new Peca("Cavalo"), pos = new Posicao("b8", "a6"));
            var lance41 = new Lance(jogador1, peca = new Peca("Cavalo"), pos = new Posicao("f5", "g7"));
            var lance42 = new Lance(jogador2, peca = new Peca("Rei"), pos = new Posicao("e8", "d8"));
            var lance43 = new Lance(jogador1, peca = new Peca("Rainha"), pos = new Posicao("f3", "f3"));
            var lance44 = new Lance(jogador2, peca = new Peca("Cavalo"), pos = new Posicao("g8", "f6"));
            var lance45 = new Lance(jogador1, peca = new Peca("Bispo"), pos = new Posicao("d6", "e7"));

            partidaImortal.addLances(lance1);
            partidaImortal.addLances(lance2);
            partidaImortal.addLances(lance3);
            partidaImortal.addLances(lance4);
            partidaImortal.addLances(lance5);
            partidaImortal.addLances(lance6);
            partidaImortal.addLances(lance7);
            partidaImortal.addLances(lance8);
            partidaImortal.addLances(lance9);
            partidaImortal.addLances(lance10);
            partidaImortal.addLances(lance11);
            partidaImortal.addLances(lance12);
            partidaImortal.addLances(lance13);
            partidaImortal.addLances(lance14);
            partidaImortal.addLances(lance15);
            partidaImortal.addLances(lance16);
            partidaImortal.addLances(lance17);
            partidaImortal.addLances(lance18);
            partidaImortal.addLances(lance19);
            partidaImortal.addLances(lance20);
            partidaImortal.addLances(lance21);
            partidaImortal.addLances(lance22);
            partidaImortal.addLances(lance23);
            partidaImortal.addLances(lance24);
            partidaImortal.addLances(lance25);
            partidaImortal.addLances(lance26);
            partidaImortal.addLances(lance27);
            partidaImortal.addLances(lance28);
            partidaImortal.addLances(lance29);
            partidaImortal.addLances(lance30);
            partidaImortal.addLances(lance31);
            partidaImortal.addLances(lance32);
            partidaImortal.addLances(lance33);
            partidaImortal.addLances(lance34);
            partidaImortal.addLances(lance35);
            partidaImortal.addLances(lance36);
            partidaImortal.addLances(lance37);
            partidaImortal.addLances(lance38);
            partidaImortal.addLances(lance39);
            partidaImortal.addLances(lance40);
            partidaImortal.addLances(lance41);
            partidaImortal.addLances(lance42);
            partidaImortal.addLances(lance43);
            partidaImortal.addLances(lance44);
            partidaImortal.addLances(lance45);

            partidaImortal.mostraLances();
        }
    }
}