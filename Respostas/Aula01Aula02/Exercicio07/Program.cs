using System;

namespace Exercicio07
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string qtdEstrelasAsString = Console.ReadLine();
            int qtdEstrelas = Convert.ToInt32(qtdEstrelasAsString);
            var qtdLinhas = qtdEstrelas;

            for (int i = 1; i <= qtdLinhas; i++)
            {
                for (int y = 1; y <= i; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}