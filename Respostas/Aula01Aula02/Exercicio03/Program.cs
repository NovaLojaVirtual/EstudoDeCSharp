using System;

namespace Exercicio03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var numerosParaCalculo = new[] {1, 2, 3, 4, 5, 95, 96, 97, 98, 99, 100};
            int somatorio = default(int);
            foreach (int numero in numerosParaCalculo)
                if (numero > 95)
                    somatorio += numero;
            Console.WriteLine(somatorio);
        }
    }
}