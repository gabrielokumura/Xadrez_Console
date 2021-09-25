using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            posicaoXadrez pos = new posicaoXadrez('c', 7);

            Console.WriteLine(pos.toPosicao());

            Console.WriteLine(pos);
            
        }
    }
}
