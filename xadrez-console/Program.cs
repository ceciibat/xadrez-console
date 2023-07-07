using System;
using tabuleiro;
using xadrez_console;

namespace tabuleiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8 , 8);

            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}