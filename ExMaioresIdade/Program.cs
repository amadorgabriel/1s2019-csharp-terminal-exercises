using System;

namespace ExMaioresIdade {
    class Program {
        static void Main (string[] args) {
            //Escreva aqui sua idade aqui
            //Armazenar idade
            //If idade > 18 = umaNovaVariavel
            //Maiores ded 18 = Soma das umaNovaVariável

            Console.WriteLine ("Pessoa, Digite sua idade: ");
            int idade1 = int.Parse (Console.ReadLine ());
            if (idade1 > 18) {
                idade1 = 1;
            } else {
                idade1 = 0;
            }

            Console.Write ("Escreva sua idade aqui: ");
            int idade2 = int.Parse (Console.ReadLine ());
            if (idade2 > 18) {
                idade2 = 1;
            } else {
                idade2 = 0;
            }

            Console.Write ("Escreva sua idade aqui: ");
            int idade3 = int.Parse (Console.ReadLine ());
            if (idade3 > 18) {
                idade3 = 1;
            } else {
                idade3 = 0;
            }

            Console.Write ("Escreva sua idade aqui: ");
            int idade4 = int.Parse (Console.ReadLine ());

            if (idade4 > 18) {
                idade4 = 1;
            } else {
                idade4 = 0;
            }

            Console.Write ("Escreva sua idade aqui: ");
            int idade5 = int.Parse (Console.ReadLine ());
            if (idade5 > 18) {
                idade5 = 1;
            } else {
                idade5 = 0;
            }

            Console.Write ("Escreva sua idade aqui: ");
            int idade6 = int.Parse (Console.ReadLine ());
            if (idade6 > 18) {
                idade6 = 1;
            } else {
                idade6 = 0;
            }

            Console.Write ("Escreva sua idade aqui: ");
            int idade7 = int.Parse (Console.ReadLine ());
            if (idade7 > 18) {
                idade7 = 1;
            } else {
                idade7 = 0;
            }

            Console.Write ("Escreva sua idade aqui: ");
            int idade8 = int.Parse (Console.ReadLine ());
            if (idade8 > 18) {
                idade8 = 1;
            } else {
                idade8 = 0;
            }

            Console.Write ("Escreva sua idade aqui: ");
            int idade9 = int.Parse (Console.ReadLine ());
            if (idade9 > 18) {
                idade9 = 1;
            } else {
                idade9 = 0;
            }

            Console.Write ("Escreva sua idade aqui: ");
            int idade10 = int.Parse (Console.ReadLine ());
            if (idade10 > 18) {
                idade10 = 1;
            } else {
                idade10 = 0;
            }

            int somaIdades = idade1 + idade2 + idade3 + idade4 + idade6 + idade7 + idade8 + idade9 + idade10;

            System.Console.WriteLine ("{0} é o numero de pessoas maiores de 18 anos", somaIdades);

            //     int maiores = 0;
            //     for (int i = 0; i < 10; i++) {
            //         System.Console.WriteLine ("Digite sua idade:");
            //         int idade = int.Parse (Console.ReadLine ());
            //         if (idade >= 18) {
            //             maiores++;
            //         }
            //     }
            //     System.Console.WriteLine (maiores);
            // }
        }
    }

}