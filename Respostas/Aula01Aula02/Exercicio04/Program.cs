using System;

namespace Exercicio04
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira o mes do ano: ");
            string mesDoAnoAsString = Console.ReadLine();

            if (!int.TryParse(mesDoAnoAsString, out int mesDoAno) || mesDoAno > 12 || mesDoAno < 1)
            {
                Console.WriteLine("Mês do ano inválido. O mes do ano deve ser entre 1 e 12");
                return;
            }

            double quartil = Math.Ceiling((double) mesDoAno / 4);
            Console.WriteLine("O mes {0} pertence a {1}º quartil", mesDoAno, quartil);
        }
    }
}