using System;

namespace Do
{
    class Program
    {
        static void Main(string[] args)
        {
            bool emailInválido = true;
            do{
                System.Console.Write("Insira seu E-mail: ");
                string email = Console.ReadLine();

                if(email.Contains("@") && email.Contains(".com")){ //A variável contém sla?
                    System.Console.WriteLine("Parabens cara, email correto");
                    emailInválido = false;
                }else{
                    System.Console.WriteLine("Digite um email Válido");
                }

            }while (emailInválido);
                
            }



        }
    }

