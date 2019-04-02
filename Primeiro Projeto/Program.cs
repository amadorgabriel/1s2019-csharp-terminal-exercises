using System;

namespace Primeiro_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome; //declarando as variáveis
            string sobrenome;
            string nomecompleto;

            Console.WriteLine("Digite seu nome aqui:"); //PRINT
            nome = Console.ReadLine(); // INPUT para a variável

            Console.WriteLine("Digite seu sobrenome");
            sobrenome = Console.ReadLine();

            nomecompleto = nome + " " + sobrenome;
            Console.WriteLine("Seu nome completo é: " +  nomecompleto);


        }
    }
}
