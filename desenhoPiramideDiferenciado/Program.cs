using System;

namespace desenhoPiramideDiferenciado {
    class Program {
        static void Main (string[] args) {
            //Digite a quantidae de triangulos
            //QuantP
            //Digite a  altura do triangulo
            //Armazenar dado alturaP
            //asterisco = " ";
            //for(int i = 0; i < QuantP; i++){
            //cw("*")
            //asterisco = asterisco + "*";
            //}


            System.Console.WriteLine ("Coé, digita ae a quantidade de triângulos parça!");
            int quantT = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Por obséquio, necessito da altura dos Triângulos");
            int tamanhoT = int.Parse(Console.ReadLine());
            
            string asterisco = " ";
            for (int i = 0; i < quantT; i++)
            {
                System.Console.WriteLine("*" + tamanhoT);
                asterisco = asterisco + "*";
                
            }



        }
    }
}