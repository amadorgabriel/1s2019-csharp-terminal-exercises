using System;

namespace WhileTabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = True;

            while (repetir)
            {

                while (contador <= 10)
                {
                    int contador = 0;
                    Console.WriteLine("Qual tabuada você deseja ?");
                    int numero = int.Parse(Console.ReadLine());

                    int resultado = numero * contador;
                    System.Console.WriteLine("{0} x {1} = {2}", numero, contador, resultado);
                    contador = contador + 1;
                }

            }

            Console.WriteLine("Eai meu chegado quer outra vez?");
            string resposta = Console.ReadLine();

            if (resposta.Equals("sim")){
                repetir = True;
            }else{
                repetir = False;
            }
            //repetir = resposta.Equals("sim") ? True : False;





        }
    }
}
