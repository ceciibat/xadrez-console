using tabuleiro;

namespace xadrez
{
    internal class Torre : Peca     // herança = a Torre é uma Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) // isso é o repasse da execução para a superclasse
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
