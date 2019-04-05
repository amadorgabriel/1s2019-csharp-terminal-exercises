using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            // "i" começa com o valor "0"
            // Condição = "i" menor que 1OO durante no loop
            // A cada loop "i" é acrecido com "1"

            for (int i = 0; i <= 100; i++) // O "FOR" tm três partes, contador, condição e somador respectivamente 
            {

            // O "i" Está sendo mostrado na tela
            // "i" = 0
            // "i" = 1
            // "i" = 2
            // "i" = ...

                Console.WriteLine(i);

                if (i % 2 == 0) // seleciona apenas os pares
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }

            }
        }
    }
}
