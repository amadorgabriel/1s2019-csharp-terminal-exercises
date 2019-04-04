using System;
using System.Threading;

namespace WhileTabuada {
    class Program {
        static void Main (string[] args) {


            bool fazTabuada = true;
            while (fazTabuada != false) {

                System.Console.WriteLine ("Escolha um número para calcular a tabuada");
                int numero = int.Parse (Console.ReadLine ());
                System.Console.WriteLine ("Aguarde um momento...");

                /** Adicionar drama! */
                Thread.Sleep (2000);

                int mult = 0;
                while (mult <= 10) {
                    int resultado = numero * mult;
                    System.Console.WriteLine ("{0} x {1} = {2}", numero, mult, resultado);
                    mult = mult + 1;
                }
                System.Console.WriteLine ("TADAAAAA!");
                System.Console.WriteLine ("Deseja continuar?");
                string resposta = Console.ReadLine ();
                fazTabuada = resposta.Equals ("sim") ? true : false;
            }

           
            //repetir = resposta.Equals("sim") ? True : False;

        }
    }
}