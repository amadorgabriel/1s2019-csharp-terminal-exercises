using System;
using System.Threading;

namespace manipulaçaoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello U-S-E-R!");
            System.Console.Write("Digite o valor do primeiro número aqui: ");
            int num1 = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o valor do segundo número aqui: ");
            int num2 = int.Parse(Console.ReadLine());
            bool Inicio = true;
            while (Inicio == true)
            {

                System.Console.WriteLine("");
                System.Console.WriteLine("--------------------------  MENU:  ------------------------------");
                System.Console.WriteLine("a. Soma dos números;");
                System.Console.WriteLine("b. Subtração do {0} pelo {1}", num1, num2);
                System.Console.WriteLine("c. Subtração do {0} pelo {1};", num2, num1);
                System.Console.WriteLine("d. Multiplicação dos dois números;");
                System.Console.WriteLine("e. Divisão do {0} pelo {1};", num1, num2);
                System.Console.WriteLine("f. Divisão do {0} pelo {1};", num2, num2);
                System.Console.WriteLine("g. Quociente inteiro da divisão do {0} pelo {1};", num1, num2);
                System.Console.WriteLine("h. Quociente inteiro da divisão do {0} pelo {1};", num2, num1);
                System.Console.WriteLine("i. Resto da Divisão do {0} pelo {1}", num1, num2);
                System.Console.WriteLine("j. Resto da divisão do {0} pelo {1}.", num2, num1);
                System.Console.WriteLine("-----------------------------------------------------------------");
                System.Console.WriteLine("");
                System.Console.WriteLine("Qual dessas opções deseja?");
                string letra = Console.ReadLine().ToLower();
                switch (letra)
                {
                    case "a":
                        System.Console.WriteLine(num1 + num2);
                        System.Console.WriteLine("reiniciando..");
                        Thread.Sleep(2000);
                        break;
                    case "b":
                        System.Console.WriteLine(num1 - num2);
                        System.Console.WriteLine("reiniciando..");
                        Thread.Sleep(2000);
                        break;
                    case "c":
                        System.Console.WriteLine(num2 - num1);
                        System.Console.WriteLine("reiniciando..");
                        Thread.Sleep(2000);
                        break;
                    case "d":
                        System.Console.WriteLine(num1 * num2);
                        System.Console.WriteLine("reiniciando..");
                        Thread.Sleep(2000);

                        break;
                    case "e":
                        System.Console.WriteLine(num1 / num2);
                        System.Console.WriteLine("reiniciando..");
                        Thread.Sleep(2000);

                        break;

                    case "f":
                        System.Console.WriteLine(num2 / num1);
                        System.Console.WriteLine("reiniciando..");
                        Thread.Sleep(2000);

                        break;
                    case "g":
                        System.Console.WriteLine(num1 % num2);
                        System.Console.WriteLine("reiniciando..");
                        Thread.Sleep(2000);

                        break;
                    case "h":
                        System.Console.WriteLine(num2 % num1);
                        System.Console.WriteLine("reiniciando..");
                        Thread.Sleep(2000);


                        break;

                    default:
                        System.Console.WriteLine("Resposta inválida, deseja voltar?");
                        string resposta = Console.ReadLine().ToLower();

                        if (resposta == "sim")
                        {
                            Inicio = true;
                        }
                        else
                        {
                            System.Console.WriteLine("Ok, flw");
                            Inicio = false;
                        }
                        break;

                }
            }

        }
    }
}
