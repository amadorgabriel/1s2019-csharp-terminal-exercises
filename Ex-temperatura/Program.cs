using System;

namespace Ex_temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a previsão do tempo atual");
            string previsao = Console.ReadLine();

            if (previsao == "calor"){
                Console.WriteLine("Vamos para a praia");

            }else if(previsao == "chuva"){
                Console.WriteLine("Vamos para Steam?");
                string resposta = Console.ReadLine();

                if(resposta == "sim"){
                    Console.WriteLine("Bora lá, meu chapa");
                }else{
                    Console.WriteLine("Então vai de NETFLIX");
                }

            }else{
                Console.WriteLine("Que tai ir a uma montanha?");
            }

        }
    }
}
