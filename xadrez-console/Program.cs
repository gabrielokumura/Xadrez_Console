using System;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p;

            Tabuleiro t = new Tabuleiro(18, 10);

            p = new Posicao(3, 4);

            Console.WriteLine(p);
        }
    }
}
