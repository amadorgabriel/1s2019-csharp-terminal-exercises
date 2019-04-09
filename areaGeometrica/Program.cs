using System;

namespace areaGeometrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma forma para caucularmos a área: ");
            System.Console.WriteLine("1 - Quadrado; \n2 - Triângulo \n3 - Círculo \n4 - Trapézio \n5 - Retângulo \n6 - Losango ");
            int forma = int.Parse(Console.ReadLine());
            switch (forma)
            {
                case 1:
                    System.Console.Write("Qual a medida do lado?");
                    float ladoQ = float.Parse(Console.ReadLine());
                    System.Console.Write("A área é igual a {0}", ladoQ*2);
                break;

                case 2:
                System.Console.Write("Qual a medida da altura?");
                float alturaT = float.Parse(Console.ReadLine());
                System.Console.Write("Qual a medida da base?");
                float baseT = float.Parse(Console.ReadLine());
                System.Console.Write("A área é igual a {0}", (alturaT*baseT)/2);
                break;

                case 3:
                System.Console.Write("Quanto equivale o raio do círculo?");
                float raioC = float.Parse(Console.ReadLine());
                System.Console.Write("A área é igual a aproximadamente {0}",  Math.Pow(raioC, 2) *3,14);
                break;

                case 4:
                System.Console.Write("Qual o tamanho da base menor?");
                float baseMenor = float.Parse(Console.ReadLine());
                System.Console.Write("Qual o tamanho da base maior?");
                float baseMaior = float.Parse(Console.ReadLine());
                System.Console.Write("Qual o valor da altura?");
                float alturaTr = float.Parse(Console.ReadLine());
                System.Console.WriteLine($"A área é igual a {((baseMenor+baseMaior)/2)*alturaTr}");
                break;

                case 5:
                System.Console.WriteLine("Qual o tamanho da largura?");
                float larguraR = float.Parse(Console.ReadLine());
                System.Console.WriteLine("Qual o tamanho da altura?");
                float alturaR = float.Parse(Console.ReadLine());
                System.Console.WriteLine($"O valor da área é igual a {larguraR*alturaR}");
                break;

                case 6:
                System.Console.WriteLine("Qual o valor da diagonal maior?");
                float dMaior = float.Parse(Console.ReadLine());
                System.Console.WriteLine("Qual o valor da diagonal menor?");
                float dMenor = float.Parse(Console.ReadLine());
                System.Console.WriteLine($"O valor da área á igual a {(dMaior * dMenor)/2}");

                break;
                
                default:
                System.Console.WriteLine("Opa, isso não foi muito certo");
                break;
            }
        }
    }
}