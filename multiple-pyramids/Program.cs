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


            System.Console.Write("Quantidade de triangulos: ");
            int quantT = int.Parse(Console.ReadLine());
            System.Console.Write("Dimensões dos Triângulos: ");
            int tamanhoT = int.Parse(Console.ReadLine());
            
            int a = 0;
            while (a < quantT)
            {

            string asterisco = "";
            for (int i = 0; i < tamanhoT; i++)
            {
                System.Console.WriteLine("*" +asterisco);
                asterisco = asterisco + "*";
                
            }

            a++;
                
            }



        }
    }
}