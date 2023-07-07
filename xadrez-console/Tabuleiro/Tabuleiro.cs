namespace tabuleiro
{
     class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set;}
        private Peca[,] Pecas;   // não pode ser acessado por outra classe

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)   // método para se ter acesso a uma peça individual
        {
            return Pecas[linha, coluna];
        }
    }   
}
