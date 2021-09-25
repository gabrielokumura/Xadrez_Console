using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro t = new Tabuleiro(8, 8);

                t.colocarPeca(new Torre(t, Cor.Preta), new Posicao(0, 0));
                t.colocarPeca(new Torre(t, Cor.Preta), new Posicao(1, 9));
                t.colocarPeca(new Rei(t, Cor.Branca), new Posicao(0, 0));


                Tela.imprimirTabuleiro(t);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message); 
            }

            
        }
    }
}
