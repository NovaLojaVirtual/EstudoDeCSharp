using System;

namespace Exercicio02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var x = 0;
            int y = default(int);
            if (x == 0 && y <= 32)
                Console.WriteLine("Sucesso!");
        }
    }
}