namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }   // protected: só pode ser alterada por ela mesma e pelas subclasses 
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; } // associações = a Peca tem 1 Tabuleiro

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QteMovimentos = 0;
        }
    }
}
