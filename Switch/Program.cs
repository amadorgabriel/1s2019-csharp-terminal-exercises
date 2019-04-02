using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Escreva-me aode vais-te passear?");
            string passeio = Console.ReadLine();

            Switch(passeio)
            {
                case 1:
                    Console.WriteLine();
                    break;
                

                case 2:
                    Console.WriteLine();
                    break;
                

                case 3:
                    Console.WriteLine();
                    break;
                

                default{
                    Console.WriteLine();
                    break;
                }
            
            }
        }
    }
}
