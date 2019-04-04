using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);

                if (i % 2 == 0)
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
