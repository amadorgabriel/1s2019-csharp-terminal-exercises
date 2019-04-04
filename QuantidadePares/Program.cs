using System;

namespace QuantidadePares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para analisarmos a qunatidade de pares:");
            int numero = int.Parse(Console.ReadLine());
            int QuantidadePares = 0;

            for (int i = 0; i <= numero; i++)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i);
                    QuantidadePares ++;
                }
            }
            System.Console.WriteLine("A quantia de Pares é:", QuantidadePares);

        }
    }
}
