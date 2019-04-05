using System;
using System.Threading;

namespace DesenhoPirâmide
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("--------------------------------------------");
            System.Console.WriteLine("              BORA NA PIRÂMIDE!             ");
            System.Console.WriteLine("                                            ");
            System.Console.WriteLine("Instruções: 1º - Digite valores das colunas ");
            System.Console.WriteLine("            2º - Aproveite                  ");
            System.Console.WriteLine("--------------------------------------------");
            System.Console.WriteLine(" ");
            Thread.Sleep(3000);

            System.Console.WriteLine("Digite um número inteiro para montarmos a forma geométrica,\no seu valor inserido será o número de linhas e colunas");
            int x = int.Parse(Console.ReadLine());
            System.Console.WriteLine("");

            bool recomeço = true;
            while (recomeço != false)
            {

                int count = 0;

                while (count < (x - 1))
                {
                    System.Console.WriteLine("*");
                    count++;

                }
                
                while (count < x)
                {
                    System.Console.WriteLine("*");
                    count++;
                }


                recomeço = false;



            }




        }
    }
}
