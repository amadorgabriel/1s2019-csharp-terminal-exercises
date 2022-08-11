using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Escreva-me aode vais-te passear?");
            string passeio = Console.ReadLine();

            switch(passeio){
                case "Montanha":
                Console.WriteLine("Rio Grande do Sul");
                break;

                case "Lago":
                Console.WriteLine("Acre");
                break;

                case "Rio de Janeiro":
                Console.WriteLine("Paraná");
                break;

                default:
                Console.WriteLine("É fica em casa mn");
                break;
        
            }
        }
    }
}
