namespace tabuleiro
{
    class Peca                                             // é uma classe genérica, é uma Peca qualquer
    {
        public Posicao Position { get; set; }               // associando classes
        public Cor CorPeca { get; protected set; }             // protected: só pode ser alterada por ela mesma e pelas subclasses 
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }       // "a Peca está em um Tabuleiro" - associações = a Peca tem 1 Tabuleiro

        public Peca(Tabuleiro paramTab, Cor paramCor)
        {
            Position = null;                                // null porque já vem "de fabrica", qnd uma Peca é criada ela não tem Posicao específica
            Tab = paramTab;
            CorPeca = paramCor;
            QteMovimentos = 0;
        }
    }
}
