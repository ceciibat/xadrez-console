namespace tabuleiro
{
    class Tabuleiro
    {
        public int QtdLinhas { get; set; }
        public int QtdColunas { get; set; }
        private Peca[,] TabPecas;                               //uma matriz do tipo Peca                    // não pode ser acessado por outra classe, só o Tabuleiro que mexe nelas /// associações = o Tabuleiro tem várias Pecas



        public Tabuleiro(int paramLinhas, int paramColunas)     // cria um objeto Tabuleiro
        {
            QtdLinhas = paramLinhas;
            QtdColunas = paramColunas;
            TabPecas = new Peca[paramLinhas, paramColunas];     // instancia matriz de Pecas
        } 



        public Peca Peca(int paramLinha, int paramColuna)       // encapsulamento (método de acesso a um elemento da matriz)                // método para se ter acesso a uma peça individual, pois a matriz Peca[,] é private, ou seja, não pode ser acessada por outra class
        {
            return TabPecas[paramLinha, paramColuna];
        }



        public Peca Peca(Posicao pos)                          //aqui cria a peça passando somente a posição        // Sobrecarga: consiste em permitir, dentro da mesma classe, mais de um método com o mesmo nome (obrigatoriamente com argumentos diferentes)
        {
            return TabPecas[pos.Linha, pos.Coluna];
        }



        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
             
            TabPecas[pos.Linha, pos.Coluna] = p;                                                       // jogando a peça 'p' na matriz TabPecas[,] nesta posição: 'TabPecas[pos.Linha, pos.Coluna]'
            p.Position = pos;                                                                          // indo lá na peça 'p' e dizendo que a Posicao dela agora é 'pos'
        }



        public bool PosicaoValida(Posicao pos)                                                         // o tabuleiro só tem posições de (0,0) a (7,7), então esse método vai verificar se está de acordo
        {
            if (pos.Linha < 0 || pos.Linha >= QtdLinhas || pos.Coluna < 0 || pos.Coluna >= QtdColunas)
            {
                return false;
            }
            return true;
        }



        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))                                                                  // se a minha posição 'pos' NÃO = ! for válida
            {
                throw new TabuleiroException("Posição inválida!");                                    // lança uma exceção
            }
        }



        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return Peca(pos) != null;
        }

    }
}
