using System;

namespace Teste_dotnet {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine("Vamos caucular a sua nota do ano, tenha em mãos todas elas");

            Console.WriteLine ("Digite a nota do seu primeiro bimestre");
            float n1 = float.Parse(Console.ReadLine ());

            Console.WriteLine ("Digite a nota do seu segundo bimestre");
            float n2 = float.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite a nota do seu terceiro semestre");
            float n3 = float.Parse (Console.ReadLine ());

            float resultado =  (n1 + n2 + n3)/3;
            Console.WriteLine ( "A sua nota é igual a "  + resultado );

            Console.WriteLine ("---------------------------------------------------------------------");
            Console.WriteLine("Digite o número de suas faltas nesse ano");
            int faltas = int.Parse (Console.ReadLine());

            if(resultado < 5 || faltas > 25){ //  || siguinifica "ou" um "or" da vida
                Console.WriteLine ("Reprovado");
            }else if(resultado < 9){// if e els
                Console.WriteLine ("Aprovado");
            }else{
                Console.WriteLine ("É isso aí jovem!");
            }
 
        }
    }
}