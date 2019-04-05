using System;

namespace Ex5.baladinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ai, você está disponivel para uma baladinha meu brother?");
            string disponibilidade = Console.ReadLine().ToLower();

            if(disponibilidade == "não"){
                Console.WriteLine("É uma pena");   
            }else{ // if(disponibilidade == "sim")
                Console.WriteLine("Você é menor de dezoito anos?");
                string r1 = Console.ReadLine().ToLower();

                if(r1 == "sim"){
                    Console.WriteLine("O teu rolê é matinê?");
                    string r2 = Console.ReadLine().ToLower();
                    if(r2 == "sim"){
                        Console.WriteLine("SEEEEXXXTOU!");
                    }else{
                        Console.WriteLine("Alô? Policia!");
                    }

                }else if(r1 == "não"){
                    Console.WriteLine("Você pagou a entrada?");
                    string entrada = Console.ReadLine().ToLower();

                    if(entrada == "sim" ){
                        Console.WriteLine("SEXTOOOUUU");
                    }else{
                        Console.WriteLine("Você tem cartão VIP?");
                        string vip = Console.ReadLine().ToLower();

                        if(vip == "sim"){
                            Console.WriteLine("SEEXXXTOUUU");

                        }else{
                            Console.WriteLine("Dinheiro não cai do céu");
                        }
                        
                    }
                }

            }
        }
    }
}
