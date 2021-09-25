using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro t = new Tabuleiro(8, 8);

            t.colocarPeca(new Torre(t, Cor.Preta), new Posicao(0, 0));
            t.colocarPeca(new Torre(t,Cor.Preta), new Posicao(1, 3));
            t.colocarPeca(new Rei(t,Cor.Branca), new Posicao(2, 4));


            Tela.imprimirTabuleiro(t);

            
        }
    }
}
