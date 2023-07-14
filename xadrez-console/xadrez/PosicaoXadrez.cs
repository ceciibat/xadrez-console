using tabuleiro;

namespace xadrez
{
     class PosicaoXadrez
    {
        public char XadrezColuna { get; set; }    
        public int XadrezLinha { get; set;}

        public PosicaoXadrez(char paramColuna, int paramLinha)
        {
            XadrezColuna = paramColuna;
            XadrezLinha = paramLinha;
        }

        public Posicao ToPosicao()
        {
            return new Posicao(8 - XadrezLinha, XadrezColuna - 'a');
        }

        public override string ToString()
        {
            return "" + XadrezColuna + XadrezLinha;
        }
    }
}
