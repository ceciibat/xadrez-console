namespace tabuleiro
{
    class Posicao                                            // uma posiçao é dizer em qual
    {
        public int Linha { get; set; } //encapsulamento     // linha e
        public int Coluna { get; set; }                     // coluna uma >peca< está

        public Posicao(int linha, int coluna)               // construtor atribui valores para novos objetos instanciados
        {
            Linha = linha;
            Coluna = coluna;
        }

        public override string ToString()  //sobreposição
        {
            return Linha + ", " + Coluna;
        }
    }
}

// sobrecarga = overload  - permite que seja criado mais de 1 método com o mesmo nome na mesma classe, porém, seus argumentos devem ser
//                          diferentes. o que irá diferenciá-los serão os parâmetros chamados ao se chamar o método para o objeto.
//
// sobreposição = override  - permite que 1 método criado na superclasse seja utilizado em outras classes (sub), é necessário q tenha
//                            o mesmo retorno, nome, tipo e quantidade de parâmetro, mas com implementações diferentes.