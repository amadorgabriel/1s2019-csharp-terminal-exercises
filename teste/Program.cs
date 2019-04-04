using System;

namespace teste {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Aonde quer ir passear?");
            string entrada = Console.ReadLine ().ToLower ();

            switch (entrada) {
                case "montanha":
                    Console.WriteLine ("ta quente");
                    break;
                case "parque":
                    Console.WriteLine ("to com frio");
                    break;

                default:
                    Console.WriteLine ("nada faz sentido");
                    break;
            }

        }
    }
}