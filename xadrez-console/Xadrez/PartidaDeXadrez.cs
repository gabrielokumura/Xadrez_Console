using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogardorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogardorAtual = Cor.Branca;
            colocarPecas();
            terminada = false;

        }

        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(tab, Cor.Branca), new posicaoXadrez('c', 1).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new posicaoXadrez('d', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new posicaoXadrez('e', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new posicaoXadrez('c', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new posicaoXadrez('d', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new posicaoXadrez('e', 2).toPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Preta), new posicaoXadrez('c', 8).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new posicaoXadrez('d', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new posicaoXadrez('e', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new posicaoXadrez('c', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new posicaoXadrez('d', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new posicaoXadrez('e', 7).toPosicao());
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQtdMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }
    }
}
