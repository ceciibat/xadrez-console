using tabuleiro;

namespace xadrez
{
    class Rei : Peca   // herança = o Rei é uma Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) // isso é o repasse da execução para a superclasse
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
