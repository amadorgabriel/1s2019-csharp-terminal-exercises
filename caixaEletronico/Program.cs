using System;

namespace caixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Notas = { 100, 50, 20, 10, 5, 2, 1 };
            System.Console.Write("Digite o valor que deseja sacar: ");
            int quantia = int.Parse(Console.ReadLine());
            int resto = 0;
            int resto2 = 0;

            for (int i = 0; i < Notas.Length; i++)
            {
                
                resto = quantia / Notas[0];
                if( resto != 0){

                resto2 = resto / Notas[1];
                int resto3 = resto2 / Notas[2];
                int resto4 = resto3 / Notas[3];
                int resto5 = resto4 / Notas[4];
                int resto6 = resto5 / Notas[5];
                int resto7 = resto6 / Notas[6];
                System.Console.WriteLine("{0} {1} {2} {3}", resto, resto2, resto3,resto4);
                }
                
            }



            // quantia / 100 = resto;
            // resto / 50 = resto;
            // resto / 20 = resto;
            // resto/ 5  =

        }
    }
}
