using System;

namespace Exercicio05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var indice = 1;
            int somatorio = default(int);
            while (indice <= 100)
            {
                somatorio += indice;
                indice++;
            }

            Console.WriteLine(somatorio);
        }
    }
}