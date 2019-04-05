using System;

namespace GamedaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quer jogar Par ou Impar?");
            string respostaJogo = Console.ReadLine().ToLower();

            if (respostaJogo == "não")
            {
                Console.WriteLine("É uma pena, cara");
            }
            else
            {
                Console.WriteLine("Escolha entre Par e Impar");
                string decisao = Console.ReadLine().ToLower();

                Random r = new Random();
                int numeroPc = r.Next(0, 10);

                Console.WriteLine("Escolha um numero!");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("O numero é do adversário é.. " + numeroPc);

                int resultado = n1 + numeroPc;
                int comparaçao = resultado % 2;


                if (comparaçao == 0)
                {
                    Console.WriteLine("O numero {0} é par, logo", resultado);
                    string par = "par";

                    if (decisao == par)
                    {
                        Console.WriteLine("Você venceu!!!");
                    }
                    else
                    {
                        Console.WriteLine("Hahahah Perdeu!!!");
                    }

                }
                else
                {
                    Console.WriteLine("O numero {0} é Impar, logo..", resultado);
                    string impar = "impar";
                    if (decisao == impar)
                    {
                        Console.WriteLine("Bem, voce venceu");
                    }
                    else
                    {
                        Console.WriteLine("Hahushausah o PC ganhou");
                    }

                }
            }
        }
    }
}
